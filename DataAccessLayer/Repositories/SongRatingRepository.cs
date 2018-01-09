using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SongRatingRepository
    {
        public bool AddSongRating(SongRatingFromPartyTable rating)
        {
            int previousType;
            using (var db = new EntitiesChooseEm())
            {
                if (!db.SongRatingFromPartyTables.Any(p => p.userID == rating.userID && p.songURL == rating.songURL && p.partyID == rating.partyID))
                {
                    db.SongRatingFromPartyTables.Add(rating);
                    previousType = 0;
                    db.SaveChanges();
                }
                else
                {
                    var aux = db.SongRatingFromPartyTables.FirstOrDefault(p => p.userID == rating.userID && p.songURL == rating.songURL && p.partyID == rating.partyID);
                    previousType = aux.voteType;


                    if (db.UsersAtParties.First(p => p.partyID == rating.partyID && p.userID == rating.userID).adminPrivileges)
                    {
                        aux.voteType += rating.voteType;
                    }
                    else
                    {
                        //Checks for vote change
                        if (aux.voteType == 1 && rating.voteType == 1) return true;
                        else if (aux.voteType == 1 && rating.voteType == -1) aux.voteType = 0;
                        else if (aux.voteType == -1 && rating.voteType == -1) return true;
                        else if (aux.voteType == -1 && rating.voteType == 1) aux.voteType = 0;
                        else aux.voteType = rating.voteType;
                     
                    }

                  
                    db.SaveChanges();
                }
                var result = db.SongRatingFromPartyTables.GroupBy(p => p.songURL == rating.songURL && p.partyID == rating.partyID)
                        .Select(g => new { membername = g.Key, total = g.Sum(i => i.voteType) });

                var atmRowVersion = db.SongsForPartyTables.First(p => p.songURL == rating.songURL && p.partyID == rating.partyID).RowVersion;

                foreach (var group in result)
                {
                    if (group.membername) {
                        try {
                            SetRating(group.total, rating.songURL, rating.partyID, atmRowVersion);
                        }

                        catch (Exception ex) {
                            RevertRating(rating, previousType);
                            throw ex; }
                    }
                }
            }
            return true;
        }


        public void RevertRating(SongRatingFromPartyTable rating, int previousType)
        {
            using (var db = new EntitiesChooseEm())
            {
                var aux = db.SongRatingFromPartyTables.First(p => p.userID == rating.userID && p.songURL == rating.songURL && p.partyID == rating.partyID);
                aux.voteType = previousType;
                db.SaveChanges();
            }
        }


        public void SetRating(int total, string uri, long partyID,byte[] atmRowVersion) {
            using (var db = new EntitiesChooseEm()) {
                var aux = db.SongsForPartyTables.First(p => p.songURL == uri && p.partyID == partyID);
                aux.rating = total;
                aux.RowVersion = atmRowVersion;
                db.SongsForPartyTables.Attach(aux);
                db.Entry(aux).State = System.Data.Entity.EntityState.Modified;

                var num = db.SaveChanges();

                if(num != 1)
                {
                    throw new Exception("Concurrency Error");

                }
            }
        }
        public int CalculateTotalSongRating(long partyID,string songURL)
        {
            int aux = 0;

            using (var db = new EntitiesChooseEm())
            {  
                var rating = db.SongRatingFromPartyTables.Where(r => r.partyID == partyID && r.songURL == songURL);
                foreach(var item in rating)
                {
                    aux += item.voteType;
                }
            }
            return aux;
        }
        public List<SongRatingFromPartyTable> GetAllRatings(long partyID, long userID)
        {
            List<SongRatingFromPartyTable> rating = new List<SongRatingFromPartyTable>();
            using (var db = new EntitiesChooseEm())
            {
                var rfp = db.SongRatingFromPartyTables.Where(rP => rP.partyID == partyID && rP.userID == userID);
                foreach (var item in rfp)
                {

                    SongRatingFromPartyTable rp = new SongRatingFromPartyTable
                    {
                        partyID = item.partyID,
                        userID = item.userID,
                        songURL = item.songURL,
                        voteType = item.voteType
                    };
                    rating.Add(rp);
                }
            }
            return rating;
        }
     public bool RemoveSongRating(long partyID, long userID, string songURL)
        {
            SongRatingFromPartyTable rating = null;
            using (var db = new EntitiesChooseEm())
            {
                rating = db.SongRatingFromPartyTables.FirstOrDefault(r => r.partyID == partyID && r.userID == userID && r.songURL == songURL);
                db.SongRatingFromPartyTables.Remove(rating);
            }
            return true;
        }
        public SongRatingFromPartyTable VoteSong(SongRatingFromPartyTable songWithUpdatedRating)
        {
            using (var db = new EntitiesChooseEm())
            {
                SongRatingFromPartyTable ratingfromDB = db.SongRatingFromPartyTables.FirstOrDefault(r => r.partyID == songWithUpdatedRating.partyID && r.userID == songWithUpdatedRating.userID && r.songURL == songWithUpdatedRating.songURL);
                ratingfromDB.voteType = songWithUpdatedRating.voteType;
                songWithUpdatedRating = ratingfromDB;
                db.SaveChanges();
            }
            return songWithUpdatedRating;
        }

    }
}
