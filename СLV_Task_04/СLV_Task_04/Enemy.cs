using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СLV_Task_04
{
    class Enemy
    {
        public void Interface(int move, int powerEnemy)
        {
            Console.Write("Игровой такт № - {0}" +
                    "\nВас атакуют!" +
                    "\nВыстрел!: -{1}нр \n", move, powerEnemy +
                    " ");
        }
    }
}
