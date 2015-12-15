using System.Drawing;
using System.Drawing.Drawing2D;

namespace Svg
{
    /// <summary>
    /// The ‘foreignObject’ element allows for inclusion of a foreign namespace which has its graphical content drawn by a different user agent
    /// </summary>
    [SvgElement("foreignObject")]
    public class SvgForeignObject : SvgVisualElement
    {

        private SvgUnit _x;
        private SvgUnit _y;
        private SvgUnit _height;
        private SvgUnit _width;


        public SvgForeignObject()
        {
        }

        /// <summary>
        /// Gets the <see cref="GraphicsPath"/> for this element.
        /// </summary>
        /// <value></value>
        public override System.Drawing.Drawing2D.GraphicsPath Path(ISvgRenderer renderer)
        {
            return GetPaths(this, renderer);
        }

        /// <summary>
        /// Gets or sets the position where the left point of the rectangle should start.
        /// </summary>
        [SvgAttribute("x")]
        public SvgUnit X
        {
            get { return _x; }
            set
            {
                if (_x != value)
                {
                    _x = value;
                    OnAttributeChanged(new AttributeEventArgs { Attribute = "x", Value = value });
                    IsPathDirty = true;
                }
            }
        }

        /// <summary>
        /// Gets or sets the position where the top point of the rectangle should start.
        /// </summary>
        [SvgAttribute("y")]
        public SvgUnit Y
        {
            get { return _y; }
            set
            {
                if (_y != value)
                {
                    _y = value;
                    OnAttributeChanged(new AttributeEventArgs { Attribute = "y", Value = value });
                    IsPathDirty = true;
                }
            }
        }

        /// <summary>
        /// Gets or sets the width of the rectangle.
        /// </summary>
        [SvgAttribute("width")]
        public SvgUnit Width
        {
            get { return _width; }
            set
            {
                if (_width != value)
                {
                    _width = value;
                    OnAttributeChanged(new AttributeEventArgs { Attribute = "width", Value = value });
                    IsPathDirty = true;
                }
            }
        }

        /// <summary>
        /// Gets or sets the height of the rectangle.
        /// </summary>
        [SvgAttribute("height")]
        public SvgUnit Height
        {
            get { return _height; }
            set
            {
                if (_height != value)
                {
                    _height = value;
                    OnAttributeChanged(new AttributeEventArgs { Attribute = "height", Value = value });
                    IsPathDirty = true;
                }
            }
        }

        /// <summary>
        /// Gets the bounds of the element.
        /// </summary>
        /// <value>The bounds.</value>
        public override System.Drawing.RectangleF Bounds
        {
            get
            {
                var r = new RectangleF();
                foreach (var c in this.Children)
                {
                    if (c is SvgVisualElement)
                    {
                        // First it should check if rectangle is empty or it will return the wrong Bounds.
                        // This is because when the Rectangle is Empty, the Union method adds as if the first values where X=0, Y=0
                        if (r.IsEmpty)
                        {
                            r = ((SvgVisualElement)c).Bounds;
                        }
                        else
                        {
                            var childBounds = ((SvgVisualElement)c).Bounds;
                            if (!childBounds.IsEmpty)
                            {
                                r = RectangleF.Union(r, childBounds);
                            }
                        }
                    }
                }

                return r;
            }
        }

        protected override bool Renderable { get { return false; } }

        ///// <summary>
        ///// Renders the <see cref="SvgElement"/> and contents to the specified <see cref="Graphics"/> object.
        ///// </summary>
        ///// <param name="renderer">The <see cref="Graphics"/> object to render to.</param>
        //protected override void Render(SvgRenderer renderer)
        //{
        //    if (!Visible || !Displayable)
        //        return;

        //    this.PushTransforms(renderer);
        //    this.SetClip(renderer);
        //    base.RenderChildren(renderer);
        //    this.ResetClip(renderer);
        //    this.PopTransforms(renderer);
        //}

        public override SvgElement DeepCopy()
        {
            return DeepCopy<SvgForeignObject>();
        }

        public override SvgElement DeepCopy<T>()
        {
            var newObj = base.DeepCopy<T>() as SvgForeignObject;
            if (this.Fill != null)
                newObj.Fill = this.Fill.DeepCopy() as SvgPaintServer;
            return newObj;
        }
    }
}
