using FarmSystem.Test2;
using System;
using System.Collections.Generic;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        //TEST 1
        public void Enter(Animal animal)
        {
            
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities

            Console.WriteLine("{0} has entered the Emydex farm",animal.GetType().Name);
        }
     
        //TEST 2
        public void MakeNoise(Animal animal)
        {
            //Test 2 : Modify this method to make the animals talk

            animal.Talk();

        }

        //TEST 3
        public void MilkAnimals(IMilkableAnimal milkAnimal)
        {
           

            milkAnimal.ProduceMilk();

        }

        //TEST 4
        public void ReleaseAllAnimals(ref List<Animal> animals)
        {
            //MilkAnimals.
            foreach (Animal an in animals)
            {
                Console.WriteLine("{0} has left the farm", an.GetType().Name);
            }

            /*Clearing the queue after releasing animals*/
            animals.Clear();
            
            OnFarmEmpty();
        }

        /*Event Handler for Farm Empty event*/
        public delegate void FarmEmptyEventHandler(Object source, EventArgs args);
        public event FarmEmptyEventHandler FarmEmptied;
        protected virtual void OnFarmEmpty()
        {
            if (FarmEmptied != null)
                FarmEmptied(this, EventArgs.Empty);
        }
    }
}