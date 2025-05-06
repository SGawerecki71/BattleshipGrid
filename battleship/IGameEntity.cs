using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    public interface IGameEntity
    {
        string Name { get; set; }
        int Size { get; set; }
        bool IsSunk { get; }
        void RegisterHit(System.Drawing.Point hit);
    }
}
