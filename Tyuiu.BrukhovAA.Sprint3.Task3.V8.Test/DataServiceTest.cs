using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BrukhovAA.Sprint3.Task3.V8.Lib;

namespace Tyuiu.BrukhovAA.Sprint3.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();
            string value = "vc,xfc44fc!e";

            var res = ds.ConvertStringToInt(value);

            int wait = 44;

            Assert.AreEqual(wait, res);
        }
    }
}
