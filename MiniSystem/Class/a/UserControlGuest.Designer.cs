namespace MiniSystem.User_Control
{
    partial class UserControlGuest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlGuest));
            this.tabPageUpdateDeleteGuest = new System.Windows.Forms.TabPage();
            this.listViewGuest = new System.Windows.Forms.ListView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lastNameTXT1 = new System.Windows.Forms.TextBox();
            this.firstNameTXT1 = new System.Windows.Forms.TextBox();
            this.phoneNoTXT1 = new System.Windows.Forms.TextBox();
            this.addressTXT1 = new System.Windows.Forms.TextBox();
            this.guestIDTXT1 = new System.Windows.Forms.TextBox();
            this.tabControlGuest = new System.Windows.Forms.TabControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameTXT = new System.Windows.Forms.TextBox();
            this.firstNameTXT = new System.Windows.Forms.TextBox();
            this.phoneNoTXT = new System.Windows.Forms.TextBox();
            this.addressTXT = new System.Windows.Forms.TextBox();
            this.guestIDTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageAddGuest = new System.Windows.Forms.TabPage();
            this.tabPageUpdateDeleteGuest.SuspendLayout();
            this.tabControlGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageAddGuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageUpdateDeleteGuest
            // 
            this.tabPageUpdateDeleteGuest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageUpdateDeleteGuest.Controls.Add(this.guestIDTXT1);
            this.tabPageUpdateDeleteGuest.Controls.Add(this.addressTXT1);
            this.tabPageUpdateDeleteGuest.Controls.Add(this.phoneNoTXT1);
            this.tabPageUpdateDeleteGuest.Controls.Add(this.firstNameTXT1);
            this.tabPageUpdateDeleteGuest.Controls.Add(this.lastNameTXT1);
            this.tabPageUpdateDeleteGuest.Controls.Add(this.label9);
            this.tabPageUpdateDeleteGuest.Controls.Add(this.label10);
            this.tabPageUpdateDeleteGuest.Controls.Add(this.label11);
            this.tabPageUpdateDeleteGuest.Controls.Add(this.label12);
            this.tabPageUpdateDeleteGuest.Controls.Add(this.label13);
            this.tabPageUpdateDeleteGuest.Controls.Add(this.btnDelete);
            this.tabPageUpdateDeleteGuest.Controls.Add(this.btnEdit);
            this.tabPageUpdateDeleteGuest.Controls.Add(this.listViewGuest);
            this.tabPageUpdateDeleteGuest.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateDeleteGuest.Name = "tabPageUpdateDeleteGuest";
            this.tabPageUpdateDeleteGuest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateDeleteGuest.Size = new System.Drawing.Size(1065, 415);
            this.tabPageUpdateDeleteGuest.TabIndex = 2;
            this.tabPageUpdateDeleteGuest.Text = "Update/Delete Guest";
            this.tabPageUpdateDeleteGuest.Click += new System.EventHandler(this.tabPageUpdateDeleteGuest_Click);
            this.tabPageUpdateDeleteGuest.Leave += new System.EventHandler(this.tabPageUpdateDeleteGuest_Leave);
            // 
            // listViewGuest
            // 
            this.listViewGuest.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listViewGuest.Font = new System.Drawing.Font("Sans Serif Collection", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewGuest.GridLines = true;
            this.listViewGuest.HideSelection = false;
            this.listViewGuest.Location = new System.Drawing.Point(308, 0);
            this.listViewGuest.Name = "listViewGuest";
            this.listViewGuest.Size = new System.Drawing.Size(757, 415);
            this.listViewGuest.TabIndex = 1;
            this.listViewGuest.UseCompatibleStateImageBehavior = false;
            this.listViewGuest.View = System.Windows.Forms.View.Details;
            this.listViewGuest.SelectedIndexChanged += new System.EventHandler(this.listViewGuest_SelectedIndexChanged);
            this.listViewGuest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewGuest_MouseClick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(13, 333);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(143, 56);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(159, 333);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 56);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(6, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 23);
            this.label13.TabIndex = 11;
            this.label13.Text = "Last Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(6, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 23);
            this.label12.TabIndex = 10;
            this.label12.Text = "Guest ID#";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(6, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "First Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(3, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Phone No.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(6, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Address";
            // 
            // lastNameTXT1
            // 
            this.lastNameTXT1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTXT1.Location = new System.Drawing.Point(111, 88);
            this.lastNameTXT1.Name = "lastNameTXT1";
            this.lastNameTXT1.Size = new System.Drawing.Size(191, 31);
            this.lastNameTXT1.TabIndex = 12;
            // 
            // firstNameTXT1
            // 
            this.firstNameTXT1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTXT1.Location = new System.Drawing.Point(111, 125);
            this.firstNameTXT1.Name = "firstNameTXT1";
            this.firstNameTXT1.Size = new System.Drawing.Size(191, 31);
            this.firstNameTXT1.TabIndex = 14;
            // 
            // phoneNoTXT1
            // 
            this.phoneNoTXT1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNoTXT1.Location = new System.Drawing.Point(111, 165);
            this.phoneNoTXT1.Name = "phoneNoTXT1";
            this.phoneNoTXT1.Size = new System.Drawing.Size(191, 31);
            this.phoneNoTXT1.TabIndex = 16;
            // 
            // addressTXT1
            // 
            this.addressTXT1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTXT1.Location = new System.Drawing.Point(111, 202);
            this.addressTXT1.Multiline = true;
            this.addressTXT1.Name = "addressTXT1";
            this.addressTXT1.Size = new System.Drawing.Size(191, 54);
            this.addressTXT1.TabIndex = 18;
            // 
            // guestIDTXT1
            // 
            this.guestIDTXT1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestIDTXT1.Location = new System.Drawing.Point(111, 51);
            this.guestIDTXT1.Name = "guestIDTXT1";
            this.guestIDTXT1.Size = new System.Drawing.Size(191, 31);
            this.guestIDTXT1.TabIndex = 9;
            // 
            // tabControlGuest
            // 
            this.tabControlGuest.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlGuest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlGuest.Controls.Add(this.tabPageAddGuest);
            this.tabControlGuest.Controls.Add(this.tabPageUpdateDeleteGuest);
            this.tabControlGuest.Location = new System.Drawing.Point(3, 3);
            this.tabControlGuest.Name = "tabControlGuest";
            this.tabControlGuest.SelectedIndex = 0;
            this.tabControlGuest.Size = new System.Drawing.Size(1073, 445);
            this.tabControlGuest.TabIndex = 0;
            this.tabControlGuest.Leave += new System.EventHandler(this.tabControlGuest_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(98, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(98, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Guest ID#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(575, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(98, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(575, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Address";
            // 
            // lastNameTXT
            // 
            this.lastNameTXT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTXT.Location = new System.Drawing.Point(268, 157);
            this.lastNameTXT.Name = "lastNameTXT";
            this.lastNameTXT.Size = new System.Drawing.Size(191, 31);
            this.lastNameTXT.TabIndex = 2;
            // 
            // firstNameTXT
            // 
            this.firstNameTXT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTXT.Location = new System.Drawing.Point(745, 161);
            this.firstNameTXT.Name = "firstNameTXT";
            this.firstNameTXT.Size = new System.Drawing.Size(191, 31);
            this.firstNameTXT.TabIndex = 4;
            // 
            // phoneNoTXT
            // 
            this.phoneNoTXT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNoTXT.Location = new System.Drawing.Point(268, 218);
            this.phoneNoTXT.Name = "phoneNoTXT";
            this.phoneNoTXT.Size = new System.Drawing.Size(191, 31);
            this.phoneNoTXT.TabIndex = 6;
            // 
            // addressTXT
            // 
            this.addressTXT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTXT.Location = new System.Drawing.Point(745, 222);
            this.addressTXT.Multiline = true;
            this.addressTXT.Name = "addressTXT";
            this.addressTXT.Size = new System.Drawing.Size(191, 54);
            this.addressTXT.TabIndex = 8;
            // 
            // guestIDTXT
            // 
            this.guestIDTXT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestIDTXT.Location = new System.Drawing.Point(268, 102);
            this.guestIDTXT.Name = "guestIDTXT";
            this.guestIDTXT.Size = new System.Drawing.Size(191, 31);
            this.guestIDTXT.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Add Guest";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.Location = new System.Drawing.Point(827, 294);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(109, 53);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabPageAddGuest
            // 
            this.tabPageAddGuest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageAddGuest.Controls.Add(this.pictureBox1);
            this.tabPageAddGuest.Controls.Add(this.buttonAdd);
            this.tabPageAddGuest.Controls.Add(this.label6);
            this.tabPageAddGuest.Controls.Add(this.guestIDTXT);
            this.tabPageAddGuest.Controls.Add(this.addressTXT);
            this.tabPageAddGuest.Controls.Add(this.phoneNoTXT);
            this.tabPageAddGuest.Controls.Add(this.firstNameTXT);
            this.tabPageAddGuest.Controls.Add(this.lastNameTXT);
            this.tabPageAddGuest.Controls.Add(this.label1);
            this.tabPageAddGuest.Controls.Add(this.label5);
            this.tabPageAddGuest.Controls.Add(this.label4);
            this.tabPageAddGuest.Controls.Add(this.label2);
            this.tabPageAddGuest.Controls.Add(this.label3);
            this.tabPageAddGuest.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddGuest.Name = "tabPageAddGuest";
            this.tabPageAddGuest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddGuest.Size = new System.Drawing.Size(1065, 415);
            this.tabPageAddGuest.TabIndex = 0;
            this.tabPageAddGuest.Text = "Add Guest";
            this.tabPageAddGuest.Click += new System.EventHandler(this.tabPageAddGuest_Click);
            // 
            // UserControlGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tabControlGuest);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlGuest";
            this.Size = new System.Drawing.Size(1079, 451);
            this.Load += new System.EventHandler(this.UserControlSetting_Load);
            this.tabPageUpdateDeleteGuest.ResumeLayout(false);
            this.tabPageUpdateDeleteGuest.PerformLayout();
            this.tabControlGuest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageAddGuest.ResumeLayout(false);
            this.tabPageAddGuest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageUpdateDeleteGuest;
        private System.Windows.Forms.TextBox guestIDTXT1;
        private System.Windows.Forms.TextBox addressTXT1;
        private System.Windows.Forms.TextBox phoneNoTXT1;
        private System.Windows.Forms.TextBox firstNameTXT1;
        private System.Windows.Forms.TextBox lastNameTXT1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListView listViewGuest;
        private System.Windows.Forms.TabControl tabControlGuest;
        private System.Windows.Forms.TabPage tabPageAddGuest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox guestIDTXT;
        private System.Windows.Forms.TextBox addressTXT;
        private System.Windows.Forms.TextBox phoneNoTXT;
        private System.Windows.Forms.TextBox firstNameTXT;
        private System.Windows.Forms.TextBox lastNameTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
