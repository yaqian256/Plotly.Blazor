/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     The UpdateMenu class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [Serializable]
    public class UpdateMenu : IEquatable<UpdateMenu>
    {
        /// <summary>
        ///     Determines whether or not the update menu is visible.
        /// </summary>
        [JsonPropertyName(@"visible")]
        public bool? Visible { get; set;} 

        /// <summary>
        ///     Determines whether the buttons are accessible via a dropdown menu or whether
        ///     the buttons are stacked horizontally or vertically
        /// </summary>
        [JsonPropertyName(@"type")]
        public Plotly.Blazor.LayoutLib.UpdateMenuLib.TypeEnum? Type { get; set;} 

        /// <summary>
        ///     Determines the direction in which the buttons are laid out, whether in a
        ///     dropdown menu or a row/column of buttons. For <c>left</c> and <c>up</c>,
        ///     the buttons will still appear in left-to-right or top-to-bottom order respectively.
        /// </summary>
        [JsonPropertyName(@"direction")]
        public Plotly.Blazor.LayoutLib.UpdateMenuLib.DirectionEnum? Direction { get; set;} 

        /// <summary>
        ///     Determines which button (by index starting from 0) is considered active.
        /// </summary>
        [JsonPropertyName(@"active")]
        public int? Active { get; set;} 

        /// <summary>
        ///     Highlights active dropdown item or active button if true.
        /// </summary>
        [JsonPropertyName(@"showactive")]
        public bool? ShowActive { get; set;} 

        /// <summary>
        ///     Gets or sets the Buttons.
        /// </summary>
        [JsonPropertyName(@"buttons")]
        public IList<Plotly.Blazor.LayoutLib.UpdateMenuLib.Button> Buttons { get; set;} 

        /// <summary>
        ///     Sets the x position (in normalized coordinates) of the update menu.
        /// </summary>
        [JsonPropertyName(@"x")]
        public decimal? X { get; set;} 

        /// <summary>
        ///     Sets the update menu&#39;s horizontal position anchor. This anchor binds
        ///     the <c>x</c> position to the <c>left</c>, <c>center</c> or <c>right</c>
        ///     of the range selector.
        /// </summary>
        [JsonPropertyName(@"xanchor")]
        public Plotly.Blazor.LayoutLib.UpdateMenuLib.XAnchorEnum? XAnchor { get; set;} 

        /// <summary>
        ///     Sets the y position (in normalized coordinates) of the update menu.
        /// </summary>
        [JsonPropertyName(@"y")]
        public decimal? Y { get; set;} 

        /// <summary>
        ///     Sets the update menu&#39;s vertical position anchor This anchor binds the
        ///     <c>y</c> position to the <c>top</c>, <c>middle</c> or <c>bottom</c> of the
        ///     range selector.
        /// </summary>
        [JsonPropertyName(@"yanchor")]
        public Plotly.Blazor.LayoutLib.UpdateMenuLib.YAnchorEnum? YAnchor { get; set;} 

        /// <summary>
        ///     Sets the padding around the buttons or dropdown menu.
        /// </summary>
        [JsonPropertyName(@"pad")]
        public Plotly.Blazor.LayoutLib.UpdateMenuLib.Pad Pad { get; set;} 

        /// <summary>
        ///     Sets the font of the update menu button text.
        /// </summary>
        [JsonPropertyName(@"font")]
        public Plotly.Blazor.LayoutLib.UpdateMenuLib.Font Font { get; set;} 

        /// <summary>
        ///     Sets the background color of the update menu buttons.
        /// </summary>
        [JsonPropertyName(@"bgcolor")]
        public object BgColor { get; set;} 

        /// <summary>
        ///     Sets the color of the border enclosing the update menu.
        /// </summary>
        [JsonPropertyName(@"bordercolor")]
        public object BorderColor { get; set;} 

        /// <summary>
        ///     Sets the width (in px) of the border enclosing the update menu.
        /// </summary>
        [JsonPropertyName(@"borderwidth")]
        public decimal? BorderWidth { get; set;} 

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
            if (!(obj is UpdateMenu other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] UpdateMenu other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Visible == other.Visible ||
                    Visible != null &&
                    Visible.Equals(other.Visible)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Direction == other.Direction ||
                    Direction != null &&
                    Direction.Equals(other.Direction)
                ) && 
                (
                    Active == other.Active ||
                    Active != null &&
                    Active.Equals(other.Active)
                ) && 
                (
                    ShowActive == other.ShowActive ||
                    ShowActive != null &&
                    ShowActive.Equals(other.ShowActive)
                ) && 
                (
                    Equals(Buttons, other.Buttons) ||
                    Buttons != null && other.Buttons != null &&
                    Buttons.SequenceEqual(other.Buttons)
                ) &&
                (
                    X == other.X ||
                    X != null &&
                    X.Equals(other.X)
                ) && 
                (
                    XAnchor == other.XAnchor ||
                    XAnchor != null &&
                    XAnchor.Equals(other.XAnchor)
                ) && 
                (
                    Y == other.Y ||
                    Y != null &&
                    Y.Equals(other.Y)
                ) && 
                (
                    YAnchor == other.YAnchor ||
                    YAnchor != null &&
                    YAnchor.Equals(other.YAnchor)
                ) && 
                (
                    Pad == other.Pad ||
                    Pad != null &&
                    Pad.Equals(other.Pad)
                ) && 
                (
                    Font == other.Font ||
                    Font != null &&
                    Font.Equals(other.Font)
                ) && 
                (
                    BgColor == other.BgColor ||
                    BgColor != null &&
                    BgColor.Equals(other.BgColor)
                ) && 
                (
                    BorderColor == other.BorderColor ||
                    BorderColor != null &&
                    BorderColor.Equals(other.BorderColor)
                ) && 
                (
                    BorderWidth == other.BorderWidth ||
                    BorderWidth != null &&
                    BorderWidth.Equals(other.BorderWidth)
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
                if (Visible != null) hashCode = hashCode * 59 + Visible.GetHashCode();
                if (Type != null) hashCode = hashCode * 59 + Type.GetHashCode();
                if (Direction != null) hashCode = hashCode * 59 + Direction.GetHashCode();
                if (Active != null) hashCode = hashCode * 59 + Active.GetHashCode();
                if (ShowActive != null) hashCode = hashCode * 59 + ShowActive.GetHashCode();
                if (Buttons != null) hashCode = hashCode * 59 + Buttons.GetHashCode();
                if (X != null) hashCode = hashCode * 59 + X.GetHashCode();
                if (XAnchor != null) hashCode = hashCode * 59 + XAnchor.GetHashCode();
                if (Y != null) hashCode = hashCode * 59 + Y.GetHashCode();
                if (YAnchor != null) hashCode = hashCode * 59 + YAnchor.GetHashCode();
                if (Pad != null) hashCode = hashCode * 59 + Pad.GetHashCode();
                if (Font != null) hashCode = hashCode * 59 + Font.GetHashCode();
                if (BgColor != null) hashCode = hashCode * 59 + BgColor.GetHashCode();
                if (BorderColor != null) hashCode = hashCode * 59 + BorderColor.GetHashCode();
                if (BorderWidth != null) hashCode = hashCode * 59 + BorderWidth.GetHashCode();
                if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
                if (TemplateItemName != null) hashCode = hashCode * 59 + TemplateItemName.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left UpdateMenu and the right UpdateMenu.
        /// </summary>
        /// <param name="left">Left UpdateMenu.</param>
        /// <param name="right">Right UpdateMenu.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (UpdateMenu left, UpdateMenu right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left UpdateMenu and the right UpdateMenu.
        /// </summary>
        /// <param name="left">Left UpdateMenu.</param>
        /// <param name="right">Right UpdateMenu.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (UpdateMenu left, UpdateMenu right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>UpdateMenu</returns>
        public UpdateMenu DeepClone()
        {
            return this.Copy();
        }
    }
}