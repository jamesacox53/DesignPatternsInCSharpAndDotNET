namespace Section07Bridge
{
    public interface IRenderer
    {
        string WhatToRenderAs { get; }
    }

    public abstract class Shape
    {
        public string Name { get; set; }

        protected IRenderer _renderer;

        public Shape(IRenderer renderer)
        {
            this._renderer = renderer;
        }

        public override string ToString()
        {
            return $"Drawing {this.Name} as {_renderer.WhatToRenderAs}";
        }
    }

    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer)
        {
            this.Name = "Triangle";
        }
    }

    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer)
        {
            this.Name = "Square";
        }
    }

    public class VectorRenderer : IRenderer
    {
        string IRenderer.WhatToRenderAs
        {
            get
            {
                return "lines";
            }
        }
    }

    public class RasterRenderer : IRenderer
    {
        string IRenderer.WhatToRenderAs
        {
            get
            {
                return "pixels";
            }
        }
    }
}
