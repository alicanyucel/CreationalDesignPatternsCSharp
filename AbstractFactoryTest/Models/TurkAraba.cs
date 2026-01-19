namespace AbstractFactoryTest.Models;

internal class TurkAraba : ICar
{
    public void Uret()
    {
      Console.WriteLine("Türk arabası üretildi.");
    }
}
