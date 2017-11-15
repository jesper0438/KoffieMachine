using System;

namespace KoffieMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // maak de koffiemachine aan
            KoffieMachine italiaansekoffiemachine = new KoffieMachine(20,20,20);

            //Bekertje koffiezwart = italiaansekoffiemachine.GeefKoffiezwart();
          
            ConsoleKeyInfo KeyInfo = Console.ReadKey();

            if (KeyInfo.KeyChar == '0')
                {
                Bekertje mijnEersteBakje = italiaansekoffiemachine.GeefCappuccino();
                mijnEersteBakje.Print();
            }
            if (KeyInfo.KeyChar == '1')
            {
                Bekertje mijnEersteBakje = italiaansekoffiemachine.GeefKoffiezwart();
                mijnEersteBakje.Print();
            }
            if (KeyInfo.KeyChar == '2')
            {
                Bekertje mijnEersteBakje = italiaansekoffiemachine.GeefLattemacchiato();
                mijnEersteBakje.Print();
            }

            Console.Read();
            // Doe dit net zo vaak totdat er een exeption optreedt
        }
    }
}
