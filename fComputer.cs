using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labaa4
{
    public partial class fComputer : Form
    {
        internal Computer TheComputer;

        internal fComputer(Computer c)
        {
            TheComputer = c;
            InitializeComponent();
        }

        private void fComputer_Load(object sender, EventArgs e)
        {
            tbModel.Text = TheComputer.ModelName;
            tbProcessor.Text = TheComputer.Processor;
            tbRAM.Text = TheComputer.RAM.ToString();
            tbStorage.Text = TheComputer.Storage.ToString();
            tbPrice.Text = TheComputer.Price.ToString();
            chbHasGraphicsCard.Checked = TheComputer.HasGraphicsCard;
            chbHasWiFi.Checked = TheComputer.HasWiFi;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbModel.Text) ||
                string.IsNullOrWhiteSpace(tbProcessor.Text) ||
                !int.TryParse(tbRAM.Text, out var ram) ||
                !int.TryParse(tbStorage.Text, out var storage) ||
                !double.TryParse(tbPrice.Text, out var price))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля правильно.");
                return;
            }

            TheComputer.ModelName = tbModel.Text;
            TheComputer.Processor = tbProcessor.Text;
            TheComputer.RAM = ram;
            TheComputer.Storage = storage;
            TheComputer.Price = price;
            TheComputer.HasGraphicsCard = chbHasGraphicsCard.Checked;
            TheComputer.HasWiFi = chbHasWiFi.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void tbPrice_TextChanged(object sender, EventArgs e) { }

        private void tbStorage_TextChanged(object sender, EventArgs e) { }

        private void tbRAM_TextChanged(object sender, EventArgs e) { }

        private void tbProcessor_TextChanged(object sender, EventArgs e) { }

        private void tbModel_TextChanged(object sender, EventArgs e) { }

        private void chbHasGraphicsCard_CheckedChanged(object sender, EventArgs e) { }

        private void chbHasWiFi_CheckedChanged(object sender, EventArgs e) { }
    }
}
