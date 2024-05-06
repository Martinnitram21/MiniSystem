namespace MiniSystem.User_Control
{
    partial class UserControlReservation
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
            this.listViewReservation = new System.Windows.Forms.ListView();
            this.btnAddReserve = new System.Windows.Forms.Button();
            this.reservIdTXT = new System.Windows.Forms.TextBox();
            this.clientTXT = new System.Windows.Forms.TextBox();
            this.roomNumberTXT = new System.Windows.Forms.ComboBox();
            this.roomTypeTXT = new System.Windows.Forms.ComboBox();
            this.dateOutTXT = new System.Windows.Forms.DateTimePicker();
            this.dateInTXT = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewReservation
            // 
            this.listViewReservation.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listViewReservation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewReservation.GridLines = true;
            this.listViewReservation.HideSelection = false;
            this.listViewReservation.Location = new System.Drawing.Point(294, 3);
            this.listViewReservation.Name = "listViewReservation";
            this.listViewReservation.Size = new System.Drawing.Size(551, 444);
            this.listViewReservation.TabIndex = 0;
            this.listViewReservation.UseCompatibleStateImageBehavior = false;
            this.listViewReservation.View = System.Windows.Forms.View.Details;
            this.listViewReservation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewReservation_MouseClick);
            // 
            // btnAddReserve
            // 
            this.btnAddReserve.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddReserve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReserve.FlatAppearance.BorderSize = 0;
            this.btnAddReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReserve.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReserve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddReserve.Location = new System.Drawing.Point(12, 371);
            this.btnAddReserve.Name = "btnAddReserve";
            this.btnAddReserve.Size = new System.Drawing.Size(276, 76);
            this.btnAddReserve.TabIndex = 6;
            this.btnAddReserve.Text = "Add Reservation";
            this.btnAddReserve.UseVisualStyleBackColor = false;
            this.btnAddReserve.Click += new System.EventHandler(this.btnAddReserve_Click_1);
            // 
            // reservIdTXT
            // 
            this.reservIdTXT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservIdTXT.Location = new System.Drawing.Point(136, 52);
            this.reservIdTXT.Name = "reservIdTXT";
            this.reservIdTXT.Size = new System.Drawing.Size(152, 27);
            this.reservIdTXT.TabIndex = 0;
            // 
            // clientTXT
            // 
            this.clientTXT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientTXT.Location = new System.Drawing.Point(136, 75);
            this.clientTXT.Name = "clientTXT";
            this.clientTXT.Size = new System.Drawing.Size(152, 27);
            this.clientTXT.TabIndex = 1;
            // 
            // roomNumberTXT
            // 
            this.roomNumberTXT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumberTXT.FormattingEnabled = true;
            this.roomNumberTXT.Items.AddRange(new object[] {
            "",
            "101",
            "102",
            "103",
            "104",
            "105"});
            this.roomNumberTXT.Location = new System.Drawing.Point(136, 152);
            this.roomNumberTXT.Name = "roomNumberTXT";
            this.roomNumberTXT.Size = new System.Drawing.Size(152, 29);
            this.roomNumberTXT.TabIndex = 3;
            this.roomNumberTXT.SelectedIndexChanged += new System.EventHandler(this.roomNumberTXT_SelectedIndexChanged);
            // 
            // roomTypeTXT
            // 
            this.roomTypeTXT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeTXT.FormattingEnabled = true;
            this.roomTypeTXT.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Deluxe",
            "Studio",
            "Suite"});
            this.roomTypeTXT.Location = new System.Drawing.Point(136, 122);
            this.roomTypeTXT.Name = "roomTypeTXT";
            this.roomTypeTXT.Size = new System.Drawing.Size(152, 29);
            this.roomTypeTXT.TabIndex = 2;
            // 
            // dateOutTXT
            // 
            this.dateOutTXT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutTXT.Location = new System.Drawing.Point(136, 230);
            this.dateOutTXT.Name = "dateOutTXT";
            this.dateOutTXT.Size = new System.Drawing.Size(152, 27);
            this.dateOutTXT.TabIndex = 5;
            // 
            // dateInTXT
            // 
            this.dateInTXT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInTXT.Location = new System.Drawing.Point(136, 197);
            this.dateInTXT.Name = "dateInTXT";
            this.dateInTXT.Size = new System.Drawing.Size(152, 27);
            this.dateInTXT.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(8, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(8, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Room Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(8, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date OUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Reservation ID#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(8, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date IN";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Info;
            this.label14.Location = new System.Drawing.Point(8, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 23);
            this.label14.TabIndex = 0;
            this.label14.Text = "Client Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(8, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Add Reservation";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(190, 335);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 39);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gold;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(12, 335);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 39);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(94, 335);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 39);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // UserControlReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddReserve);
            this.Controls.Add(this.reservIdTXT);
            this.Controls.Add(this.clientTXT);
            this.Controls.Add(this.roomNumberTXT);
            this.Controls.Add(this.roomTypeTXT);
            this.Controls.Add(this.dateOutTXT);
            this.Controls.Add(this.dateInTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listViewReservation);
            this.Name = "UserControlReservation";
            this.Size = new System.Drawing.Size(848, 448);
            this.Load += new System.EventHandler(this.UserControlReservation_Load);
            this.Leave += new System.EventHandler(this.roomNumberTXT_SelectedIndexChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewReservation;
        private System.Windows.Forms.Button btnAddReserve;
        private System.Windows.Forms.TextBox reservIdTXT;
        private System.Windows.Forms.TextBox clientTXT;
        private System.Windows.Forms.ComboBox roomNumberTXT;
        private System.Windows.Forms.ComboBox roomTypeTXT;
        private System.Windows.Forms.DateTimePicker dateOutTXT;
        private System.Windows.Forms.DateTimePicker dateInTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
    }
}
