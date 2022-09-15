using Indexer;

namespace Indexers
{

    class Test
    {
        public static void Main()

        {
            KlassIndexer obj = new KlassIndexer();
            // KlassIndexer skapar ett objekt obj 
            obj[0] = "Den första";
            obj[1] = "Den andra";
            obj[2] = "Den tredje";
            obj[3] = "Den fjärde";
            obj[4] = "Den femte";
            Console.WriteLine("Ett exempel på en indexerare");
            Console.WriteLine();
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n", obj[0], obj[1], obj[2], obj[3], obj[4]);
            Console.ReadKey();
        }
    }
}
