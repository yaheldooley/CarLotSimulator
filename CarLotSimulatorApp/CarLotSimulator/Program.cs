using System;
using System.Collections.Generic;

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

			Carlot carlot = new Carlot();

			var chevy = new Car()
			{
				Make = "Chevy",
				Model = "Bolt",
				Year = 2022,
				EngineNoise = "None",
				HonkNoise = "Standard Honk",
				IsDriveable = true,
			};
			carlot.allCars.Add(chevy);

			Car mustang = new Car();
			mustang.Make = "Ford";
			mustang.Model = "Mustang";
			mustang.Year = 2019;
			mustang.EngineNoise = "Brum Brum Bruuuuuuum";
			mustang.HonkNoise = "Ah-ooh-guhh";
			mustang.IsDriveable = true;
			carlot.allCars.Add(mustang);

			Car caravan = new Car("Dodge", "Caravan", 1998, "Standard");
			caravan.HonkNoise = "Beep beep";
			caravan.IsDriveable = false;
			carlot.allCars.Add(caravan);

			//*************BONUS*************//

			// Set the properties utilizing the 3 different ways we learned about, one way for each car

			//*************BONUS X 2*************//

			//Create a CarLot class
			//It should have at least one property: a List of cars
			//Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
			//At the end iterate through the list printing each of car's Year, Make, and Model to the console
			carlot.PrintAllCarsToConsole();
		}

        public class Car
        {
            public string Make { get; set; }
			public string Model { get; set; }
			public int Year { get; set; }
			public string EngineNoise { get; set; }
			public string HonkNoise { get; set; }
			public bool IsDriveable { get; set; }

			public Car() 
			{ 
			
			}

			public Car(string make, string model, int year, string engine)
			{
				Make = make;
				Model = model;
				Year = year;
				EngineNoise = engine;
			}

			public void MakeEngineNoise(string engineNoise)
            {
                Console.WriteLine($"The sound of {engineNoise} starts");
            }

            public void MakeHonkNoise(string honkNoise)
            {
				Console.WriteLine($"A car's {honkNoise} sounds");
			}

		}

		public class Carlot
		{
			public List<Car> allCars = new List<Car>();

			public void PrintAllCarsToConsole()
			{
				for (int i = 0; i < allCars.Count; i++)
				{
					Console.WriteLine($"{i + 1}. Make: {allCars[i].Make}, Model: {allCars[i].Model}, Year: {allCars[i].Year}");
				}
			}
		}


    }
}
