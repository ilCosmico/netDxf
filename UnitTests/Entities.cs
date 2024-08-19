using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using netDxf;
using netDxf.Entities;
using static UnitTesting.Toolkit;

namespace UnitTesting
{
    [TestClass]
    public class Entities
    {
        [TestMethod]
        public void RetrieveEllipseParams()
        {
            DxfDocument dxf = DxfDocument.Load(TestAsset("ellipse.dxf"));
            
            Assert.AreEqual(1, dxf.Entities.Ellipses.Count());

            Ellipse ellipse = dxf.Entities.Ellipses.First();

            Assert.IsInstanceOfType(ellipse, typeof(Ellipse));

            Assert.AreEqual(3.261025321817105, ellipse.StartParamRaw);
            Assert.AreEqual(4.103896461580776, ellipse.EndParamRaw);
        }
    }
}