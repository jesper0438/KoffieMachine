using System;

namespace KoffieMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int milliseconds = 1500;
                // maak de koffiemachine aan
                KoffieMachine italiaansekoffiemachine = new KoffieMachine(20, 20, 20);
                

            while (true)
            {
                Console.WriteLine("maak keuze");
                //Bekertje koffiezwart = italiaansekoffiemachine.GeefKoffiezwart();

                ConsoleKeyInfo KeyInfo = Console.ReadKey();

                if (KeyInfo.KeyChar == '0')
                {
                    Bekertje cappuccino = italiaansekoffiemachine.GeefCappuccino();
                    cappuccino.Print();
                    Console.WriteLine(italiaansekoffiemachine);
                    //Console.ReadLine();
                    System.Threading.Thread.Sleep(milliseconds);
                }
                if (KeyInfo.KeyChar == '1')
                {
                    Bekertje koffiezwart = italiaansekoffiemachine.GeefKoffiezwart();
                    koffiezwart.Print();
                    Console.WriteLine(italiaansekoffiemachine);
                   // Console.ReadLine();
                    System.Threading.Thread.Sleep(milliseconds);
                }
                if (KeyInfo.KeyChar == '2')
                {
                    Bekertje lattemacchiato = italiaansekoffiemachine.GeefLattemacchiato();
                    lattemacchiato.Print();
                    Console.WriteLine(italiaansekoffiemachine);
                    //Console.ReadLine();
                    System.Threading.Thread.Sleep(milliseconds);
                }


                // Doe dit net zo vaak totdat er een exeption optreedt
            }
        }
    }
}
