using System;

class Program
{
    static void Main(string[] args)
    {
        Customer linda = new Customer("Linda Freeman", new Address("517 River Road", "Saginaw", "Michigan", "USA"));
        List<Product> amazonCart = new List<Product>();
        amazonCart.Add(new Product("Glue Sticks", 5, "ASM123", 5.99f));
        amazonCart.Add(new Product("Felt", 2, "RES299", 5.04f));
        amazonCart.Add(new Product("Googly Eyes", 1, "BGD433", 2.99f));
        Order order1 = new Order(linda, amazonCart);

        Customer john = new Customer("John Smith", new Address("248 Oak Street", "Portland", "Oregon", "USA"));
        List<Product> johnCart = new List<Product>();
        johnCart.Add(new Product("Notebook", 3, "NTB101", 3.49f));
        johnCart.Add(new Product("Pens", 10, "PN202", 1.99f));
        johnCart.Add(new Product("Stapler", 1, "STP303", 7.59f));
        Order order2 = new Order(john, johnCart);

        Customer emily = new Customer("Emily Wang", new Address("92 Harbor Avenue", "Vancouver", "British Columbia", "Canada"));
        List<Product> emilyCart = new List<Product>();
        emilyCart.Add(new Product("Sketchbook", 2, "SKT404", 9.99f));
        emilyCart.Add(new Product("Charcoal Pencils", 1, "CHP505", 4.75f));
        emilyCart.Add(new Product("Fixative Spray", 1, "FXS606", 6.89f));
        Order order3 = new Order(emily, emilyCart);

        order1.DisplayOrder();
        order2.DisplayOrder();
        order3.DisplayOrder();
    }
}