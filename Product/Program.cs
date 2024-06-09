using Product;

class Program
{
    static void Main(string[] args)
    {
        var tv = new Electronic { Name = "TV", Price = 500m, Material = "Plastic" };
        var shirt = new Clothes { Name = "Shirt", Price = 20m, Size = "M" };

        var order = new Order();
        order.AddProduct(tv);
        order.AddProduct(shirt);

        order.GetDetails();

        Console.WriteLine($"Total Amount: {order.GetTotalAmount()}");

        order.RemoveProduct(tv);

        order.GetDetails();
    }
}