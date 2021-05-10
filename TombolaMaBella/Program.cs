using System;
using System.Threading;

namespace TombolaMaBella
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variabili
            int[] tombola = new int[90];
            Random estrazione = new Random();
            int tutto = default;

            int num = default;

            int estratti = default;
            estratti = 0;


            Console.WriteLine("\n\n\t########   #####   #     #  ####     #####   ##        #### ");
            Console.WriteLine("\t   ##     #     #  ##   ##  #   #   #     #  ##       #    #");
            Console.WriteLine("\t   ##     #     #  # # # #  ####    #     #  ##       #    #");
            Console.WriteLine("\t   ##     #     #  #  #  #  #    #  #     #  ##       ######");
            Console.WriteLine("\t   ##     #     #  #     #  #    #  #     #  ##       #    #");
            Console.WriteLine("\t   ##      #####   #     #  ####     #####   #######  #    #");

            Console.ReadKey(true);
            Console.Clear();

            while (estratti != 90)
            {
                tutto = 1;
                num = estrazione.Next(1, 91);


                if (tombola[num - 1] != num)
                {
                    //Instestazione
                    Console.Clear();

                    Console.Write("Il numero estratto è:");
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(num);
                    Console.ResetColor();

                    tombola[num - 1] = num;
                    estratti += 1;



                    //Tabella
                    while (tutto != 91)
                    {
                        if (tombola[tutto - 1] == tutto)
                        {
                            //numero
                            if (tutto < 10)
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Write($"0{tutto}");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Write(tutto);
                                Console.ResetColor();
                            };

                        }

                        //No Numero
                        else if (tutto < 10)
                            Console.Write($"0{tutto}");
                        else
                        Console.Write($"{tutto}");

                        Console.Write("  ");

                        if (tutto == 10 || tutto == 20 || tutto == 30 || tutto == 40 || tutto == 50 || tutto == 60 || tutto == 70 || tutto == 80)

                            Console.WriteLine();

                        tutto += 1;
                    }

                    Console.ReadKey(true);
                }

            }

        }
    }
}
