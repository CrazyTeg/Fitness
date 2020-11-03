using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fitness.BL.Controller;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Fitness.BL.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
        //[TestMethod()]
        //public void UserControllerTest()
        //{
        //    Assert.Fail();
        //}

        // Arrenge
        // Act
        // Assert

        [TestMethod()]
        public void SetNewUserDataTest()
        {
            // Arrenge
            var userName = Guid.NewGuid().ToString();
            var birthDay = DateTime.Now.AddYears(-18);
            var weight = 90;
            var height = 190;
            var gender = "man";

            // Act
            var controller = new UserController(userName);
            controller.SetNewUserData(gender, birthDay, weight, height);
            var controller2 = new UserController(userName);
            // Assert

            Assert.AreEqual(userName, controller2.CurrentUser.Name);
            Assert.AreEqual(birthDay, controller2.CurrentUser.BirthDate);
            Assert.AreEqual(gender, controller2.CurrentUser.Gender.Name);
            Assert.AreEqual(weight, controller2.CurrentUser.Weight);
            Assert.AreEqual(height, controller2.CurrentUser.Height);
        }

        [TestMethod()]
        public void SaveTest()
        {
            // Arrenge
            var userName = Guid.NewGuid().ToString();
            // Act
            var controller = new UserController(userName);
            
            // Assert

            Assert.AreEqual(userName, controller.CurrentUser.Name);
        }
    }
}