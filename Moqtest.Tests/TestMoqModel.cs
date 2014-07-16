using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Moq;

namespace Moqtest.Tests
{
    [TestFixture]
    public class TestMoqModel
    {
        public MoqModel Model { get; set; }

        public TestMoqModel()
        {
            this.Model = Mock.Of<MoqModel>();
        }
        
        [Test]
        public void TestDateIsNotNull()
        {
            Assert.NotNull(this.Model.Date);
        }

        [Test]
        public void TestHypotenuse()
        {
            var a = 3;
            var b = 4;
            var hypo = this.Model.Hypotenuse(a, b);

            Assert.AreEqual(5, hypo);
        }
    }
}
