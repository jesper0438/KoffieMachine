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

        // Het aantal gram melkpoeder

        // Vergeet de constructor niet
        // en stel de private fields / velden in

        private void ControleerResources()
        {
            if( this.Suikerklontjes < 0)
            {
                throw new Exception("DE SUIKER IS OP!!!");
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
