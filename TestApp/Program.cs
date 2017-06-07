using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathFinder;


namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = Graph.FromCsv(Environment.CurrentDirectory + @"\trains.csv");

            Finder pathFinder = new Finder(graph, graph.GeVertexByName("A"), graph.GeVertexByName("D"));

            List<List<Connection> > paths = pathFinder.GetAllPaths();

            foreach (var path in paths)
            {
                Console.WriteLine("-----------------------");
                foreach (var connection in path)
                {
                    Console.WriteLine("Z:  {0} O: {1} Do: {2} O: {3}", connection.Source.Value, connection.LeavingTime, connection.Target.Value, connection.ArrivalTime);
                }
                Console.WriteLine("---------------");
            }

            Console.WriteLine("Koniec");

            Console.ReadKey();
        }
    }
}
