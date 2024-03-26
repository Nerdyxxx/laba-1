using System;

class Program
{
    static void Main()
    {
        Organization organization = new Organization("Организация1", "Адрес1", 2000);
        organization.DisplayInfo();
        organization.ConductMeeting();

        InsuranceCompany insuranceCompany = new InsuranceCompany("Страховая компания1", "Адрес2", 1995, "Автострахование");
        insuranceCompany.DisplayInfo();
        insuranceCompany.ProcessClaim();

        OilGasCompany oilGasCompany = new OilGasCompany("Нефтегазовая компания1", "Адрес3", 1985, "Нефть");
        oilGasCompany.DisplayInfo();
        oilGasCompany.ExtractResource();

        Factory factory = new Factory("Завод1", "Адрес4", 1970, "Производственная линия1");
        factory.DisplayInfo();
        factory.ProduceGoods();

        Console.ReadLine();
    }
}
