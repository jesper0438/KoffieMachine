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

        private void ControleerResourcesCappuccino()
        {
            if( this.Suikerklontjes < 2)
            {
                throw new Exception("DE SUIKER IS OP!!!");
            }
            if( this.Koffiebonen < 4)
            {
                throw new Exception("BONEN OP");
            }
            if( this.Melkpoeder < 5)
            {
                throw new Exception("Melk op");
            }

            // Vul dit aan voor de overige velden
        }
        private void ControleerResourcesLattemacchiato()
        {
            if (this.Suikerklontjes < 1)
            {
                throw new Exception("DE SUIKER IS OP!!!");
            }
            if (this.Koffiebonen < 3)
            {
                throw new Exception("BONEN OP");
            }
            if (this.Melkpoeder < 5)
            {
                throw new Exception("Melk op");
            }

            // Vul dit aan voor de overige velden
        }
        private void ControleerResourcesKoffiezwart()
        {
            if (this.Koffiebonen < 0)
            {
                throw new Exception("BONEN OP");
            }

            // Vul dit aan voor de overige velden
        }

        public Bekertje GeefCappuccino()
        {
            ControleerResourcesCappuccino();
            
            this.Suikerklontjes = this.Suikerklontjes -= 2;
            this.Koffiebonen = this.Koffiebonen -= 4;
            this.Melkpoeder = this.Melkpoeder -= 5;
           

            Bekertje bekertjeC = new Bekertje( KoffieSoort.cappuccino );
     
            return bekertjeC;
        }
        public Bekertje GeefLattemacchiato()
        {
            ControleerResourcesLattemacchiato();

            this.Suikerklontjes -= 1;
            this.Koffiebonen -= 3;
            this.Melkpoeder -= 5;
            Bekertje bekertjeL = new Bekertje(KoffieSoort.lattemacchiato);

            return bekertjeL;
        }
        public Bekertje GeefKoffiezwart()
        {
            ControleerResourcesKoffiezwart();

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
