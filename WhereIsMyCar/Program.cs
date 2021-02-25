using System;

namespace WhereIsMyCar
{
    class Program
    {
        //        Create a class Car
        //The car has a mark name(string), model name(string), registration number(string, no longer than six characters), color(string), odometer(int) and fuel tank(int)
        //The odometer value equals 0 by default.
        //The fuel tank value by default is 60.
        //No car characteristics can be changed after the car object has been created.*
        //All the car characteristics can be accessed using ‘.’ (E.g.newCar.Model);
        //The car can drive.Every lap the car passes increases the value of the odometer by 100 and decreases the value of the fuel tank by 5 .
      
   //     Part 2
//Write a program that allows you to create a car object and makes the car drive until the fuel tank is empty(equals 0). When the fuel tank value reaches 0, the car stops.
//Part 3
//Write a method to display all the car properties (characteristics).




        static void Main(string[] args)
        {
            Car MeanMachine = new Car("Ford", "Focus", "AAA123", "white");
            MeanMachine.PrintCarInfo();
            MeanMachine.Drive();
            MeanMachine.PrintCarInfo();
            MeanMachine.DriveEmpty();
            MeanMachine.PrintCarInfo();
        }
    }
}
