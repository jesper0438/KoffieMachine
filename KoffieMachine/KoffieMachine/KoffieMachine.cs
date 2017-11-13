using System;
using System.Collections.Generic;
using System.Text;

namespace KoffieMachine
{
    class KoffieMachine
    {
        // Het aantal suikerklontjes
        private int Suikerklontjes;

        // Het aantal koffiebonen
        private int Koffiebonen;

        // Het aantal gram melkpoeder
        private int Melkpoeder;

        // Vergeet de constructor niet
        public KoffieMachine(int AantalSuikerklontjes, int Aantalkoffiebonen, int AantalMelkpoeder)
        {
            Suikerklontjes = AantalSuikerklontjes;
            Koffiebonen = Aantalkoffiebonen;
            Melkpoeder = AantalMelkpoeder;
        }
        // en stel de private fields / velden in

        private void ControleerResources()
        {
            if( this.Suikerklontjes < 0)
            {
                throw new Exception("DE SUIKER IS OP!!!");
            }
            if( this.Koffiebonen < 0)
            {
                throw new Exception("BONEN OP");
            }
            if( this.Melkpoeder <0)
            {
                throw new Exception("Melk op");
            }

            // Vul dit aan voor de overige velden
        }

        public Bekertje GeefCappuccino()
        {
            ControleerResources();

            // Een cappuccino bestaat uit:
            // 2 suikerklontjes
            // 4 koffiebonen
            // 10 gram melk
            //this.Suikerklontjes -= 2;
            //this.Suikerklontjes = this.Suikerklontjes - 2;

            Bekertje bekertje = new Bekertje( KoffieSoort.cappuccino );

            return bekertje;
        }
    }
}
