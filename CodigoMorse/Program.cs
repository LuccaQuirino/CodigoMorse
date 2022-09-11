using System;
using System.Collections.Generic;
using System.Threading;

namespace CodigoMorse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Start();
        }

        private static void Start()
        {
            int options = Menu();

            Actions(options);
        }

        private static int Menu()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Este programa es un programa diseñado para la traduccion de ingles a morse o de morse a ingles");
            Console.SetCursorPosition(18, 3);
            Console.WriteLine("Elija tipo de traducción");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("1. De Español a morse");
            Console.WriteLine("2. De morse a Español");
            Console.WriteLine("3. Salir del Programa");
            Console.WriteLine("-------------------------------------------------------------------------------");

            string chosen = Console.ReadLine();

            int options = int.Parse(chosen);
            return options;
        }

        private static void Actions(int options)
        {
            switch (options)
            {
                case 1:
                    TranslateSpanishToMorseCode();

                    Console.ReadKey();
                    Start();
                    break;

                case 2:
                    TranslateMorseCodeToSpanish();

                    Console.ReadKey();
                    Start();
                    break;

                case 3:
                    Console.WriteLine("Adios!!");
                    Thread.Sleep(1000);
                    break;
            }
        }

        private static void TranslateMorseCodeToSpanish()
        {
            string morseCodeText = AnouncmentAndText();

            Dictionary<string, string> english = new Dictionary<string, string>
                    {
                     {".-", "a"}, {"-...", "b"}, {"-.-.", "c"}, {"-..", "d"},

                     {".", "e"}, {"..-.", "f"}, {"--.", "g"}, {"....", "h"},

                     {"..", "i"}, {".---", "j"}, {"-.-", "k"}, {".-..", "l"},

                     {"--", "m"}, {"-.", "n"}, {"---", "o"}, {".--.", "p"},

                     {"--.-", "q"}, {".-.", "r"}, {"...", "s"}, {"-", "t"},

                     {"..-", "u"}, {"...-", "v"}, {".--", "w"}, {"-..-", "x"},

                     {"-.--", "y"}, {"--..", "z"}, {"-----", "0"}, {".----", "1"},

                     {"..---", "2"}, {"...--", "3"}, {"....-", "4"}, {".....", "5"},

                     {"-....", "6"}, {"--...", "7"}, {"---..", "8"}, {"----.", "9"},

                     {"////", " "}, {".-.-.-","."}, {"--..--",","}, {"..--..","?"},

                     {"-.---", "!"}
                     };
            var codes = morseCodeText.Split(" ");
            foreach (string letter in codes)
            {
                Console.Write(english[letter.ToString()] + " ");
            }
        }

        private static void TranslateSpanishToMorseCode()
        {
            string englishText = AnouncmentAndText();

            Dictionary<string, string> morseCode = new Dictionary<string, string>
                    {
                     {"a", ".-"}, {"b", "-..."}, {"c", "-.-."}, {"d", "-.."},

                     {"e", "."}, {"f", "..-."}, {"g", "--."}, {"h", "...."},

                     {"i", ".."}, {"j", ".---"}, {"k", "-.-"}, {"l", ".-.."},

                     {"m", "--"}, {"n", "-."}, {"o", "---"}, {"p", ".--."},

                     {"q", "--.-"}, {"r", ".-."}, {"s", "..."}, {"t", "-"},

                     {"u", "..-"}, {"v", "...-"}, {"w", ".--"}, {"x", "-..-"},

                     {"y", "-.--"}, {"z", "--.."}, {"0", "-----"}, {"1", ".----"},

                     {"2", "..---"}, {"3", "...--"}, {"4", "....-"}, {"5", "....."},

                     {"6", ".----"}, {"7", "..---"}, {"8", "...--"}, {"9", "....-"},

                     {" ", "////"}, {".",".-.-.-"}, {",","--..--"}, {"?","..--.."},

                     {"!", "-.---"}
                    };

            foreach (char letra in englishText)
            {
                Console.Write(morseCode[letra.ToString()] + " ");
            }
        }

        private static string AnouncmentAndText()
        {
            Console.WriteLine("Escriba el texto para traducirlo");

            string text = Console.ReadLine();

            return text;
        }
    }
}
