using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Threading;

namespace Lommeregner_1
{
    internal class Program
    {

        [Obsolete]
        static void Main(string[] args)
        {

            //Variabler
            string Velkommen, gentage;              // String variabel med navne velkommen og gentage
            char Valg, Funktion;                    // Char variabler med navne Valg og Funktioner
            float Tal1, Tal2, relsutat;             // float variabler med navne Tal1, Tal2 og relsutat

            gentage = "1";                          // Sætter varablen gentage til 1

            #region Velkomst

            Velkommen = "velkommen til min lommeregner og ip lookup";   // sætter variblen velkommen til en velkomst

            Console.ForegroundColor = ConsoleColor.Cyan;                // laver texten til have cyan
            Console.SetCursorPosition((Console.WindowWidth - Velkommen.Length) / 2, Console.CursorTop); // får cursern i miden af skermen

            foreach (char i in Velkommen)           // For hvær karektere i Velkommen så gør det her
            {
                Console.Write(i);                   // Skriver en karektere 
                Thread.Sleep(35);                   // Venter i 35 milisikunder
            }

            Console.ForegroundColor = ConsoleColor.White;   // laver text faven om til hvid
            Console.WriteLine("");                  // laver et melemrum

            #endregion

            #region Menu

            foreach (char i in "Her skal du vælge hvad du ville gøre")  // forhvær karekter i en text så gør det her
            {
                Console.Write(i);                   // skriver en karektere
                Thread.Sleep(15);                   // venter i 15 milisikunder
            }

            while (gentage == "1")                  // imens gentage er 1 så gentag denne kode
            {
                Console.WriteLine("");              // laver et melemrum
                Console.WriteLine("");              // laver et melemrum
                Console.WriteLine("1. Normal lommeregner"); // skriver en text på skermen
                Console.WriteLine("2. Ip lookup");  // skriver en text på skermen
                Console.WriteLine("");              // laver et melemrum
                Console.Write("intast hvad du ville: ");    // skriver en text på skermen

                Valg = Convert.ToChar(Console.ReadLine()); // ser efter hvad man har skrevet in i consollen og gemmer det i variablen valg

                #endregion

                #region Lommeregnern

                if (Valg == '1')                    // Hvis valg er 1 så gør det her
                {
                    Console.Clear();                // Gør sådan at det ikke er noget teskt på skermen


                    foreach (char i in "Det her er lommeregnern")   // for hvær karktere i en teskt så gør det her
                    {
                        Console.Write(i);           // skriv en kaktere fra teskt
                        Thread.Sleep(20);           // vent i 20 milisikunder
                    }       

                    Console.WriteLine("");          // laver et mellemrum
                    Console.Write("Inskriv dit første Tal. Husk at skrive komma tal med Komma: ");  // skriver en text på skermen
                    Tal1 = float.Parse(Console.ReadLine()); // gammer det man har skrivet i en variabel og laver den til en float

                    Console.Clear();                // Gør sådan at det ikke er noget teskt på skermen

                    Console.WriteLine("hvad ville du gøre nu:");
                    Console.WriteLine("");          // Gør sådan at det ikke er noget teskt på skermen
                    Console.WriteLine("1. Pluse talne sammen"); // skriver en text på skermen
                    Console.WriteLine("2. minus dem");          // skriver en text på skermen
                    Console.WriteLine("3. Gange dem");          // skriver en text på skermen
                    Console.WriteLine("4. Divider dem");        // skriver en text på skermen

                    Funktion = Convert.ToChar(Console.ReadLine()); // gemmer det man har skrivet i en variabel og laver den til en char vadi

                    if (Funktion == '1')            // hvis svaret er 1 så gør det her
                    {
                        Console.Write("Inskriv dit andet Tal. Husk at skrive komma tal med Komma: ");   // skriver en text på skermen
                        Tal2 = float.Parse(Console.ReadLine()); // Gemmer det andet tal til en variabel og laver det til en float

                        relsutat = Tal1 + Tal2;     // pluser de 2 tal sammen og gemmer det i variablen resutat

                        Console.WriteLine("relsutatet er " + Tal1 + " + " + Tal2 + " = " + relsutat); // udskriver relsutaltet af regnestykket
                    }

                    if (Funktion == '2')            // hvis svaret er 2 så gør det her
                    {
                        Console.Write("Inskriv dit andet Tal. Husk at skrive komma tal med Komma: ");   // skriver en text på skermen
                        Tal2 = float.Parse(Console.ReadLine()); // Gemmer det andet tal til en variabel og laver det til en float

                        relsutat = Tal1 - Tal2; // minuser de 2 tal sammen og gemmer det i variablen resutat


                        Console.WriteLine("relsutatet er " + Tal1 + " - " + Tal2 + " = " + relsutat);   // udskriver relsutaltet af regnestykket
                    }

                    if (Funktion == '3')           // hvis svaret er 3 så gør det her
                    {
                        Console.Write("Inskriv dit andet Tal. Husk at skrive komma tal med Komma: ");   // skriver en text på skermen
                        Tal2 = float.Parse(Console.ReadLine());  // Gemmer det andet tal til en variabel og laver det til en float

                        relsutat = Tal1 * Tal2; // ganger de 2 tal sammen og gemmer det i variablen resutat

                        Console.WriteLine("relsutatet er " + Tal1 + " * " + Tal2 + " = " + relsutat);   // udskriver relsutaltet af regnestykket
                    }

                    if (Funktion == '4')        // hvis svaret er 4 så gør det her
                    {
                        Console.Write("Inskriv dit andet Tal. Husk at skrive komma tal med Komma: ");   // skriver en text på skermen
                        Tal2 = float.Parse(Console.ReadLine()); // Gemmer det andet tal til en variabel og laver det til en float

                        relsutat = Tal1 / Tal2;  // ganger de 2 tal sammen og gemmer det i variablen resutat

                        Console.WriteLine("relsutatet er " + Tal1 + " / " + Tal2 + " = " + relsutat);   // udskriver relsutaltet af regnestykket
                    }
                }


                #endregion

                #region Ip
                if (Valg == '2') // Hvis variablen valg er 2 så gør det her
                {

                    string hostName = Dns.GetHostName(); // Få navnet på computern og gemmer det i en variabel
                    Console.WriteLine("Computerns navn : " + hostName); //skriver navnet på computern
                    string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();    // Får ens ip og gemmer og putter i en variabel
                    Console.WriteLine("Din ip er : " + myIP);   // Udskriver ens ip

                    string[] tokens = myIP.Split('.');  // Laver en string array som hedder togens til at suparer ens ip
                    int value1 = Int32.Parse(tokens[0]);    // gemmer den første oktet i en varabel som hedder value1
                    int value2 = Int32.Parse(tokens[1]);    // gemmer den anden oktet i en varabel som hedder value2
                    int value3 = Int32.Parse(tokens[2]);    // gemmer den trede oktet i en varabel som hedder value3
                    int value4 = Int32.Parse(tokens[3]);    // gemmer den fjere oktet i en varabel som hedder value4

                    string Bip1 = Convert.ToString(value1, 2); // laver value1 til binær
                    string Bip2 = Convert.ToString(value2, 2); // laver value2 til binær
                    string Bip3 = Convert.ToString(value3, 2); // laver value3 til binær
                    string Bip4 = Convert.ToString(value4, 2); // laver value4 til binær

                    string binaryIP = Bip1 + "." + Bip2 + "." + Bip3 + "." + Bip4; // sætter de binære tal sammen med punktum ind i mellem hvær tal

                    Console.WriteLine("Din binære ip er : " + binaryIP);           // skriver ens binær ;

                }


                Console.WriteLine("");   // laver et melemrum
                Console.WriteLine("");   // laver et melemrum
                Console.WriteLine("Ville du gentage programmet eller gå ud af det. Hvis ja = 1 eller Nej = 2: ");   // skriver en text på skermen
                gentage = Console.ReadLine(); // Gemmer ens svar til en variabel som hedder gentage

                if (gentage == "1")     // hvis variablen gentage er 1 så gør det her
                {   
                    continue; // gliv ved mad at køre while l
                }
                else                    // Hvis der er noget andet end 1 så gør det her
                {
                    break;              // Gø ud af løkken
                }
                #endregion
            }
        }
    }
}
