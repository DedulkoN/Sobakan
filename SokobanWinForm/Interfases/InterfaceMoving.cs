namespace SokobanWinForm.Interfases
{
    /// <summary>
    /// Интерфейс движения
    /// </summary>
    internal interface InterfaceMoving
    {
        /// <summary>
        /// вверх
        /// </summary>
        /// <returns>истина, если удачно</returns>
        bool moveUp();
        /// <summary>
        /// вниз
        /// </summary>
        /// <returns>истина, если удачно</returns>
        bool moveDown();
        /// <summary>
        /// налево
        /// </summary>
        /// <returns>истина, если удачно</returns>
        bool moveLeft();
        /// <summary>
        /// направо
        /// </summary>
        /// <returns>истина, если удачно</returns>
        bool moveRight();

    }
}
