using System;

// Інтерфейс Lamp
interface Lamp
{
    string Type { get; set; }
    string Manufacturer { get; set; }
    int Lumen { get; set; }
    string LightType { get; set; }
    int ElementCount { get; set; }
    
    void PrintDetails();
    void ChangeLumen(int newLumen);
}

// Інтерфейс Camera
interface Camera
{
    string Type { get; set; }
    string Manufacturer { get; set; }
    int Sensitivity { get; set; }
    
    void PrintDetails();
    void ChangeSensitivity(int newSensitivity);
}

// Клас PhotoStudio реалізує інтерфейси Lamp і Camera
class PhotoStudio : Lamp, Camera
{
    // Реалізація властивостей для Lamp
    public string Type { get; set; }
    public string Manufacturer { get; set; }
    public int Lumen { get; set; }
    public string LightType { get; set; }
    public int ElementCount { get; set; }

    // Реалізація властивостей для Camera
    public int Sensitivity { get; set; }

    // Реалізація методів для Lamp
    public void PrintLampDetails()
    {
        Console.WriteLine($"Lamp Type: {Type}");
        Console.WriteLine($"Manufacturer: {Manufacturer}");
        Console.WriteLine($"Lumen: {Lumen}");
        Console.WriteLine($"Light Type: {LightType}");
        Console.WriteLine($"Element Count: {ElementCount}");
    }

    public void ChangeLumen(int newLumen)
    {
        Lumen = newLumen;
    }

    // Реалізація методів для Camera
    public void PrintCameraDetails()
    {
        Console.WriteLine($"Camera Type: {Type}");
        Console.WriteLine($"Manufacturer: {Manufacturer}");
        Console.WriteLine($"Sensitivity: {Sensitivity}");
    }

    public void ChangeSensitivity(int newSensitivity)
    {
        Sensitivity = newSensitivity;
    }
}

// Основна програма
class Program
{
    static void Main(string[] args)
    {
        // Створення екземплярів класу PhotoStudio
        PhotoStudio studio1 = new PhotoStudio
        {
            Type = "LED",
            Manufacturer = "BrandA",
            Lumen = 800,
            LightType = "Warm White",
            ElementCount = 5,
            Sensitivity = 1600
        };

        PhotoStudio studio2 = new PhotoStudio
        {
            Type = "Fluorescent",
            Manufacturer = "BrandB",
            Lumen = 1200,
            LightType = "Cool White",
            ElementCount = 3,
            Sensitivity = 3200
        };

        // Виведення характеристик
        Console.WriteLine("Studio 1 Details:");
        studio1.PrintLampDetails();
        studio1.PrintCameraDetails();

        Console.WriteLine("\nStudio 2 Details:");
        studio2.PrintLampDetails();
        studio2.PrintCameraDetails();

        // Зміна світлочутливості для studio1
        studio1.ChangeSensitivity(2000);
        
        // Виведення оновленої характеристики
        Console.WriteLine("\nUpdated Studio 1 Camera Details:");
        studio1.PrintCameraDetails();
    }
}
