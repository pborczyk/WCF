using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PathFinder;

namespace TrainsService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TrainsService" in both code and config file together.
    public class TrainsService : ITrainsService
    {
        public List<Path> GetPaths(PathsQuery pathsQuery)
        {
            Graph graph = Graph.FromCsv(@"D:\Pobrane\trains.csv");

            if (!graph.ContainsVertex(pathsQuery.SourceCity) || !graph.ContainsVertex(pathsQuery.TargetCity))
            {
                throw new FaultException("No such city in database.");
            }


            Finder pathFinder = new Finder(graph, graph.GeVertexByName(pathsQuery.SourceCity), graph.GeVertexByName(pathsQuery.TargetCity));
            try
            {
                if (pathsQuery.LeavingTime != null)
                {
                    pathFinder.LeaveTime = DateTime.Parse(pathsQuery.LeavingTime);
                }

                if (pathsQuery.ArrivalTime != null)
                {
                    pathFinder.ArrivalTime = DateTime.Parse(pathsQuery.ArrivalTime);
                }
            }
            catch (Exception e)
            {
                throw new FaultException("Date parsing error.");
            }
            List<List<Connection>> paths = pathFinder.GetAllPaths();
            List<Path> toReturn = new List<Path>();

            foreach (var path in paths)
            {
                List<string> pathList = new List<string>();

                foreach (var connection in path)
                {
                    pathList.Add("FROM: " + connection.Source + " AT: " + connection.LeavingTime + " TO: " + connection.Target + " AT: " + connection.ArrivalTime);
                }

                Path newPath = new Path();
                newPath.Value = pathList;
                toReturn.Add(newPath);
            }

            return toReturn;
        }
    }
}
