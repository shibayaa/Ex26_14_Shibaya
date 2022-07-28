using InputUtilitys;
namespace Ex27_14_Shibaya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var width = InputUtility.InputFloat("幅");
            var height = InputUtility.InputFloat("高さ");
            var depth = InputUtility.InputFloat("奥行");
            Box box = new Box(width, height, depth);
            Console.WriteLine($"boxの表面積={box.GetSurface()}\nboxの体積={box.GetVolume()}");

            var radius = InputUtility.InputFloat("半径");
            Cylinder cylinder = new Cylinder(radius, height);
            Console.WriteLine($"円柱の表面積={box.GetSurface()}\n円柱の体積={box.GetVolume()}");

            Sphere sphere = new Sphere(radius);
            Console.WriteLine($"球の表面積={box.GetSurface()}\n球の体積={box.GetVolume()}");

            var bottom = InputUtility.InputFloat("三角形の底辺");
            var top = InputUtility.InputFloat("三角形の高さ");
            TriangularPrism triangularprism = new TriangularPrism(bottom, top, height);
            Console.WriteLine($"三角柱の表面積={box.GetSurface()}\n三角柱の体積={box.GetVolume()}");
        }
        class Box
        {
            private float width;
            private float height;
            private float depth;
            public Box(float w, float h, float d)
            {
                this.width = w;
                this.height = h;
                this.depth = d;
            }
            public float GetVolume()
            {
                return width * height * depth;
            }
            public float GetSurface()
            {
                return (width * height + height * depth + depth * width) * 2;
            }
        }
        class Cylinder
        {
            private float radius;
            private float height;

            public Cylinder(float r, float h)
            {
                this.radius = r;
                this.height = h;
            }

            public float GetVolume()
            {
                return radius * radius * (float)Math.PI * height;
            }
            public float GetSurface()
            {
                return (radius * radius * (float)Math.PI) * 2 + (radius * 2 * (float)Math.PI * height);
            }
        }
        class Sphere
        {
            private float radius;
            public Sphere(float r)
            {
                this.radius = r;
            }

            public float GetVolume()
            {
                return 4 * (float)Math.PI / 3 * radius * radius * radius;
            }
            public float GetSurface()
            {
                return (4 * (float)Math.PI * radius * radius);
            }
        }
        class TriangularPrism

        {
            private float bottom;
            private float top;
            private float height;

            public TriangularPrism(float r, float t, float h)
            {
                this.bottom = r;
                this.top = t;
                this.height = h;
            }

            public float GetVolume()
            {
                return (bottom * top) / 2 * height;
            }
            public float GetSurface()
            {
                return bottom * top + (bottom + top + (float)Math.Sqrt(bottom * bottom + top * top)) * height;
            }
        }
    }
}

