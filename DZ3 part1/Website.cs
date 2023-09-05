using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_part1;

internal class Website
{
    private string siteName;
    private string siteUrl;
    private string siteDescription;
    private string siteIpAddress;

    // Метод для ввода данных о веб-сайте
    public void InputData()
    {
        Console.Write("Введите название сайта: ");
        siteName = Console.ReadLine();

        Console.Write("Введите путь к сайту: ");
        siteUrl = Console.ReadLine();

        Console.Write("Введите описание сайта: ");
        siteDescription = Console.ReadLine();

        Console.Write("Введите IP адрес сайта: ");
        siteIpAddress = Console.ReadLine();
    }

    // Метод для вывода данных о веб-сайте
    public void DisplayData()
    {
        Console.WriteLine("Название сайта: " + siteName);
        Console.WriteLine("Путь к сайту: " + siteUrl);
        Console.WriteLine("Описание сайта: " + siteDescription);
        Console.WriteLine("IP адрес сайта: " + siteIpAddress);
    }

    // Методы для доступа к отдельным полям класса
    public string GetSiteName()
    {
        return siteName;
    }

    public void SetSiteName(string name)
    {
        siteName = name;
    }

    public string GetSiteUrl()
    {
        return siteUrl;
    }

    public void SetSiteUrl(string url)
    {
        siteUrl = url;
    }

    public string GetSiteDescription()
    {
        return siteDescription;
    }

    public void SetSiteDescription(string description)
    {
        siteDescription = description;
    }

    public string GetSiteIpAddress()
    {
        return siteIpAddress;
    }

    public void SetSiteIpAddress(string ipAddress)
    {
        siteIpAddress = ipAddress;
    }
}
