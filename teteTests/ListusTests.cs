using Microsoft.VisualStudio.TestTools.UnitTesting;
using tete.MYPAGE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tete.Componens;

namespace tete.MYPAGE.Tests
{
    [TestClass()]
    public class ListusTests
    {
        [TestMethod()]
        public void ListusTest()
        {
            User newuser = new User();
            newuser.Login = "123";
            newuser.Password = "123";
            newuser.Name = "1234";
            Bdconnect.db.User.Add(newuser);
            Bdconnect.db.SaveChanges();
            var us = Bdconnect.db.User.Where(u => u.Login == newuser.Login && u.Password == newuser.Password && u.Name == newuser.Name).FirstOrDefault();
            Assert.IsTrue(us != null);


        }
  
        [TestMethod()]
        public void ListusTest2()
        {
            User newuser = new User();
            newuser.Login = "123";
            newuser.Password = "123";
            newuser.Name = "1234";
            Bdconnect.db.User.Add(newuser);
            Bdconnect.db.SaveChanges();
            var us = Bdconnect.db.User.Where(u => u.Login == newuser.Login && u.Password == newuser.Password && u.Name == newuser.Name).FirstOrDefault();
            newuser.Name = "12";
            Bdconnect.db.SaveChanges();
            var usee = Bdconnect.db.User.Where(u => u.Login == newuser.Login && u.Password == newuser.Password && u.Name == "12").FirstOrDefault();
            Assert.IsTrue(usee != null);
            //var user = Bdconnect.db.User.Where(x => x.Name == newuser.Name).FirstOrDefault();
            //Assert.IsTrue(user == null);


        }
        [TestMethod()]
        public void ListusTest3()
        {
            User newuser = new User();

            newuser.Name = "1234";
            //var us = Bdconnect.db.User.Where(u => u.Login == "123" && u.Password == "123").FirstOrDefault();
            //Assert.IsTrue(us != null);
            var user = Bdconnect.db.User.Where(x => x.Name == newuser.Name && x.Login == "123" && x.Password == "123").FirstOrDefault();
            Bdconnect.db.User.Remove(user);
            Assert.IsTrue(user != null);


        }
    }
}