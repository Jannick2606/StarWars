using StarWarsEF;

internal class Program
{
    private static void Main(string[] args)
    {
        Extractor extractor = new Extractor();
        List<string> planets = new List<string>();
        planets = extractor.Number1();
        Iterate(planets);
        planets = extractor.Number2();
        Iterate(planets);
        planets = extractor.Number3();
        Iterate(planets);
        planets = extractor.Number4();
        Iterate(planets);
        planets = extractor.Number5();
        Iterate(planets);
        planets = extractor.Number6();
        Iterate(planets);
        planets = extractor.Number7();
        Iterate(planets);
        planets = extractor.Number8();
        Iterate(planets);
        planets = extractor.Number9();
        Iterate(planets);
        planets = extractor.Number10();
        Iterate(planets);
        planets = extractor.Number11();
        Iterate(planets);
        planets = extractor.Number12();
        Iterate(planets);
        planets = extractor.Number13();
        Iterate(planets);
        planets = extractor.Number14();
        Iterate(planets);
        planets = extractor.Number15();
        Iterate(planets);
        planets = extractor.Number16();
        Iterate(planets);
    }
    static void Iterate(List<string> planets)
    {
        foreach (string planet in planets)
        {
            Console.WriteLine(planet);
        }
        Console.WriteLine();
    }
}