using System;
using System.Collections.Generic;
using System.Text;

namespace WhereIsMyCar
{
    class Car
    {
        //The car has a mark name(string), model name(string), registration number(string, no longer than six characters), color(string), odometer(int) and fuel tank(int)
        private string _markName;
        private string _modelName;
        private string _regNumber;
        private string _color;
        private int _odometer = 0;
        private int _fueltank = 60;
        public Car(string markName, string modelName, string regNumber, string color)
        {
            _markName = markName;
            _modelName = modelName;
            if (regNumber.Length>6) {
                throw new ArgumentOutOfRangeException($"Registration number cannot be more than 6 characters. Current: {regNumber}");  
            }
            _regNumber = regNumber;
            _color = color;
        }
        public string Mark { get { return _markName; } }
        public string Model { get { return _modelName; } }
        public string Registration { get { return _regNumber; } }
        public string Color { get { return _color; } }
        public int Odometer { get { return _odometer; } }
        public int FuelTank { get { return _fueltank; } }
        public void PrintCarInfo()
        {
            Console.WriteLine($"Mark: {_markName}\nModel: {_modelName}\nRegistration: {_regNumber}\nColor: {_color}\nOdometer: {_odometer}\nFueltank: {_fueltank}");
        }
        public void Drive()
        {
            Console.WriteLine("wroom-wroom");
            _odometer += 100;
            _fueltank -= 5;
        }
        public void DriveEmpty()
        {
            do
            {
                Drive();

            } while (_fueltank > 0);
        }
    }
}
