using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var flag = new UkraineFlag();
            flag.Draw();

            Console.ReadKey();
        }
    }
    abstract class TwoColorFlag
    {
        public void Draw()
        {
            DrawTopPart();
            DrawBottomPart();
        }

        protected abstract void DrawTopPart();
        protected abstract void DrawBottomPart();
    }
    class PolandFlag : TwoColorFlag
    {
        protected override void DrawTopPart()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(new string(' ', 7));
        }

        protected override void DrawBottomPart()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(new string(' ', 7));
        }
    }
    class UkraineFlag : TwoColorFlag
    {
        protected override void DrawTopPart()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string(' ', 7));
        }

        protected override void DrawBottomPart()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string(' ', 7));
        }
    }
}
