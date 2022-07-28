using InputUtilitys;
namespace Ex26_14_Shibaya
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
            public Box(float w = 1)
            {
                this.width = w;
                this.height = w;
                this.depth = w;
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

    }

}