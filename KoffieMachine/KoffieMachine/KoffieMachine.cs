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
        public KoffieMachine( int AantalSuikerklontjes, int Aantalkoffiebonen, int AantalMelkpoeder ) 
        {
            this.Suikerklontjes = AantalSuikerklontjes;
            this.Koffiebonen = Aantalkoffiebonen;
            this.Melkpoeder = AantalMelkpoeder;
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
            if( this.Melkpoeder < 0)
            {
                throw new Exception("Melk op");
            }

            // Vul dit aan voor de overige velden
        }

        public Bekertje GeefCappuccino()
        {
            ControleerResources();
            
            this.Suikerklontjes = this.Suikerklontjes -= 2;
            this.Koffiebonen = this.Koffiebonen -= 4;
            this.Melkpoeder = this.Melkpoeder -= 5;
           

            Bekertje bekertjeC = new Bekertje( KoffieSoort.cappuccino );
     
            return bekertjeC;
        }
        public Bekertje GeefLattemacchiato()
        {
            ControleerResources();

            this.Suikerklontjes -= 1;
            this.Koffiebonen -= 3;
            this.Melkpoeder -= 5;
            Bekertje bekertjeL = new Bekertje(KoffieSoort.lattemacchiato);

            return bekertjeL;
        }
        public Bekertje GeefKoffiezwart()
        {
            ControleerResources();

            this.Suikerklontjes -= 0;
            this.Koffiebonen -= 4;
            this.Melkpoeder -= 0;
            Bekertje bekertjeZ = new Bekertje(KoffieSoort.koffiezwart);

            return bekertjeZ;
        }
        public override string ToString()
        {
            return $"Deze automaat heeft {Suikerklontjes} suikerklontjes, {Koffiebonen} koffiebonen en {Melkpoeder} gram melkpoeder.";
        }
    }
}
