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
    public partial class AbsenceDetails : Form
    {
        private Absence absence;
        private readonly IAbsenceManager absenceManager;
        public AbsenceDetails(Absence absence, IAbsenceManager absenceManager)
        {
            InitializeComponent();

            LoadEnums();
            this.absence = absence;
            this.absenceManager = absenceManager;
        }

        private void AbsenceDetails_Load(object sender, EventArgs e)
        {
            dtpAbsence.Value = absence.Date;
            dgvEmployee.Rows.Add(absence.Employee.Id, absence.Employee.FirstName, absence.Employee.LastName, absence.Employee.Email, absence.Employee.PhoneNumber);
            rtbReason.Text = absence.AbsenceReason;
            rtbDescription.Text = absence.AbsenceDescription;
            cbTicketStatus.SelectedIndex = (int)absence.TicketStatus;
        }

        private void btnUpdateAbsence_Click(object sender, EventArgs e)
        {
            try
            {
                absence.TicketStatus = (TicketStatus)cbTicketStatus.SelectedIndex;

                bool success = absenceManager.UpdateAbsence(absence);

                if(success)
                {
                    MessageBox.Show("Absence Updated!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadEnums()
        {
            cbTicketStatus.Items.Clear();

            foreach(TicketStatus ticketStatus in Enum.GetValues(typeof(TicketStatus)))
            {
                cbTicketStatus.Items.Add(ticketStatus);
            }

            cbTicketStatus.SelectedIndex = 0;
        }
    }
}
