using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SokobanWinForm.Interfases;

namespace SokobanWinForm.Classes
{
    internal class ClassGameController: ClassLevelMatrix, InterfaceMoving, InterfaceGameVictory
    {
        //выше - множественное наследование (один класс и интерфейсы в нужном числе)


        /// <summary>
        /// Конструктор
        /// </summary>
       public ClassGameController()
            :base (6,7) 
        {
            //выше - вызов конструктора базового класса из класса-наследника

            //заполнение матрицы уровня, пока так - потом сделать из файла
            for (int i = 0; i < i_count; i++)
                for(int j = 0; j < j_count; j++)
                { LevelMatrix[i, j] = MatrixValue.z; }

            for (int i = 0; i < i_count; i++)
            {
                LevelMatrix[i, j_count-1] = MatrixValue.w;
                LevelMatrix[i, 0] = MatrixValue.w;
            }

            for(int i = 0; i < j_count; i++)
            {
                LevelMatrix[0, i] = MatrixValue.w;
                LevelMatrix[i_count-1, i] = MatrixValue.w;
            }
            LevelMatrix[1, 1] = MatrixValue.p;
            LevelMatrix[2, 2] = MatrixValue.b;
            LevelMatrix[3, 4] = MatrixValue.t;

        }

       
        public bool moveDown()
        {
            ClassСoordinates coordinate = getPlayerCoordinate();
            //Проверка на выход за границу
            if ((coordinate.j+1)==j_count) 
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
                if ((coordinate.j + 2) == j_count) 
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
                if ((coordinate.j + 2) == j_count)
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
            ClassСoordinates coordinate = getPlayerCoordinate();
            //Проверка на выход за границу
            if ((coordinate.i - 1) == -1)
                return false;

            //перемещение на пустоe поле
            if (LevelMatrix[coordinate.i- 1, coordinate.j ] == MatrixValue.z)
            {

                LevelMatrix[coordinate.i- 1, coordinate.j ] = MatrixValue.p;
                if (LevelMatrix[coordinate.i, coordinate.j] == MatrixValue.p)
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                else LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.t;
                return true;
            }

            //перемещение на Целевое
            if (LevelMatrix[coordinate.i- 1, coordinate.j ] == MatrixValue.t)
            {
                LevelMatrix[coordinate.i- 1, coordinate.j ] = MatrixValue.pt;
                LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                return true;
            }

            //сдвиг ящика обычный: в никуда, на пустое, на целевое
            if (LevelMatrix[coordinate.i- 1, coordinate.j ] == MatrixValue.b)
            {
                if ((coordinate.i - 2) == -1)
                    return false;

                if (LevelMatrix[coordinate.i - 2, coordinate.j] == MatrixValue.z)
                {
                    LevelMatrix[coordinate.i- 1, coordinate.j ] = MatrixValue.p;
                    LevelMatrix[coordinate.i- 2, coordinate.j ] = MatrixValue.b;
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    return true;
                }

                if (LevelMatrix[coordinate.i- 2, coordinate.j ] == MatrixValue.t)
                {
                    LevelMatrix[coordinate.i- 1, coordinate.j ] = MatrixValue.p;
                    LevelMatrix[coordinate.i- 2, coordinate.j ] = MatrixValue.bt;
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    return true;
                }

            }

            //сдвиг ящика с целевой точки
            if (LevelMatrix[coordinate.i-1, coordinate.j ] == MatrixValue.bt)
            {
                if ((coordinate.j -2) == -1)
                    return false;

                if (LevelMatrix[coordinate.i -2, coordinate.j ] == MatrixValue.z)
                {
                    LevelMatrix[coordinate.i - 1, coordinate.j ] = MatrixValue.pt;
                    LevelMatrix[coordinate.i - 2, coordinate.j ] = MatrixValue.b;
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    return true;

                }
                if (LevelMatrix[coordinate.i - 2, coordinate.j ] == MatrixValue.t)
                {
                    LevelMatrix[coordinate.i - 1, coordinate.j ] = MatrixValue.pt;
                    LevelMatrix[coordinate.i - 2, coordinate.j ] = MatrixValue.bt;
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    return true;
                }

            }

            return false;
        }

