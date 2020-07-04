using System;

namespace ConsoleApp12.Race.BL.Cars.Cargo
{
    class Daf : Car
    {
        /// <summary>
        /// Достичь финиша.
        /// </summary>
        delegate void ReachFinishLn(string message);
        /// <summary>
        /// Финиш.
        /// </summary>
        event ReachFinishLn Finish;
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
            speed = StaticRandom.random.Next(30, 190);

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

        public override string ToString() => "DAF";
    }
}