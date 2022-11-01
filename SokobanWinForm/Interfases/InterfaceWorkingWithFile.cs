namespace SokobanWinForm.Interfases
{
    /// <summary>
    /// работа с файлами
    /// </summary>
    internal interface InterfaceWorkingWithFile
    {
        /// <summary>
        /// загрузка из файла
        /// </summary>
        /// <param name="filename">путь к файлу</param>
        /// <returns>истина, если удачно</returns>
        bool LoadFromFile(string filename);

        /// <summary>
        /// сохранить в файл
        /// </summary>
        /// <param name="filename">имя файла</param>
        /// <returns>истина, если удачно</returns>
        bool SaveToFile(string filename);
    }
}
