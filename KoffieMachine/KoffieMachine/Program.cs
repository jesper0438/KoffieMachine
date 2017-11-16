using System;

namespace KoffieMachine
{
    class Program
    {
        static void Main(string[] args)
        {
           
                // maak de koffiemachine aan
                KoffieMachine italiaansekoffiemachine = new KoffieMachine(20, 20, 20);
                Console.WriteLine("maak keuze");

            while (true)
            {

                //Bekertje koffiezwart = italiaansekoffiemachine.GeefKoffiezwart();

                ConsoleKeyInfo KeyInfo = Console.ReadKey();

                if (KeyInfo.KeyChar == '0')
                {
                    Bekertje cappuccino = italiaansekoffiemachine.GeefCappuccino();
                    cappuccino.Print();
                    Console.WriteLine(italiaansekoffiemachine);
                    Console.ReadLine();
                }
                if (KeyInfo.KeyChar == '1')
                {
                    Bekertje koffiezwart = italiaansekoffiemachine.GeefKoffiezwart();
                    koffiezwart.Print();
                    Console.WriteLine(italiaansekoffiemachine);
                    Console.ReadLine();
                }
                if (KeyInfo.KeyChar == '2')
                {
                    Bekertje lattemacchiato = italiaansekoffiemachine.GeefLattemacchiato();
                    lattemacchiato.Print();
                    Console.WriteLine(italiaansekoffiemachine);
                    Console.ReadLine();
                }


                // Doe dit net zo vaak totdat er een exeption optreedt
            }
        }
    }
}
