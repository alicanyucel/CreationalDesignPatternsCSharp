// See https://aka.ms/new-console-template for more information
using AbstractFactory.Models;

Console.WriteLine("Abstract Factory");
IYemekFactory factory = new ItalyanMutfagiFactory();
IAnaYemek anaYemek=factory.YemekHazirla();
anaYemek.Hazirla();
ISalata salata=factory.SalataHazirla();
salata.Hazirla();
