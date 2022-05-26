namespace Prn.Se1629;
public class ProductManagement:IProduct
{
    private Product[] listProduct;
    private int size; //so luong phan tu co that trong mang
    public ProductManagement()
    {
        this.size = 0;
        this.listProduct = new Product[Utils.InitLenghtProduct];
    }

    public ProductManagement(Product[] listProduct)
    {
        this.listProduct = listProduct;
        foreach (Product product in listProduct)
        {
            if (product != null)
            {
                this.size++;
            }
        }    
    }

    public Product[] ListProduct { get => listProduct; set => listProduct = value; }

    public void Add(Product p)
    {
        //viết giải thuật để thực thi chèn 1 phần tử vào mảng 1 chieu tĩnh 
        /*check de xem mang con trong khong?*/
        CheckSize(p);

    }

    private void CheckSize(Product p)
    {
        if (this.size >= this.ListProduct.Length)
        {
            //thuc hien noi mang
            Product[] tmp = new Product[this.size * 2];
            //hot du lieu tu cu sang tmp moi nay
            for (int i = 0; i < this.size; i++)
            {
                tmp[i] = this.ListProduct[i];
            }
            this.ListProduct = tmp;

        }
        /*2. neu ma con cho trong thi ta chi viec add product vao*/
        this.ListProduct[this.size] = p;
    }

    public bool Delete(Product p)
    {
        int index = 0;
        /*1. tim phan tu p co trong mang hay khong*/
        foreach(var item in this.ListProduct)
        {
            index++;
            if (item is not null && item.Id == p.Id)
            {
                /*neu tim thay thi xoa di*/
                for (int i = 0; i < this.size; i++)
                {
                    listProduct[i] = this.listProduct[i + 1];
                    listProduct[this.size] = null;
                }
                return true;
            }
        }
        return false;
    }

    public void Display()
    {
        foreach (Product p in this.ListProduct)
        {
            Console.WriteLine(p);
        }
    }

    public Product Get(int productID)
    {
        throw new NotImplementedException();
    }

    public bool Update(Product p)
    {
        throw new NotImplementedException();
    }
}