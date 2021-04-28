using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class Printer
    {
        public string Name { get; set; }
        public string Appointment { get; set; }
        public string Printing_technology { get; set; }
        public int Buyers { get; set; }
        public double YearIncome { get; set; }
        public double Square { get; set; }
        public bool HasPhotoprinting { get; set; }
        public bool HasTwo_sided_printing { get; set; }
        public double GetYearIncomePerInhabitant()
        {
            return YearIncome / Buyers;
        }
        public Printer()
        {
        }
        public Printer(string name, string appointment, string print_tech,
        int buyers, double yearIncome, double square,
        bool hasPhoto, bool hasTwo)
        {
            Name = name;
            Appointment = appointment;
            Printing_technology = print_tech;
            Buyers = buyers;
            YearIncome = yearIncome;
            Square = square;
            HasPhotoprinting = hasPhoto;
            HasTwo_sided_printing = hasTwo;
        }
    }
}
