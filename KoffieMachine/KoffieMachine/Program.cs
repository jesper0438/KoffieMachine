using System;

namespace KoffieMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            // maak de koffiemachine aan
            KoffieMachine italiaansekoffiemachine = new KoffieMachine(20,20,20);

            // neem een bekertje koffie
            //Console.WriteLine(italiaansekoffiemachine.GeefCappuccino());
            //Console.WriteLine(italiaansekoffiemachine.GeefKoffiezwart());
            //Console.WriteLine(italiaansekoffiemachine.GeefLattemacchiato());
            italiaansekoffiemachine.GeefCappuccino().Print();
            italiaansekoffiemachine.GeefKoffiezwart().Print();
            italiaansekoffiemachine.GeefLattemacchiato().Print();

            // Bekertje beker = new Bekertje(KoffieSoort.cappuccino);
            // bekertje.Print();
            Console.Read();
            // Doe dit net zo vaak totdat er een exeption optreedt
        }
    }
}
