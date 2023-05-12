using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PasswordGenerator;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEmptyLabel()
        {
            //Arrange
            MainForm main = new MainForm();

            //Assert and act
            Assert.AreEqual("", main.passwordTB.Text);

        }

        [TestMethod]
        public void TestPassIsNotNull()
        {
            //Arrange
            MainForm main = new MainForm();
            main.passwordTB.Text = "Yl3frg";

            //Assert and act
            Assert.IsNotNull(main.passwordTB.Text);

        }
        [TestMethod]
        public void TestCheckBoxLover()
        {
            //Arrange
            MainForm main = new MainForm();
            main.lowerCharsCB.Checked = true;

            //Assert and act
            Assert.AreEqual(main.lowerCharsCB.Checked, true);

        }
    }
}
