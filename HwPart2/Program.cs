using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temp1 = new Temperature();
            Console.WriteLine(temp1.ToString());

            Temperature temp2 = new Temperature('C', 20);
            temp2.SetTemperature(45);
            Console.WriteLine(temp2.ToString());
            temp2.SetScaleAndTemperature('F', 32);

            if (temp1.Equals(temp2))
            {
                Temperature temp3 = new Temperature('F');
                temp3.SetTemperature(84);
                Console.WriteLine(temp3.ToString());
            }
            else
            {
                Temperature temp4 = new Temperature(40);
                temp4.SetScale('F');
                Console.WriteLine(temp4.ToString());
            }

            Console.Read();
        }
    }

    class Temperature
    {
        float temperature;
        char scale;

        public Temperature()
        {
            temperature = 0;
            scale = 'C';
        }

        public Temperature(float _temperature)
        {
            scale = 'C';
            temperature = _temperature;
        }

        public Temperature(char _scale)
        {
            scale = char.ToUpper(_scale);
            if (_scale != 'C' && _scale != 'F')
                scale = 'C';
            temperature = 0;
        }

        public Temperature(char _scale, float _temperature)
        {
            scale = char.ToUpper(_scale);
            if (_scale != 'C' && _scale != 'F')
                scale = 'C';

            temperature = _temperature;
        }

        public void SetTemperature(float _temp)
        {
            temperature = _temp;
        }

        public void SetScale(char _scale)
        {
            scale = char.ToUpper(_scale);
            if (_scale != 'C' && _scale != 'F')
                scale = 'C';
        }

        public void SetScaleAndTemperature(char _scale, float _temp)
        {
            scale = char.ToUpper(_scale);
            if (_scale != 'C' && _scale != 'F')
                scale = 'C';

            temperature = _temp;
        }

        public float GetTemperatureCelsius()
        {
            if (scale != 'C')
                return (temperature - 32) / 1.8f;
            return temperature;
        }

        public float GetTemperatureFahrenheit()
        {
            if (scale != 'F')
                return temperature * 1.8f + 32;
            return temperature;
        }

        public bool Equals(Temperature _temperature)
        {
            return GetTemperatureFahrenheit() == _temperature.GetTemperatureFahrenheit();
        }

        public override string ToString()
        {
            if (scale == 'C')
                return temperature + " degrees Celsius";
            return temperature + " degrees Fahrenheit";
        }
    }
}
