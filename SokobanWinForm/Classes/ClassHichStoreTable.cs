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
    internal class ClassHichStoreTable
    {
        public List<ClasssScoreRecord> scores;

        [NonSerialized]
        private string filename = "HichStore.bin";

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

    }
}
