using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Svg
{
    /// <summary>
    /// Defines the various coordinate units certain SVG elements may use.
    /// </summary>
    [TypeConverter(typeof(SvgCoordinateUnitsConverter))]
    public enum SvgCoordinateUnits
    {
        inherit,
        /// <summary>
        /// Indicates that the coordinate system of the owner element is to be used.
        /// </summary>
        objectBoundingBox,
        /// <summary>
        /// Indicates that the coordinate system of the entire document is to be used.
        /// </summary>
        userSpaceOnUse,
    }
}
