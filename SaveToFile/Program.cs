using System;
using System.IO;

namespace Save_To_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = "imiona.txt";
            if (File.Exists(filePath))
            {
                // Sprawdzić, czy mamy jakieś nazwisko zapisane
                var fileContent = File.ReadAllText(filePath);

                if (fileContent.Length > 0)
                {
                    //              Jeśli tak, wypisujemy i pytamy o usunięcie
                    //              Jeśli usunął, wczytujemy nowe
                    //              Jeśli nie usunąl, kończymy program
                    Console.WriteLine("Zapisane imię to: " + fileContent);
                    Console.WriteLine("Czy chcesz usunąć to imię? tak/nie ");
                    var userAnswer = Console.ReadLine();
                    if (userAnswer == "tak")
                    {
                        File.Delete(filePath);
                    }
                    else
                    {
                        return;
                    }
                }
            }

            Console.WriteLine("Podaj swoje imię?");
            var userName = Console.ReadLine();
            File.WriteAllText(filePath, userName);



            // Jeśli nie, wczytujemy i zapisujemy
        }
    }
}
