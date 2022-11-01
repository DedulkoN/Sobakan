using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SokobanWinForm.Classes;

namespace SokobanWinForm
{
    public partial class FormMain : Form
    {
        ClassGameController GameController = new ClassGameController();
        PictureBox[,] pictures;
        public FormMain()
        {
            InitializeComponent();
            RePaint();
        }


        /// <summary>
        /// Отрисовка и перерисовка игрового поля
        /// </summary>
        public void RePaint()
        {
            //В методе динамически создаем нужное число картинок, запихиваем их, что б не потерялись в архив
            //если картинки уже есть - удаляем старые, создаем новые
            //дает выше нагрузку на ОЗУ, но в наших объемах - приемлимо.
            
            if (pictures != null)
            {
                for (int i = 0; i < GameController.i_count; i++)
                    for (int j = 0; j < GameController.j_count; j++)
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


        }

        private void FormMain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Down:
                    if( GameController.moveDown()) RePaint();
                    break;
                case Keys.Up:
                    if (GameController.moveUp()) RePaint();
                    break;
                case Keys.Left:
                    if (GameController.moveLeft()) RePaint();
                    break;
                case Keys.Right:
                    if (GameController.moveRight()) RePaint();
                    break;

            }
            if (GameController.VictoryValidate()) MessageBox.Show("победа!");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameController.SaveToFile("1.lvl");
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameController.LoadFromFile("1.lvl");
            RePaint();
        }
    }
}
