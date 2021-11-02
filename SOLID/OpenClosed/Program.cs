using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir sınıf ...gelişime... açık ..........değişime...... kapalı olmalı
            //Yeni bir özellik eklemek istediğinizde varolan sınıfları değiştirmemeniz gerekir.
            Customer customer = new Customer { Cart = new PremiumCart() };
            OrderManagement orderManagement = new OrderManagement { Customer = customer };
            var price = orderManagement.GetDiscountedPrice(1000);
            Console.WriteLine(price);
        }

    }

    public abstract class Cart
    {
        public abstract double GetPrice(double price);
        public List<Customer> Customers { get; set; }

    }

    public class StandartCart : Cart
    {
        public override double GetPrice(double price)
        {
            return price * 0.95;
        }
    }

    public class SilverCart : Cart
    {
        public override double GetPrice(double price)
        {
            return price * 0.90;

        }
    }

    public class GoldCart : Cart
    {
        public override double GetPrice(double price)
        {
            return price * 0.85;

        }
    }

    public class PremiumCart : Cart
    {
        public override double GetPrice(double price)
        {
            return price * 0.80;

        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public Cart Cart { get; set; }
        [ForeignKey("Cart")]
        public int CartId { get; set; }
    }
    public class OrderManagement
    {
        public Customer Customer { get; set; }
        public double GetDiscountedPrice(double price)
        {

            return Customer.Cart.GetPrice(price);
        }
    }
}
