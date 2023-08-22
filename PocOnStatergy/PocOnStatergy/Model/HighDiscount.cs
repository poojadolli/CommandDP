using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnStatergy.Model
{
   public class HighDiscount:IStrategy
    {
        int IStrategy.GetFinalBill(int BillAmount)//overide getfinalmethod
        {
            return (int)(BillAmount - (BillAmount * 0.5));

        }
    }
}
