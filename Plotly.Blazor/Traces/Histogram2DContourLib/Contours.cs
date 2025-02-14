/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.Histogram2DContourLib
{
    /// <summary>
    ///     The Contours class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class Contours : IEquatable<Contours>
    {
        /// <summary>
        ///     If <c>levels</c>, the data is represented as a contour plot with multiple
        ///     levels displayed. If <c>constraint</c>, the data is represented as constraints
        ///     with the invalid region shaded as specified by the <c>operation</c> and
        ///     <c>value</c> parameters.
        /// </summary>
        [JsonPropertyName(@"type")]
        public Plotly.Blazor.Traces.Histogram2DContourLib.ContoursLib.TypeEnum? Type { get; set;} 

        /// <summary>
        ///     Sets the starting contour level value. Must be less than <c>contours.end</c>
        /// </summary>
        [JsonPropertyName(@"start")]
        public decimal? Start { get; set;} 

        /// <summary>
        ///     Sets the end contour level value. Must be more than <c>contours.start</c>
        /// </summary>
        [JsonPropertyName(@"end")]
        public decimal? End { get; set;} 

        /// <summary>
        ///     Sets the step between each contour level. Must be positive.
        /// </summary>
        [JsonPropertyName(@"size")]
        public decimal? Size { get; set;} 

        /// <summary>
        ///     Determines the coloring method showing the contour values. If <c>fill</c>,
        ///     coloring is done evenly between each contour level If <c>heatmap</c>, a
        ///     heatmap gradient coloring is applied between each contour level. If <c>lines</c>,
        ///     coloring is done on the contour lines. If <c>none</c>, no coloring is applied
        ///     on this trace.
        /// </summary>
        [JsonPropertyName(@"coloring")]
        public Plotly.Blazor.Traces.Histogram2DContourLib.ContoursLib.ColoringEnum? Coloring { get; set;} 

        /// <summary>
        ///     Determines whether or not the contour lines are drawn. Has an effect only
        ///     if <c>contours.coloring</c> is set to <c>fill</c>.
        /// </summary>
        [JsonPropertyName(@"showlines")]
        public bool? ShowLines { get; set;} 

        /// <summary>
        ///     Determines whether to label the contour lines with their values.
        /// </summary>
        [JsonPropertyName(@"showlabels")]
        public bool? ShowLabels { get; set;} 

        /// <summary>
        ///     Sets the font used for labeling the contour levels. The default color comes
        ///     from the lines, if shown. The default family and size come from <c>layout.font</c>.
        /// </summary>
        [JsonPropertyName(@"labelfont")]
        public Plotly.Blazor.Traces.Histogram2DContourLib.ContoursLib.LabelFont LabelFont { get; set;} 

        /// <summary>
        ///     Sets the contour label formatting rule using d3 formatting mini-languages
        ///     which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format.
        /// </summary>
        [JsonPropertyName(@"labelformat")]
        public string LabelFormat { get; set;} 

        /// <summary>
        ///     Sets the constraint operation. <c>=</c> keeps regions equal to <c>value</c>
        ///     <c>&lt;</c> and <c>&lt;=</c> keep regions less than <c>value</c> <c>&gt;</c>
        ///     and <c>&gt;=</c> keep regions greater than <c>value</c> <c>[]</c>, <c>()</c>,
        ///     <c>[)</c>, and <c>(]</c> keep regions inside <c>value[0]</c> to <c>value[1]</c>
        ///     <c>][</c>, <c>)(</c>, <c>](</c>, <c>)[</c> keep regions outside <c>value[0]</c>
        ///     to value[1]` Open vs. closed intervals make no difference to constraint
        ///     display, but all versions are allowed for consistency with filter transforms.
        /// </summary>
        [JsonPropertyName(@"operation")]
        public Plotly.Blazor.Traces.Histogram2DContourLib.ContoursLib.OperationEnum? Operation { get; set;} 

        /// <summary>
        ///     Sets the value or values of the constraint boundary. When <c>operation</c>
        ///     is set to one of the comparison values (=,&lt;,&gt;=,&gt;,&lt;=) <c>value</c>
        ///     is expected to be a number. When <c>operation</c> is set to one of the interval
        ///     values ([],(),[),(],][,)(,](,)[) <c>value</c> is expected to be an array
        ///     of two numbers where the first is the lower bound and the second is the
        ///     upper bound.
        /// </summary>
        [JsonPropertyName(@"value")]
        public object Value { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Contours other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Contours other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Start == other.Start ||
                    Start != null &&
                    Start.Equals(other.Start)
                ) && 
                (
                    End == other.End ||
                    End != null &&
                    End.Equals(other.End)
                ) && 
                (
                    Size == other.Size ||
                    Size != null &&
                    Size.Equals(other.Size)
                ) && 
                (
                    Coloring == other.Coloring ||
                    Coloring != null &&
                    Coloring.Equals(other.Coloring)
                ) && 
                (
                    ShowLines == other.ShowLines ||
                    ShowLines != null &&
                    ShowLines.Equals(other.ShowLines)
                ) && 
                (
                    ShowLabels == other.ShowLabels ||
                    ShowLabels != null &&
                    ShowLabels.Equals(other.ShowLabels)
                ) && 
                (
                    LabelFont == other.LabelFont ||
                    LabelFont != null &&
                    LabelFont.Equals(other.LabelFont)
                ) && 
                (
                    LabelFormat == other.LabelFormat ||
                    LabelFormat != null &&
                    LabelFormat.Equals(other.LabelFormat)
                ) && 
                (
                    Operation == other.Operation ||
                    Operation != null &&
                    Operation.Equals(other.Operation)
                ) && 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Type != null) hashCode = hashCode * 59 + Type.GetHashCode();
                if (Start != null) hashCode = hashCode * 59 + Start.GetHashCode();
                if (End != null) hashCode = hashCode * 59 + End.GetHashCode();
                if (Size != null) hashCode = hashCode * 59 + Size.GetHashCode();
                if (Coloring != null) hashCode = hashCode * 59 + Coloring.GetHashCode();
                if (ShowLines != null) hashCode = hashCode * 59 + ShowLines.GetHashCode();
                if (ShowLabels != null) hashCode = hashCode * 59 + ShowLabels.GetHashCode();
                if (LabelFont != null) hashCode = hashCode * 59 + LabelFont.GetHashCode();
                if (LabelFormat != null) hashCode = hashCode * 59 + LabelFormat.GetHashCode();
                if (Operation != null) hashCode = hashCode * 59 + Operation.GetHashCode();
                if (Value != null) hashCode = hashCode * 59 + Value.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Contours and the right Contours.
        /// </summary>
        /// <param name="left">Left Contours.</param>
        /// <param name="right">Right Contours.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Contours left, Contours right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Contours and the right Contours.
        /// </summary>
        /// <param name="left">Left Contours.</param>
        /// <param name="right">Right Contours.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Contours left, Contours right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Contours</returns>
        public Contours DeepClone()
        {
            return this.Copy();
        }
    }
}