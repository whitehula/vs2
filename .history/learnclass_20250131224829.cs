using System;
using System.Numerics;

namespace ValueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit unit = new Unit();
            Player player = new Player();
            unit.Move();
            player.Move();
        }
        public class Unit
        {
            publicint speed;
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


}