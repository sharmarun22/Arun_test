
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
        int promotionValueForA_eachOfThree = 130;
        int promotionValueForB_eachOfTwo = 45;
        int promotionValueForCAndD_Only = 15;
        public static void Main(string[] args)
        {
            
           
        }

        private int AfterPromotionValue(int item_A_Quantity, int item_B_Quantity, int item_C_Quantity, int item_D_Quantity)
        {
            int promotionForA = 3;
            int promotionForB = 2;
            int total = 0;
            int excludedFromPromotionValue;
            int prmotionValue;
            if (item_A_Quantity != 0)
            {
                prmotionValue = item_A_Quantity / promotionForA;
                excludedFromPromotionValue = item_A_Quantity - (prmotionValue * promotionForA);
                total = (prmotionValue * promotionValueForA_eachOfThree) + (excludedFromPromotionValue * item_A_Value);
            }
            if (item_B_Quantity != 0)
            {
                prmotionValue = item_B_Quantity / promotionForB;
                excludedFromPromotionValue = item_B_Quantity - (prmotionValue * promotionForB);
                total += (prmotionValue * promotionValueForB_eachOfTwo) + (excludedFromPromotionValue * item_B_Value);
            }
            if (item_C_Quantity != 0 && item_D_Quantity != 0)
            {
                if(item_C_Quantity<item_D_Quantity)
                {
                    total += (item_C_Quantity * promotionValueForCAndD_Only)+ (item_D_Quantity - item_C_Quantity) * item_D_Value;
                }
                if (item_D_Quantity < item_C_Quantity)
                {
                    total += (item_D_Quantity * promotionValueForCAndD_Only) + (item_C_Quantity - item_D_Quantity) * item_C_Value;
                }
                if (item_D_Quantity == item_C_Quantity)
                {
                    total += item_D_Value * promotionValueForCAndD_Only;
                }
            }
            else
            {
                if(item_C_Quantity!=0)
                {
                    total += item_C_Quantity * item_C_Value;
                }
            }
            return total;
        }

        public int CheckoutScenarioC(int item_A_Quantity, int item_B_Quantity, int item_C_Quantity, int item_D_Quantity)
        {
            throw new NotImplementedException();
        }

        public int CheckoutScenarioA(int item_A_Quantity, int item_B_Quantity, int item_C_Quantity)
        {
            return (item_A_Quantity * item_A_Value) + (item_B_Quantity * item_B_Value) + (item_C_Quantity * item_C_Value);
        }

        public int CheckoutScenarioB(int item_A_Quantity, int item_B_Quantity, int item_C_Quantity, int item_D_Quantity)
        {
            return AfterPromotionValue(item_A_Quantity, item_B_Quantity, item_C_Quantity, item_D_Quantity);
        }

    }
   

}
