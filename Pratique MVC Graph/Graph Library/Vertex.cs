using System;
using System.Collections.Generic;
using System.Text;

namespace Graph_Library
{
    public class Vertex<T>
    {
        public Vertex()
        {
        }
        public Vertex(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public List<Edge<T>> Edges { get; } = new List<Edge<T>>();
        public bool Visited { get; set; }
    }
   
}
