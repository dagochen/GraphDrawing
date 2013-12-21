using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphDrawing.Main;

namespace GraphDrawing.Test
{
    [TestClass]
    public class EdgeTest
    {
        private Edge a, b, c;
        
        private Vertice x, y , z;
        

        [TestInitialize]
        public void testSetup()
        {
            x = new Vertice("X");
            y = new Vertice("Y");
            z = new Vertice("Z");

            a = new Edge(5, x, y, true);
            b = new Edge(3, y, z, true);
            c = new Edge(2, z, x, true);

        }

        [TestMethod]
        public void testConstructor()
        {

            Assert.IsNotNull(a);
            Assert.IsInstanceOfType(a, typeof(Edge));


        }

        [TestMethod]
        public void testChangeValue()
        {

            Assert.AreEqual(5,a.Value);
            a.Value = 3.83;
            Assert.AreEqual(3.83, a.Value);


        }
       
        [TestMethod]
        public void testChangeDirected()
        {

            Assert.AreEqual(true, a.IsDirected);
            a.IsDirected = false;
            Assert.AreEqual(false, a.IsDirected);


        }

        [TestMethod]
        public void testEquals()
        {

            Assert.IsFalse(a.Equals(b));
            Assert.IsFalse(b.Equals(c));
            Assert.IsFalse(c.Equals(a));
            Assert.IsTrue(a.Equals(a));
            Assert.IsTrue(b.Equals(b));
            Assert.IsTrue(c.Equals(c));
            Assert.IsFalse(c.Equals(x));


        }

    }
}
