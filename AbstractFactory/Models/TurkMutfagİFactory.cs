namespace AbstractFactory.Models;

internal class TurkMutfagİFactory : IYemekFactory
{
    public ISalata SalataHazirla()
    {
        return new TurkSalata();
    }

    public IAnaYemek YemekHazirla()
    {
       return new TurkAnaYemek();
    }
}
