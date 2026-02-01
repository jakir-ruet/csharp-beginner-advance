using System;

namespace MyApp.EnumDemo
{
    public class EnumDemoRunner
    {
        public static void Run()
        {
            Order order = new Order
            {
                OrderId = 501,
                Status = OrderStatus.Pending
            };

            Console.WriteLine($"Order {order.OrderId} status: {order.Status}");
            ProcessOrder(order);
        }

        static void ProcessOrder(Order order)
        {
            switch (order.Status)
            {
                case OrderStatus.Pending:
                    Console.WriteLine("Waiting for payment...");
                    break;
                case OrderStatus.Paid:
                    Console.WriteLine("Preparing items for shipment...");
                    break;
                case OrderStatus.Shipped:
                    Console.WriteLine("Order is on the way...");
                    break;
                case OrderStatus.Delivered:
                    Console.WriteLine("Order delivered successfully.");
                    break;
                case OrderStatus.Cancelled:
                    Console.WriteLine("Order has been cancelled.");
                    break;
            }
        }
    }
}
