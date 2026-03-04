using System;
using System.Numerics;

namespace ValueExample
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
        
       
    


}