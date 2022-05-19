namespace Prn.Se1629;

public interface IProduct
{
    void Add(Product p);
    bool Update(Product p);
    bool Delete(Product p);
    Product Get(int productID);
    //default là public abstract void

    void Display();
    

}