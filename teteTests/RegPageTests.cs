using Microsoft.VisualStudio.TestTools.UnitTesting;
using tete.MYPAGE;
using System;
using System.Collections.Generic;
using System.Linq;
using tete.Componens;
using System.Text;
using System.Threading.Tasks;


namespace tete.MYPAGE.Tests     
{
    [TestClass()]
    public class RegPageTests
    {public static testimgEntities db = new testimgEntities();                                                                                         
        [TestMethod()]
        public void RegPageTest()
        {
            var us = Bdconnect.db.User.Where(u => u.Login == "1111").FirstOrDefault();
            Assert.IsTrue(us != null);
        }
    }
}