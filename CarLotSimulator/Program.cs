using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();
            
            var carOne = new Car();
            carOne.Year = 2008;
            carOne.Make = "Nissan";
            carOne.Model = "Maxima";
            carOne.EngineNoise = "Vroom";
            carOne.HonkNoise = "Maaaaah";
            carOne.IsDriveable = true;

            lot.Cars.Add(carOne);

            var carTwo = new Car()
            {
                Year = 2012,
                Make = "Ford",
                Model = "Fusion",
                EngineNoise = "Whirr",
                HonkNoise = "Meep",
                IsDriveable = true,
            };

            lot.Cars.Add(carTwo);

            var carThree = new Car(2005, "Mazda", "Three", "Nil", "Also Nil", false);

            lot.Cars.Add(carThree);

            carOne.MakeEngineNoise(carOne.EngineNoise);
            carTwo.MakeEngineNoise(carTwo.EngineNoise);
            carThree.MakeEngineNoise(carThree.EngineNoise);

            foreach (var vehicle in lot.Cars)
            {
                Console.WriteLine($"Year: {vehicle.Year} Make: {vehicle.Make} Model: {vehicle.Model}");
            }
        }
    }
}
