using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjectPP
{
    public partial class CustomerHomePage : Form
    {
        private string connectionString = @"Server=SADIK\SQLEXPRESS;Database=[Practice Database];Trusted_Connection=True;";
        private string userName;

        // --- Default Constructor ---
        public CustomerHomePage()
        {
            InitializeComponent();
            this.Load += CustomerHomePage_Load;
        }

        // --- Optional Constructor with User Name ---
        public CustomerHomePage(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            this.Load += CustomerHomePage_Load;
        }

        private void CustomerHomePage_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userName))
            {
                lblWelcomeUser.Text = "Welcome, " + userName;
            }
            LoadProductsFromDatabase();
        }

        private void LoadProductsFromDatabase(string categoryFilter = null)
        {
            pnlBody.Controls.Clear();
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string query = "SELECT * FROM Product_Details";
                    if (!string.IsNullOrEmpty(categoryFilter))
                    {
                        query += " WHERE Product_type = @Category";
                    }

                    using (SqlCommand sqlCmd = new SqlCommand(query, sqlCon))
                    {
                        if (!string.IsNullOrEmpty(categoryFilter))
                        {
                            sqlCmd.Parameters.AddWithValue("@Category", categoryFilter);
                        }

                        using (SqlDataReader reader = sqlCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                pnlBody.Controls.Add(CreateProductCard(
                                    reader["Product_code"].ToString(),
                                    reader["Image"] as byte[],
                                    reader["Model"].ToString(),
                                    Convert.ToDecimal(reader["Current_Price"]),
                                    Convert.ToDecimal(reader["Regular_Price"]),
                                    reader["Status"].ToString(),
                                    reader["Brand_name"].ToString(),
                                    reader["Key_Features"].ToString(),
                                    reader["Product_type"].ToString()
                                ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
<<<<<<< HEAD
                MessageBox.Show("Failed to load products. \nError: " + ex.Message, "Database Error");
            }
        }

        private Panel CreateProductCard(string productCode, byte[] imageData, string model, decimal currentPrice, decimal regularPrice, string status, string brand, string keyFeatures, string productType)
=======
                MessageBox.Show("Failed to load products from the database.\nError: " + ex.Message, "Database Error");
            }
        }

        private Panel CreateProductCard(byte[] imageData, string model, decimal currentPrice, decimal regularPrice, string status, string brand, string keyFeatures)
>>>>>>> 0854c634a3d73ea5f487cb6d4aadb9bf43bc174b
        {
            Panel card = new Panel { Width = 260, Height = 360, BackColor = Color.White, Margin = new Padding(15), BorderStyle = BorderStyle.FixedSingle };
            PictureBox pic = new PictureBox { Dock = DockStyle.Top, Height = 150, SizeMode = PictureBoxSizeMode.Zoom };
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pic.Image = Image.FromStream(ms);
                }
            }
            else { pic.BackColor = Color.Gainsboro; }

            Label brandLabel = new Label { Text = brand, Font = new Font("Segoe UI", 9F), ForeColor = Color.Gray, Dock = DockStyle.Top, Padding = new Padding(10, 5, 10, 0), Height = 30 };
            Label nameLabel = new Label { Text = model, Font = new Font("Segoe UI", 10F, FontStyle.Bold), Dock = DockStyle.Top, Padding = new Padding(10, 0, 10, 5), Height = 55 };
            Label statusLabel = new Label { Text = status, Font = new Font("Segoe UI", 9F, FontStyle.Bold), Dock = DockStyle.Top, Padding = new Padding(10, 0, 10, 5), Height = 30 };
            statusLabel.ForeColor = status.ToLower() == "in stock" ? Color.Green : Color.Red;

            Panel pricePanel = new Panel { Dock = DockStyle.Top, Height = 40, Padding = new Padding(10, 0, 10, 0) };
            Label currentPriceLabel = new Label { Text = "৳" + currentPrice.ToString("N0"), Font = new Font("Segoe UI", 12F, FontStyle.Bold), ForeColor = Color.FromArgb(0, 123, 255), Dock = DockStyle.Left, AutoSize = true };
            Label regularPriceLabel = new Label { Text = "৳" + regularPrice.ToString("N0"), Font = new Font("Segoe UI", 10F, FontStyle.Strikeout), ForeColor = Color.Gray, Dock = DockStyle.Left, AutoSize = true, Padding = new Padding(10, 3, 0, 0) };
            pricePanel.Controls.Add(regularPriceLabel);
            pricePanel.Controls.Add(currentPriceLabel);

