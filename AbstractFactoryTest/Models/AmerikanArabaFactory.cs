namespace AbstractFactoryTest.Models;

internal class AmerikanArabaFactory:ICarFactory
{
    public ICar CreateCar()
    {
        return new AmericanAraba();
    }

}
