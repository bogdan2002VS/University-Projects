using Logic;
using Logic.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediabazaar
{
    public partial class CreateShift : Form
    {
        private readonly IShiftManager shiftManager;
        public CreateShift(IShiftManager shiftManager)
        {
            this.shiftManager = shiftManager;
            InitializeComponent();
        }

        private void CreateShift_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateShift_Click(object sender, EventArgs e)
        {
            try
            {
                Shift shift = new Shift
                {
                    Start = dateTimePickStart.Value,
                    End = dateTimePickEnd.Value,
                    MaxCashier = Convert.ToInt32(numericUpDownMaxCashier.Value),
                    MaxSecurity = Convert.ToInt32(numericUpDownMaxSecurity.Value),
                    MaxStockManager = Convert.ToInt32(numericUpDownMaxStockManager.Value),
                    MaxDepoManager = Convert.ToInt32(numericUpDownMaxDepartmentManager.Value),
                    MaxEmployeeManager = Convert.ToInt32(numericUpDownMaxEmployeeManager.Value),
                    MaxHR = Convert.ToInt32(numericUpDownMaxHR.Value)
                };

                Result<bool> success = shiftManager.CreateShift(shift);

                if (success.IsExceptionType<ArgumentException>())
                {
                    MessageBox.Show(success.Exception.Message);
                    return;
                }

                if (success.Success)
                {
                    MessageBox.Show("Shift Created");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
