﻿using LagoVista.Core.Models.Geo;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LagoVista.Core.Tests.Geo
{

    [TestClass]
    public class GeoLocationMathTests
    {

        [TestMethod]
        public void GeogrpahyType_Find_North()
        {
            var start = new GeoLocation(27, -82);
            var end = new GeoLocation(29, -82);

            var heading = start.HeadingTo(end);
            Console.WriteLine($"heading => {heading}");
            Assert.AreEqual(0, heading, 2);
        }

        [TestMethod]
        public void GeogrpahyType_Find_South()
        {
            var start = new GeoLocation(27, -82);
            var end = new GeoLocation(25, -82);

            var heading = start.HeadingTo(end);
            Console.WriteLine($"heading => {heading}");
            Assert.AreEqual(180, heading, 2);
        }

        [TestMethod]
        public void GeogrpahyType_Find_West()
        {
            var start = new GeoLocation(25, -82);
            var end = new GeoLocation(25, -83);

            var heading = start.HeadingTo(end);
            Console.WriteLine($"heading => {heading}");
            Assert.AreEqual(270, Convert.ToInt32(heading));
        }

        [TestMethod]
        public void GeogrpahyType_Find_East()
        {
            var start = new GeoLocation(25, -82);
            var end = new GeoLocation(25, -81);

            var heading = start.HeadingTo(end);
            Console.WriteLine($"heading => {heading}");
            Assert.AreEqual(Convert.ToInt32(90), Convert.ToInt32(heading));
        }

    }
}
