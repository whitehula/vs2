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
            enemy enemy = new enemy();
            enemy.Move();
            enemyMelee enemyMelee = new enemyMelee();
            enemyMelee.Move();
            Unit unit1 = enemyMelee;
            unit1.Move();
            List<Unit> UnitList = new List<Unit>(){
                unit,
                enemy,
                enemyMelee
            };//记得加；
            //unit1.Sad();本身还没有Sad方法，所以报错
        }
        public class enemyMelee:enemy
        {
            public override void Move()
            {
                Console.WriteLine("EnemyMelee is melee attacking");
            }
            public void Sad()
            {
                Console.WriteLine("EnemyMelee is sad");
        }}
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
            protected int speed;//
            public virtual void Move()
            {
                Console.WriteLine("Moving");
            }
        }
       
    }


}