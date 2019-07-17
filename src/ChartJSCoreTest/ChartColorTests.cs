using System;
using System.Globalization;
using ChartJSCore.Helpers;
using NUnit.Framework;

namespace ChartJSCoreTest
{
    [TestFixture]
    public class ChartColorTests
    {
        [Test]
        public void Too_Big_Alpha_Throws_ArgumentOutOfRangeException()
        {
            byte red = 0;
            byte green = 0;
            byte blue = 0;
            double alpha = 1.1;

            Assert.Throws<ArgumentOutOfRangeException>(() => ChartColor.FromRgba(red, green, blue, alpha));
        }

        [Test]
        public void Too_Small_Alpha_Throws_ArgumentOutOfRangeException()
        {
            byte red = 0;
            byte green = 0;
            byte blue = 0;
            double alpha = -5;

            Assert.Throws<ArgumentOutOfRangeException>(() => ChartColor.FromRgba(red, green, blue, alpha));
        }

        [Test]
        public void FromRgba_Populates_Correct_Values()
        {
            byte expectedRed = 187;
            byte expectedGreen = 55;
            byte expectedBlue = 4;
            double expectedAlpha = 0.65;

            var actualColor = ChartColor.FromRgba(expectedRed, expectedGreen, expectedBlue, expectedAlpha);

            Assert.AreEqual(expectedRed, actualColor.Red);
            Assert.AreEqual(expectedGreen, actualColor.Green);
            Assert.AreEqual(expectedBlue, actualColor.Blue);
            Assert.AreEqual(expectedAlpha, actualColor.Alpha);
        }

        [Test]
        public void FromRgb_Populates_Correct_Values()
        {
            byte expectedRed = 66;
            byte expectedGreen = 99;
            byte expectedBlue = 111;

            var actualColor = ChartColor.FromRgb(expectedRed, expectedGreen, expectedBlue);

            Assert.AreEqual(expectedRed, actualColor.Red);
            Assert.AreEqual(expectedGreen, actualColor.Green);
            Assert.AreEqual(expectedBlue, actualColor.Blue);
        }

        [Test]
        public void FromRgb_Populates_Alpha_With_One()
        {
            double expectedAlpha = 1.0;

            var actualColor = ChartColor.FromRgb(0, 0, 0);

            Assert.AreEqual(expectedAlpha, actualColor.Alpha);
        }

        [Test]
        public void FromHexString_Throws_FormatException_Without_Hex_Specifier()
        {
            string hexString = "12abef";

            Assert.Throws<FormatException>(() => ChartColor.FromHexString(hexString));
        }


        [Test]
        public void FromHexString_Throws_FormatException_With_False_Length()
        {
            string tooShortHexString = "#12abe";
            string tooLongHexString = "#12abefa";

            Assert.Throws<FormatException>(() => ChartColor.FromHexString(tooShortHexString));
            Assert.Throws<FormatException>(() => ChartColor.FromHexString(tooLongHexString));
        }

        [Test]
        public void FromHexString_Throws_FormatException_Invalid_Hex_Character()
        {
            string invalidHexString = "#12abex";

            Assert.Throws<FormatException>(() => ChartColor.FromHexString(invalidHexString));
        }

        [Test]
        public void FromHexString_Populates_Correct_Values()
        {
            byte expectedRed = 154;
            byte expectedGreen = 89;
            byte expectedBlue = 77;
            double expectedAlpha = 1.0;

            var actualColor = ChartColor.FromHexString($"#{expectedRed:X}{expectedGreen:X}{expectedBlue:X}");

            Assert.AreEqual(expectedRed, actualColor.Red);
            Assert.AreEqual(expectedGreen, actualColor.Green);
            Assert.AreEqual(expectedBlue, actualColor.Blue);
            Assert.AreEqual(expectedAlpha, actualColor.Alpha);
        }

        [Test]
        public void GetRandomChartColor_With_Random_Alpha_Returns_Values_In_Boundry()
        {
            var randomColor = ChartColor.CreateRandomChartColor(true);

            Assert.That(randomColor.Red, Is.GreaterThanOrEqualTo(0).And.LessThanOrEqualTo(256));
            Assert.That(randomColor.Green, Is.GreaterThanOrEqualTo(0).And.LessThanOrEqualTo(256));
            Assert.That(randomColor.Blue, Is.GreaterThanOrEqualTo(0).And.LessThanOrEqualTo(256));
            Assert.That(randomColor.Alpha, Is.GreaterThanOrEqualTo(0.0).And.LessThanOrEqualTo(1.0));
        }

        [Test]
        public void GetRandomChartColor_Without_Random_Alpha_Returns_Values_In_Boundry_And_Alpha_One()
        {
            double expectedAlpha = 1.0;

            var randomColor = ChartColor.CreateRandomChartColor(false);

            Assert.That(randomColor.Red, Is.GreaterThanOrEqualTo(0).And.LessThanOrEqualTo(256));
            Assert.That(randomColor.Green, Is.GreaterThanOrEqualTo(0).And.LessThanOrEqualTo(256));
            Assert.That(randomColor.Blue, Is.GreaterThanOrEqualTo(0).And.LessThanOrEqualTo(256));
            Assert.AreEqual(randomColor.Alpha, expectedAlpha);
        }

        [Test]
        public void ToString_Returns_Correct_Rgba_String_Representation()
        {
            byte red = 4;
            byte green = 65;
            byte blue = 154;
            double alpha = 0.232;

            string expectedString = $"rgba({red}, {green}, {blue}, {alpha.ToString(CultureInfo.InvariantCulture)})";

            var color = ChartColor.FromRgba(red, green, blue, alpha);
            var actualString = color.ToString();

            Assert.AreEqual(expectedString, actualString);
        }

        [Test]
        public void ToString_Comma_Culture_Returns_Correct_Rgba_String_Representation()
        {
            byte red = 4;
            byte green = 65;
            byte blue = 154;
            double alpha = 0.232;

            CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("nl-NL");
            string expectedString = $"rgba({red}, {green}, {blue}, {alpha.ToString(CultureInfo.InvariantCulture)})";

            var color = ChartColor.FromRgba(red, green, blue, alpha);
            var actualString = color.ToString();

            Assert.AreEqual(expectedString, actualString);
        }
    }
}
