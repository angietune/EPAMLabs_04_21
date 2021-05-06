using System;
using GeometricFigures;
using NUnit.Framework;

namespace Lab4
{
    public class Tests
    {
        [Test]
        public void RectangleArea([Range(1, 20, 1)] double size1, [Range(1, 20, 1)] double size2)
        {
            double RA = GeometricFigures.Rectangle.GetArea(size1, size2);
            double result = size1 * size2;
            Assert.AreEqual(result, RA);
        }

        [Test]
        public void RectangleLength([Range(1, 20, 1)] double size1, [Range(1, 20, 1)] double size2)
        {
            double RL = GeometricFigures.Rectangle.GetLength(size1, size2);
            double result = (size1 + size2) * 2;
            Assert.AreEqual(result, RL);
        }

        [Test]
        public void TestSquareArea([Range(1, 20, 1)] double size)
        {
            double SA = GeometricFigures.Square.GetArea(size);
            double result = size * size;
            Assert.AreEqual(result, SA);
        }

        [Test]
        public void TestSquareLength([Range(1, 20, 1)] double size)
        {
            double SL = GeometricFigures.Square.GetLength(size);
            double result = size * 4;
            Assert.AreEqual(result, SL);
        }

        [Test]
        public void TestTriangleArea([Range(1, 20, 1)] double size1, [Range(1, 20, 1)] double size2, [Range(1, 20, 1)] double size3)
        {
            if ((size1 + size2)>size3 && (size1 + size3) > size2 && (size2 + size3) > size1)
            {
                double TA = GeometricFigures.Triangle.GetArea(size1, size2, size3);
                double p = (size1 + size2 + size3) / 2;
                double result = Math.Sqrt(p * (p - size1) * (p - size2) * (p - size3));
                Assert.AreEqual(result, TA);
            } else
            {
                throw new Exception("Triangle does not exist");
            }
        }
        [Test]
        public void TestTriangleLength([Range(1, 20, 1)] double size1, [Range(1, 20, 1)] double size2, [Range(1, 20, 1)] double size3)
        {
            if ((size1 + size2) > size3 && (size1 + size3) > size2 && (size2 + size3) > size1)
            {
                double TL = GeometricFigures.Triangle.GetLength(size1, size2, size3);
                double result = size1 + size2 + size3;
                Assert.AreEqual(result, TL);
            } else
            {
                throw new Exception("Triangle does not exist");
            }
        }

    }
}