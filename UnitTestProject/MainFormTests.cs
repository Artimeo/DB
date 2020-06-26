using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DB;
using System.Windows.Forms;

namespace DB.Tests
{
    [TestClass]
    public class UnitTest_case2
    {
        [TestMethod]
        public void TestMethod_case2_1()
        {
            MainForm mainFormTest = new MainForm();
            int returned = mainFormTest.SearchParts("Все", "saasdasdmlkanqwneqwnenjnkjasdsandjnsadasdklmsadlkamsdlkmaskd alksdlkamsdkaslkd    askdnlasdalkdsnsalkdqelkqnwknlqewnnewqknqlwe");
            Assert.AreEqual(-1, returned);
        }
        [TestMethod]
        public void TestMethod_case2_2()
        {
            MainForm mainFormTest = new MainForm();
            int returned = mainFormTest.SearchParts("Все", "-\\,,-*0_ёЁ~+?&)||//");
            Assert.AreEqual(-1, returned);
        }
        [TestMethod]
        public void TestMethod_case2_3()
        {
            MainForm mainFormTest = new MainForm();
            int returned = mainFormTest.SearchParts("Все1", "Запчасть");
            Assert.AreEqual(-2, returned);
        }
        [TestMethod]
        public void TestMethod_case2_4()
        {
            MainForm mainFormTest = new MainForm();
            int returned = mainFormTest.SearchParts("Все", "");
            Assert.AreEqual(-3, returned);
        }
    }

    [TestClass]
    public class UnitTest_case3
    {
        [TestMethod]
        public void TestMethod_case3_1()
        {
            MainForm mainForm = new MainForm();
            AddDealsForm addDealsForm = new AddDealsForm(mainForm);

            DateTime returnedData = addDealsForm.dateTimePicker.Value;
            DateTime actualData = System.DateTime.Now;
            Assert.AreEqual(actualData.Date, returnedData.Date);
        }

        [TestMethod]
        public void TestMethod_case3_2()
        {
            MainForm mainForm = new MainForm();
            AddDealsForm addDealsForm = new AddDealsForm(mainForm);

            addDealsForm.buttonSetCurrentDate.PerformClick();

            DateTime returnedData = addDealsForm.dateTimePicker.Value;
            DateTime actualData = System.DateTime.Now;
            Assert.AreEqual(actualData.Date, returnedData.Date);
        }
    }
}
