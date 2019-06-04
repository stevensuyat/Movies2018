using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayDgvCustomers();
            DisplayDgvMovies();
            DisplayDgvRented();

            var dateAndTime = DateTime.Now;
            txtDateOfUpload.Text = dateAndTime.ToShortDateString();
            txtDateJoined.Text = dateAndTime.ToShortDateString();

        }

        Database myDatabase = new Database();

        public void DisplayDgvCustomers()
        {
            //clear out old data.
            dgvCustomers.DataSource = null;
            try
            {
                dgvCustomers.DataSource = myDatabase.FillDgvCustomers();

                //pass the datatable data to the DataGridView
                dgvCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
            catch (Exception)
            {
                MessageBox.Show("dgvCustomers not filling with data");
            }
        }

        public void DisplayDgvMovies()
        {
            //clear out old data.
            dgvMovies.DataSource = null;
            try
            {
                dgvMovies.DataSource = myDatabase.FillDgvMovies();

                //pass the datatable data to the DataGridView
                dgvMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


            }
            catch (Exception)
            {
                MessageBox.Show("dgvMovies not filling with data");
            }
        }

        public void DisplayDgvRented()
        {
            //clear out old data.
            dgvRented.DataSource = null;
            try
            {
                dgvRented.DataSource = myDatabase.FillDgvRented();

                //pass the datatable data to the DataGridView
                dgvRented.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


            }
            catch (Exception)
            {
                MessageBox.Show("dgvRented not filling with data");
            }
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myDatabase.AddOrUpdateCustomer(lblCustID.Text, txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhone.Text, txtDateJoined.Text, btnAddCustomer.Text));

            tabControl1.SelectedIndex = 0;
            DisplayDgvCustomers();
        }

        private void BtnUpdateCustomers_Click(object sender, EventArgs e)
        {
            myDatabase.AddOrUpdateCustomer(lblCustID.Text, txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhone.Text, txtDateJoined.Text, btnUpdateCustomer.Text);

            tabControl1.SelectedIndex = 0;
            DisplayDgvCustomers();
        }

        private void BtnDeleteCustomers_Click(object sender, EventArgs e)
        {
            myDatabase.DeleteCustomer(lblCustID.Text);

            tabControl1.SelectedIndex = 0;
            DisplayDgvCustomers();
        }

        private void DgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //takes in the current date
            var dateAndTime = DateTime.Now;
            //these are the cell clicks for the values in the row that you click on
            try
            {
                myDatabase.CustID = (int)dgvCustomers.Rows[e.RowIndex].Cells[0].Value;
                lblCustID.Text = myDatabase.CustID.ToString();
                txtFirstName.Text = dgvCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = dgvCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddress.Text = dgvCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhone.Text = dgvCustomers.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDateJoined.Text = dateAndTime.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void BtnAddMovie_Click(object sender, EventArgs e)
        {
            myDatabase.AddOrUpdateMovie(lblMovieID.Text, txtTitle.Text, txtGenre.Text, txtYear.Text, txtRating.Text, txtPlot.Text, txtCopies.Text, txtRental_Cost.Text, txtDateOfUpload.Text, btnAddMovie.Text);

            tabControl1.SelectedIndex = 1;
            DisplayDgvMovies();
        }

        private void BtnUpdateMovie_Click(object sender, EventArgs e)
        {
            myDatabase.AddOrUpdateMovie(lblMovieID.Text, txtTitle.Text, txtGenre.Text, txtYear.Text, txtRating.Text, txtPlot.Text, txtCopies.Text, txtRental_Cost.Text, txtDateOfUpload.Text, btnUpdateMovie.Text);

            tabControl1.SelectedIndex = 1;
            DisplayDgvMovies();
        }

        private void BtnDeleteMovie_Click(object sender, EventArgs e)
        {
            myDatabase.DeleteCustomer(lblCustID.Text);

            tabControl1.SelectedIndex = 1;
            DisplayDgvCustomers();
        }

        private void DgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //takes in the current date
            var dateAndTime = DateTime.Now;
            //these are the cell clicks for the values in the row that you click on
            try
            {
                myDatabase.MovieID = (int)dgvMovies.Rows[e.RowIndex].Cells[0].Value;
                lblMovieID.Text = myDatabase.MovieID.ToString();
                txtTitle.Text = dgvMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtGenre.Text = dgvMovies.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtYear.Text = dgvMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtRating.Text = dgvMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPlot.Text = dgvMovies.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtCopies.Text = dgvMovies.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtRental_Cost.Text = dgvMovies.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDateOfUpload.Text = dateAndTime.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
