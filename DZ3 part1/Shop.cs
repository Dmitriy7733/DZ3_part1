using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_part1;
internal class Shop
{
    private string name;
    private string address;
    private string profileDescription;
    private string phoneNumber;
    private string email;

    public void InputData()
    {
        Console.WriteLine("Введите название магазина:");
        name = Console.ReadLine();

        Console.WriteLine("Введите адрес магазина:");
        address = Console.ReadLine();

        Console.WriteLine("Введите описание профиля магазина:");
        profileDescription = Console.ReadLine();

        Console.WriteLine("Введите контактный телефон магазина:");
        phoneNumber = Console.ReadLine();

        Console.WriteLine("Введите контактный email магазина:");
        email = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine($"Название магазина: {name}");
        Console.WriteLine($"Адрес: {address}");
        Console.WriteLine($"Описание профиля магазина: {profileDescription}");
        Console.WriteLine($"Контактный телефон: {phoneNumber}");
        Console.WriteLine($"Контактный email: {email}");
    }

    public string GetName()
    {
        return name;
    }

    public string GetAddress()
    {
        return address;
    }

    public string GetProfileDescription()
    {
        return profileDescription;
    }

    public string GetPhoneNumber()
    {
        return phoneNumber;
    }

    public string GetEmail()
    {
        return email;
    }
}
