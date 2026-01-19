namespace AbstractFactory.Models;

internal class ItalyanSalata : ISalata
{
    public void Hazirla()
    {
        Console.WriteLine("İtalyan salatası hazırlanıyor...");
    }
}
