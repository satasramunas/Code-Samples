using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoWebApi.Helpers;

namespace TodoWebApi.UnitTests.Helpers
{
    [TestFixture]
    public class DiscountHelperTests
    {
        [Test]
        public void GetDiscountPrice_GivenValidPrice_AppliesDiscount()
        {
            var originalPrice = 1.0M;
            var discountedPrice = DiscountHelper.GetDiscountPrice(originalPrice);
            Assert.AreEqual(0.9M, discountedPrice);
        }
    }
}
