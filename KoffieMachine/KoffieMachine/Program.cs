using System;

namespace KoffieMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // maak de koffiemachine aan
            KoffieMachine italiaansekoffiemachine = new KoffieMachine(20,20,20);

            Bekertje koffiezwart = italiaansekoffiemachine.GeefKoffiezwart();

            koffiezwart.Print();
            Console.WriteLine(italiaansekoffiemachine);
            //System.Threading.Thread.Sleep(milliseconds);

            Bekertje lattemacchiato = italiaansekoffiemachine.GeefLattemacchiato();
            lattemacchiato.Print();
            Console.WriteLine(italiaansekoffiemachine);

           // System.Threading.Thread.Sleep(milliseconds);
            Bekertje cappuccino = italiaansekoffiemachine.GeefCappuccino();
            // maak de koffiemachine aan
            cappuccino.Print();
            Console.WriteLine(italiaansekoffiemachine);


            Console.Read();
            // Doe dit net zo vaak totdat er een exeption optreedt
        }
    }
}
