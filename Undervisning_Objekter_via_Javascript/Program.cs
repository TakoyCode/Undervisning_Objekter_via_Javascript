namespace Undervisning_Objekter_via_Javascript
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // JS objekt eks: var x = {Width: 50, Height:30};


            // C# objekt skrivet så nærme vi kommer ett JS objekt eks:
            var x = new { Width = 50, Height = 30};
            Console.WriteLine("X bredden er " + x.Width + " og høyden er " + x.Height);
            // Ulempe med denne er at vi lager ett anonymt objekt


            // C# objekt skrevet på den klassike C# måten eks:
            Box y = new Box();

            // Metode 1 for å endre feltene i ett objekt:
            y.Width = 16;
            y.Height = 32;

            Console.WriteLine("Y bredden er " + y.Width + " og høyden er " + y.Height);


            // Metode 2 for å endre feltene i ett objekt:
            // I stedet for å lage objektet og så sette feltene etterpå, så lager du objektet og setter feltene samtidig
            Box z = new Box
            {
                Width = 12,
                Height = 45,
            };

            Console.WriteLine("Z bredden er " + z.Width + " og høyden er " + z.Height);
            

            // Vi kan også putte metoder inni klasser, som gjør det lettere å gjøre samme ting flere steder eks: 
            Box q = new Box
            {
                Width = 1,
                Height = 2,
            };

            q.Show('q');


            // Med Resharper trykk ctrl + r + ctrl + r, for at den renamer en variabel på alle steder den blir brukt
            // Med Resharper trykk alt + enter som at den legger til public/internal for deg på variablen du bruker det på
            // Kan også bruke keybinden over ^^, til at resharper kan lage ett "skelton" for en ikke laget metode
            // Kan trykke f12 til å hoppe til en metode sin kode, fra hvor den er kallet 
        }
    }
}
