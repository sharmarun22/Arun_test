using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CheckScenarioA()
        {
            int item_A_Quantity = 1;
            int item_B_Quantity = 1;
            int item_C_Quantity = 1;
            var ObjProg = new MainProject.Program();
            Assert.AreEqual(ObjProg.CheckoutScenarioA(item_A_Quantity, item_B_Quantity, item_C_Quantity), 100);
        }
        [TestMethod]
        public void CheckScenarioB()
        {
            int item_A_Quantity = 5;
            int item_B_Quantity = 5;
            int item_C_Quantity = 1;
            int item_D_Quantity = 0;

            var ObjProg = new MainProject.Program();
          
            Assert.AreEqual(ObjProg.CheckoutScenarioB(item_A_Quantity, item_B_Quantity, item_C_Quantity,item_D_Quantity), 370);
        }


    }
}
