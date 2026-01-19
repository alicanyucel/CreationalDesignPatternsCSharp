using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryTest.Models
{
    internal class TurkArabaFactory : ICarFactory
    {
        public ICar CreateCar()
        {
          return new TurkAraba();
        }
    }
}
