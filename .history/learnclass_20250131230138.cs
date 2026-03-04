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
        public class enemyMelee
        public class enemy:Unit
        {
            public override void Move()
            {
                Console.WriteLine("Enemy is moving");
            }
        }
         public class Player:Unit
        {
            public Player(){
            speed = 5;//字符初始化
            }
            public override void Move()
            {
                Console.WriteLine("Player is moving");
            }
        }
        public class Unit
        {
            public int speed;
            public virtual void Move()
            {
                Console.WriteLine("Moving");
            }
        }
       
    }


}