using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>{
        new Order(
            new Customer(
                "Jimmy",
                new Address("1008 Snow Vally Street", "Tulsa", "OK", "74008", "USA")), 
            new List<Product>{
                new Product("Loaf of Bread", 392, (float)2.99, 2),
                new Product("Jug of Milk", 377, (float)3.49, 1),
                new Product("One Dozen Eggs", 324, (float)2.99, 3)}),
        new Order(
            new Customer(
                "Melissa",
                new Address("221 Seneca Avenue", "Hamilton", "ON", "L9B 1M1", "Canada")), 
            new List<Product>{
                new Product("Bunch of Bananas", 591, (float)2.49, 1),
                new Product("Loaf of Bread", 392, (float)2.99, 2),
                new Product("Whole Ham", 407, (float)8.99, 1)}),
        new Order(
            new Customer(
                "Tom",
                new Address("29 Silver Spear Drive", "Greenwood", "SC", "29646", "USA")), 
            new List<Product>{
                new Product("One Dozen Eggs", 324, (float)2.99, 1),
                new Product("Pack of Bacon", 419, (float)3.99, 2)}),
        new Order(
            new Customer(
                "Alice",
                new Address("8909 Young Avenue", "Grayslake", "IL", "60030", "USA")), 
            new List<Product>{
                new Product("Bunch of Bananas", 591, (float)2.49, 2),
                new Product("Single Apple", 587, (float)0.99, 16),
                new Product("Jug of Milk", 377, (float)3.49, 2),
                new Product("Loaf of Bread", 392, (float)2.99, 1)})
        };

        int orderNum = 1;
        foreach (Order order in orders)
        {
            Console.WriteLine("\n\x1b[1m----------------------------------------------------------------\x1b[0m");
            Console.WriteLine($"\x1b[1mOrder No. {orderNum}\x1b[0m");
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine($"\n\x1b[1mTotal Price:\x1b[0m\n{Math.Round(order.TotalOrderCost(), 2)}");
            orderNum += 1;
        }
        Console.Write("\n\n");
    }
}