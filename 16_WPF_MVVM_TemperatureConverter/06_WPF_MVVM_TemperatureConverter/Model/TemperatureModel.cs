using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_WPF_MVVM_TemperatureConverter.Model // Defining the namespace for the Model
{
    public class TemperatureModel // Defining the TemperatureModel class
    {
        public double Celsius { get; set; } // Property for Celsius temperature
        public double Fahrenheit { get; set; } // Property for Fahrenheit temperature
        public double Kelvin { get; set; } // Property for Kelvin temperature
    }
}
