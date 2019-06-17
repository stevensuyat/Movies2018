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
            DisplayDgvUnreturned();

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

        public void DisplayDgvUnreturned()
        {
            //clear out old data.
            dgvUnreturned.DataSource = null;
            try
            {
                dgvUnreturned.DataSource = myDatabase.FillDgvUnretuned();

                //pass the datatable data to the DataGridView
                dgvUnreturned.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


            }
            catch (Exception)
            {
                MessageBox.Show("dgvUnreturned not filling with data");
            }
        }

        public void RefreshData_Click(object sender, EventArgs e)
        {
            DisplayDgvCustomers();
            DisplayDgvMovies();
            DisplayDgvRented();
            DisplayDgvUnreturned();
        }

        //ADD button for Customers
        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myDatabase.AddOrUpdateCustomer(lblCustID.Text, txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhone.Text, txtDateJoined.Text, btnAddCustomer.Text));

            tabControl1.SelectedIndex = 0;
            DisplayDgvCustomers();
        }

        //UPDATE button for Customers
        private void BtnUpdateCustomers_Click(object sender, EventArgs e)
        {
            myDatabase.AddOrUpdateCustomer(lblCustID.Text, txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhone.Text, txtDateJoined.Text, btnUpdateCustomer.Text);

            tabControl1.SelectedIndex = 0;
            DisplayDgvCustomers();
        }

        //DELETE button for Customers
        private void BtnDeleteCustomers_Click(object sender, EventArgs e)
        {
            myDatabase.DeleteCustomer(lblCustID.Text);

            tabControl1.SelectedIndex = 0;
            DisplayDgvCustomers();
        }

        //Sends data from data grid view to text box
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

        //ADD button for Movies
        private void BtnAddMovie_Click(object sender, EventArgs e)
        {
            myDatabase.AddOrUpdateMovie(lblMovieID.Text, txtTitle.Text, txtGenre.Text, txtYear.Text, txtRating.Text, txtPlot.Text, txtCopies.Text, txtRental_Cost.Text, txtDateOfUpload.Text, btnAddMovie.Text);

            tabControl1.SelectedIndex = 1;
            DisplayDgvMovies();
        }

        //UPDATE button for Movies
        private void BtnUpdateMovie_Click(object sender, EventArgs e)
        {
            myDatabase.AddOrUpdateMovie(lblMovieID.Text, txtTitle.Text, txtGenre.Text, txtYear.Text, txtRating.Text, txtPlot.Text, txtCopies.Text, txtRental_Cost.Text, txtDateOfUpload.Text, btnUpdateMovie.Text);

            tabControl1.SelectedIndex = 1;
            DisplayDgvMovies();
        }

        //DELETE button for Movies
        private void BtnDeleteMovie_Click(object sender, EventArgs e)
        {
            myDatabase.DeleteMovie(lblMovieID.Text);

            tabControl1.SelectedIndex = 1;
            DisplayDgvMovies();
        }

        //Sends data from data grid view to text box
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

        //Sends data from data grid view to label
        private void DgvRented_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                myDatabase.RMID = (int)dgvRented.Rows[e.RowIndex].Cells[0].Value;
                lblRMID.Text = myDatabase.RMID.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //Sends data from data grid view to label
        private void DgvUnreturned_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                myDatabase.RMID = (int)dgvUnreturned.Rows[e.RowIndex].Cells[0].Value;
                lblRMID.Text = myDatabase.RMID.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //button to return movie
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            string dateAndTime = DateTime.Now.ToString();
            myDatabase.ReturnMovie(lblRMID.Text, dateAndTime);
            lblRMID.Text = "0";

            DisplayDgvUnreturned();
            DisplayDgvRented();
        }

        //button to rent movie
        private void BtnRent_Click(object sender, EventArgs e)
        {
            string dateAndTime = DateTime.Now.ToString();
            string DateReturned = string.Empty;
            int MovieIDFK = Convert.ToInt32(lblMovieID.Text);
            int CustIDFK = Convert.ToInt32(lblCustID.Text);
            lblRMID.Text = "0";
            myDatabase.RentMovie(lblRMID.Text, MovieIDFK, CustIDFK, dateAndTime, DateReturned);

            tabControl1.SelectedIndex = 2;
            DisplayDgvRented();

            //reset customer fields
            lblCustID.Text = "0";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtDateJoined.Text = "";

            //reset movie fields
            lblMovieID.Text = "0";
            txtTitle.Text = "";
            txtGenre.Text = "";
            txtYear.Text = "";
            txtRating.Text = "";
            txtPlot.Text = "";
            txtCopies.Text = "";
            txtRental_Cost.Text = "";
            txtDateOfUpload.Text = "";
        }

    }
}
