using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace battleship
{
    public abstract class GameEntity : IGameEntity
    {
        public string Name { get; set; } = string.Empty;
        public int Size { get; set; }
        public List<Point> Coordinates { get; set; } = new List<Point>();

        public virtual bool IsSunk => Coordinates.Count == 0;

        public abstract void RegisterHit(Point hit);

        public override string ToString()
        {
            return $"{Name} ({Size}) - {(IsSunk ? "Sunk" : "Afloat")}";
        }
    }
}
