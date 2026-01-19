namespace AbstractFactoryTest.Models;

internal class IngilizAraba : ICar
{
    public void Uret()
    {
       Console.WriteLine("İngiliz arabası üretildi.");
    }
}
