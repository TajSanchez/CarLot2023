﻿namespace CarLot2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarLot dougDimmadome = new CarLot();

            Car vehicle = new Car();
            vehicle.Make = "Ferrari";
            vehicle.Model = "Spider";
            vehicle.Year = 1995;
            vehicle.EngineNoise = "BRRRRMMmmmmm";
            vehicle.HonkNoise = "Meep Meep";
            vehicle.IsDrivable = true;


            dougDimmadome.Inventory.Add(vehicle);

            vehicle.MakeEngineNoise();
            vehicle.MakeHonkNoise();
            Console.WriteLine();

            var mcclarren = new Car()
            {
                Make = "McClarren",
                Model = "Senna",
                Year = 2019,
                EngineNoise = "oooooweee",
                HonkNoise = "Move Over",
                IsDrivable = false
            };

            dougDimmadome.Inventory.Add(mcclarren);

            mcclarren.MakeEngineNoise();
            mcclarren.MakeHonkNoise();
            Console.WriteLine();

            var porsche = new Car("Porsche", "Mission E", 2024, "Shhhhhhh", " Gerald Broflovski voice: Thannnnksssss", true);

            porsche.MakeEngineNoise();
            porsche.MakeHonkNoise();
            dougDimmadome.Inventory.Add(porsche);

            Console.WriteLine();
            Console.WriteLine("These are my cars in my lot");
            Console.WriteLine("Here is the number of cars in my lot: " + CarLot.numberOfCars);

            Console.WriteLine();

            foreach (var car in dougDimmadome.Inventory)
            {
                Console.WriteLine($"{car.Make}, {car.Model}, {car.Year}, {car.IsDrivable}");
            }

        }

    }
}