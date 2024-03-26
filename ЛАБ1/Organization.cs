using System;

public class Organization
{
    public string Name { get; set; }
    public string Address { get; set; }
    public int YearFounded { get; set; }

    public Organization(string name, string address, int yearFounded)
    {
        Name = name;
        Address = address;
        YearFounded = yearFounded;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Организация: {Name}");
        Console.WriteLine($"Адрес: {Address}");
        Console.WriteLine($"Год основания: {YearFounded}");
    }

    public void ConductMeeting()
    {
        Console.WriteLine($"Проводим совещание в {Name}");
    }

    public void OrganizeEvent()
    {
        Console.WriteLine($"Организуем мероприятие в {Name}");
    }
}
