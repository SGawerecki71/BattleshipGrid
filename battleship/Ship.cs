using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    internal class Ship : GameEntity
    {
        public Ship(string name, int size)
        {
            Name = name;
            Size = size;
        }

        public override void RegisterHit(Point hit)
        {
            Coordinates.RemoveAll(p => p == hit);
        }

        public void RegisterHit(int x, int y)
        {
            RegisterHit(new Point(x, y));
        }
    }
}
