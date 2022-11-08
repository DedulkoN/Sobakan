using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace SokobanWinForm.Classes
{
    /// <summary>
    /// Таблица рекордов
    /// </summary>
    [Serializable]
    public class ClassHichStoreTable
    {
        /// <summary>
        /// таблица с результатами
        /// </summary>
        public List<ClasssScoreRecord> scores;
        /// <summary>
        /// файл сохранения рекордов
        /// </summary>
        [NonSerialized]
        private const string filename = "HichStore.bin";
        /// <summary>
        /// макс записей на уровень
        /// </summary>
        [NonSerialized]
        private const int maxRecords = 10;

        public ClassHichStoreTable()
        {
            scores = new List<ClasssScoreRecord>();
        }

        /// <summary>
        /// Загрузка данных
        /// </summary>
        /// <returns> Истина,если всё прошло удачно</returns>
        public bool LoadData()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ClassHichStoreTable));

                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    var temp = xmlSerializer.Deserialize(fs) as ClassHichStoreTable;
                    this.scores = temp.scores;

                }            
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Сохранение данных
        /// </summary>
        /// <returns>Истина, если сохранено</returns>
        public bool SaveData()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ClassHichStoreTable));             

                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {
                    xmlSerializer.Serialize(fs, this);

                }


                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Попытка записи в таблицу рекордов
        /// </summary>
        /// <param name="PlayerName">Имя игрока</param>
        /// <param name="Sctore">Очки/секунды</param>
        /// <param name="Level">Уровень</param>
        /// <returns>истина, если результат записан</returns>
        public bool InSctore(string PlayerName, int Sctore, int Level)
        {
            var LevelScore = scores.Where(e => e.Level == Level);
            if (LevelScore.Count()< maxRecords)
            {
                //если записей меньше максимума - сохраняем
                scores.Add(new ClasssScoreRecord(Sctore, PlayerName, Level));
                return true;
            }
            else
            {
                int maxScore = LevelScore.Max(e => e.Score);
                if (maxScore > Sctore)
                {
                    var temp = LevelScore.Where(e => e.Score == maxScore).First();
                    scores.Remove(temp);
                    scores.Add(new ClasssScoreRecord(Sctore, PlayerName, Level));
                    return true;
                }
            }
            return false;
        }

    }
}
