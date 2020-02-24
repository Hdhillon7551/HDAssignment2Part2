using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HDAssignment2Part2.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
       [Test]
       public void EquilateralTriangle_AnalyzeTest()
        {
            Assert.AreEqual(6, 6, 6, TriangleSolver.Analyze(6, 6, 6));
        }

        [Test]
        public void IsoscelesTriangle_AnalyzeTest()
        {
            Assert.AreEqual(4, 6, 6, TriangleSolver.Analyze(4, 6, 6));
        }

        [Test]
        public void ScaleneTriangle_AnalyzeTest()
        {
            Assert.AreEqual(4, 5, 6, TriangleSolver.Analyze(4, 5, 6));
        }
        [Test]
        public void TriangleNotCreated_AnalyzeTest()
        {
            Assert.AreEqual(0,0, 0, TriangleSolver.Analyze(0, 0, 0));
        }

        [Test]
        public void TriangleCreated_AnalyzeTest()
        {
            Assert.AreEqual(3, 4, 5, TriangleSolver.Analyze(3, 4, 5));
        }
        [Test]
        public void EquiangularTriangle_AnalyzeTest()
        {
            Assert.AreEqual(7, 7, 7, TriangleSolver.Analyze(7, 7, 7));
        }
    }
}
