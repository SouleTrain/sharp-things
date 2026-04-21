using System;
namespace TurningDemo
{
    internal class Program
    {
        static void Main()
        {
            Leaf leaf = new();
            leaf.Turn();

            Page page = new Page();
            page.Turn();

            Corner corner = new Corner();
            corner.Turn();

            Pancake pancake = new Pancake();
            pancake.Turn();
        }
    }
    public interface ITurnable
    {
        void Turn();
    }
    class Page : ITurnable
    {
        public void Turn() 
        {
            Console.WriteLine($"You turn a page...Bob Seger is pretty awesome\n");
        }
    }
    class Corner : ITurnable
    {
        public void Turn()
        {
            Console.WriteLine($"You turn a corner, your elbow catches the wall and it hurts\n");
        }
    }
    class Pancake : ITurnable
    {
        public void Turn()
        {
            Console.WriteLine($"You turn a Pancake... yum\n");
        }
    }
    class Leaf : ITurnable 
    {
        public void Turn()
        {
            Console.WriteLine($"You turn over a new leaf... naruto uzumaki\n");
        }
    }
}
