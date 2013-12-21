using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphDrawing.Main;
namespace GraphDrawing.Test
{
    [TestClass]
    public class VerticeTest
    {
        Vertice vert, vert2;

        

        [TestInitialize]
        public void testSetup()
        {
            vert = new Vertice("Hallo");
            vert2 = new Vertice();

        }


        [TestMethod]
        public void testConstructor()
        {

            Assert.IsNotNull(vert);
            Assert.IsInstanceOfType(vert, typeof(Vertice));


            Assert.IsNotNull(vert2);
            Assert.IsInstanceOfType(vert2, typeof(Vertice));


        }

        [TestMethod]
        public void testCanBeVisited()
        {


            Assert.IsFalse(vert.IsVisited);
            vert.IsVisited = true;

            Assert.IsTrue(vert.IsVisited);

        }

        [TestMethod]
        public void testNameChanged()
        {

            Assert.AreEqual("", vert2.Name);
            vert2.Name = "Neuer Name";
            Assert.AreEqual("Neuer Name", vert2.Name);

        }

        


    }
}
