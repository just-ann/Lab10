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
   
    public partial class fPrinter : Form
    {
        internal  Printer ThePrinter;
        internal fPrinter(Printer t)
        {
            ThePrinter = t;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
         
        AcceptButton = btnOk;
            ThePrinter.Name = tbName.Text.Trim();
            ThePrinter.Appointment = tbAppointment.Text.Trim();
            ThePrinter.Printing_technology = tbPrinting_technology.Text.Trim();
            ThePrinter.Buyers = int.Parse(tbBuyers.Text.Trim());
            ThePrinter.YearIncome = double.Parse(tbYearIncome.Text.Trim());
            ThePrinter.Square = double.Parse(tbSquare.Text.Trim());
            ThePrinter.HasPhotoprinting = chbHasPhotoprinting.Checked;
            ThePrinter.HasTwo_sided_printing = chbHasTwo_sided_printing.Checked;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelButton = btnCancel;
            DialogResult = DialogResult.Cancel;
        }

        private void fTown_Load(object sender, EventArgs e)
        {
            if (ThePrinter != null)
            {
                tbName.Text = ThePrinter.Name;
                tbAppointment.Text = ThePrinter.Appointment;
                tbPrinting_technology.Text = ThePrinter.Printing_technology;
                tbBuyers.Text = ThePrinter.Buyers.ToString();
                tbYearIncome.Text = ThePrinter.YearIncome.ToString("0.00");
                tbSquare.Text = ThePrinter.Square.ToString("0.000");
                chbHasPhotoprinting.Checked = ThePrinter.HasPhotoprinting;
                chbHasTwo_sided_printing.Checked = ThePrinter.HasTwo_sided_printing;
            }
        }

    
    } 
  
}
