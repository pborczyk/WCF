using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    public class Finder
    {
        private Graph graph;

        private Vertex source;

        private Vertex target;

        private List<List<Connection>> paths = new List<List<Connection>>();

        public DateTime? LeaveTime { get; set; } = null;

        public DateTime? ArrivalTime { get; set; } = null;

        public Finder(Graph graph, Vertex source, Vertex target)
        {
            this.graph = graph;
            this.source = source;
            this.target = target;
        }


        public List<List<Connection>> GetAllPaths()
        {
            graph.CleanState();
            DepthSearchFirst(source, LeaveTime, new List<Connection>());
            if (ArrivalTime != null)
            {
                paths = paths.Where(path =>
                {
                    return DateTime.Compare(
                               path[path.Count - 1].ArrivalTime,
                               ArrivalTime.Value) <= 0;

                }).ToList();
            }
            return paths;
        }


        private void DepthSearchFirst(Vertex vertex, DateTime? arrivalTime, List<Connection> path)
        {
            vertex.Visted = true;
            foreach (var connection in graph.GetConnections(vertex, arrivalTime ?? DateTime.MinValue))
            {

                
                {
                    List<Connection> newPath = new List<Connection>(path);
                    newPath.Add(connection);
                    if (connection.Target.Equals(target))
                    {
                        paths.Add(newPath);
                    }
                    DepthSearchFirst(connection.Target, connection.ArrivalTime, newPath);
                }
               

            }

        }
    }
}

