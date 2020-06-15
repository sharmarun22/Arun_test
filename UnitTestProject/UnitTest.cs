using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace UnitTestProject
{
   
    [TestClass]
    public class UnitTest
    {
        int item_A_Quantity;
        int item_B_Quantity;
        int item_C_Quantity;
        int item_D_Quantity;
        [TestMethod]
        public void CheckScenarioA()
        {
             item_A_Quantity = 1;
             item_B_Quantity = 1;
             item_C_Quantity = 1;
            var ObjProg = new MainProject.Program();
            Assert.AreEqual(ObjProg.CheckoutScenarioA(item_A_Quantity, item_B_Quantity, item_C_Quantity), 100);
        }
        [TestMethod]
        public void CheckScenarioB()
        {
             item_A_Quantity = 5;
             item_B_Quantity = 5;
             item_C_Quantity = 1;
             item_D_Quantity = 0;

            var ObjProg = new MainProject.Program();
          
            Assert.AreEqual(ObjProg.CheckoutScenarioB(item_A_Quantity, item_B_Quantity, item_C_Quantity,item_D_Quantity), 370);
        }
        [TestMethod]
        public void CheckScenarioC()
        {
             item_A_Quantity = 3;
             item_B_Quantity = 5;
             item_C_Quantity = 1;
             item_D_Quantity = 1;

            var ObjProg = new MainProject.Program();

            Assert.AreEqual(ObjProg.CheckoutScenarioC(item_A_Quantity, item_B_Quantity, item_C_Quantity, item_D_Quantity), 280);
        }


    }
}
