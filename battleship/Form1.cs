namespace battleship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void EnemyGrid_Paint(object sender, PaintEventArgs e)
        {
            DrawGrid(e.Graphics, EnemyGrid);
        }

        private void PlayerGid_Paint(object sender, PaintEventArgs e)
        {
            DrawGrid(e.Graphics, PlayerGrid);
        }

        private const int gridSize = 10;
        private void DrawGrid(Graphics g, Panel panel)
        {
            int cellWidth = panel.Width / gridSize;
            int cellHeight = panel.Height / gridSize;
            Pen pen = Pens.Black;

            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    int x = col * cellWidth;
                    int y = row * cellHeight;
                    g.DrawRectangle(pen, x, y, cellWidth, cellHeight);
                }
            }
        }

        private void PlayerTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enemytxt_TextChanged(object sender, EventArgs e)
        {

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
            Point cell = GetCellFromClick(e, EnemyGrid);
            MessageBox.Show($"Enemy Grid Clicked: Row {cell.Y}, Col {cell.X}");
            // TODO: Handle attack logic
        }

        private void PlayerGid_MouseClick(object sender, MouseEventArgs e)
        {
            Point cell = GetCellFromClick(e, PlayerGrid);
            MessageBox.Show($"Player Grid Clicked: Row {cell.Y}, Col {cell.X}");
            // TODO: Place ship or handle attack
        }
    }
}
