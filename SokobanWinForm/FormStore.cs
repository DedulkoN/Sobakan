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
    public partial class FormStore : Form
    {
        ClassHichStoreTable StoreTable = new ClassHichStoreTable();
        int maxLevel = 15;
        public FormStore()
        {
            InitializeComponent();

            StoreTable.LoadData();
            toolStripComboBox1.Items.Clear();
            for(int i=1;i<= maxLevel; i++)
            {
                toolStripComboBox1.Items.Add(i.ToString());
            }
           
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Level = Int32.Parse( toolStripComboBox1.SelectedItem.ToString());
            dataGridView1.Rows.Clear();

            List<ClasssScoreRecord> store = StoreTable.scores.Where(x => x.Level == Level).OrderBy(x=>x.Score).ToList();
           // store.Sort();
            int i = 1;
            foreach(ClasssScoreRecord row in store)
            {
                dataGridView1.Rows.Add(i, row.Player, row.Score);
                i++;
            }
        }
    }
}
