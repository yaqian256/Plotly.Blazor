/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.SankeyLib.LinkLib
{
    /// <summary>
    ///     The ConcentrationScales class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class ConcentrationScales : IEquatable<ConcentrationScales>
    {
        /// <summary>
        ///     The label of the links to color based on their concentration within a flow.
        /// </summary>
        [JsonPropertyName(@"label")]
        public string Label { get; set;} 

        /// <summary>
        ///     Sets the upper bound of the color domain.
        /// </summary>
        [JsonPropertyName(@"cmax")]
        public decimal? CMax { get; set;} 

        /// <summary>
        ///     Sets the lower bound of the color domain.
        /// </summary>
        [JsonPropertyName(@"cmin")]
        public decimal? CMin { get; set;} 

        /// <summary>
        ///     Sets the colorscale. The colorscale must be an array containing arrays mapping
        ///     a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string.
        ///     At minimum, a mapping for the lowest (0) and highest (1) values are required.
        ///     For example, &#39;[[0, <c>rgb(0,0,255)</c>], [1, <c>rgb(255,0,0)</c>]]&#39;.
        ///     To control the bounds of the colorscale in color space, use<c>cmin</c> and
        ///     <c>cmax</c>. Alternatively, <c>colorscale</c> may be a palette name string
        ///     of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        /// </summary>
        [JsonPropertyName(@"colorscale")]
        public object ColorScale { get; set;} 

        /// <summary>
        ///     When used in a template, named items are created in the output figure in
        ///     addition to any items the figure already has in this array. You can modify
        ///     these items in the output figure by making your own item with <c>templateitemname</c>
        ///     matching this <c>name</c> alongside your modifications (including &#39;visible:
        ///     false&#39; or &#39;enabled: false&#39; to hide it). Has no effect outside
        ///     of a template.
        /// </summary>
        [JsonPropertyName(@"name")]
        public string Name { get; set;} 

        /// <summary>
        ///     Used to refer to a named item in this array in the template. Named items
        ///     from the template will be created even without a matching item in the input
        ///     figure, but you can modify one by making an item with <c>templateitemname</c>
        ///     matching its <c>name</c>, alongside your modifications (including &#39;visible:
        ///     false&#39; or &#39;enabled: false&#39; to hide it). If there is no template
        ///     or no matching item, this item will be hidden unless you explicitly show
        ///     it with &#39;visible: true&#39;.
        /// </summary>
        [JsonPropertyName(@"templateitemname")]
        public string TemplateItemName { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is ConcentrationScales other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] ConcentrationScales other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Label == other.Label ||
                    Label != null &&
                    Label.Equals(other.Label)
                ) && 
                (
                    CMax == other.CMax ||
                    CMax != null &&
                    CMax.Equals(other.CMax)
                ) && 
                (
                    CMin == other.CMin ||
                    CMin != null &&
                    CMin.Equals(other.CMin)
                ) && 
                (
                    ColorScale == other.ColorScale ||
                    ColorScale != null &&
                    ColorScale.Equals(other.ColorScale)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    TemplateItemName == other.TemplateItemName ||
                    TemplateItemName != null &&
                    TemplateItemName.Equals(other.TemplateItemName)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Label != null) hashCode = hashCode * 59 + Label.GetHashCode();
                if (CMax != null) hashCode = hashCode * 59 + CMax.GetHashCode();
                if (CMin != null) hashCode = hashCode * 59 + CMin.GetHashCode();
                if (ColorScale != null) hashCode = hashCode * 59 + ColorScale.GetHashCode();
                if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
                if (TemplateItemName != null) hashCode = hashCode * 59 + TemplateItemName.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left ConcentrationScales and the right ConcentrationScales.
        /// </summary>
        /// <param name="left">Left ConcentrationScales.</param>
        /// <param name="right">Right ConcentrationScales.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (ConcentrationScales left, ConcentrationScales right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left ConcentrationScales and the right ConcentrationScales.
        /// </summary>
        /// <param name="left">Left ConcentrationScales.</param>
        /// <param name="right">Right ConcentrationScales.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (ConcentrationScales left, ConcentrationScales right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>ConcentrationScales</returns>
        public ConcentrationScales DeepClone()
        {
            return this.Copy();
        }
    }
}