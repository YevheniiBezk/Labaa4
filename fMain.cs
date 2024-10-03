using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labaa4
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        private void fMain_Load(object sender, EventArgs e)
        {
            gvComputers.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "modelName";
            column.Name = "Бренд";
            gvComputers.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Processor";
            column.Name = "Процесор";
            gvComputers.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "RAM";
            column.Name = "Оперативна Пам'ять";
            gvComputers.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Storage";
            column.Name = "Пам'ять";
            gvComputers.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Price";
            column.Name = "Ціна";
            gvComputers.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasGraphicsCard";
            column.Name = "Відеокарта";
            column.Width = 60;
            gvComputers.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasWiFi";
            column.Name = "Вайфай";
            column.Width = 60;
            gvComputers.Columns.Add(column);


            bindSrcComputers.Add(new Computer("Acer", "i7", 16, 1000, 999, true, true));
            EventArgs args = new EventArgs(); OnResize(args);
        }
        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void gvComputers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            {
                Computer computer = new Computer();

                fComputer ft = new fComputer(computer);
                if (ft.ShowDialog() == DialogResult.OK)
                {
                    bindSrcComputers.Add(computer);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            {
                Computer computer = (Computer)bindSrcComputers.List[bindSrcComputers.Position];

                fComputer ft = new fComputer(computer);
                if (ft.ShowDialog() == DialogResult.OK)
                {
                    bindSrcComputers.List[bindSrcComputers.Position] = computer;
                }
            
        }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Видалити поточний запис?", "Видалення запису",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    bindSrcComputers.RemoveCurrent();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bindSrcComputers.Clear();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
    }
}