        public bool moveRight()
        {
            ClassСoordinates coordinate = getPlayerCoordinate();
            //Проверка на выход за границу
            if ((coordinate.i + 1) == i_count)
                return false;

            //перемещение на пустоe поле
            if (LevelMatrix[coordinate.i + 1, coordinate.j] == MatrixValue.z)
            {

                LevelMatrix[coordinate.i + 1, coordinate.j] = MatrixValue.p;
                if (LevelMatrix[coordinate.i, coordinate.j] == MatrixValue.p)
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                else LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.t;
                return true;
            }

            //перемещение на Целевое
            if (LevelMatrix[coordinate.i + 1, coordinate.j] == MatrixValue.t)
            {
                LevelMatrix[coordinate.i + 1, coordinate.j] = MatrixValue.pt;
                LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                return true;
            }

            //сдвиг ящика обычный: в никуда, на пустое, на целевое
            if (LevelMatrix[coordinate.i + 1, coordinate.j] == MatrixValue.b)
            {
                if ((coordinate.i + 2) == i_count)
                    return false;

                if (LevelMatrix[coordinate.i + 2, coordinate.j] == MatrixValue.z)
                {
                    LevelMatrix[coordinate.i + 1, coordinate.j] = MatrixValue.p;
                    LevelMatrix[coordinate.i + 2, coordinate.j] = MatrixValue.b;
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    return true;
                }

                if (LevelMatrix[coordinate.i + 2, coordinate.j] == MatrixValue.t)
                {
                    LevelMatrix[coordinate.i + 1, coordinate.j] = MatrixValue.p;
                    LevelMatrix[coordinate.i + 2, coordinate.j] = MatrixValue.bt;
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    return true;
                }

            }

            //сдвиг ящика с целевой точки
            if (LevelMatrix[coordinate.i + 1, coordinate.j] == MatrixValue.bt)
            {
                if ((coordinate.i + 2) == i_count)
                    return false;

                if (LevelMatrix[coordinate.i + 2, coordinate.j] == MatrixValue.z)
                {
                    LevelMatrix[coordinate.i + 1, coordinate.j] = MatrixValue.pt;
                    LevelMatrix[coordinate.i + 2, coordinate.j] = MatrixValue.b;
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    return true;

                }
                if (LevelMatrix[coordinate.i + 2, coordinate.j] == MatrixValue.t)
                {
                    LevelMatrix[coordinate.i + 1, coordinate.j] = MatrixValue.pt;
                    LevelMatrix[coordinate.i + 2, coordinate.j] = MatrixValue.bt;
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    return true;
                }

            }

            return false;
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
            if (LevelMatrix[coordinate.i, coordinate.j - 1] == MatrixValue.bt)
            {
                if ((coordinate.j - 2) == -1)
                    return false;

                if (LevelMatrix[coordinate.i, coordinate.j - 2] == MatrixValue.z)
                {
                    LevelMatrix[coordinate.i, coordinate.j - 1] = MatrixValue.pt;
                    LevelMatrix[coordinate.i, coordinate.j - 2] = MatrixValue.b;
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    return true;

                }
                if (LevelMatrix[coordinate.i, coordinate.j - 2] == MatrixValue.t)
                {
                    LevelMatrix[coordinate.i, coordinate.j - 1] = MatrixValue.pt;
                    LevelMatrix[coordinate.i, coordinate.j - 2] = MatrixValue.bt;
                    LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    return true;
                }

            }

            return false;
        }

        public void Victory()
        {
            throw new NotImplementedException();
        }

        public bool VictoryValidate()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Поиск нахождения игрока
        /// </summary>
        /// <returns>Координаты</returns>
        private ClassСoordinates getPlayerCoordinate()
        {
            ClassСoordinates сoordinates = new ClassСoordinates();
            for (int i = 0; i < i_count; i++)
                for (int j = 0; j < j_count; j++)
                    if (LevelMatrix[i, j] == MatrixValue.p || LevelMatrix[i, j] == MatrixValue.pt)
                    {
                        сoordinates.i = i;
                        сoordinates.j = j;
                    }

            return сoordinates;
        }
        
    }
}
