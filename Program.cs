using System;
using System.Collections.Generic;

namespace crispy_happiness
{
    public class Write
    {
        public static void TypeLine(string line, int delay = 50, bool linebreak = false)
        {
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                System.Threading.Thread.Sleep(delay);
            }
            if (linebreak)
            {
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static List<Object> objects = new List<Object>(); 
        
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Entity player = new Entity(10, '@', 10, 10, ConsoleColor.Red);
            Entity npc = new Entity(10, '@', 5, 10, ConsoleColor.Yellow);
            objects.Add(player);
            objects.Add(npc);

            DrawObjects();
            Console.ReadLine();
            //Run In Circle
            for (int i = 0; i < 8; i++)
            {
                Console.SetCursorPosition(0, 0);
                player.move((direction)i);
                DrawObjects();

                System.Threading.Thread.Sleep(200);
            }

            Console.ReadLine();
        }

        static void DrawObjects()
        {
            DrawObjects(objects);
        }
        static void DrawObjects(List<Object> o)
        {
            foreach (Object ob in objects)
            {
                ob.clear();
                ob.draw();

            }
        }

    }
}
