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
            public sealed override void Move()
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
            ~Player(){
                Console.WriteLine("Player is being destroyed");
                //析构函数，当对象被销毁时调用
            }
            public override void Move()
            {
                Console.WriteLine("Player is moving");
            }
        }
        public class Unit
        {
            protected int speed;//受保护的变量，只能在本类及其子类中访问
            public virtual void Move()
            {
                Console.WriteLine("Moving");
            }
        }
        /*abstract class:只能被继承，不能实例化，不能创建对象，只能作为基类使用，不能有自己的实例变量和方法，只能包含抽象方法和属性。
        abstract方法：不能实现，只能声明，必须由子类实现。
        收藏：https://so.csdn.net/so/search?q=c%23&t=blog&u=abraham_ly
        */
        public sealed class bag
        {
            //sealed类：不能被继承，只能在本类中访问
            public void Open()
            {
                
            }
        }
       
    }


}