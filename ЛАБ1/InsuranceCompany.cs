public class InsuranceCompany : Organization
{
    public string InsuranceType { get; set; }

    public InsuranceCompany(string name, string address, int yearFounded, string insuranceType)
        : base(name, address, yearFounded)
    {
        InsuranceType = insuranceType;
    }

    public void ProcessClaim()
    {
        Console.WriteLine($"Обрабатываем страховой случай для {InsuranceType}");
    }

    public void CalculatePremium()
    {
        Console.WriteLine($"Рассчитываем премию для {InsuranceType}");
    }

    public void OfferPolicy()
    {
        Console.WriteLine($"Предлагаем полис для {InsuranceType}");
    }
}
