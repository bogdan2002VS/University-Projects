namespace Room.Forms
{
    partial class Room
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtMessages = new System.Windows.Forms.RichTextBox();
            this.tbmessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstRooms = new System.Windows.Forms.ListBox();
            this.btnScrollToBottom = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtMessages
            // 
            this.txtMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessages.Location = new System.Drawing.Point(80, 61);
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ReadOnly = true;
            this.txtMessages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtMessages.Size = new System.Drawing.Size(379, 178);
            this.txtMessages.TabIndex = 6;
            this.txtMessages.Text = "";
            this.txtMessages.TextChanged += new System.EventHandler(this.txtMessages_TextChanged);
            // 
            // tbmessage
            // 
            this.tbmessage.Location = new System.Drawing.Point(80, 256);
            this.tbmessage.Name = "tbmessage";
            this.tbmessage.Size = new System.Drawing.Size(306, 23);
            this.tbmessage.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(392, 256);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lstRooms
            // 
            this.lstRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRooms.FormattingEnabled = true;
            this.lstRooms.IntegralHeight = false;
            this.lstRooms.ItemHeight = 15;
            this.lstRooms.Location = new System.Drawing.Point(471, 91);
            this.lstRooms.Name = "lstRooms";
            this.lstRooms.Size = new System.Drawing.Size(120, 96);
            this.lstRooms.TabIndex = 15;
            this.lstRooms.SelectedIndexChanged += new System.EventHandler(this.lstRooms_SelectedIndexChanged_Click);
            // 
            // btnScrollToBottom
            // 
            this.btnScrollToBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScrollToBottom.Enabled = false;
            this.btnScrollToBottom.Location = new System.Drawing.Point(471, 61);
            this.btnScrollToBottom.Name = "btnScrollToBottom";
            this.btnScrollToBottom.Size = new System.Drawing.Size(106, 24);
            this.btnScrollToBottom.TabIndex = 16;
            this.btnScrollToBottom.Text = "Scroll to bottom";
            this.btnScrollToBottom.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(481, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Location = new System.Drawing.Point(80, 31);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(417, 27);
            this.lblHeading.TabIndex = 19;
            this.lblHeading.Text = "Heading";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 576);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnScrollToBottom);
            this.Controls.Add(this.lstRooms);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbmessage);
            this.Controls.Add(this.txtMessages);
            this.Name = "Room";
            this.Text = "Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtMessages;
        private System.Windows.Forms.TextBox tbmessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstRooms;
        private System.Windows.Forms.Button btnScrollToBottom;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Timer timer1;
    }
}