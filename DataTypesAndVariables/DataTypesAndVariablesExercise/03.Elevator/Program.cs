using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)countOfPeople / elevatorCapacity);
            //if (countOfPeople % elevatorCapacity != 0)
            //{
            //    if (countOfPeople % elevatorCapacity <= elevatorCapacity)
            //    {
            //        courses++;
            //    }
            //    else
            //    {
            //        courses += (countOfPeople % elevatorCapacity) / elevatorCapacity;
            //    }
            //}

            Console.WriteLine(courses);
        }
    }
}
