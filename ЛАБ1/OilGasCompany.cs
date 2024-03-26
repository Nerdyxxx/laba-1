public class OilGasCompany : Organization
{
    public string Product { get; set; }

    public OilGasCompany(string name, string address, int yearFounded, string product)
        : base(name, address, yearFounded)
    {
        Product = product;
    }

    public void ExtractResource()
    {
        Console.WriteLine($"Добываем ресурс {Product}");
    }

    public void RefineProduct()
    {
        Console.WriteLine($"Перерабатываем продукт {Product}");
    }

    public void TransportProduct()
    {
        Console.WriteLine($"Транспортируем продукт {Product}");
    }
}
