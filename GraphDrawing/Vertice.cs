using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphDrawing.Main
{
    public class Vertice
    {
        public static int id = 1;


        public String Name;

        public bool IsVisited;

        public int ID;

        public Vertice()
        {
            this.Name = "";
            this.IsVisited = false;
            this.ID = id;
            id++;
        }


        public Vertice(String name = "")
        {
            this.Name = name;
            this.IsVisited = false;
            this.ID = id;
            id++;
        }
    }
}
