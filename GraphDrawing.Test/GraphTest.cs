using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphDrawing.Main;

namespace GraphDrawing.Test
{
    [TestClass]
    public class GraphTest
    {
        private Graph graph;
        private Vertice v;
        [TestInitialize]
        public void testSetup()
        {
            graph = new Graph();
            v = new Vertice();
        }

        [TestMethod]
        public void testGraphConstructor()
        {
            Assert.IsNotNull(graph);
            Assert.IsInstanceOfType(graph, typeof(Graph));
            Assert.AreEqual(0, graph.Edges.Count);
            Assert.AreEqual(0, graph.Vertices.Count);
        }

        [TestMethod]
        public void testAddVertice()
        {
            Assert.AreEqual(0, graph.Vertices.Count);
            graph.addVertice(v);
            Assert.AreEqual(1, graph.Vertices.Count);
            Assert.IsTrue(graph.Vertices.Contains(v));
        
        }



    }
}
