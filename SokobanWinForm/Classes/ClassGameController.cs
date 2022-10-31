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
                LevelMatrix[i, 5] = MatrixValue.w;
                LevelMatrix[i, 0] = MatrixValue.w;
            }

            for(int i = 0; i < 6; i++)
            {
                LevelMatrix[0, i] = MatrixValue.w;
                LevelMatrix[4, i] = MatrixValue.w;
            }
            LevelMatrix[1, 1] = MatrixValue.p;
            LevelMatrix[2, 2] = MatrixValue.b;
            LevelMatrix[3, 4] = MatrixValue.t;

        }

        public bool moveDown()
        {
            ClassСoordinates coordinate = getPlayerCoordinate();
            //Проверка на выход за границу
            if ((coordinate.j+1)==6) 
                return false;

            //перемещение на пустоe поле
            if (LevelMatrix[coordinate.i, coordinate.j+1]==MatrixValue.z)
            {
               
                LevelMatrix[coordinate.i, coordinate.j+1] = MatrixValue.p;
                if (LevelMatrix[coordinate.i, coordinate.j] == MatrixValue.p)
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                else LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.t;
                return true;
            }

            //перемещение на Целевое
            if (LevelMatrix[coordinate.i, coordinate.j + 1] == MatrixValue.t)
            {
                LevelMatrix[coordinate.i, coordinate.j + 1] = MatrixValue.pt;
                LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                return true;
            }

            //сдвиг ящика обычный: в никуда, на пустое, на целевое
            if (LevelMatrix[coordinate.i, coordinate.j + 1] == MatrixValue.b )
            {
                if ((coordinate.j + 2) == 6) 
                    return false;

                if (LevelMatrix[coordinate.i, coordinate.j + 2] == MatrixValue.z)
                {
                    LevelMatrix[coordinate.i, coordinate.j + 1] = MatrixValue.p;
                    LevelMatrix[coordinate.i, coordinate.j + 2] = MatrixValue.b;
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    return true;
                }

                if (LevelMatrix[coordinate.i, coordinate.j + 2] == MatrixValue.t)
                {
                    LevelMatrix[coordinate.i, coordinate.j + 1] = MatrixValue.p;
                    LevelMatrix[coordinate.i, coordinate.j + 2] = MatrixValue.bt;
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    return true;
                }

            }

            //сдвиг ящика с целевой точки
            if (LevelMatrix[coordinate.i, coordinate.j + 1] == MatrixValue.bt)
            {
                if ((coordinate.j + 2) == 6)
                    return false;

                if (LevelMatrix[coordinate.i, coordinate.j + 2] == MatrixValue.z)
                {
                    LevelMatrix[coordinate.i, coordinate.j + 1] = MatrixValue.pt;
                    LevelMatrix[coordinate.i, coordinate.j + 2] = MatrixValue.b;
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    return true;

                }
                if (LevelMatrix[coordinate.i, coordinate.j + 2] == MatrixValue.t)
                {
                    LevelMatrix[coordinate.i, coordinate.j + 1] = MatrixValue.pt;
                    LevelMatrix[coordinate.i, coordinate.j + 2] = MatrixValue.bt;
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    return true;
                }

            }    

                return false;
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
            ClassСoordinates coordinate = getPlayerCoordinate();
            //Проверка на выход за границу
            if ((coordinate.j - 1) == -1)
                return false;

            //перемещение на пустоe поле
            if (LevelMatrix[coordinate.i, coordinate.j - 1] == MatrixValue.z)
            {

                LevelMatrix[coordinate.i, coordinate.j - 1] = MatrixValue.p;
                if (LevelMatrix[coordinate.i, coordinate.j] == MatrixValue.p)
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                else LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.t;
                return true;
            }

            //перемещение на Целевое
            if (LevelMatrix[coordinate.i, coordinate.j - 1] == MatrixValue.t)
            {
                LevelMatrix[coordinate.i, coordinate.j - 1] = MatrixValue.pt;
                LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                return true;
            }

            //сдвиг ящика обычный: в никуда, на пустое, на целевое
            if (LevelMatrix[coordinate.i, coordinate.j - 1] == MatrixValue.b)
            {
                if ((coordinate.j - 2) == -1)
                    return false;

                if (LevelMatrix[coordinate.i, coordinate.j - 2] == MatrixValue.z)
                {
                    LevelMatrix[coordinate.i, coordinate.j - 1] = MatrixValue.p;
                    LevelMatrix[coordinate.i, coordinate.j - 2] = MatrixValue.b;
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    return true;
                }

                if (LevelMatrix[coordinate.i, coordinate.j - 2] == MatrixValue.t)
                {
                    LevelMatrix[coordinate.i, coordinate.j - 1] = MatrixValue.p;
                    LevelMatrix[coordinate.i, coordinate.j - 2] = MatrixValue.bt;
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    return true;
                }

            }

            //сдвиг ящика с целевой точки
            if (LevelMatrix[coordinate.i, coordinate.j + 1] == MatrixValue.bt)
            {
                if ((coordinate.j + 2) == 6)
                    return false;

                if (LevelMatrix[coordinate.i, coordinate.j + 2] == MatrixValue.z)
                {
                    LevelMatrix[coordinate.i, coordinate.j + 1] = MatrixValue.pt;
                    LevelMatrix[coordinate.i, coordinate.j + 2] = MatrixValue.b;
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    return true;

                }
                if (LevelMatrix[coordinate.i, coordinate.j + 2] == MatrixValue.t)
                {
                    LevelMatrix[coordinate.i, coordinate.j + 1] = MatrixValue.pt;
                    LevelMatrix[coordinate.i, coordinate.j + 2] = MatrixValue.bt;
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    return true;
                }

            }

            return false;
        }

        /// <summary>
        /// Поиск нахождения игрока
        /// </summary>
        /// <returns>Координаты</returns>
        private ClassСoordinates getPlayerCoordinate()
        {
            ClassСoordinates сoordinates = new ClassСoordinates();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 6; j++)
                    if (LevelMatrix[i, j] == MatrixValue.p)
                    {
                        сoordinates.i = i;
                        сoordinates.j = j;
                    }

            return сoordinates;
        }
        
    }
}
