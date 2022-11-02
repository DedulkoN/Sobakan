namespace SokobanWinForm.Interfases
{
    /// <summary>
    /// события победы
    /// </summary>
    internal interface InterfaceGameVictory
    {
        /// <summary>
        /// проверка условий победы
        /// </summary>
        /// <returns>истина, если победа</returns>
        bool VictoryValidate();
        /// <summary>
        /// обработка победы
        /// </summary>
        bool Victory();
       

    }
}
