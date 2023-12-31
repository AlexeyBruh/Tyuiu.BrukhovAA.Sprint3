﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BrukhovAA.Sprint3.Task0.V22.Lib;

namespace Tyuiu.BrukhovAA.Sprint3.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 8;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 31.328;

            Assert.AreEqual(wait, res);

        }
    }
}
