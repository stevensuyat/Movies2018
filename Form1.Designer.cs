namespace Movies2018
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpgCustomers = new System.Windows.Forms.TabPage();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.tbpgMovies = new System.Windows.Forms.TabPage();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.tbpgRented = new System.Windows.Forms.TabPage();
            this.dgvRented = new System.Windows.Forms.DataGridView();
            this.tbpgUnreturned = new System.Windows.Forms.TabPage();
            this.dgvUnreturned = new System.Windows.Forms.DataGridView();
            this.tbpgBestCustomers = new System.Windows.Forms.TabPage();
            this.dgvBestCustomers = new System.Windows.Forms.DataGridView();
            this.tbpgTopMovies = new System.Windows.Forms.TabPage();
            this.dgvTopMovies = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomers = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtDateJoined = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.txtRental_Cost = new System.Windows.Forms.TextBox();
            this.txtDateOfUpload = new System.Windows.Forms.TextBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblRMID = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbpgCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tbpgMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.tbpgRented.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRented)).BeginInit();
            this.tbpgUnreturned.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnreturned)).BeginInit();
            this.tbpgBestCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestCustomers)).BeginInit();
            this.tbpgTopMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpgCustomers);
            this.tabControl1.Controls.Add(this.tbpgMovies);
            this.tabControl1.Controls.Add(this.tbpgRented);
            this.tabControl1.Controls.Add(this.tbpgUnreturned);
            this.tabControl1.Controls.Add(this.tbpgBestCustomers);
            this.tabControl1.Controls.Add(this.tbpgTopMovies);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(951, 344);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.RefreshData_Click);
            // 
            // tbpgCustomers
            // 
            this.tbpgCustomers.Controls.Add(this.dgvCustomers);
            this.tbpgCustomers.Location = new System.Drawing.Point(4, 22);
            this.tbpgCustomers.Name = "tbpgCustomers";
            this.tbpgCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgCustomers.Size = new System.Drawing.Size(943, 318);
            this.tbpgCustomers.TabIndex = 0;
            this.tbpgCustomers.Text = "Customers";
            this.tbpgCustomers.UseVisualStyleBackColor = true;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Location = new System.Drawing.Point(3, 3);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(937, 312);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomers_CellContentClick);
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomers_CellContentClick);
            // 
            // tbpgMovies
            // 
            this.tbpgMovies.Controls.Add(this.dgvMovies);
            this.tbpgMovies.Location = new System.Drawing.Point(4, 22);
            this.tbpgMovies.Name = "tbpgMovies";
            this.tbpgMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgMovies.Size = new System.Drawing.Size(943, 318);
            this.tbpgMovies.TabIndex = 1;
            this.tbpgMovies.Text = "Movies";
            this.tbpgMovies.UseVisualStyleBackColor = true;
            // 
            // dgvMovies
            // 
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovies.Location = new System.Drawing.Point(3, 3);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.Size = new System.Drawing.Size(937, 312);
            this.dgvMovies.TabIndex = 0;
            this.dgvMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMovies_CellContentClick);
            this.dgvMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMovies_CellContentClick);
            // 
            // tbpgRented
            // 
            this.tbpgRented.Controls.Add(this.dgvRented);
            this.tbpgRented.Location = new System.Drawing.Point(4, 22);
            this.tbpgRented.Name = "tbpgRented";
            this.tbpgRented.Size = new System.Drawing.Size(943, 318);
            this.tbpgRented.TabIndex = 2;
            this.tbpgRented.Text = "Rented";
            this.tbpgRented.UseVisualStyleBackColor = true;
            // 
            // dgvRented
            // 
            this.dgvRented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRented.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRented.Location = new System.Drawing.Point(0, 0);
            this.dgvRented.Name = "dgvRented";
            this.dgvRented.Size = new System.Drawing.Size(943, 318);
            this.dgvRented.TabIndex = 0;
            this.dgvRented.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRented_CellContentClick);
            this.dgvRented.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRented_CellContentClick);
            // 
            // tbpgUnreturned
            // 
            this.tbpgUnreturned.Controls.Add(this.dgvUnreturned);
            this.tbpgUnreturned.Location = new System.Drawing.Point(4, 22);
            this.tbpgUnreturned.Name = "tbpgUnreturned";
            this.tbpgUnreturned.Size = new System.Drawing.Size(943, 318);
            this.tbpgUnreturned.TabIndex = 3;
            this.tbpgUnreturned.Text = "Unreturned";
            this.tbpgUnreturned.UseVisualStyleBackColor = true;
            // 
            // dgvUnreturned
            // 
            this.dgvUnreturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnreturned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUnreturned.Location = new System.Drawing.Point(0, 0);
            this.dgvUnreturned.Name = "dgvUnreturned";
            this.dgvUnreturned.Size = new System.Drawing.Size(943, 318);
            this.dgvUnreturned.TabIndex = 0;
            this.dgvUnreturned.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUnreturned_CellContentClick);
            this.dgvUnreturned.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUnreturned_CellContentClick);
            // 
            // tbpgBestCustomers
            // 
            this.tbpgBestCustomers.Controls.Add(this.dgvBestCustomers);
            this.tbpgBestCustomers.Location = new System.Drawing.Point(4, 22);
            this.tbpgBestCustomers.Name = "tbpgBestCustomers";
            this.tbpgBestCustomers.Size = new System.Drawing.Size(943, 318);
            this.tbpgBestCustomers.TabIndex = 4;
            this.tbpgBestCustomers.Text = "Best Customers";
            this.tbpgBestCustomers.UseVisualStyleBackColor = true;
            // 
            // dgvBestCustomers
            // 
            this.dgvBestCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBestCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBestCustomers.Location = new System.Drawing.Point(0, 0);
            this.dgvBestCustomers.Name = "dgvBestCustomers";
            this.dgvBestCustomers.Size = new System.Drawing.Size(943, 318);
            this.dgvBestCustomers.TabIndex = 0;
            // 
            // tbpgTopMovies
            // 
            this.tbpgTopMovies.Controls.Add(this.dgvTopMovies);
            this.tbpgTopMovies.Location = new System.Drawing.Point(4, 22);
            this.tbpgTopMovies.Name = "tbpgTopMovies";
            this.tbpgTopMovies.Size = new System.Drawing.Size(943, 318);
            this.tbpgTopMovies.TabIndex = 5;
            this.tbpgTopMovies.Text = "Top Movies";
            this.tbpgTopMovies.UseVisualStyleBackColor = true;
            // 
            // dgvTopMovies
            // 
            this.dgvTopMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopMovies.Location = new System.Drawing.Point(0, 0);
            this.dgvTopMovies.Name = "dgvTopMovies";
            this.dgvTopMovies.Size = new System.Drawing.Size(943, 318);
            this.dgvTopMovies.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date Joined";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Movie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 537);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Title";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 639);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Year";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 537);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Rating ( G, PG, PG-13, etc. )";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(520, 588);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Rental Cost ($)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(520, 537);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Copies";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(239, 588);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Plot";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 588);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Genre";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(520, 639);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Date of Upload";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(665, 384);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(119, 23);
            this.btnAddCustomer.TabIndex = 31;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(665, 413);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(119, 23);
            this.btnUpdateCustomer.TabIndex = 32;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.BtnUpdateCustomers_Click);
            // 
            // btnDeleteCustomers
            // 
            this.btnDeleteCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomers.Location = new System.Drawing.Point(665, 442);
            this.btnDeleteCustomers.Name = "btnDeleteCustomers";
            this.btnDeleteCustomers.Size = new System.Drawing.Size(119, 23);
            this.btnDeleteCustomers.TabIndex = 33;
            this.btnDeleteCustomers.Text = "Delete";
            this.btnDeleteCustomers.UseVisualStyleBackColor = true;
            this.btnDeleteCustomers.Click += new System.EventHandler(this.BtnDeleteCustomers_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(15, 404);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(138, 20);
            this.txtFirstName.TabIndex = 34;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(15, 458);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(138, 20);
            this.txtLastName.TabIndex = 35;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(242, 404);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(194, 20);
            this.txtAddress.TabIndex = 36;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(242, 458);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(122, 20);
            this.txtPhone.TabIndex = 37;
            // 
            // txtDateJoined
            // 
            this.txtDateJoined.Location = new System.Drawing.Point(479, 404);
            this.txtDateJoined.Name = "txtDateJoined";
            this.txtDateJoined.Size = new System.Drawing.Size(144, 20);
            this.txtDateJoined.TabIndex = 38;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(19, 553);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(178, 20);
            this.txtTitle.TabIndex = 39;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(19, 604);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(120, 20);
            this.txtGenre.TabIndex = 40;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(19, 655);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(89, 20);
            this.txtYear.TabIndex = 41;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(242, 553);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(100, 20);
            this.txtRating.TabIndex = 42;
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(242, 604);
            this.txtPlot.Multiline = true;
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(238, 71);
            this.txtPlot.TabIndex = 43;
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(523, 553);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(100, 20);
            this.txtCopies.TabIndex = 44;
            // 
            // txtRental_Cost
            // 
            this.txtRental_Cost.Location = new System.Drawing.Point(523, 604);
            this.txtRental_Cost.Name = "txtRental_Cost";
            this.txtRental_Cost.Size = new System.Drawing.Size(100, 20);
            this.txtRental_Cost.TabIndex = 45;
            // 
            // txtDateOfUpload
            // 
            this.txtDateOfUpload.Location = new System.Drawing.Point(523, 655);
            this.txtDateOfUpload.Name = "txtDateOfUpload";
            this.txtDateOfUpload.Size = new System.Drawing.Size(100, 20);
            this.txtDateOfUpload.TabIndex = 46;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.Location = new System.Drawing.Point(665, 571);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(119, 23);
            this.btnAddMovie.TabIndex = 47;
            this.btnAddMovie.Text = "Add";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.BtnAddMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMovie.Location = new System.Drawing.Point(665, 600);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(119, 23);
            this.btnUpdateMovie.TabIndex = 48;
            this.btnUpdateMovie.Text = "Update";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.BtnUpdateMovie_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMovie.Location = new System.Drawing.Point(665, 629);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(119, 23);
            this.btnDeleteMovie.TabIndex = 49;
            this.btnDeleteMovie.Text = "Delete";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.BtnDeleteMovie_Click);
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(192, 366);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(14, 13);
            this.lblCustID.TabIndex = 50;
            this.lblCustID.Text = "0";
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieID.Location = new System.Drawing.Point(155, 515);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(14, 13);
            this.lblMovieID.TabIndex = 51;
            this.lblMovieID.Text = "0";
            // 
            // btnRent
            // 
            this.btnRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.Location = new System.Drawing.Point(813, 458);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(119, 52);
            this.btnRent.TabIndex = 52;
            this.btnRent.Text = "RENT";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.BtnRent_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(813, 521);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(119, 52);
            this.btnReturn.TabIndex = 53;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(110, 366);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 54;
            this.label16.Text = "CustomerID:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(91, 515);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 55;
            this.label17.Text = "MovieID:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(662, 511);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 13);
            this.label18.TabIndex = 56;
            this.label18.Text = "RentedMovieID:";
            // 
            // lblRMID
            // 
            this.lblRMID.AutoSize = true;
            this.lblRMID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMID.Location = new System.Drawing.Point(767, 511);
            this.lblRMID.Name = "lblRMID";
            this.lblRMID.Size = new System.Drawing.Size(14, 13);
            this.lblRMID.TabIndex = 57;
            this.lblRMID.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 695);
            this.Controls.Add(this.lblRMID);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.lblMovieID);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.txtDateOfUpload);
            this.Controls.Add(this.txtRental_Cost);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.txtPlot);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtDateJoined);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnDeleteCustomers);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = " ";
            this.tabControl1.ResumeLayout(false);
            this.tbpgCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tbpgMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.tbpgRented.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRented)).EndInit();
            this.tbpgUnreturned.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnreturned)).EndInit();
            this.tbpgBestCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestCustomers)).EndInit();
            this.tbpgTopMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpgCustomers;
        private System.Windows.Forms.TabPage tbpgMovies;
        private System.Windows.Forms.TabPage tbpgRented;
        private System.Windows.Forms.TabPage tbpgUnreturned;
        private System.Windows.Forms.TabPage tbpgBestCustomers;
        private System.Windows.Forms.TabPage tbpgTopMovies;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.DataGridView dgvRented;
        private System.Windows.Forms.DataGridView dgvUnreturned;
        private System.Windows.Forms.DataGridView dgvBestCustomers;
        private System.Windows.Forms.DataGridView dgvTopMovies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnDeleteCustomers;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtDateJoined;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.TextBox txtRental_Cost;
        private System.Windows.Forms.TextBox txtDateOfUpload;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblRMID;
    }
}

