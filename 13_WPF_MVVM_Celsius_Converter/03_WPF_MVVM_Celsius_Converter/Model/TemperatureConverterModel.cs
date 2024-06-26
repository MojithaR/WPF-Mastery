using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WPF_MVVM_Celsius_Converter.Model
{
    internal class TemperatureConverterModel
    {
        public double Celsius { get; set; }
        public double Kelvin => Celsius + 273.15;
        public double Fahrenheit => Celsius * 9 / 5 + 32;
    }
}
