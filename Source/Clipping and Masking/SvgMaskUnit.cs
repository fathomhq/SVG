using System.ComponentModel;

namespace Svg.Clipping_and_Masking
{
    [TypeConverter(typeof(SvgMaskUnitConverter))]
    public enum SvgMaskUnit
    {
        /// <summary>
        /// x, y, width and height represent values in the current user coordinate system in place at the time when the &lt;mask&gt; element is referenced (i.e., the user coordinate system for the element referencing the &lt;mask&gt; element via the mask attribute).
        /// </summary>
        userspaceonuse,

        /// <summary>
        /// x, y, width and height represent fractions or percentages of the bounding box of the element to which the mask is applied. A bounding box could be considered the same as if the content of the &lt;mask&gt; were bound to a "0 0 1 1" viewbox.
        /// </summary>
        objectboundingbox
    }
}
