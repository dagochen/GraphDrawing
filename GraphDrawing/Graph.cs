using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDrawing.Main
{
    public class Graph
    {
        private List<Vertice> _vertices;
        private List<Edge> _edges;


        public List<Vertice> Vertices
        {
            get
            {
                return _vertices.ToList<Vertice>();
            }
        }

        public List<Edge> Edges
        {
            get
            {
                return _edges.ToList<Edge>();
            }
        }

        public Graph()
        {
            _vertices = new List<Vertice>();
            _edges = new List<Edge>();
        }




        public void addVertice(Vertice v)
        {
            _vertices.Add(v);
        }
    }
}
