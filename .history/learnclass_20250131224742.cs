using System;
using System.Numerics;

namespace ValueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public class Unit
        {
            int speed;
            public virtual void Move()
            {
                Console.WriteLine("Moving");
            }
        }
        public class Player:Unit
        {
            speed = 5;
            public override void Move()
            {
                Console.WriteLine("Player is moving");
            }
    }


}