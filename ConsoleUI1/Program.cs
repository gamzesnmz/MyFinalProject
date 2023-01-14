using Business.Concrete;
using Data_Access1.Concrete.InMemory;

class Program
{
    static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager(new InMemoryProductDal());

        foreach (var product in productManager.GetAll())
        {
            Console.WriteLine(product.ProductName);

        }
        
    }

}
