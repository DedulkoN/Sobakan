using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SokobanWinForm.Interfases;

namespace SokobanWinForm.Classes
{
    internal class ClassGameController: ClassLevelMatrix, InterfaceMoving
    {
        //выше - множественное наследование (один класс и интерфейсы в нужном числе)


        /// <summary>
        /// Конструктор
        /// </summary>
       public ClassGameController()
            :base (4,5) 
        {
            //выше - вызов конструктора базового класса из класса-наследника


        }

        public bool moveDown()
        {
            throw new NotImplementedException();
        }

        public bool moveLeft()
        {
            throw new NotImplementedException();
        }

        public bool moveRight()
        {
            throw new NotImplementedException();
        }

        public bool moveUp()
        {
            throw new NotImplementedException();
        }
    }
}
