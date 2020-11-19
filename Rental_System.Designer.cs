﻿
namespace Movie_System
{
    partial class Rental_System
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
            this.Tab_Cont_Data = new System.Windows.Forms.TabControl();
            this.tab_Customer = new System.Windows.Forms.TabPage();
            this.DGV_Customer = new System.Windows.Forms.DataGridView();
            this.tab_Movie = new System.Windows.Forms.TabPage();
            this.DGV_Movie = new System.Windows.Forms.DataGridView();
            this.tab_Rental = new System.Windows.Forms.TabPage();
            this.DGV_Rental = new System.Windows.Forms.DataGridView();
            this.Pnl_Customer = new System.Windows.Forms.Panel();
            this.llb_FName = new System.Windows.Forms.Label();
            this.lbl_LName = new System.Windows.Forms.Label();
            this.lbl_Mobile = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txt_FName = new System.Windows.Forms.TextBox();
            this.txt_LName = new System.Windows.Forms.TextBox();
            this.txt_Mobile = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.Tab_Cont_Data.SuspendLayout();
            this.tab_Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).BeginInit();
            this.tab_Movie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Movie)).BeginInit();
            this.tab_Rental.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rental)).BeginInit();
            this.Pnl_Customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Cont_Data
            // 
            this.Tab_Cont_Data.Controls.Add(this.tab_Customer);
            this.Tab_Cont_Data.Controls.Add(this.tab_Movie);
            this.Tab_Cont_Data.Controls.Add(this.tab_Rental);
            this.Tab_Cont_Data.Location = new System.Drawing.Point(12, 12);
            this.Tab_Cont_Data.Name = "Tab_Cont_Data";
            this.Tab_Cont_Data.SelectedIndex = 0;
            this.Tab_Cont_Data.Size = new System.Drawing.Size(544, 291);
            this.Tab_Cont_Data.TabIndex = 0;
            // 
            // tab_Customer
            // 
            this.tab_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tab_Customer.Controls.Add(this.DGV_Customer);
            this.tab_Customer.Location = new System.Drawing.Point(4, 22);
            this.tab_Customer.Name = "tab_Customer";
            this.tab_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Customer.Size = new System.Drawing.Size(536, 265);
            this.tab_Customer.TabIndex = 0;
            this.tab_Customer.Text = "Customer";
            // 
            // DGV_Customer
            // 
            this.DGV_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customer.Location = new System.Drawing.Point(6, 6);
            this.DGV_Customer.Name = "DGV_Customer";
            this.DGV_Customer.Size = new System.Drawing.Size(524, 253);
            this.DGV_Customer.TabIndex = 0;
            // 
            // tab_Movie
            // 
            this.tab_Movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tab_Movie.Controls.Add(this.DGV_Movie);
            this.tab_Movie.Location = new System.Drawing.Point(4, 22);
            this.tab_Movie.Name = "tab_Movie";
            this.tab_Movie.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Movie.Size = new System.Drawing.Size(536, 265);
            this.tab_Movie.TabIndex = 1;
            this.tab_Movie.Text = "Movie";
            // 
            // DGV_Movie
            // 
            this.DGV_Movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Movie.Location = new System.Drawing.Point(7, 7);
            this.DGV_Movie.Name = "DGV_Movie";
            this.DGV_Movie.Size = new System.Drawing.Size(523, 252);
            this.DGV_Movie.TabIndex = 0;
            // 
            // tab_Rental
            // 
            this.tab_Rental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tab_Rental.Controls.Add(this.DGV_Rental);
            this.tab_Rental.Location = new System.Drawing.Point(4, 22);
            this.tab_Rental.Name = "tab_Rental";
            this.tab_Rental.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Rental.Size = new System.Drawing.Size(536, 265);
            this.tab_Rental.TabIndex = 2;
            this.tab_Rental.Text = "Rental";
            // 
            // DGV_Rental
            // 
            this.DGV_Rental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Rental.Location = new System.Drawing.Point(7, 7);
            this.DGV_Rental.Name = "DGV_Rental";
            this.DGV_Rental.Size = new System.Drawing.Size(523, 252);
            this.DGV_Rental.TabIndex = 0;
            // 
            // Pnl_Customer
            // 
            this.Pnl_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Pnl_Customer.Controls.Add(this.btn_Delete);
            this.Pnl_Customer.Controls.Add(this.btn_Update);
            this.Pnl_Customer.Controls.Add(this.btn_Add);
            this.Pnl_Customer.Controls.Add(this.txt_Address);
            this.Pnl_Customer.Controls.Add(this.txt_Mobile);
            this.Pnl_Customer.Controls.Add(this.txt_LName);
            this.Pnl_Customer.Controls.Add(this.txt_FName);
            this.Pnl_Customer.Controls.Add(this.lbl_Address);
            this.Pnl_Customer.Controls.Add(this.lbl_Mobile);
            this.Pnl_Customer.Controls.Add(this.lbl_LName);
            this.Pnl_Customer.Controls.Add(this.llb_FName);
            this.Pnl_Customer.Location = new System.Drawing.Point(16, 309);
            this.Pnl_Customer.Name = "Pnl_Customer";
            this.Pnl_Customer.Size = new System.Drawing.Size(378, 136);
            this.Pnl_Customer.TabIndex = 1;
            // 
            // llb_FName
            // 
            this.llb_FName.AutoSize = true;
            this.llb_FName.Location = new System.Drawing.Point(13, 10);
            this.llb_FName.Name = "llb_FName";
            this.llb_FName.Size = new System.Drawing.Size(57, 13);
            this.llb_FName.TabIndex = 0;
            this.llb_FName.Text = "First Name";
            // 
            // lbl_LName
            // 
            this.lbl_LName.AutoSize = true;
            this.lbl_LName.Location = new System.Drawing.Point(13, 40);
            this.lbl_LName.Name = "lbl_LName";
            this.lbl_LName.Size = new System.Drawing.Size(58, 13);
            this.lbl_LName.TabIndex = 1;
            this.lbl_LName.Text = "Last Name";
            // 
            // lbl_Mobile
            // 
            this.lbl_Mobile.AutoSize = true;
            this.lbl_Mobile.Location = new System.Drawing.Point(12, 73);
            this.lbl_Mobile.Name = "lbl_Mobile";
            this.lbl_Mobile.Size = new System.Drawing.Size(78, 13);
            this.lbl_Mobile.TabIndex = 2;
            this.lbl_Mobile.Text = "Mobile Number";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(13, 105);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(45, 13);
            this.lbl_Address.TabIndex = 3;
            this.lbl_Address.Text = "Address";
            // 
            // txt_FName
            // 
            this.txt_FName.Location = new System.Drawing.Point(130, 7);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Size = new System.Drawing.Size(103, 20);
            this.txt_FName.TabIndex = 4;
            // 
            // txt_LName
            // 
            this.txt_LName.Location = new System.Drawing.Point(130, 40);
            this.txt_LName.Name = "txt_LName";
            this.txt_LName.Size = new System.Drawing.Size(103, 20);
            this.txt_LName.TabIndex = 5;
            // 
            // txt_Mobile
            // 
            this.txt_Mobile.Location = new System.Drawing.Point(130, 73);
            this.txt_Mobile.Name = "txt_Mobile";
            this.txt_Mobile.Size = new System.Drawing.Size(103, 20);
            this.txt_Mobile.TabIndex = 6;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(130, 105);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(103, 20);
            this.txt_Address.TabIndex = 7;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(281, 10);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 36);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Update.Location = new System.Drawing.Point(281, 50);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 36);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Delete.Location = new System.Drawing.Point(281, 90);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 36);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // Rental_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pnl_Customer);
            this.Controls.Add(this.Tab_Cont_Data);
            this.Name = "Rental_System";
            this.Text = "Video Rental System";
            this.Tab_Cont_Data.ResumeLayout(false);
            this.tab_Customer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).EndInit();
            this.tab_Movie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Movie)).EndInit();
            this.tab_Rental.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rental)).EndInit();
            this.Pnl_Customer.ResumeLayout(false);
            this.Pnl_Customer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab_Cont_Data;
        private System.Windows.Forms.TabPage tab_Customer;
        private System.Windows.Forms.TabPage tab_Movie;
        private System.Windows.Forms.TabPage tab_Rental;
        private System.Windows.Forms.DataGridView DGV_Customer;
        private System.Windows.Forms.DataGridView DGV_Movie;
        private System.Windows.Forms.DataGridView DGV_Rental;
        private System.Windows.Forms.Panel Pnl_Customer;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Mobile;
        private System.Windows.Forms.TextBox txt_LName;
        private System.Windows.Forms.TextBox txt_FName;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Mobile;
        private System.Windows.Forms.Label lbl_LName;
        private System.Windows.Forms.Label llb_FName;
    }
}

