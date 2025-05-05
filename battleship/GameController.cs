using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleship
{
    internal class GameController
    {
        public bool IsPlayerTurn { get; private set; } = true;

        public string HandleAttack(int[,] grid, List<Ship> ships, Point cell)
        {
            foreach (var ship in ships)
            {
                if (ship.Coordinates.Contains(cell))
                {
                    ship.RegisterHit(cell);
                    grid[cell.X, cell.Y] = 3;
                    return $"Hit on {ship.Name}!";
                }
            }

            grid[cell.X, cell.Y] = 2;
            return "Miss!";
        }

        public void SwitchTurn()
        {
            IsPlayerTurn = !IsPlayerTurn;
        }

        public bool AllShipsSunk(List<Ship> ships)
        {
            return ships.TrueForAll(s => s.IsSunk);
        }
    }
}
