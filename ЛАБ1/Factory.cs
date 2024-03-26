public class Factory : Organization
{
    public string ProductionLine { get; set; }

    public Factory(string name, string address, int yearFounded, string productionLine)
        : base(name, address, yearFounded)
    {
        ProductionLine = productionLine;
    }

    public void ProduceGoods()
    {
        Console.WriteLine($"Производим товары на линии {ProductionLine}");
    }

    public void MaintainEquipment()
    {
        Console.WriteLine($"Проводим техническое обслуживание оборудования на заводе");
    }

    public void ShipProducts()
    {
        Console.WriteLine($"Отгружаем продукцию с завода");
    }
}
