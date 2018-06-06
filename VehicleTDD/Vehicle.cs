using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTDD
{
    public class Vehicle
    {
        
       
        public string GetName { get; set; }
        public Vehicle()
        {

        }
        public Vehicle(string name)
        { 
            this.GetName = name;
        }
    }
}
