using System;
using SokobanWinForm.Interfases;

namespace SokobanWinForm.Classes
{
    /// <summary>
    /// Контроллер игры - основной функционал по игровой логике
    /// </summary>
    [Serializable]    
    internal class ClassGameController: ClassLevelMatrix,  InterfaceMoving, InterfaceGameVictory
    {
        //выше - множественное наследование (один класс и интерфейсы в нужном количестве)
      
        /// <summary>
        /// число шагов
        /// </summary>
        public int count_step;
        /// <summary>
        /// номер текущего уровня в игре
        /// </summary>
        public int gameLVL;
        /// <summary>
        /// максимальный уровень в игре
        /// </summary>
        static int maxLvl = 15;

        /// <summary>
        /// имя игрока
        /// </summary>
        public string playerName { get; set; }
        
        /// <summary>
        /// время в текущем раунде
        /// </summary>
        public int levelTime { get; set; }

        [NonSerialized]
        /// <summary>
        /// таблица рекордов
        /// </summary>
        ClassHichStoreTable storeTable = new ClassHichStoreTable();

        /// <summary>
        /// Конструктор
        /// </summary>
       public ClassGameController():base(5,6)            
        {
            startLvl(1);
            storeTable.LoadData();
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

      /// <summary>
      /// Победа в уровне
      /// </summary>
      /// <returns>истина, если нет перехода на уровень выше</returns>
        public bool Victory()
        {
            if( storeTable.InSctore(playerName, levelTime, gameLVL) )
            {
                storeTable.SaveData();
                System.Windows.Forms.MessageBox.Show("Ваш результат попал в таблицу рекордов!");
            }

            if (gameLVL==maxLvl)
            {
                return true;
            }
            else
            {
                gameLVL++;
                startLvl(gameLVL);
                return false;
            }

            

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
            levelTime = 0;
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
        /// <summary>
        /// запуск уровня
        /// </summary>
        /// <param name="lvl">номер уровня</param>
        public void startLvl(int lvl)
        {
            this.LoadFromFile($"Levels/{lvl}.lvl");
            count_step = 0;
            levelTime = 0;
            gameLVL = lvl;
        }

    }
}
