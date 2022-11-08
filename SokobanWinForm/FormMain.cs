using System;
using System.Drawing;
using System.Windows.Forms;
using SokobanWinForm.Classes;

namespace SokobanWinForm
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// игровой контроллер
        /// </summary>
        ClassGameController GameController = new ClassGameController();
        /// <summary>
        /// игровое поле
        /// </summary>
        PictureBox[,] pictures;
        public FormMain()
        {
            FormAutorization formAutorization = new FormAutorization();
            if (formAutorization.ShowDialog() == DialogResult.OK)
            {
                InitializeComponent();
                GoLVL(1);
                GameController.playerName = formAutorization.PlayerName;
            }
        }


        /// <summary>
        /// Отрисовка и перерисовка игрового поля
        /// </summary>
        private void RePaint()
        {
            //В методе динамически создаем нужное число картинок, запихиваем их, что б не потерялись в архив
            //если картинки уже есть - удаляем старые, создаем новые
            //дает выше нагрузку на ОЗУ, но в наших объемах - приемлимо.
            
            if (pictures != null)
            {
                for (int i = 0; i < pictures.GetLength(0); i++)
                    for (int j = 0; j < pictures.GetLength(1); j++)
                        panel1.Controls.Remove(pictures[i, j]);                
            }
          pictures = new PictureBox[GameController.i_count, GameController.j_count];

            for (int i = 0; i < GameController.i_count; i++)
                for(int j = 0; j < GameController.j_count; j++)
                {
                    pictures[i, j] = new PictureBox();
                    pictures[i, j].Size = new Size(40, 40);
                    pictures[i, j].Location = new Point(i * 40, j * 40);
                    pictures[i, j].BorderStyle = BorderStyle.FixedSingle;

                    switch(GameController.LevelMatrix[i,j])
                    {
                        case MatrixValue.p:
                            pictures[i, j].Image = Image.FromFile("Image/Player.png");
                            break;
                        case MatrixValue.b:
                            pictures[i, j].Image = Image.FromFile("Image/Box.png");
                            break;
                        case MatrixValue.w:
                            pictures[i, j].Image = Image.FromFile("Image/Wall.png");
                            break;
                        case MatrixValue.t:
                            pictures[i, j].Image = Image.FromFile("Image/target.png");
                            break;
                        case MatrixValue.bt:
                            pictures[i, j].Image = Image.FromFile("Image/BoxOnTarget.png");
                            break;
                        case MatrixValue.pt:
                            pictures[i, j].Image = Image.FromFile("Image/PlayerTarget.png");
                            break;
                        default:

                            break;

                    }
                    panel1.Controls.Add(pictures[i, j]);
                    
                }
            toolStripStatusLabel1.Text = GameController.getSteps();

        }
        /// <summary>
        /// обработка нажатий клавиш
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Down:
                    if( GameController.moveDown()) RePaint();
                    GameController.count_step++;
                    break;
                case Keys.Up:
                    if (GameController.moveUp()) RePaint();
                    GameController.count_step++;
                    break;
                case Keys.Left:
                    if (GameController.moveLeft()) RePaint();
                    GameController.count_step++;
                    break;
                case Keys.Right:
                    if (GameController.moveRight()) RePaint();
                    GameController.count_step++;
                    break;
            }
           
            toolStripStatusLabel1.Text = GameController.getSteps();
            //проверка условий победы и обработка
            if (GameController.VictoryValidate())
            {
                if (GameController.Victory())
                    MessageBox.Show($"Победа!{Environment.NewLine}Последний уровень завершен", "Victory!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    RePaint();
                    MessageBox.Show($"Уровень пройден{Environment.NewLine}Запущен следующий уровень" , "Victory!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Text = $"Сокобан, уровень {GameController.gameLVL}";
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameController.SaveToFile(DateTime.Now.Ticks +".lvl");
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // GameController.LoadFromFile("15.lvl");
            RePaint();
        }

        /// <summary>
        /// смена уровня
        /// </summary>
        /// <param name="level">номер уровня</param>
        private void GoLVL(int level)
        {
            GameController.startLvl(level);
            RePaint();
            this.Text = $"Сокобан, уровень {level}";
        }

        private void перезапуститьТекущийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Перезапустить уровень?", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GameController.RestartLevel();
                RePaint();
             }
        }

        private void уровень1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoLVL(1);

        }

        private void уровень2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoLVL(2);
        }

        private void уровень3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoLVL(3);

        }

        private void уровень4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoLVL(4);
        }

        private void уровень5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoLVL(5);
        }

        private void уровень6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoLVL(6);
        }

        private void уровень7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoLVL(7);
        }

        private void уровень8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoLVL(8);
        }

        private void уровень9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoLVL(9);
        }

        private void уровень10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoLVL(10);
        }

        private void уровень11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoLVL(11);
        }

        private void уровень12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoLVL(12);
        }

        private void уровень13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoLVL(13);
        }

        private void уровень14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoLVL(14);
        }

        private void уровень15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoLVL(15);
        }

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
