using System;
using System.Globalization;
using Newtonsoft.Json;

namespace ChartJSCore.Helpers
{
    [JsonConverter(typeof(ToStringJsonConverter))]
    public class ChartColor
    {
        /// <summary>
        /// The red (r) value of the color
        /// Has a value between 0 and 256
        /// </summary>
        public byte Red { get; set; } = 0;

        /// <summary>
        /// The green (g) value of the color
        /// Has a value between 0 and 256
        /// </summary>
        public byte Green { get; set; } = 0;

        /// <summary>
        /// The blue (b) value of the color
        /// Has a value between 0 and 256
        /// </summary>
        public byte Blue { get; set; } = 0;

        /// <summary>
        /// The alpha (a) value of the color which specifies the opacity
        /// Has a value between 0.0 and 1.0
        /// </summary>
        public double Alpha { get; set; } = 0.1;


        /// <summary>
        /// Creates a new color with the specified values.
        /// The alpha-value (<see cref="a"/>) must be between 0.0 and 1.0
        /// </summary>
        /// <param name="r">The red (r) value of the color</param>
        /// <param name="g">The green (g) value of the color</param>
        /// <param name="b">The blue (b) value of the color</param>
        /// <param name="a">he alpha (a) value of the color which specifies the opacity. Has a value between 0.0 and 1.0.</param>
        /// <returns>A new color with the specified values</returns>
        /// <exception cref="ArgumentOutOfRangeException">Throws when the alpha value has an invalid value</exception>
        public static ChartColor FromRgba(byte r, byte g, byte b, double a)
        {
            if (a < 0 || a > 1)
                throw new ArgumentOutOfRangeException("The alpha value must be a value between 0.0 and 1.0", nameof(a));

            return new ChartColor { Red = r, Green = g, Blue = b, Alpha = a };
        }


        /// <summary>
        /// Creates a new color with the specified values and the alpha fixed at 1.0 (fully opaque).
        /// </summary>
        /// <param name="r">The red (r) value of the color</param>
        /// <param name="g">The green (g) value of the color</param>
        /// <param name="b">The blue (b) value of the color</param>
        /// <returns>A new color with the specified values and alpha = 1.0 (fully opaque).</returns>
        public static ChartColor FromRgb(byte r, byte g, byte b) => new ChartColor { Red = r, Green = g, Blue = b, Alpha = 1 };


        /// <summary>
        /// Creates a new color with the specified values and the alpha fixed at 1.0 (fully opaque).
        /// </summary>
        /// <param name="hexString">The color in hexadecimal representation in the format #aabbcc</param>
        /// <returns>A new color with the specified values and alpha = 1.0</returns>
        /// <exception cref="FormatException">Throws when the hex-string has an invalid format</exception>
        public static ChartColor FromHexString(string hexString)
        {
            var color = new ChartColor();

            try
            {
                hexString = hexString.Remove(0, 1);
                if (hexString.Length == 6)
                {
                    color.Red = byte.Parse(hexString.Substring(0, 2), NumberStyles.HexNumber);
                    color.Green = byte.Parse(hexString.Substring(2, 2), NumberStyles.HexNumber);
                    color.Blue = byte.Parse(hexString.Substring(4, 2), NumberStyles.HexNumber);
                    color.Alpha = 1;

                    return color;
                }
            }
            catch (FormatException)
            {
                // Could not parse the hex-string.
            }
            catch (ArgumentOutOfRangeException)
            {
                // Could not parse the hex-string.
            }
            catch (ArgumentNullException)
            {
                // Could not parse the hex-string.
            }

            throw new FormatException("The hex string has an invalid format. It has to contain 3 or 4 numbers encoded in hex.");
        }


        /// <summary>
        /// Creates a new color with random values for r, g, b and a.
        /// </summary>
        /// <param name="randomAlpha">Specifies whether a random alpha (between 0.0 and 1.0) or a fixed at 1.0 should be chosen.</param>
        /// <returns>A new color with random values</returns>
        public static ChartColor CreateRandomChartColor(bool randomAlpha)
        {
            var rand = new Random();
            return new ChartColor
            {
                Red = (byte)rand.Next(0, 256),
                Green = (byte)rand.Next(0, 256),
                Blue = (byte)rand.Next(0, 256),
                Alpha = randomAlpha 
                    ? rand.NextDouble() 
                    : 1.0
            };
        }

        /// <summary>
        /// Produces a string of the form 'rgba(r, g, b, a)'
        /// </summary>
        /// <returns>A string of the form 'rgba(r, g, b, a)'</returns>
        public override string ToString() => $"rgba({Red}, {Green}, {Blue}, {Alpha.ToString(CultureInfo.InvariantCulture)})";
    }
}
