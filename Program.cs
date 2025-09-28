using System.Dynamic;

namespace GrundernaIOOP
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Skapar 2st objekt för cirklarna av klassen Circle
            Circle circle = new Circle(5);
            Circle circle2 = new Circle(6);
            //Hämtar metoden av cirkeln två gånger och sätter in 2st olika radier samt skriver ut själva cirkelns area
            Console.WriteLine("Arean av cirkeln med 5 i radie är: " + Circle.GetArea(5));
            Console.WriteLine("Arean av cirkeln med 6 i radie är: " + Circle.GetArea(6));
        }
    }
}
