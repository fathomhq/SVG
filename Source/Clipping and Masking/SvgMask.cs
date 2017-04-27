using System;
using System.Collections.Generic;
using System.Text;
using Svg.Clipping_and_Masking;

namespace Svg
{
    public class SvgMask : SvgElement
    {
        /// <summary>
        /// The maskUnits attribute defines the coordinate system for attributes x, y, width and height. 
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the maskUnits attribute isn't specified, then the effect is as if a value of objectBoundingBox were specified.
        /// </para>
        /// </remarks>
        public SvgMaskUnit MaskUnits { get; set; }

        /// <summary>
        /// The maskContentUnits attribute defines the coordinate system for the contents of the &lt;mask&gt;.
        /// </summary>
        /// <remarks>
        /// <para>If the maskContentUnits attribute isn't specified, then the effect is as if a value of userSpaceOnUse were specified.</para>
        /// <para>Note that values defined as a percentage inside the content of the &lt;mask&gt; are not affected by this attribute. It means that even if you set the value of maskContentUnits to objectBoundingBox, percentage values will be calculated as if the value of the attribute were userSpaceOnUse.</para>
        /// </remarks>
        public SvgMaskUnit MaskContentUnits { get; set; }

        /// <summary>
        /// This attribute indicates an x-axis coordinate in the user coordinate system. The exact effect of this coordinate depend on each element. Most of the time, it represent the x-axis coordinate of the upper-left corner of the rectangular region of the reference element (see each individual element's documentation for exceptions).Its syntax is the same as that for &lt;length&gt;
        /// </summary>
        /// <remarks>
        /// If the attribute is not specified, the effect is as if a value of 0 were specified except for the &lt;filter&gt; and &lt;mask&gt; elements where the default value is -10%.
        /// </remarks>
        [SvgAttribute("x")]
        public SvgUnit X { get; set; }

        /// <summary>
        /// The y attribute indicates a y-axis coordinate in the current SVG coordinate system. The exact effect of this coordinate depends on the element. Most of the time, it represent the y-axis coordinate of the upper-left corner of the bounding box of the reference element, positioning the element vertically.
        /// </summary>
        /// <remarks>
        /// If the attribute is not specified, the default value is 0, except for the &lt;filter&gt; and &lt;mask&gt; elements where the default is -10%.
        /// </remarks>
        [SvgAttribute("y")]
        public SvgUnit Y { get; set; }

        /// <summary>
        /// This attribute indicates an horizontal length in the user coordinate system. The exact effect of this coordinate depends on each element. Most of the time, it represents the width of the rectangular region of the reference element (see each individual element's documentation for exceptions).
        /// </summary>
        /// <remarks>
        /// This attribute must be specified except for the &lt;svg&gt; element where the default value is 100% (except for root &lt;svg&gt; elements that have HTML parents) and the &lt;filter&gt; and &lt;mask&gt; elements where the default value is 120%.
        /// </remarks>
        [SvgAttribute("width")]
        public SvgUnit Width { get; set; }

        /// <summary>
        /// This attribute indicates a vertical length in the user coordinate system. The exact effect of this coordinate depends on each element. Most of the time, it represents the height of the rectangular region of the reference element (see each individual element's documentation for exceptions).
        /// </summary>
        /// <remarks>
        /// This attribute must be specified except for the &lt;svg&gt; element where the default value is 100% and the &lt;filter&gt; and &lt;mask&gt; elements where the default value is 120%.
        /// </remarks>
        [SvgAttribute("height")]
        public SvgUnit Height { get; set; }

        public override SvgElement DeepCopy()
		{
			return DeepCopy<SvgMask>();
		}

    }
}