using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Data.Common;

namespace calc
{
    class MyMathTest
    {
        [TestFixture]
        class Tests_Add
        {
            [TestCase]
            public void TestAddPositive()
            {
                MyMath math = new MyMath();
                Assert.AreEqual(30, math.Add(10, 20));

            }
            [TestCase]
            public void TestAddNegative()
            {
                MyMath math = new MyMath();
                Assert.AreEqual(45, math.Add(10, 20));

            }

        }
        class Tests_Sub
        {
            [TestCase]
            public void TestSubPositive()
            {
                MyMath math = new MyMath();
                Assert.AreEqual(-10, math.Sub(10, 20));

            }
            [TestCase]
            public void TestAddNegative()
            {
                MyMath math = new MyMath();
                Assert.AreEqual(45, math.Sub(10, 20));

            }
        }
        class Tests_Mul
        {
            [TestCase]
            public void TestMulPositive()
            {
                MyMath math = new MyMath();
                Assert.AreEqual(200, math.Mul(10, 20));

            }
            [TestCase]
            public void TestMulNegative()
            {
                MyMath math = new MyMath();
                Assert.AreEqual(45, math.Mul(10, 20));

            }
        }
        class Tests_Dev
        {
            [TestCase]
            public void TestDevPositive()
            {
                MyMath math = new MyMath();
                Assert.AreEqual(0.5, math.Dev(10, 20));

            }
            [TestCase]
            public void TestDevNegative()
            {
                MyMath math = new MyMath();
                Assert.AreEqual(45, math.Dev(10, 20));

            }
            [TestCase]
            public void IsDevInteger()
            {
                MyMath math = new MyMath();
                Assert.IsInstanceOf(typeof(int) , math.Dev(10, 20));
            }
        }
    }
}
