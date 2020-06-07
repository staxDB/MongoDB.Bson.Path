﻿using NUnit.Framework;
using System.Text.RegularExpressions;

namespace MongoDB.Bson.Path.Test
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class MiscellaneousUtilsTests
    {
        [Test]
        public void GetRegexOptions()
        {
            var opts = MiscellaneousUtils.GetRegexOptions("imsxRUBBISH");
            Assert.AreEqual(opts, RegexOptions.IgnoreCase | RegexOptions.Multiline |
                RegexOptions.Singleline | RegexOptions.ExplicitCapture);
        }
    }
}
