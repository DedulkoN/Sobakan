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
            :base (5,6) 
        {
            //выше - вызов конструктора базового класса из класса-наследника

            //заполнение матрицы уровня, пока так - потом сделать из файла
            for (int i = 0; i < 5; i++)
                for(int j = 0; j < 6; j++)
                { LevelMatrix[i, j] = MatrixValue.z; }

            for (int i = 0; i < 5; i++)
            {
                LevelMatrix[i, 6] = MatrixValue.w;
                LevelMatrix[i, 0] = MatrixValue.w;
            }

            for(int i = 0; i < 6; i++)
            {
                LevelMatrix[0, i] = MatrixValue.w;
                LevelMatrix[5, i] = MatrixValue.w;
            }
            LevelMatrix[1, 1] = MatrixValue.p;
            LevelMatrix[2, 2] = MatrixValue.b;
            LevelMatrix[3, 4] = MatrixValue.t;

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
