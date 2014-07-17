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

        [Test]
        public void TestGreatest()
        {
            var a = 3.5;
            var b = 4;
            var greatest = this.Model.Greatest(a, b);

            Assert.AreEqual(4, greatest);

            a = 3.5;
            b = -4;
            greatest = this.Model.Greatest(a, b);

            Assert.AreEqual(3.5, greatest);
        }

        [Test]
        public void TestTimeConversion()
        {
            var seconds = 556;
            var converted = this.Model.ConvertToHMS(seconds);

            Assert.AreEqual("0:9:16", converted);


            seconds = 3600;
            converted = this.Model.ConvertToHMS(seconds);

            Assert.AreEqual("1:0:0", converted);


            seconds = 3660;
            converted = this.Model.ConvertToHMS(seconds);

            Assert.AreEqual("1:1:0", converted);


            seconds = 3669;
            converted = this.Model.ConvertToHMS(seconds);

            Assert.AreEqual("1:1:9", converted);
        }
    }
}
