using System;


public class Funktioner
{
    
    public int Plus(int x, int y)
    {
        string int1 = Console.ReadLine();
        Console.WriteLine(int1);
        return x + y;
    }

    public double Pythagoras(double num1, double num2)
    {
        double result = Math.Sqrt(Math.Pow(num1, 2)+ Math.Pow(num2, 2));

        return result;
    }

    public int Factorial(int num)
    {
        if (num == 0)
        {
            return 1;
        }
        else
        {
            return num * Factorial(num - 1);
        }
    }

}
class Menu
{
    static void Main()
    {
        MainMenu();

    }

    public static bool MainMenu()
    {
        Funktioner funktioner = new Funktioner();

        Console.Clear();
        Console.WriteLine("-->HOVEDMENU<--");
        Console.WriteLine("Vælg en undermenu:");
        Console.WriteLine("1) <Trigonometri>\n2) <Rekursion>\n3) <Formler indenfor fysikfaget>");
        Console.WriteLine("4) Exit");

        switch (Console.ReadLine())
        {
            case "1":
                TrigonometriMenu();
                return true;
            case "2":
                RekursionMenu();
                return true;
            case "3":
                FysikMenu();
                return true;
            case "4":
                return false;
            default: return true;
        }
    }

    public static bool TrigonometriMenu()
    {
        Funktioner funktioner = new Funktioner();

        Console.Clear();
        Console.WriteLine("-->TRIGONOMETRI<--");
        Console.WriteLine("Vælg en funktion:");
        Console.WriteLine("1) Pythagoras\n2) 2\n3) 3\n4) <Tilbage>");

        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("---\nDenne funktion regner hypotenusen af en retvinklet trekant ud fra den hosliggende - og modstående katete");
                // Tager input
                Console.WriteLine("INPUT: Længde af den hosliggende katete:");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("INPUT: Længde af den modstående katete:");
                double num2 = double.Parse(Console.ReadLine());
                // Regner resultatet i en double variabel.
                double result = funktioner.Pythagoras(num1, num2);
                Console.WriteLine("Længden af hypotenusen er: " + result);
               
                ContinueTrigonometriMenu();
                return true;
            case "2":
                ContinueTrigonometriMenu();
                return true;
            case "3":
                ContinueTrigonometriMenu();
                return true;
            case "4":
                MainMenu();
                return true;
            default: return true;
        }
    }

    public static bool RekursionMenu()
    {
        Console.Clear();
        Console.WriteLine("-->REKURSION<--");
        Console.WriteLine("Vælg en funktion:");
        Console.WriteLine("1) 1\n2) 2\n3) 3\n4) <Tilbage>");


        switch (Console.ReadLine())
        {
            case "1":
                ContinueRekursionMenu();
                return true;
            case "2":
                ContinueRekursionMenu();
                return true;
            case "3":
                ContinueRekursionMenu();
                return true;
            case "4":
                MainMenu();
                return true;
            default: return true;
        }
    }

    public static bool FysikMenu()
    {
        Console.Clear();
        Console.WriteLine("-->FYSIK<--");
        Console.WriteLine("Vælg en funktion:");
        Console.WriteLine("1) 1\n2) 2\n3) 3\n4) <Tilbage>");


        switch (Console.ReadLine())
        {
            case "1":
                ContinueFysikMenu();
                return true;
            case "2":
                ContinueFysikMenu();
                return true;
            case "3":
                ContinueFysikMenu();
                return true;
            case "4":
                MainMenu();
                return true;
            default: return true;
        }
    }


    // 'Continue-Funktioner' der er til for at gøre brugeroplevelsen bedre, ved ikke at boote dem ud af prgrammet efter hver funktion.
    public static bool ContinueMainMenu()
    {
        Console.WriteLine("Continue?");
        Console.WriteLine("1) Yes");
        Console.WriteLine("2) No");

        switch (Console.ReadLine())
        {
            case "1":
                MainMenu();
                return true;
            case "2":
                return false;
            default: return true;
        }

    }
    public static bool ContinueTrigonometriMenu()
    {
        Console.WriteLine("Continue?");
        Console.WriteLine("1) Yes");
        Console.WriteLine("2) No");

        switch (Console.ReadLine())
        {
            case "1":
                TrigonometriMenu();
                return true;
            case "2":
                return false;
            default: return true;
        }

    }
    public static bool ContinueRekursionMenu()
    {
        Console.WriteLine("Continue?");
        Console.WriteLine("1) Yes");
        Console.WriteLine("2) No");

        switch (Console.ReadLine())
        {
            case "1":
                RekursionMenu();
                return true;
            case "2":
                return false;
            default: return true;
        }

    }
    public static bool ContinueFysikMenu()
    {
        Console.WriteLine("Continue?");
        Console.WriteLine("1) Yes");
        Console.WriteLine("2) No");

        switch (Console.ReadLine())
        {
            case "1":
                FysikMenu();
                return true;
            case "2":
                return false;
            default: return true;
        }

    }

}