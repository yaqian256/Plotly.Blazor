/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.PointCloudLib.MarkerLib
{
    /// <summary>
    ///     The Border class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Border : IEquatable<Border>
    {
        /// <summary>
        ///     Sets the stroke color. It accepts a specific color. If the color is not
        ///     fully opaque and there are hundreds of thousands of points, it may cause
        ///     slower zooming and panning.
        /// </summary>
        [JsonPropertyName(@"color")]
        public object Color { get; set;} 

        /// <summary>
        ///     Specifies what fraction of the marker area is covered with the border.
        /// </summary>
        [JsonPropertyName(@"arearatio")]
        public decimal? AreaRatio { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Border other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Border other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Color == other.Color ||
                    Color != null &&
                    Color.Equals(other.Color)
                ) && 
                (
                    AreaRatio == other.AreaRatio ||
                    AreaRatio != null &&
                    AreaRatio.Equals(other.AreaRatio)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Color != null) hashCode = hashCode * 59 + Color.GetHashCode();
                if (AreaRatio != null) hashCode = hashCode * 59 + AreaRatio.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Border and the right Border.
        /// </summary>
        /// <param name="left">Left Border.</param>
        /// <param name="right">Right Border.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Border left, Border right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Border and the right Border.
        /// </summary>
        /// <param name="left">Left Border.</param>
        /// <param name="right">Right Border.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Border left, Border right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Border</returns>
        public Border DeepClone()
        {
            return this.Copy();
        }
    }
}