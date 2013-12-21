using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDrawing.Main
{
   public class Edge
    {

        public Double Value;

        public bool IsDirected;

        public Vertice FirstVertice;

        public Vertice SecondVertice;


        public Edge(Double value, Vertice first, Vertice second, bool directed)
        {
            this.Value = value;
            this.FirstVertice = first;
            this.SecondVertice = second;
            this.IsDirected = directed;
        }


        public override bool Equals(object obj)
        {
            if (obj is Edge)
            {
                Edge other = (Edge)obj;

                return (other.FirstVertice.Equals(this.FirstVertice) && other.SecondVertice.Equals(this.SecondVertice) && other.IsDirected == this.IsDirected && other.Value == this.Value);
            }
            
            return false;
        }
        
    
        
    }
}
