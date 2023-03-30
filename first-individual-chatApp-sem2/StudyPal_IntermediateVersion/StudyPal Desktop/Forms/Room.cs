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
using BUSLOGIC.Exceptions;
using DAL.Exception;
using BUSLOGIC.Classes.UserHandler;
using DAL;

namespace Room.Forms
{
    public partial class Room : Form
    {
        SubjectManager subjectManager = new SubjectManager(new QueryExecutor<Object>(SQLConnect._connectionstring));
        ChatRoomManagercs chatRoomManagercs = new ChatRoomManagercs(new QueryExecutor<Object>(SQLConnect._connectionstring));
        User currentUser;
        long subjectId;
        bool openedTheChat = false;
        public Room(User currentUser,Subject subject)
        {
            InitializeComponent();
            btnDelete.Visible = false;
            lblHeading.Text = subject.Name;
            this.currentUser = currentUser;
            subjectId = subject.Id;
            try
            {   List<ChatRoom> rooms = chatRoomManagercs.GetChatRooms(subject.Id);

                foreach (var chatRoom in rooms)
                {
                    lstRooms.Items.Add(chatRoom.Name);
                }
            }
            catch(DatabaseException ex)
            {
                MessageBox.Show("Fatal Error with Database" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fatal Error" + ex.Message);
            }

            
        }
            

        private void btnSend_Click(object sender, EventArgs e)
        {
            txtMessages.Text = txtMessages.Text + $"<{this.currentUser.Name}>:{tbmessage.Text}" + "\n";
            txtMessages.SelectionStart = txtMessages.Text.Length;
            txtMessages.ScrollToCaret();

            string selectedChatRoomName = lstRooms.SelectedItem.ToString();
            try
            {
                ChatRoom chatRoom = chatRoomManagercs.GetChatRoomByName(selectedChatRoomName);
                chatRoomManagercs.SendMessage(chatRoom.ID, $"{tbmessage.Text}", currentUser.Name);
               
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

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedChatRoomName = lstRooms.SelectedItem.ToString();
            ChatRoom chatRoom = chatRoomManagercs.GetChatRoomByName(selectedChatRoomName);
            chatRoomManagercs.DeleteChatRoom(chatRoom.ID);
            chatRoomManagercs.DeleteMessage(chatRoom.ID);
            var item = lstRooms.SelectedItem;
            lstRooms.SelectedIndex = lstRooms.SelectedIndex - 1;
            lstRooms.Items.Remove(item);
            btnDelete.Visible = false;
        }

        private void lstRooms_SelectedIndexChanged_Click(object sender, EventArgs e)
        {

            txtMessages.Clear();
            openedTheChat = true;
            string selectedChatRoomName = lstRooms.SelectedItem.ToString();
            try
            {
                ChatRoom chatRoom = chatRoomManagercs.GetChatRoomByName(selectedChatRoomName);
                if (this.currentUser.ID == chatRoom.AdminID)
                {
                    btnDelete.Visible = true;
                }
                foreach (var message in chatRoomManagercs.GetMessages(chatRoom.ID))
                {
                    txtMessages.Text = txtMessages.Text + $"<{message.From}>:" + message.Text + "\n";
                }
                txtMessages.SelectionStart = txtMessages.Text.Length;
                txtMessages.ScrollToCaret();
     
                return;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (openedTheChat)
            {
                lstRooms_SelectedIndexChanged_Click(sender, e);
            }
            
        }

        private void txtMessages_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
