using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SokobanWinForm.Interfases;

namespace SokobanWinForm.Classes
{
    [Serializable]
    internal class ClassGameController: ClassLevelMatrix,  InterfaceMoving, InterfaceGameVictory
    {
        //выше - множественное наследование (один класс и интерфейсы в нужном числе)
      
        public int count_step;

        /// <summary>
        /// Конструктор
        /// </summary>
       public ClassGameController():base(8,5)            
        {
            count_step = 0;
            //заполнение матрицы уровня, пока так - потом сделать из файла
            for (int i = 0; i < i_count; i++)
                for(int j = 0; j < j_count; j++)
                { LevelMatrix[i, j] = MatrixValue.z; }

            for (int i = 0; i < i_count; i++)
            {
                LevelMatrix[i, j_count -1] = MatrixValue.w;
                LevelMatrix[i, 0] = MatrixValue.w;
            }

            for(int i = 0; i < j_count; i++)
            {
                LevelMatrix[0, i] = MatrixValue.w;
                LevelMatrix[i_count -1, i] = MatrixValue.w;
            }
            LevelMatrix[1, 1] = MatrixValue.p;
            LevelMatrix[2, 1] = MatrixValue.b;
            LevelMatrix[3, 1] = MatrixValue.t;
            LevelMatrix[4, 1] = MatrixValue.b;
            LevelMatrix[5, 1] = MatrixValue.t;
            LevelMatrix[4, 3] = MatrixValue.b;
            LevelMatrix[1, 3] = MatrixValue.t;



        }



        public bool moveDown()
        {
            ClassСoordinates coordinate = getPlayerCoordinate();
            //Проверка на выход за границу
            if ((coordinate.j+1)== j_count) 
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
                    if (LevelMatrix[coordinate.i, coordinate.j] == MatrixValue.p)
                        LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    else LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.t;
                    return true;
                }

                if (LevelMatrix[coordinate.i, coordinate.j + 2] == MatrixValue.t)
                {
                    LevelMatrix[coordinate.i, coordinate.j + 1] = MatrixValue.p;
                    LevelMatrix[coordinate.i, coordinate.j + 2] = MatrixValue.bt;
                    if (LevelMatrix[coordinate.i, coordinate.j] == MatrixValue.p)
                        LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    else LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.t;
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
                    if (LevelMatrix[coordinate.i, coordinate.j] == MatrixValue.p)
                        LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    else LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.t;
                    return true;

                }
                if (LevelMatrix[coordinate.i, coordinate.j + 2] == MatrixValue.t)
                {
                    LevelMatrix[coordinate.i, coordinate.j + 1] = MatrixValue.pt;
                    LevelMatrix[coordinate.i, coordinate.j + 2] = MatrixValue.bt;
                    if (LevelMatrix[coordinate.i, coordinate.j] == MatrixValue.p)
                        LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    else LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.t;
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
                    if (LevelMatrix[coordinate.i, coordinate.j] == MatrixValue.p)
                        LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    else LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.t;
                    return true;
                }

                if (LevelMatrix[coordinate.i- 2, coordinate.j ] == MatrixValue.t)
                {
                    LevelMatrix[coordinate.i- 1, coordinate.j ] = MatrixValue.p;
                    LevelMatrix[coordinate.i- 2, coordinate.j ] = MatrixValue.bt;
                    if (LevelMatrix[coordinate.i, coordinate.j] == MatrixValue.p)
                        LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    else LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.t;
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
                    if (LevelMatrix[coordinate.i, coordinate.j] == MatrixValue.p)
                        LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    else LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.t;
                    return true;

                }
                if (LevelMatrix[coordinate.i - 2, coordinate.j ] == MatrixValue.t)
                {
                    LevelMatrix[coordinate.i - 1, coordinate.j ] = MatrixValue.pt;
                    LevelMatrix[coordinate.i - 2, coordinate.j ] = MatrixValue.bt;
                    if (LevelMatrix[coordinate.i, coordinate.j] == MatrixValue.p)
                        LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    else LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.t;
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
                    if (LevelMatrix[coordinate.i, coordinate.j] == MatrixValue.p)
                        LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    else LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.t;
                    return true;
                }

                if (LevelMatrix[coordinate.i + 2, coordinate.j] == MatrixValue.t)
                {
                    LevelMatrix[coordinate.i + 1, coordinate.j] = MatrixValue.p;
                    LevelMatrix[coordinate.i + 2, coordinate.j] = MatrixValue.bt;
                    if (LevelMatrix[coordinate.i, coordinate.j] == MatrixValue.p)
                        LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    else LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.t;
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
                    if (LevelMatrix[coordinate.i, coordinate.j] == MatrixValue.p)
                        LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    else LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.t;
                    return true;

                }
                if (LevelMatrix[coordinate.i + 2, coordinate.j] == MatrixValue.t)
                {
                    LevelMatrix[coordinate.i + 1, coordinate.j] = MatrixValue.pt;
                    LevelMatrix[coordinate.i + 2, coordinate.j] = MatrixValue.bt;
                    if (LevelMatrix[coordinate.i, coordinate.j] == MatrixValue.p)
                        LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    else LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.t;
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
                    if (LevelMatrix[coordinate.i, coordinate.j] == MatrixValue.p)
                        LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    else LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.t;
                    return true;
                }

                if (LevelMatrix[coordinate.i, coordinate.j - 2] == MatrixValue.t)
                {
                    LevelMatrix[coordinate.i, coordinate.j - 1] = MatrixValue.p;
                    LevelMatrix[coordinate.i, coordinate.j - 2] = MatrixValue.bt;
                    if (LevelMatrix[coordinate.i, coordinate.j] == MatrixValue.p)
                        LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    else LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.t;
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
                    if (LevelMatrix[coordinate.i, coordinate.j] == MatrixValue.p)
                        LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    else LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.t;
                    return true;

                }
                if (LevelMatrix[coordinate.i, coordinate.j - 2] == MatrixValue.t)
                {
                    LevelMatrix[coordinate.i, coordinate.j - 1] = MatrixValue.pt;
                    LevelMatrix[coordinate.i, coordinate.j - 2] = MatrixValue.bt;
                    if (LevelMatrix[coordinate.i, coordinate.j] == MatrixValue.p)
                        LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.z;
                    else LevelMatrix[coordinate.i, coordinate.j] = MatrixValue.t;
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
           for (int i =0; i< i_count; i++)
                for(int j=0;j< j_count;j++)
                {
                    if (LevelMatrix[i, j] == MatrixValue.b) return false;
                }
            return true;
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

        /// <summary>
        /// перезапуск уровня
        /// </summary>
        /// <returns></returns>
        public bool RestartLevel()
        {
            count_step = 0;
            return LoadFromFile(thisFileName);
        }

        /// <summary>
        /// Сообщение о шагах
        /// </summary>
        /// <returns></returns>
        public string getSteps()
        {
            return $"Пройдено шагов: {count_step}";
        }

    }
}
