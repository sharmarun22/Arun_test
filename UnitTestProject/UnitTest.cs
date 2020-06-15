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
            int iteam_A_Quantity = 1;
            int iteam_B_Quantity = 1;
            int iteam_C_Quantity = 1;
            var ObjProg = new MainProject.Program();
            ObjProg.CheckoutScenario1(2, 1, 1);
           //int totalValue = CheckoutScenario1(iteam_A_Quantity, iteam_B_Quantity, iteam_C_Quantity);

        }


    }
}
