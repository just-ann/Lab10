using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvPrinters.AutoGenerateColumns = false;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Назва";
            gvPrinters.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Appointment";
            column.Name = "Призначення";
            gvPrinters.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Printing_technology";
            column.Name = "Технологія друку";
            gvPrinters.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Buyers";
            column.Name = "Покупців";
            gvPrinters.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "YearIncome";
            column.Name = "Річн. дохід";
            gvPrinters.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Square";
            column.Name = "Площа";
            column.Width = 80;
            gvPrinters.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasPhotoprinting";
            column.Name = "Фотодрук";
            column.Width = 60;
            gvPrinters.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasTwo_sided_printing";
            column.Name = "Двусторонній друк";
            column.Width = 60;
            gvPrinters.Columns.Add(column);
            bindSrcPrinters.Add(new Printer("Sony2312", "Для офісу", "Струменева", 98,
            176566, 14, false, true)); 
           
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Printer printer = new Printer();
            fPrinter ft = new fPrinter(printer);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcPrinters.Add(printer);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Printer printer = (Printer)bindSrcPrinters.List[bindSrcPrinters.Position];
            fPrinter ft = new fPrinter(printer);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcPrinters.List[bindSrcPrinters.Position] = printer;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?",
"Видалення запису", MessageBoxButtons.OKCancel,
MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcPrinters.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
"Очистити таблицю?\n\nВсі дані будуть втрачені",
"Очищення даних", MessageBoxButtons.OKCancel,
MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcPrinters.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
MessageBoxButtons.OKCancel,
MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
