using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace PathFinder
{
    public class Graph
    {
        ISet<Vertex> vertices = new HashSet<Vertex>();
        ISet<Connection> connections = new HashSet<Connection>();

        public void AddVertex(Vertex vertex)
        {
            vertices.Add(vertex);
        }

        public bool ContainsVertex(string name)
        {
            return vertices.Any(v => v.Value == name);
        }

        public Vertex GeVertexByName(string name)
        {
            return vertices.First(v => v.Value == name);
        }

        public void AddConnection(Connection connection)
        {
            connections.Add(connection);
        }

        public void AddConnectionWithVertices(Connection connection)
        {
            vertices.Add(connection.Source);
            vertices.Add(connection.Target);
            connections.Add(connection);
        }

        public List<Connection> GetConnections(Vertex vertex, DateTime afterTime)
        {
            return connections.Where(con => Equals(con.Source, vertex))
                .Where(con => DateTime.Compare(afterTime, con.LeavingTime) <= 0).ToList();
        }

        public static Graph FromCsv(string csvPath)
        {
            Graph graph = new Graph();

            using (TextFieldParser parser = new TextFieldParser(csvPath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                parser.ReadFields(); // ommiting header
                while (!parser.EndOfData)
                {
                    //Process row
                    string[] fields = parser.ReadFields();
                    string sourceCity = fields[0];
                    DateTime leavingTime = DateTime.Parse(fields[1]);
                    string targetCity = fields[2];
                    DateTime arrivalTime = DateTime.Parse(fields[3]);

                    Connection newConnection = new Connection(new Vertex(sourceCity), new Vertex(targetCity), leavingTime, arrivalTime);

                    if (DateTime.Compare(newConnection.LeavingTime, newConnection.ArrivalTime) < 0)
                    {
                        graph.AddConnectionWithVertices(newConnection);
                    }
                    
                }
            }

            return graph;
        }

        public void CleanState()
        {
            foreach (var vertex in vertices)
            {
                vertex.Visted = false;
            }
        }
    }
}

