using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokobanWinForm.Classes
{
    /// <summary>
    /// Значения ячеек матрицы уровня
    /// </summary>
    public enum MatrixValue 
    { 
        /// <summary>
        /// Игрок
        /// </summary>
        p, 
        /// <summary>
        /// Ящик
        /// </summary>
        b, 
        /// <summary>
        /// Стена
        /// </summary>
        w, 
        /// <summary>
        /// Целевая точка
        /// </summary>
        t,
        /// <summary>
        /// Ящик на целевой точке
        /// </summary>
        bt, 
        /// <summary>
        /// Пустая клетка
        /// </summary>
        z 
    }

    /// <summary>
    /// матрица уровня
    /// </summary>
    public class ClassLevelMatrix
    {
        /// <summary>
        /// сама матрица уровня
        /// </summary>
        public MatrixValue[,] LevelMatrix;

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="rows">кол-во строк</param>
        /// <param name="columns">кол-во столбцов</param>
        public ClassLevelMatrix(int rows, int columns )
        {
            LevelMatrix = new MatrixValue[rows, columns];
        }


    }
}
