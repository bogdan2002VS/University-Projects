using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSLOGIC.Classes;
using DAL.Exception;
using BUSLOGIC.Classes.UserHandler;
using DAL;
using StudyPalDesktop.Forms;


namespace StudyPalDesktop.Presentation
{
    public partial class UserHomePage : Form
    {
        User currentUser = null;
        List<Subject> subjects = null;
        SubjectManager subjectManager = new SubjectManager(new QueryExecutor<Object>(SQLConnect._connectionstring));
        UserManager dal = new UserManager(new QueryExecutor<Object>(SQLConnect._connectionstring));
        public UserHomePage(User currentUser)
        {
            InitializeComponent();
            string loggedInUser = $"{currentUser.Name}";

            lblUser.Text = loggedInUser;
            this.currentUser = currentUser;
            subjects = subjectManager.GetSubjects();

            if (DateTime.Now.Hour < 12)
            {
                lblDayMessage.Text = $"Good Morning {currentUser.Name} ";
            }
            else if (DateTime.Now.Hour < 18)
            {
                lblDayMessage.Text = $"Good Afternoon {currentUser.Name}";
            }
            else
            {
                lblDayMessage.Text = $"Good Evening {currentUser.Name}";
            }
            if (currentUser is Admin)
            {
                comboBox1.Visible = false;
                btnEnterRooms.Text = "Create";
                lblEnter.Text = "Here you can type the subject name";
            }
            else
            {
                foreach (var subject in subjects)
                {
                    comboBox1.Items.Add(subject.Name.ToString());
                }
                tbDescription.Visible = false;
                tbSubjectName.Visible = false;
            }
                       
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            dal.DeleteUser(currentUser.Username, currentUser.Password);
            MessageBox.Show("Your account was deleted");
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
  

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReleaseTracker_Click(object sender, EventArgs e)
        {
           
        }

        private void btnFavourites_Click(object sender, EventArgs e)
        {
            
        }

        private void lblDayMessage_Click(object sender, EventArgs e)
        {

        }

        private void pnlHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEnterRooms_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.Visible == true )
                {
                    Subject subject = subjectManager.GetSubjectsByName(comboBox1.SelectedItem.ToString());
                    Room.Forms.Room roomPage = new Room.Forms.Room(currentUser, subject);
                    roomPage.Show();
                    this.Close();
                }

                if(currentUser is Admin)
                {
                    subjectManager.CreateSubject(tbSubjectName.Text, tbDescription.Text);
                    Subject createdSubject = subjectManager.GetSubjectsByName(tbSubjectName.Text);
                    Room.Forms.Room roomPagee = new Room.Forms.Room(currentUser, createdSubject);
                    roomPagee.Show();
                    this.Close();
                }


            }
            catch (DatabaseException ex)
            {
                MessageBox.Show("Fatal Error with Database" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fatal Error" + ex.Message);
            }



        }

        private void btnUpdateMyAccount_Click(object sender, EventArgs e)
        {
            bool forUpdate = true;
            RegisterForm registerForm = new RegisterForm(forUpdate,currentUser);
            registerForm.Show();
            this.Close();
        }
    }
}
