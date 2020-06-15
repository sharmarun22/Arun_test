
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace MainProject
{
    public class Program
    {
        int item_A_Value = 50;
        int item_B_Value = 30;
        int item_C_Value = 20;
        int item_D_Value = 15;
        public static void Main(string[] args)
        {
            

        }

        //private int AfterPromotionValue(int item_A_Quantity, int item_B_Quantity,int item_C_Quantity,int item_D_Quantity)
        //{
        //    int promotionForA = 3;
        //    int promotionForB = 2;
        //    int promotionForCAndD = 1;
            
        //    if (item_A_Quantity !=0)
        //    {
        //        int calculativeValue = item_A_Quantity / promotionForA;
        //    }
        //    if (item_B_Quantity != 0)
        //    {
        //    }
        //    if (item_C_Quantity != 0 && item_D_Quantity!=0)
        //    { 
        //    }
        //    return 0;
        //}
        public int CheckoutScenarioA(int item_A_Quantity, int item_B_Quantity, int item_C_Quantity)
        {
            return (item_A_Quantity * item_A_Value) + (item_B_Quantity * item_B_Value) + (item_C_Quantity * item_C_Value);
        }

        //public int CheckoutScenarioB(int item_A_Quantity, int item_B_Quantity, int item_C_Quantity)
        //{
        //    return (item_A_Quantity * item_A_Value) + (item_B_Quantity * item_B_Value) + (item_C_Quantity * item_C_Value);
        //}

    }


}
