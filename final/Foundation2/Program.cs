using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("804 Main st", "Seattle", "Washington", "USA");
        Address a2 = new Address("14995 River ave", "Quebec City", "Quebec", "Canada");
        
        Customer c1 = new Customer("Jeremy Houser", a1);
        Customer c2 = new Customer("Derek Evegnee", a2);

        Product c1p1 = new Product("Dice", "0115", 0.59, 20);
        Product c1p2 = new Product("Kitchen Knife", "99245", 14.99, 2);

        Product c2p1 = new Product("iPhone charger", "11522", 12.99, 3);
        Product c2p2 = new Product("Textbook", "999-55", 200, 2);
        Product c2p3 = new Product("Pen", "02555", 2.99, 5);
        
        Order o1 = new Order(c1);
        o1.AddProduct(c1p1);
        o1.AddProduct(c1p2);

        Order o2 = new Order(c2);
        o2.AddProduct(c2p1);
        o2.AddProduct(c2p2);
        o2.AddProduct(c2p3);

        Console.WriteLine();
        o1.Display();
        Console.WriteLine();
        o2.Display();
    }
}