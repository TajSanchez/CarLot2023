using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CarLot2023
{
    public class CarLot
    {
        public static int numberOfCars = 0;
        
        public List<Car> Inventory { get; set; } = new List<Car>();
    }
}   
