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
        private Queue<Point> targetQueue = new Queue<Point>();
        private HashSet<Point> triedPoints = new HashSet<Point>();



        public string HandleAttack(int[,] grid, List<Ship> ships, Point cell)
        {
            if (grid[cell.X, cell.Y] == 2 || grid[cell.X, cell.Y] == 3)
                return "Already attacked this cell!";

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

        public void AddAdjacentTargets(Point hit, int gridSize)
        {
            List<Point> directions = new List<Point>
            {
                new Point(0, -1), 
                new Point(0, 1), 
                new Point(-1, 0), 
                new Point(1, 0)  
            };

            foreach (var dir in directions)
            {
                Point next = new Point(hit.X + dir.X, hit.Y + dir.Y);
                if (next.X >= 0 && next.X < gridSize && next.Y >= 0 && next.Y < gridSize && !triedPoints.Contains(next))
                {
                    targetQueue.Enqueue(next);
                }
            }
        }

        public bool HasTargets() => targetQueue.Count > 0;

        public Point GetNextTarget()
        {
            return targetQueue.Dequeue();
        }

        public void MarkTried(Point p)
        {
            triedPoints.Add(p);
        }
    }
}
