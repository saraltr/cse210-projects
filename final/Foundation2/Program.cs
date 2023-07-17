using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Encapsulation with Online Ordering\n");

        Address customerAddress1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer = new Customer("Lea Jones", customerAddress1);

        // creates an order
        Order order1 = new Order(customer);
        order1.AddProduct(new Product("Rice", "P1", 13.5, 1));
        order1.AddProduct(new Product("Eggs", "P2", 3.7, 1));
        order1.AddProduct(new Product("Tangerine", "P3", 0.99, 5));
        order1.AddProduct(new Product("Pasta", "P4", 1.37, 2));

        // print packing label and shipping label
        order1.GetPackingLabel();
        order1.GetShippingLabel();

        Address customerAddress2 = new Address("123 Maple Street", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Marie Brown", customerAddress2);

        // creates the second order
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Milk", "P5", 2.99, 2));
        order2.AddProduct(new Product("Eggs", "P2", 3.7, 2));
        order2.AddProduct(new Product("Apples", "P6", 0.99, 6));
        order2.AddProduct(new Product("Bread", "P7", 1.99, 1));


        // packing label and shipping label for the second order
        order2.GetPackingLabel();
        order2.GetShippingLabel();
    }
}