using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot2023
{
    internal class Car
    {

        public Car()
        {

        }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }

        public bool IsDrivable { get; set; }


        public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDrivable)
        {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;
        }

        public void MakeEngineNoise()
        {
            Console.WriteLine($"This is the engine noise {EngineNoise}");

        }

        public void MakeHonkNoise()
        {

            Console.WriteLine($"This is the honk noise {HonkNoise}");


        }
    }
}
