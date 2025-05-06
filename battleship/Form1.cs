namespace battleship
{
    public partial class Form1 : Form
    {
        private int shipIndexToPlace = 0;
        private bool placingShips = true;
        private bool placeHorizontal = true;
        private string[] shipNames = { "Carrier", "Battleship", "Cruiser", "Submarine", "Destroyer" };
        private int[] shipSizes = { 5, 4, 3, 3, 2 };
        private int[,] playerGrid = new int[gridSize, gridSize];
        private List<Ship> playerShips = new List<Ship>();
        private int[,] enemyGrid = new int[gridSize, gridSize];
        private List<Ship> enemyShips = new List<Ship>();
        private GameController controller = new GameController();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            PlaceEnemyShipsRandomly();
            lblStatus.Text = "Game started! Player's turn.";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void EnemyGrid_Paint(object sender, PaintEventArgs e)
        {
            DrawGrid(e.Graphics, EnemyGrid, enemyGrid, true);
        }

        private void PlayerGid_Paint(object sender, PaintEventArgs e)
        {
            DrawGrid(e.Graphics, PlayerGridPanel, playerGrid);
        }

        private const int gridSize = 10;
        private void DrawGrid(Graphics g, Panel panel, int[,] grid, bool hideships = false)
        {
            int cellWidth = panel.Width / gridSize;
            int cellHeight = panel.Height / gridSize;
            Pen pen = Pens.Black;
            Brush shipBrush = Brushes.Gray;
            Brush hitBrush = Brushes.Red;
            Brush missBrush = Brushes.White;

            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    int x = col * cellWidth;
                    int y = row * cellHeight;
                    g.DrawRectangle(pen, x, y, cellWidth, cellHeight);

                    int cellValue = grid[col, row];

                    if (cellValue == 3)
                        g.FillRectangle(hitBrush, x + 1, y + 1, cellWidth - 2, cellHeight - 2);
                    else if (cellValue == 2)
                        g.FillRectangle(missBrush, x + 1, y + 1, cellWidth - 2, cellHeight - 2);
                    else if (cellValue == 1 && !hideships)
                        g.FillRectangle(shipBrush, x + 1, y + 1, cellWidth - 2, cellHeight - 2);
                }
            }
        }

        private Point GetCellFromClick(MouseEventArgs e, Panel panel)
        {
            int cellWidth = panel.Width / gridSize;
            int cellHeight = panel.Height / gridSize;

            int col = e.X / cellWidth;
            int row = e.Y / cellHeight;

            return new Point(col, row);
        }

        private void EnemyGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (placingShips || !controller.IsPlayerTurn)
                return;

            Point cell = GetCellFromClick(e, EnemyGrid);

            if (enemyGrid[cell.X, cell.Y] == 2 || enemyGrid[cell.X, cell.Y] == 3)
            {
                lblStatus.Text = "You already attacked this spot!";
                return;
            }

            string result = controller.HandleAttack(enemyGrid, enemyShips, cell);
            lblStatus.Text = result;
            EnemyGrid.Invalidate();

            if (controller.AllShipsSunk(enemyShips))
            {
                lblStatus.Text = "Player wins!";
                return;
            }

            controller.SwitchTurn();
            EnemyTurn();
        }

        private void EnemyTurn()
        {
            Random rand = new Random();
            Point cell;

            if (controller.HasTargets())
            {
                cell = controller.GetNextTarget();
            }
            else
            {
                do
                {
                    int x = rand.Next(gridSize);
                    int y = rand.Next(gridSize);
                    cell = new Point(x, y);
                }
                while (playerGrid[cell.X, cell.Y] == 2 || playerGrid[cell.X, cell.Y] == 3);
            }

            controller.MarkTried(cell);
            string result = controller.HandleAttack(playerGrid, playerShips, cell);
            lblStatus.Text = "Enemy Turn: " + result;
            PlayerGridPanel.Invalidate();

            if (controller.AllShipsSunk(playerShips))
            {
                lblStatus.Text = "Enemy wins!";
                return;
            }

            if (playerGrid[cell.X, cell.Y] == 3) 
            {
                controller.AddAdjacentTargets(cell, gridSize);
            }

            controller.SwitchTurn();
        }


        private void PlayerGid_MouseClick(object sender, MouseEventArgs e)
        {
            if (!placingShips || shipIndexToPlace >= shipNames.Length)
                return;

            Point cell = GetCellFromClick(e, PlayerGridPanel);

            bool placed = PlaceShip(playerGrid, playerShips, shipNames[shipIndexToPlace], shipSizes[shipIndexToPlace], cell, placeHorizontal);

            if (placed)
            {
                shipIndexToPlace++;
                lblStatus.Text = $"Placed {shipNames[shipIndexToPlace - 1]}.";
                PlayerGridPanel.Invalidate();

                if (shipIndexToPlace >= shipNames.Length)
                {
                    placingShips = false;
                    lblStatus.Text = "All ships placed!";
                }
            }
            else
            {
                lblStatus.Text = "Invalid placement. Try again.";
            }
        }

        private bool PlaceShip(int[,] grid, List<Ship> ships, string name, int size, Point start, bool horizontal)
        {
            var ship = new Ship(name, size);

            for (int i = 0; i < size; i++)
            {
                int x = horizontal ? start.X + i : start.X;
                int y = horizontal ? start.Y : start.Y + i;

                if (x >= gridSize || y >= gridSize || grid[x, y] != 0)
                    return false;

                ship.Coordinates.Add(new Point(x, y));
            }

            foreach (var p in ship.Coordinates)
                grid[p.X, p.Y] = 1;

            ships.Add(ship);
            return true;
        }

        private void PlaceEnemyShipsRandomly()
        {
            Random rand = new Random();

            for (int i = 0; i < shipNames.Length; i++)
            {
                bool placed = false;
                while (!placed)
                {
                    int x = rand.Next(gridSize);
                    int y = rand.Next(gridSize);
                    bool horizontal = rand.Next(2) == 0;
                    placed = PlaceShip(enemyGrid, enemyShips, shipNames[i], shipSizes[i], new Point(x, y), horizontal);
                }
            }
        }

        private void cbPlacement_CheckedChanged(object sender, EventArgs e)
        {
            placeHorizontal = cbPlacement.Checked;
            cbPlacement.Text = placeHorizontal ? "Orientation: Horizontal" : "Orientation: Vertical";
        }
    }
}
