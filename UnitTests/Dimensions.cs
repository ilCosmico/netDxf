using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using netDxf;
using netDxf.Entities;
using static UnitTesting.Toolkit;

namespace UnitTesting
{
    [TestClass]
    public class Dimensions
    {
        [TestMethod]
        public void ReadOrientedDim_1()
        {
            DxfDocument dxf = DxfDocument.Load(TestAsset("TestOrientedDim_1.dxf"));
            
            Assert.AreEqual(1, dxf.Entities.Dimensions.Count());
            
            Assert.IsInstanceOfType(dxf.Entities.Dimensions.First(), typeof(LinearDimension));
        }
        
        [TestMethod]
        public void ReadOrientedDim_2()
        {
            DxfDocument dxf = DxfDocument.Load(TestAsset("TestOrientedDim_2.dxf"));
            
            Assert.AreEqual(1, dxf.Entities.Dimensions.Count());
            
            Assert.IsInstanceOfType(dxf.Entities.Dimensions.First(), typeof(LinearDimension));
        }
    }
}