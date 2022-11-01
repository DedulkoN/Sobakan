using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SokobanWinForm.Interfases;
using System.IO;

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
        z ,
        /// <summary>
        /// Игрок на цели
        /// </summary>
        pt 
    }

    [Serializable]
    /// <summary>
    /// матрица уровня
    /// </summary>
    public class ClassLevelMatrix:InterfaceWorkingWithFile
    {
        /// <summary>
        /// кол-во строк
        /// </summary>
        public int i_count { get; set; }
        /// <summary>
        /// кол-во столбцов
        /// </summary>
        public int j_count { get; set; }
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
            i_count = rows;
            j_count = columns;
        }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="levelMatrix">Матрица уровня</param>
        public ClassLevelMatrix(MatrixValue[,] levelMatrix)
        {
            LevelMatrix = levelMatrix;
            GetMatrixDimension();
        }

        public bool LoadFromFile(string filename)
        {
            //загрузка и сохранение уровня реализовано через сериализацию класса
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ClassLevelMatrix));
                FileStream fs = new FileStream(filename, FileMode.Open);                
                var temp = xmlSerializer.Deserialize(fs) as ClassLevelMatrix;
                this.LevelMatrix = temp.LevelMatrix;
                GetMatrixDimension();
                return true;

            }
            catch { return false; }
        }

        public bool SaveToFile(string filename)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ClassLevelMatrix));
                           
                using (FileStream fs = new FileStream(filename, FileMode.CreateNew))
                {
                    xmlSerializer.Serialize(fs, this);

                }
               
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// подсчет размерности матрицы
        /// </summary>
        private void GetMatrixDimension()
        {
            i_count = LevelMatrix.GetLength(0);
            j_count = LevelMatrix.GetLength(1);
        }
    }
}
