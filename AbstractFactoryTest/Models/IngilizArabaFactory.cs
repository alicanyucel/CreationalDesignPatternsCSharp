using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryTest.Models
{
    internal class IngilizArabaFactory : ICarFactory
    {
        public ICar CreateCar()
        {
           return new IngilizAraba();
        }
    }
}
