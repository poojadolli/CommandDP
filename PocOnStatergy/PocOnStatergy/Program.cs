using PocOnStatergy.Model;

namespace PocOnStatergy
{
    internal class Program
    {
        static void Main(string[] args)
        {
          ShoppingMall objShoppingMall=new ShoppingMall(new LowDiscount());
            objShoppingMall.CustomerName = "abc";
            objShoppingMall.BillAmount= 1000; ;
            Console.WriteLine("Final Bill:"  + objShoppingMall.GetFinalBill());

            ShoppingMall objShoppingMall2 = new ShoppingMall(new HighDiscount());
            objShoppingMall2.CustomerName = "pqr";
            objShoppingMall2.BillAmount = 1000; ;
            Console.WriteLine("Final Bill:"  +   objShoppingMall2.GetFinalBill());

            ShoppingMall objShoppingMall3 = new ShoppingMall(new NoDiscount());
            objShoppingMall3.CustomerName = "xyz";
            objShoppingMall3.BillAmount = 1000; ;

            Console.WriteLine("Final Bill:"  + objShoppingMall3.GetFinalBill());
        }
    }
}