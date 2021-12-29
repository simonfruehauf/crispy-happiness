using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crispy_happiness
{

    class Object
    {
        char icon;
        int x;
        int y;
        ConsoleColor fc;
        ConsoleColor bc;

        public Object() { }


        public Object(char _i, int _x, int _y, ConsoleColor _fc, ConsoleColor _bc = ConsoleColor.Black) //y is line
        {
            icon = _i;
            x = _x;
            y = _y;
            bc = _bc;
            fc = _fc;
        }

        public void move(int _x, int _y)
        {
            this.clear();
            x += _x;
            y += _y;
        }
        public void move(direction dir)
        {
            this.clear();
            switch (dir)
            {
                case direction.North:
                    y--;
                    break;
                case direction.NorthEast:
                    y--;
                    x++;
                    break;
                case direction.East:
                    x++;
                    break;
                case direction.SouthWest:
                    y++;
                    x--;
                    break;
                case direction.South:
                    y++;
                    break;
                case direction.SouthEast:
                    y++;
                    x++;
                    break;
                case direction.West:
                    x--;
                    break;
                case direction.NorthWest:
                    y--;
                    x--;
                    break;
                default:
                    break;
            }
        }

        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = bc;
            Console.ForegroundColor = fc;
            Console.Write(icon);
            Console.SetCursorPosition(0, 0); //reset Cursor

        }

        public void clear()
        {
            Console.SetCursorPosition(x, y);
            Console.ResetColor();
            Console.Write(' ');
            Console.SetCursorPosition(0, 0); //reset Cursor

        }
    }

    class Entity:Object
    {
        int health;
        public Entity() { }

        public Entity(int _h, char _i, int _x, int _y, ConsoleColor _fc, ConsoleColor _bc = ConsoleColor.Black) : base(_i, _x, _y, _fc, _bc)
        {
            health = _h;
        }
    }
}
