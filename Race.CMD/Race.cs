using ConsoleApp12.Race.BL.Cars.Sports;
using System.Threading;
using System;

class Race
{
    /// <summary>
    /// Выйти на старт.
    /// </summary>
    delegate void LeaveOnStart();
    /// <summary>
    /// Начать гонку.
    /// </summary>
    /// <returns>Скорость.</returns>
    delegate int StartTheRace(int distanceCovered);

    private static void Main()
    {
        // Начать гонку:
        StartRace(InputManager());
    }
    /// <summary>
    /// Взятие входных данных.
    /// </summary>
    /// <returns></returns>
    private static int InputManager()
    {
        Console.WriteLine("Введите расстояние трассы:");
        int.TryParse(Console.ReadLine(), out int distance);
        return distance;
    }       
    /// <summary>
    /// Начать гонку.
    /// </summary>
    private static void StartRace(int distance)
    {
        Console.Clear();
        var lykanFenyr = new LykanFenyrSupersport();
        var porscheTaycan = new PorscheTaycanTurboS();

        // Выводим машины на старт:
        LeaveOnStart onStart = lykanFenyr.LeaveOnStart;
        onStart += porscheTaycan.LeaveOnStart;
        onStart();

        Thread.Sleep(3000);
        StartTheRace startTheRace;

        // Расстояние пройденное первой:
        int distanceCovered = 0,
            // Расстояние пройденное второй:
            distanceCoveredTwo = 0;

        for (; ; )
        {
            Console.Clear();
            // Первая машина едет:
            startTheRace = lykanFenyr.Go;
            distanceCovered += startTheRace(distanceCovered);
            Console.WriteLine(lykanFenyr.ToString() + "-" + distanceCovered + "м");

            // Если первая машина достигла финиша:
            if (distanceCovered >= distance && distanceCoveredTwo < distanceCovered)
            {
                lykanFenyr.Finish += DisplayMessage;
                lykanFenyr.ReachFinishLine("\n" + lykanFenyr.ToString() + " прибыла на финиш первая!");
                Environment.Exit(0);
            }

            // Вторая машина едет:
            startTheRace = porscheTaycan.Go;
            distanceCoveredTwo += startTheRace(distanceCoveredTwo);
            Console.WriteLine(porscheTaycan.ToString() + "-"+ distanceCoveredTwo + "м");

            // Если вторая машина достигла финиша:
            if (distanceCoveredTwo >= distance && distanceCovered < distanceCoveredTwo)
            {
                porscheTaycan.Finish += DisplayMessage;
                porscheTaycan.ReachFinishLine("\n" + porscheTaycan.ToString() + " прибыла на финиш первая!");
                Environment.Exit(0);
            }

            Thread.Sleep(1000);
        }
    }
    /// <summary>
    /// Сообщение о финише.
    /// </summary>
    /// <param name="message"></param>
    private static void DisplayMessage(string message) => Console.WriteLine(message);
}