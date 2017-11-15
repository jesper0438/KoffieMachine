using System;
using System.Collections.Generic;
using System.Text;

namespace KoffieMachine
{
    class Bekertje
    {
        //instantie variabele 
        private KoffieSoort SoortKoffie;

        //constructor
        public Bekertje(KoffieSoort koffieSoort)
        {
            SoortKoffie = koffieSoort;
        }
        //methods
        public void PrintKoffieZwart()
        {
            Console.WriteLine("Koffie zwart");
        }

        public void PrintLatteMacchiato()
        {
            Console.WriteLine("Gewoon een bak melk");
        }

       
        public void PrintCappuccino()
        {
            Console.WriteLine("          {");
            Console.WriteLine("       }   }   {");
            Console.WriteLine("      {   {  }  }");
            Console.WriteLine("       }   }{  {");
            Console.WriteLine("      {  }{  }  }");
            Console.WriteLine("     ( }{ }{  { )");
            Console.WriteLine("    .-{   }   }-.");
            Console.WriteLine("   ( ( } { } { } )");
            Console.WriteLine("   |`-.._____..-'|");
            Console.WriteLine("   |             ;--.");
            Console.WriteLine("   |   (__)     (__  \\");
            Console.WriteLine("   |   (oo)      | )  )");
            Console.WriteLine("   |    \\/       |/  /");
            Console.WriteLine("   |             /  /    ");
            Console.WriteLine("   |            (  /");
            Console.WriteLine("   \\             y'");
            Console.WriteLine("    `-.._____..-'");
            // Thanks to -Felix Lee- (Decorative)-
        }

        public void Print()
        {
            if(this.SoortKoffie == KoffieSoort.cappuccino)
            {
                PrintCappuccino();
            }

            else if (this.SoortKoffie == KoffieSoort.koffiezwart)
            {
                PrintKoffieZwart();
            }

            else if (this.SoortKoffie == KoffieSoort.lattemacchiato)
            {
                PrintLatteMacchiato();
            }
        }

    }
}
