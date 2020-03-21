using System;
using System.Collections.Generic;
using System.Text;
using DersMvvmYapisi.Models;


namespace DersMvvmYapisi.ViewModels
{
   public  class CarViewModel
    {

        public List<Car> Cars { get; set; }


        public CarViewModel()
        {
            Cars = new List<Car>
            {
                new Car{Marka = "Audi",Model = "Q8"},
                new Car{Marka = "BMW",Model = "320d"},
                new Car{Marka = "Bugatti",Model = "EB110"},
            };
        }


    }
}
