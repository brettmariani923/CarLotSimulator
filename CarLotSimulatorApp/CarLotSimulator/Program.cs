using System;
using System.Net.Sockets;
using System.Xml.Schema;
using Microsoft.VisualBasic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            CarLot carLot = new CarLot();

            Car newCar1 = new Car();
            //Car newCar1 = new Car() {Make = Volve......};
            Car newCar2 = new Car();
            Car newCar3 = new Car();

            newCar1.Make = "Volvo";
            newCar2.Make = "Audi";
            newCar3.Make = "BMW";

            newCar1.Model = "s80";
            newCar2.Model = "A8";
            newCar3.Model = "i90";


            newCar1.Year = 2004;
            newCar2.Year = 2008;
            newCar3.Year = 2009;

            newCar1.EngineNoise("quiet");
            newCar2.EngineNoise("loud");
            newCar3.EngineNoise("skips");

            newCar1.HonkNoise("loud");
            newCar2.HonkNoise("loud");
            newCar3.HonkNoise("loud");

            newCar1.Driveable = true;
            newCar2.Driveable = true;
            newCar3.Driveable = true;

            carLot.Cars.Add(newCar1);
            carLot.Cars.Add(newCar2);
            carLot.Cars.Add(newCar3);


            foreach (Car car in carLot.Cars)
            {
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
                Console.WriteLine(car.Year);
               
            }
    
        }
    

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        
    } 
}