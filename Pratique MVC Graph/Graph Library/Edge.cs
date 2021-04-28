using System;

namespace Graph_Library
{
    public class Edge<T>
    {
        public Edge()
        {

        }
        public Edge(Vertex<T> destination, double weight)
        {
            Destination = destination;
            Weight = weight;
        }

        public Vertex<T> Destination { get; set; }

        public double Weight { get; set; }
    }
}
