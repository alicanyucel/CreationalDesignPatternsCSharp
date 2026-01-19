using AbstractFactoryTest.Models;

ICarFactory carFactory = new AmerikanArabaFactory();
ICar car = carFactory.CreateCar();
car.Uret();
ICarFactory carFactory1 = new TurkArabaFactory();
ICar car1 = carFactory1.CreateCar();    
car1.Uret();
ICarFactory carFactory2=new IngilizArabaFactory();
ICar car2=carFactory2.CreateCar();  
car2.Uret();
Console.ReadKey();