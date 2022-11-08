using System;

namespace SokobanWinForm.Classes
{
    /// <summary>
    /// запись в таблице рекордов
    /// </summary>
    [Serializable]
    public class ClasssScoreRecord
    {
        /// <summary>
        /// кол-во очков
        /// </summary>
        public int Score { get; set; }
        /// <summary>
        /// игрок
        /// </summary>
        public string Player { get; set; }
        /// <summary>
        /// уровень
        /// </summary>
        public int Level { get; set; }

        public ClasssScoreRecord()
        {
            Score = 0;
            Player = "Noname";
            Level = 0;
        }

        public ClasssScoreRecord(int score, string player, int level)
        {
            Score = score;
            Player = player;
            Level = level;
        }
    }
}