<<<<<<< HEAD
            FlowLayoutPanel actionsPanel = new FlowLayoutPanel { Dock = DockStyle.Bottom, Height = 45, Padding = new Padding(5, 5, 5, 5), FlowDirection = FlowDirection.LeftToRight };
            LinkLabel detailsLink = new LinkLabel { Text = "View Details", Font = new Font("Segoe UI", 10F), LinkColor = Color.DodgerBlue, Margin = new Padding(5, 5, 20, 5), AutoSize = true, TabStop = false };
=======
            LinkLabel detailsLink = new LinkLabel
            {
                Text = "View Details",
                Dock = DockStyle.Bottom,
                Height = 40,
                Font = new Font("Segoe UI", 10F),
                LinkColor = Color.DodgerBlue,
                TextAlign = ContentAlignment.MiddleCenter,
                TabStop = false
            };
>>>>>>> 0854c634a3d73ea5f487cb6d4aadb9bf43bc174b
            detailsLink.LinkClicked += (s, ev) => { MessageBox.Show(keyFeatures, "Key Features: " + model); };

            Button buyButton = new Button { Text = "Buy Now", Font = new Font("Segoe UI", 10F, FontStyle.Bold), BackColor = Color.FromArgb(40, 167, 69), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Size = new Size(120, 35) };
            buyButton.FlatAppearance.BorderSize = 0;
            buyButton.Click += (s, ev) =>
            {
                PurchasePage purchaseForm = new PurchasePage(imageData, model, currentPrice, productCode, productType, keyFeatures, status);
                purchaseForm.ShowDialog(this);
            };

            actionsPanel.Controls.Add(detailsLink);
            actionsPanel.Controls.Add(buyButton);

            card.Controls.Add(actionsPanel);
            card.Controls.Add(pricePanel);
            card.Controls.Add(statusLabel);
            card.Controls.Add(nameLabel);
            card.Controls.Add(brandLabel);
            card.Controls.Add(pic);
            return card;
        }

<<<<<<< HEAD
        private void btnSearch_Click(object sender, EventArgs e) { /* ... */ }
        private void CategoryButton_Click(object sender, EventArgs e) { /* ... */ }
        private void txtSearch_Enter(object sender, EventArgs e) { /* ... */ }
        private void txtSearch_Leave(object sender, EventArgs e) { /* ... */ }
=======
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "Search Products...")
            {
                MessageBox.Show("Searching for: " + txtSearch.Text, "Search Initiated");
            }
            else
            {
                MessageBox.Show("Please enter a product to search for.", "Search");
            }
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string category = clickedButton.Text;
                MessageBox.Show("Category clicked: " + category);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search Products...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search Products...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        // Unused paint/click events — you may delete them or leave them for Designer
        private void pnlBody_Paint(object sender, PaintEventArgs e) { }
        private void lblWelcomeUser_Click(object sender, EventArgs e) { }
        private void txtSearch_TextChanged(object sender, EventArgs e) { }
        private void lblShopName_Click(object sender, EventArgs e) { }
        private void pnlHeader_Paint(object sender, PaintEventArgs e) { }
        private void pnlCategories_Paint(object sender, PaintEventArgs e) { }
>>>>>>> 0854c634a3d73ea5f487cb6d4aadb9bf43bc174b
    }
}
