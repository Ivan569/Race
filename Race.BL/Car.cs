namespace ConsoleApp12.Race.BL
{
    /// <summary>
    /// Автомобиль.
    /// </summary>
    abstract class Car
    {
        /// <summary>
        /// Скорость.
        /// </summary>
        public abstract int Speed { get; }
        /// <summary>
        /// Ехать.
        /// </summary>
        public abstract int Go(int distanceCovered);
        /// <summary>
        /// Выйти на старт.
        /// </summary>
        public abstract void LeaveOnStart();
        /// <summary>
        /// Достичь финиша.
        /// </summary>
        /// <param name="message"></param>
        public abstract void ReachFinishLine(string message);
    }
}