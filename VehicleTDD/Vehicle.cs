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
        public string Model { get; set; }
        public string Make { get; set; }
        public string Year { get; set; }
        public double EngineSize { get; set; }
        public int RimSize { get; set; }
        public string VehColor { get; set; }

        public Vehicle()
        {

        }
        public Vehicle(string model, string make, string year)
        {
            this.Model = model;
            this.Make = make;
            this.Year = year;
        }
        
        public double GetMPH(double distance, double time)
        {
            if (time == 0)
            {
                return 0;
            }
            return distance / time;
        } 

        public double GetMPH(double distance, TimeSpan time)
        {
            double hours = time.TotalHours;
            return GetMPH(distance, hours);
        }
       
    }
}
