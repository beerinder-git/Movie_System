﻿using System;
using System.Windows.Forms;

namespace Movie_System
{
    public partial class Rental_System : Form
    {
        Database Obj_Data = new Database();
        public Rental_System()
        {
            InitializeComponent();
            Customer_Load();
            Movies_Load();
            Rental_Load();
        }


        public void Customer_Load()
        {
            DGV_Customer.DataSource = null;
            try
            {
                DGV_Customer.DataSource = Obj_Data.FillCustomer_Data();
                DGV_Customer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Movies_Load()
        {
            DGV_Movie.DataSource = null;
            try
            {
                DGV_Movie.DataSource = Obj_Data.FillMovies_Data();
                DGV_Movie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Rental_Load()
        {
            DGV_Rental.DataSource = null;
            try
            {
                DGV_Rental.DataSource = Obj_Data.FillRental_Data();
                DGV_Rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_FName.Text != "" && txt_LName.Text != "" && txt_Address.Text != "" && txt_Mobile.Text != "")
            {
                string message = Obj_Data.CustomerInsert(txt_FName.Text, txt_LName.Text, txt_Mobile.Text, txt_Address.Text);
                MessageBox.Show(message);
                txt_FName.Text = "";
                txt_LName.Text = "";
                txt_Mobile.Text = "";
                txt_Address.Text = "";
                Customer_Load();
            }
            else
            {
                MessageBox.Show("Please fill all the fileds then press Add button");
            }
        }
    }
}
