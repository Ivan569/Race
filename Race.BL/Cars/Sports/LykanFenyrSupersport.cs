using System;

namespace ConsoleApp12.Race.BL.Cars.Sports
{
    /// <summary>
    /// Автомобиль Lykan Fenyr Supersport.
    /// </summary>
    class LykanFenyrSupersport : Car
    {
        /// <summary>
        /// Достичь финиша.
        /// </summary>
        public delegate void Reach(string message);
        /// <summary>
        /// Финиш.
        /// </summary>
        public event Reach Finish;
        /// <summary>
        /// Скорость.
        /// </summary>
        private int speed;

        public override int Speed { get => speed; }
        /// <summary>
        /// Ехать.
        /// </summary>
        /// <returns>Скорость.</returns>
        public override int Go(int distanceCovered)
        {
            speed = StaticRandom.random.Next(100, 320);

            distanceCovered = Convert.ToInt32(speed / 3.6);

            return distanceCovered;
        }
        /// <summary>
        /// Выйти на старт.
        /// </summary>
        public override void LeaveOnStart()
        {
            Console.WriteLine(ToString() + " на старте!");
            speed = 0;
        }
        /// <summary>
        /// Достичь финиша.
        /// </summary>
        /// <param name="message"></param>
        public override void ReachFinishLine(string message)
        {
            Finish?.Invoke(message);
            speed = 0;
        }

        public override string ToString() => "Lykan Fenyr Supersport";
    }
}