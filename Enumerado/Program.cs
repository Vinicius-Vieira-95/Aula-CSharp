using System;

namespace Enumerado
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order(123, DateTime.Now, OrderStatus.PendingPayment);

            Console.WriteLine(order);

            string txt = OrderStatus.Processing.ToString();

        }
    }
}
