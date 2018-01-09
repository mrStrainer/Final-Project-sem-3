using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogicLayer;
using DataAccessLayer;

namespace UnitTesting
{
   

    [TestClass]
    public class UserTests
    {
        UserLogic UL;
        long id;
        [TestInitialize]
        public void TestIni() {
                UL = new UserLogic();
            id = UL.Createuser("test", "test", true, 9000, 1);
        }


       [TestMethod]
        public void ReadCreatedUserTest()
        {
            Assert.AreEqual(UL.GetUserByID(id).ID, id);
        }

        [TestMethod]
        public void UpdateUserTest()
        {
            UserTable userTable = UL.GetUserByID(id);
            userTable.lastName = "modifiedTest";
           UserTable updatedUT = UL.UpdateUser(userTable.ID, userTable.firstName, userTable.lastName,userTable.accountType,userTable.zip,userTable.currentPartyID.GetValueOrDefault());
            Assert.IsTrue(updatedUT.lastName.Equals("modifiedTest"));
        }
        [TestCleanup]
        public void CleanupTest()
        {
            UL.RemoveUser(id);
        }
    }
}