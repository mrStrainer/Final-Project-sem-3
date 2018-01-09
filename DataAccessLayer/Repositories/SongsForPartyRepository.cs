using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SongsForPartyRepository
    {
        public bool AddSongInPartyPlaylist(SongsForPartyTable playlist)
        {
            using (var db = new EntitiesChooseEm())
            {
                db.SongsForPartyTables.Add(playlist);
                db.SaveChanges();
            }
            return true;

        }

        public SongsForPartyTable GetSongFromPartyPlaylist(long partyID, string songURL)
        {
            SongsForPartyTable song = null;
            using (var db = new EntitiesChooseEm())
            {
                song = db.SongsForPartyTables.FirstOrDefault(p => p.partyID == partyID && p.songURL == songURL);
            }
            return song;
        }

        public List<SongsForPartyTable> GetAllSongs(long partyID)
        {           
            List<SongsForPartyTable> songs = new List<SongsForPartyTable>();
            using (var db = new EntitiesChooseEm())
            {
                var sfp = db.SongsForPartyTables.Where(sP => sP.partyID == partyID);
                foreach(var item in sfp)
                {
                    SongsForPartyTable sp = new SongsForPartyTable
                    {
                        partyID = item.partyID,
                        songURL = item.songURL,
                        rating = item.rating,
                        RowVersion = item.RowVersion
                    };
                    songs.Add(sp);
                }
            }
            return songs;
        }


        public bool RemoveSongFromPartyPlaylist(long partyID, string songURL)
        {
            using (var db = new EntitiesChooseEm())
            {

                db.SongRatingFromPartyTables.RemoveRange(db.SongRatingFromPartyTables.Where(p => ((p.partyID == partyID) && (p.songURL == songURL))));
                
                db.SongsForPartyTables.RemoveRange(db.SongsForPartyTables.Where(p => ((p.partyID == partyID) && (p.songURL == songURL))));
                db.SaveChanges();
            }
            return true;
        }


        public SongsForPartyTable UpdateSongRating(SongsForPartyTable songWithUpdatedRating)
        {
            using (var context = new EntitiesChooseEm())
            {
                SongsForPartyTable song = context.SongsForPartyTables.FirstOrDefault(p => p.songURL == songWithUpdatedRating.songURL && p.partyID == songWithUpdatedRating.partyID);
                song.rating = songWithUpdatedRating.rating;
                context.SaveChanges();
            }
            return songWithUpdatedRating;
        }
    }
}
