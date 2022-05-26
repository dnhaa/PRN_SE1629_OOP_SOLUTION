namespace Prn.Se1629;
public class Program
{
    public static void Main()
    {
        /*1. Khai bao doi tuog managerproduct*/
        IProduct productManagement = new ProductManagement();
        /*2. Them n product vao*/
        productManagement.Add(new Product(1, "dell", "decent with current feature", 3.44, 10));
        productManagement.Add(new Product(2, "mac", "advanced feature", 33, 43));
        productManagement.Add(new Product(3, "iphone", "S13 3 camera", 3444, 5));
        productManagement.Add(new Product(4, "nokia", "old asf", 7, 1));
        productManagement.Display();
    }
}