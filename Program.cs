using System;

class Program
{
    // Citeste un numar pozitiv; intreaba din nou daca valoarea e gresita
    static double CitesteValoarePozitiva(string mesaj)
    {
        while (true)
        {
            Console.Write(mesaj);
            string? text = Console.ReadLine();

            if (!double.TryParse(text, out double valoare))
            {
                Console.WriteLine("Eroare: introduceti un numar.");
            }
            else if (valoare < 0)
            {
                Console.WriteLine("Eroare: valoarea nu poate fi negativa.");
            }
            else if (valoare == 0)
            {
                Console.WriteLine("Eroare: valoarea trebuie sa fie mai mare ca 0.");
            }
            else
            {
                return valoare;
            }
        }
    }

    static void Main()
    {
        double lungime = CitesteValoarePozitiva("Lungime: ");
        double latime = CitesteValoarePozitiva("Latime: ");

        double arie = lungime * latime;
        double perimetru = 2 * (lungime + latime);

        Console.WriteLine($"Aria = {arie}");
        Console.WriteLine($"Perimetrul = {perimetru}");
    }
}