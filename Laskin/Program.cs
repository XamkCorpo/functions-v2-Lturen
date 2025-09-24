namespace Laskin
{
    internal class Program
    {//Tästä alkaa, näiden kommenttien sisälle kaikki funktiot

        static void Main(string[] args)
        {
            int operation = AskOperation();

            Console.WriteLine("Syötä ensimmäinen numero");
            double number1 = AskNumber();

            Console.WriteLine("Syötä toinen numero");
            double number2 = AskNumber();

            double result = laske(number1, number2, operation);

            //string operatioSymbol = GetOperationSymbol(operation);


            //PrintResult(result, num1, num2, operatioSymbol);

            Tuloksentulos(operation, number1, number2, result);

        }

        private static void Tuloksentulos(int operation, double number1, double number2, double result)
        {
            string symbol = "";

            if (operation == 1)
            {
                symbol = "+";
            }
            else if (operation == 2)
            {
                symbol = "-";
            }
            else if (operation == 3)
            {
                symbol = "*";
            }
            else if (operation == 4)
            {
                symbol = "/";
            }

            Console.WriteLine($"Tulos: {number1} {symbol} {number2} = {result}");
        }

        static double laske(double number1, double number2, int operation)
        {
            double tulos = 0;

            if (operation == 1)
            {
                tulos = number1 + number2;
            }
            else if (operation == 2)
            {
                tulos = number1 - number2;
            }
            else if (operation == 3)
            {
                tulos = number2 * number2;
            }
            else if (operation == 4)
            {
                if (number2 == 0)
                {
                    Console.WriteLine("Nollalla ei voi jakaa, yritä uudelleen");
                }
                else
                {
                    tulos = number1 / number2;

                }
            }
            return tulos;
        }






        static int AskOperation()
        {
            Console.WriteLine("Valitse laskutoimitus");
            Console.WriteLine("1. Plus");
            Console.WriteLine("2. Miinus");
            Console.WriteLine("3. Kertolasku");
            Console.WriteLine("4. Jakolasku");

            int operation = 0;

            while (true)
            {
                string valinta = Console.ReadLine();

                //Tämä varmistaa, että syöte ei ole tyhjä sekä, että syöte on numero
                bool conversionOk = int.TryParse(valinta, out operation);

                if (string.IsNullOrEmpty(valinta) && conversionOk == false)
                {
                    Console.WriteLine("Virheellinen syöte. Syötä numero:");
                    valinta = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            return operation;
        }

        static double AskNumber() ///kysytään y
        {
            string y = Console.ReadLine();
            double number = 0;
            while (string.IsNullOrEmpty(y) || !double.TryParse(y, out number))
            {
                Console.WriteLine("Virheellinen syöte. Syötä numero:");
                y = Console.ReadLine();
            }
            return number;
        }

    } //Tähän loppuu, älä tämän aaltosulun ulkopuolelle laita


}






//else if (valinta == "1")
//{
//    Console.WriteLine("Tulos on " + (double.Parse(x) + double.Parse(y)));
//}
//else if (valinta == "2")
//{
//    Console.WriteLine("Tulos on " + (double.Parse(x) - double.Parse(y)));
//}
//else if (valinta == "3")
//{
//    Console.WriteLine("Tulos on " + (double.Parse(x) * double.Parse(y)));
//}
//else if (valinta == "4")
//{
//    if (y == "0")
//    {
//        Console.WriteLine("Nollalla ei voi jakaa, yritä uudelleen");
//        continue;
//    }
//    else
//    {
//        Console.WriteLine("Tulos on " + (double.Parse(x) / double.Parse(y)));
//    }
//    continue;
//}
//return;
