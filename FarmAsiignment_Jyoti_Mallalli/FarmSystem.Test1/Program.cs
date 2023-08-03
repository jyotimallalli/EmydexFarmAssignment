using FarmSystem.Test2;
using System;
using System.Collections.Generic;
namespace FarmSystem.Test1
{
    internal class Program
    {
       
        private static void Main(string[] args)
        {
            /*Animal Queue*/
            List<Animal> animals = new List<Animal>();

            /*Subscribe to farm empty event*/
            EmydexFarmSystem farm = new EmydexFarmSystem();
            farm.FarmEmptied += OnFarmEmptied;

            /*Exercises*/
            Excercise1(ref animals, ref farm);
            Excercise2(ref animals, ref farm);
            Excercise3(ref animals, ref farm);
            Excercise4(ref animals,ref farm);

           
            Console.ReadKey();
        }

/************************************************************************************************************
Exercise 1 : Apply OOP concepts (abstraction and encapsulation) to the classes 
modify the code to get the output below
Cow has entered the farm
Hen has entered the farm
Horse has entered the farm
Sheep has entered the farm
***************************************************************************************************************/
        private static void Excercise1(ref List<Animal> animals, ref EmydexFarmSystem farm)
        {
            Console.WriteLine("Exercise 1 : Press any key when it is time to open the Farm to animals");
            Console.ReadKey();

            /*Cow*/
            Animal cow = new Cow();
            cow.Id = Guid.NewGuid().ToString();
            cow.NoOfLegs = 4;
            animals.Add(cow);

            
            /*Hen*/
            Animal hen = new Hen();
            hen.Id = Guid.NewGuid().ToString();
            cow.NoOfLegs = 2;
            animals.Add(hen);

            /*Horse*/
            Animal horse = new Horse();
            horse.Id = Guid.NewGuid().ToString();
            horse.NoOfLegs = 4;
            animals.Add(horse);

           
            /*Sheep*/
            Animal sheep = new Sheep();
            sheep.Id = Guid.NewGuid().ToString();
            sheep.NoOfLegs = 4;
            animals.Add(sheep);

            foreach(Animal an in animals)
            {
                farm.Enter(an);
            }
            
            Console.ReadKey();
        }

/***************************************************************************************************************
 Test Excercise 2
 If you have completed the first test excercise, you can continue with the second one
 Modify the program and EmydexFarmSystem.MakeNoise() method to get the below output
 Expected Test 2 Program Output

 Exercise 2 : Press any key to scare the animals in the farm
    Cow has entered the farm
    Hen has entered the farm
    Horse has entered the farm
    Sheep has entered the farm
    Cow says Moo!
    Hen says CLUCKAAAAAWWWWK!
    Horse says Neigh!
    Sheep says baa!
 *****************************************************************************************************************/
        private static void Excercise2(ref List<Animal> animals, ref EmydexFarmSystem farm)
        {
            //TODO : Apply OOP concepts and modify the code below to get the required output 
            Console.WriteLine("Exercise 2 : Press any key to scare the animals in the farm");
            Console.ReadKey();
           
            /*Animals Entered the Farm*/
            foreach (Animal an in animals)
            {
                farm.Enter(an);
            }

            /*Animals make noise*/
            foreach (Animal an in animals)
            {
                farm.MakeNoise(an);

            }

            Console.ReadKey();
        }

/*****************************************************************************************************************
Test Excercise 3
If you have completed the previous test excercise, you can continue with this one 
The project includes an interface IMilkableAnimal. Make use of this interface to implement on the relevant classes
so that calling the EmydexFarmSystem.MilkAnimals() method to get the below output

Expected Test 3 Program Output

Exercise 3 : Press any key when it is time to milk animals
Cow has entered the farm
Hen has entered the farm
Horse has entered the farm
Sheep has entered the farm
Cow was milked!
************************************************************************************************************/
        private static void Excercise3(ref List<Animal> animals, ref EmydexFarmSystem farm)
        {
            //TODO : Apply OOP concepts and modify the code below to get the required output 
            Console.WriteLine("Exercise 3 : Press any key when it is time to milk animals");
            Console.ReadKey();
         
            /*Animals Entered Farm*/
            foreach (Animal an in animals)
            {
                farm.Enter(an);
            }

            /*Milk Animals*/
            foreach (Animal an in animals)
            {
                if(an is IMilkableAnimal)
                farm.MilkAnimals(an as IMilkableAnimal);

            }
          
            Console.ReadKey();
        }

/****************************************************************************************************
Test Excercise 4
Modify the EmydexFarmSystem.ReleaseAllAnimals() so that all animals are released (simply clear the collection )
Expose an event on the FarmSystem FarmEmpty which is invoked once all the animals are released
Subscribe to that event in the main to get the expected output

Expected Test 4 Program Output

Exercise 4: Press any key to free all animals
Cow has entered the farm
Hen has entered the farm
Horse has entered the farm
Sheep has entered the farm
Cow has left the farm
Hen has left the farm
Horse has left the farm
Sheep has left the farm
Emydex Farm is now empty
********************************************************************************************************************/
        private static void Excercise4(ref List<Animal> animals,ref EmydexFarmSystem farm)
        {
            //TODO : Apply OOP concepts and modify the code below to get the required output 
            Console.WriteLine("Exercise 4: Press any key to free all animals");
            Console.ReadKey();

            /*Animals Entered Farm*/
            foreach (Animal an in animals)
            {
                farm.Enter(an);
            }
            /*Release All ANimals*/
            farm.ReleaseAllAnimals(ref animals);
            
            Console.ReadKey();
        }

        /*Subscriber Function to Farm Empty */
        public static void OnFarmEmptied(Object source,EventArgs e)
        {
            Console.WriteLine("Emydex Farm is now empty");
        }
    }
}