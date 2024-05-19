using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undervisning_Objekter_via_Javascript
{
    internal class Box
    {
        // Dette blir for å lage "malen" for en boks,
        // også sånn at vi kan bruke den flere ganger til å lage flere av samme objekt

        // tilgangskontroller:
        // public - tilgjengelig utenfor klassen
        // private - bare tilgjengelig inni klassen
        // internal - ganske lik som private med noen små forskjeller
        // protected  - Du får denne hvis du ikke legger til en tilgangskontroller 

        public int Width;
        public int Height;

        public void Show(char letter)
        {
            // Trenger ikke å skrive this. foran variablen inni klassen, siden det er objekt variabler kan vi få tak i de direkte.
            // Men gjør det her så jeg husker at man kan gjøre det.
            Console.WriteLine(char.ToUpper(letter) + " bredden er " + this.Width + " og høyden er " + this.Height);
        }


    }
}
