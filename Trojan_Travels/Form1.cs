using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.IO.Packaging;
using System.Linq;
using System.Windows.Forms;
using Trojan_Travels.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Trojan_Travels
{




    // Code Author: Xiao Li
    // This lab (Project_Workshop_1_–_CPRG006) is to generate a Windows Form App, in order that employees of Travel Experts can administer the data stored in their database.
    public partial class Form1 : Form
    {
        private TravelExpertsContext dbContext;
        private BindingSource packageBindingSource = new BindingSource();
        private BindingSource psBindingSource = new BindingSource();
        private BindingSource supplierBindingSource = new BindingSource();
        private BindingSource productBindingSource = new BindingSource();


        // sets up multiple DataGridView controls for displaying data from a database. It configures the columns, binds them to properties in entity classes, and loads data into these controls during the form's initialization. 
        public Form1()
        {
            InitializeComponent();

            this.AutoScroll = true;

            dbContext = new TravelExpertsContext();

            dataGVPackage.AutoGenerateColumns = false; // Disable auto-generation of columns
            // Add columns manually
            dataGVPackage.Columns.Add("PackageIdColumn", "Package ID");
            dataGVPackage.Columns.Add("PkgNameColumn", "Pacakge Name");
            dataGVPackage.Columns.Add("PkgStartDateColumn", "Pacakge Start Date");
            dataGVPackage.Columns.Add("PkgEndDateColumn", "Pacakge End Date");
            dataGVPackage.Columns.Add("PkgDescColumn", "Pacakge Description");
            dataGVPackage.Columns.Add("PkgBasePriceColumn", "Pacakge Base Price ($)");
            dataGVPackage.Columns.Add("PkgAgencyCommissionColumn", "Pacakge Agency Commission ($)");
            // Bind columns to the corresponding properties in the entity
            dataGVPackage.Columns["PackageIdColumn"].DataPropertyName = "PackageId";
            dataGVPackage.Columns["PkgNameColumn"].DataPropertyName = "PkgName";
            dataGVPackage.Columns["PkgStartDateColumn"].DataPropertyName = "PkgStartDate";
            dataGVPackage.Columns["PkgEndDateColumn"].DataPropertyName = "PkgEndDate";
            dataGVPackage.Columns["PkgDescColumn"].DataPropertyName = "PkgDesc";
            dataGVPackage.Columns["PkgBasePriceColumn"].DataPropertyName = "PkgBasePrice";
            dataGVPackage.Columns["PkgAgencyCommissionColumn"].DataPropertyName = "PkgAgencyCommission";
            // Set the AutoSizeMode property for each column
            dataGVPackage.Columns["PkgNameColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            // Set the format for the columns
            dataGVPackage.Columns["PkgBasePriceColumn"].DefaultCellStyle.Format = "0.00";
            dataGVPackage.Columns["PkgAgencyCommissionColumn"].DefaultCellStyle.Format = "0.00";
            dataGVPackage.DataSource = packageBindingSource;

            dataGVPS.AutoGenerateColumns = false; // Disable auto-generation of columns
            // Add columns manually
            dataGVPS.Columns.Add("ProductSupplierIdColumn", "Product_Supplier ID");
            dataGVPS.Columns.Add("ProductIdColumn", "Product ID");
            dataGVPS.Columns.Add("SupplierIdColumn", "Supplier ID");
            // Bind columns to the corresponding properties in the entity
            dataGVPS.Columns["ProductSupplierIdColumn"].DataPropertyName = "ProductSupplierId";
            dataGVPS.Columns["ProductIdColumn"].DataPropertyName = "ProductId";
            dataGVPS.Columns["SupplierIdColumn"].DataPropertyName = "SupplierId";
            // Set the AutoSizeMode property for each column
            dataGVPS.Columns["ProductSupplierIdColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGVPS.Columns["ProductIdColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGVPS.Columns["SupplierIdColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGVPS.DataSource = psBindingSource;

            dataGVProduct.AutoGenerateColumns = false; // Disable auto-generation of columns
            // Add columns manually
            dataGVProduct.Columns.Add("ProductIdColumn", "Product ID");
            dataGVProduct.Columns.Add("ProdNameColumn", "Product Name");
            // Bind columns to the corresponding properties in the entity
            dataGVProduct.Columns["ProductIdColumn"].DataPropertyName = "ProductId";
            dataGVProduct.Columns["ProdNameColumn"].DataPropertyName = "ProdName";
            // Set the AutoSizeMode property for each column
            dataGVProduct.Columns["ProductIdColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGVProduct.Columns["ProdNameColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            // Set the DataSource
            dataGVProduct.DataSource = productBindingSource;

            dataGVSupplier.AutoGenerateColumns = false; // Disable auto-generation of columns
            // Add columns manually
            dataGVSupplier.Columns.Add("SupplierIdColumn", "Supplier ID");
            dataGVSupplier.Columns.Add("SupNameColumn", "Supplier Name");
            // Bind columns to the corresponding properties in the Product entity
            dataGVSupplier.Columns["SupplierIdColumn"].DataPropertyName = "SupplierId";
            dataGVSupplier.Columns["SupNameColumn"].DataPropertyName = "SupName";
            // Set the AutoSizeMode property for each column
            dataGVSupplier.Columns["SupplierIdColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGVSupplier.Columns["SupNameColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGVSupplier.DataSource = supplierBindingSource;

            LoadData();
            clearButton();
        }


        // retrieve data
        private void LoadData()
        {
            var packages = dbContext.Packages.ToList();
            packageBindingSource.DataSource = packages;

            var productsSuppliers = dbContext.ProductsSuppliers.ToList();
            psBindingSource.DataSource = productsSuppliers;

            var products = dbContext.Products.ToList();
            productBindingSource.DataSource = products;

            var suppliers = dbContext.Suppliers.ToList();
            supplierBindingSource.DataSource = suppliers;
        }


        // Package Add Button
        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            // Check for empty input fields
            if (string.IsNullOrWhiteSpace(txtPackageName.Text) ||
                string.IsNullOrWhiteSpace(txtPackageDescription.Text) ||
                string.IsNullOrWhiteSpace(txtPackageBasePrice.Text) ||
                string.IsNullOrWhiteSpace(txtPackageCommission.Text))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            // Validate date
            if (dateTimePickerEndDate.Value <= dateTimePickerStartDate.Value)
            {
                MessageBox.Show("Package end date must be great than package start date.");
                return;
            }

            // Validate monetary values
            if (!decimal.TryParse(txtPackageBasePrice.Text, out decimal basePrice) ||
                !decimal.TryParse(txtPackageCommission.Text, out decimal commission) ||
                basePrice < 0 || commission < 0)
            {
                MessageBox.Show("Please enter valid non-negative monetary values.");
                return;
            }

            // Check commission against base price
            if (commission > basePrice)
            {
                MessageBox.Show("Commission cannot be greater than the base price.");
                return;
            }

            // Create a new package.
            Models.Package newPackage = new Models.Package
            {
                PkgName = txtPackageName.Text,
                PkgStartDate = dateTimePickerStartDate.Value.Date,
                PkgEndDate = dateTimePickerEndDate.Value.Date,
                PkgDesc = txtPackageDescription.Text,
                PkgBasePrice = Math.Round(Convert.ToDecimal(txtPackageBasePrice.Text), 2),
                PkgAgencyCommission = Math.Round(Convert.ToDecimal(txtPackageCommission.Text), 2)
            };

            dbContext.Packages.Add(newPackage);

            dbContext.SaveChanges();

            if (!string.IsNullOrEmpty(txtProductSupplierId.Text))
            {
                int productSupplierId = Convert.ToInt32(txtProductSupplierId.Text);

                // Check if the combination of PackageId and ProductSupplierId already exists
                bool exists = dbContext.PackagesProductsSuppliers
                    .Any(pps => pps.PackageId == newPackage.PackageId && pps.ProductSupplierId == productSupplierId);

                if (!exists)
                {
                    // If the combination doesn't exist, create a new entry
                    PackagesProductsSupplier newPackageProductsSupplier = new PackagesProductsSupplier
                    {
                        PackageId = newPackage.PackageId,
                        ProductSupplierId = productSupplierId,
                    };

                    dbContext.PackagesProductsSuppliers.Add(newPackageProductsSupplier);
                    dbContext.SaveChanges();
                }
                else
                {
                    // Handle the case where the combination already exists
                    MessageBox.Show("The combination of PackageId and ProductSupplierId already exists.");
                }
            }

            LoadData();

            MessageBox.Show("Package added successfully!");

            clearEntry();
        }


        // Package Edit Button
        private void btnEditPackage_Click(object sender, EventArgs e)
        {
            // Get the selected package from the DataGridView
            if (dataGVPackage.SelectedRows.Count > 0)
            {
                int packageId = Convert.ToInt32(dataGVPackage.SelectedRows[0].Cells[0].Value);
                Models.Package selectedPackage = dbContext.Packages.Find(packageId);

                // Check for empty input fields
                if (string.IsNullOrWhiteSpace(txtPackageName.Text) ||
                    string.IsNullOrWhiteSpace(txtPackageDescription.Text) ||
                    string.IsNullOrWhiteSpace(txtPackageBasePrice.Text) ||
                    string.IsNullOrWhiteSpace(txtPackageCommission.Text))
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return;
                }

                // Validate date
                if (dateTimePickerEndDate.Value <= dateTimePickerStartDate.Value)
                {
                    MessageBox.Show("Package end date must be great than package start date.");
                    return;
                }

                // Validate monetary values
                if (!decimal.TryParse(txtPackageBasePrice.Text, out decimal basePrice) ||
                    !decimal.TryParse(txtPackageCommission.Text, out decimal commission) ||
                    basePrice < 0 || commission < 0)
                {
                    MessageBox.Show("Please enter valid non-negative monetary values.");
                    return;
                }

                // Check commission against base price
                if (commission > basePrice)
                {
                    MessageBox.Show("Commission cannot be greater than the base price.");
                    return;
                }
                if (selectedPackage != null)
                {
                    // Update the selected package with the edited values
                    selectedPackage.PkgName = txtPackageName.Text;
                    selectedPackage.PkgStartDate = dateTimePickerStartDate.Value.Date;
                    selectedPackage.PkgEndDate = dateTimePickerEndDate.Value.Date;
                    selectedPackage.PkgDesc = txtPackageDescription.Text;
                    selectedPackage.PkgBasePrice = Math.Round(Convert.ToDecimal(txtPackageBasePrice.Text), 2);
                    selectedPackage.PkgAgencyCommission = Math.Round(Convert.ToDecimal(txtPackageCommission.Text), 2);

                    // Save changes to the database
                    dbContext.SaveChanges();
                }

                // Create a new Package_Product_Supplier.
                if (!string.IsNullOrEmpty(txtProductSupplierId.Text))
                {
                    int productSupplierId = Convert.ToInt32(txtProductSupplierId.Text);

                    // Check if the combination of PackageId and ProductSupplierId already exists
                    bool exists = dbContext.PackagesProductsSuppliers
                        .Any(pps => pps.PackageId == packageId && pps.ProductSupplierId == productSupplierId);

                    if (!exists)
                    {
                        // If the combination doesn't exist, create a new entry
                        PackagesProductsSupplier newPackageProductsSupplier = new PackagesProductsSupplier
                        {
                            PackageId = packageId,
                            ProductSupplierId = productSupplierId,
                        };

                        dbContext.PackagesProductsSuppliers.Add(newPackageProductsSupplier);
                        dbContext.SaveChanges();
                    }
                    else
                    {
                        // Handle the case where the combination already exists
                        MessageBox.Show("The combination of PackageId and ProductSupplierId already exists.");
                    }
                }

                LoadData();

                MessageBox.Show("Package edited successfully!");

                clearEntry();
            }
            else
            {
                MessageBox.Show("Please select a package to edit.");
            }
        }


        // Package Delete Button
        private void btnPackageDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you Sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int packageId = Convert.ToInt32(dataGVPackage.SelectedRows[0].Cells[0].Value);

                    var thisPackage = dbContext.Packages.Where(p => p.PackageId == packageId).FirstOrDefault();

                    if (thisPackage != null)
                    {
                        dbContext.Packages.Remove(thisPackage);

                        // Save changes to the database
                        dbContext.SaveChanges();

                        LoadData();
                    }
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select an entire row.");
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException is SqlException sqlException && sqlException.Number == 547)
                {
                    // SQL Server error number 547 corresponds to a foreign key constraint violation
                    MessageBox.Show("This package is associated with other records and cannot be deleted.");
                }
                else
                {
                    // Handle other database errors
                    MessageBox.Show("An error occurred while deleting the package: " + ex.Message);
                }
            }
        }


        // Supplier_Product Add Button
        private void btnAddSupplierProduct_Click(object sender, EventArgs e)
        {
            int supplierId = -1;
            int productId = -1;
            if (int.TryParse(txtPSSupplierId.Text, out supplierId) && int.TryParse(txtPSProductId.Text, out productId))
            {
                // Conversion successful, both inputs are valid integers
                ProductsSupplier newProductsSupplier = new ProductsSupplier
                {
                    ProductId = productId,
                    SupplierId = supplierId
                };

                dbContext.ProductsSuppliers.Add(newProductsSupplier);

                // Save changes to the database
                dbContext.SaveChanges();

                LoadData();

                MessageBox.Show("Product-Supplier combination added successfully!");

                clearEntry();
            }
            else
            {
                MessageBox.Show("Please select both Product ID and Supplier ID.");
            }
        }


        // Supplier_Product Edit Button
        private void btnEditSupplierProduct_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPSProductSupplierId.Text, out int productSupplierId))
            {
                MessageBox.Show("Please select a valid Product_Supplier ID.");
                return;
            }

            ProductsSupplier selectedProductsSupplier = dbContext.ProductsSuppliers.Find(productSupplierId);

            if (selectedProductsSupplier == null)
            {
                MessageBox.Show("Product_Supplier not found.");
                return;
            }

            if (!int.TryParse(txtPSSupplierId.Text, out int supplierId) || !int.TryParse(txtPSProductId.Text, out int productId))
            {
                MessageBox.Show("Please select valid Supplier ID and Product ID.");
                return;
            }

            selectedProductsSupplier.ProductId = productId;
            selectedProductsSupplier.SupplierId = supplierId;

            // Save changes to the database
            dbContext.SaveChanges();

            LoadData();

            MessageBox.Show("Product_Supplier edited successfully!");

            clearEntry();
        }


        // Product_Supplier Delete Button
        private void btnSPDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you Sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int productSupplierId = Convert.ToInt32(dataGVPS.SelectedRows[0].Cells[0].Value);

                    var thisProductSupplier = dbContext.ProductsSuppliers.Where(p => p.ProductSupplierId == productSupplierId).First<ProductsSupplier>();

                    dbContext.ProductsSuppliers.Remove(thisProductSupplier);

                    // Save changes to the database
                    dbContext.SaveChanges();

                    LoadData();
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select an entire row.");
            }
        }


        // Supplier Add Button
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            // Retrieve the maximum SupplierId value from the database
            int maxSupplierId = dbContext.Suppliers.Max(s => s.SupplierId);

            // Generate a new SupplierId greater than the maximum value
            int newSupplierId = maxSupplierId + 1;
            if (!string.IsNullOrEmpty(txtSupplierName.Text))
            { 
                Supplier newSupplier = new Supplier
                {
                    SupplierId = newSupplierId,
                    SupName = txtSupplierName.Text,
                };

                dbContext.Suppliers.Add(newSupplier);

                // Save changes to the database
                dbContext.SaveChanges();

                LoadData();

                MessageBox.Show("Supplier added successfully!");

                clearEntry();
            }
            else
            {
                MessageBox.Show("Supplier Name is required");
            }
        }


        // Supplier Edit Button
        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEditSupplierId.Text, out int supplierId))
            {
                MessageBox.Show("Please select a valid Supplier ID.");
                return;
            }

            Supplier selectedSupplier = dbContext.Suppliers.Find(supplierId);

            if (selectedSupplier == null)
            {
                MessageBox.Show("Supplier not found.");
                return;
            }

            string supplierName = txtSupplierName.Text.Trim();

            if (string.IsNullOrEmpty(supplierName))
            {
                MessageBox.Show("Supplier Name is required.");
                return;
            }

            selectedSupplier.SupName = supplierName;


            // Save changes to the database
            dbContext.SaveChanges();

            LoadData();

            MessageBox.Show("Supplier edited successfully!");

            clearEntry();
        }


        // Supplier Delete Button
        private void btnSupplierDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you Sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int supplierId = Convert.ToInt32(dataGVSupplier.SelectedRows[0].Cells[0].Value);

                    var thisSupplier = dbContext.Suppliers.Where(p => p.SupplierId == supplierId).First<Supplier>();
                    dbContext.Suppliers.Remove(thisSupplier);

                    // Save changes to the database
                    dbContext.SaveChanges();

                    LoadData();
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select an entire row.");
            }
        }


        // Product Add Button
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductName.Text))
            {
                Product newProduct = new Product
                {
                    ProdName = txtProductName.Text,
                };

                dbContext.Products.Add(newProduct);

                // Save changes to the database
                dbContext.SaveChanges();

                LoadData();

                MessageBox.Show("Product added successfully!");

                clearEntry();
            }
            else
            {
                MessageBox.Show("Product Name is required");
            }
        }



        // Product Edit Button
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEditProductId.Text, out int productId))
            {
                MessageBox.Show("Please select a valid Product ID.");
                return;
            }

            Product selectedProduct = dbContext.Products.Find(productId);

            if (selectedProduct == null)
            {
                MessageBox.Show("Supplier not found.");
                return;
            }

            string productName = txtProductName.Text.Trim();

            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Product Name is required.");
                return;
            }

            selectedProduct.ProdName = productName;


            // Save changes to the database
            dbContext.SaveChanges();

            LoadData();

            MessageBox.Show("Product edited successfully!");

            clearEntry();
        }


        // Product Delete Button
        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you Sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int productId = Convert.ToInt32(dataGVProduct.SelectedRows[0].Cells[0].Value);

                    var thisProduct = dbContext.Products.Where(p => p.ProductId == productId).First<Product>();
                    dbContext.Products.Remove(thisProduct);

                    // Save changes to the database
                    dbContext.SaveChanges();

                    LoadData();
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select an entire row.");
            }
        }


        // Product DataGridView event handler for clicked cells
        private void dataGVProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "ProductIdColumn"
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    // Get the selected ProductId from the clicked cell
                    int productId = Convert.ToInt32(dataGVProduct.Rows[e.RowIndex].Cells["ProductIdColumn"].Value);

                    // Display debugging messages
                    MessageBox.Show("Cell clicked. ProductId: " + productId);

                    // Set the value of txtEditProductId TextBox
                    if (btnEditSupplierProduct.Enabled == true)
                    {
                        txtPSProductId.Text = productId.ToString();
                    }

                    if (btnEditProduct.Enabled == true)
                    {
                        txtEditProductId.Text = productId.ToString();
                    }

                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show("An error occurred: " + ex.Message);

                    if (ex.InnerException != null)
                    {
                        MessageBox.Show("Inner Exception: " + ex.InnerException.Message);
                    }
                }
            }
        }


        // Supplier DataGridView event handler for clicked cells
        private void dataGVSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "SupplierIdColumn"
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    // Get the selected SupplierId from the clicked cell
                    int supplierId = Convert.ToInt32(dataGVSupplier.Rows[e.RowIndex].Cells["SupplierIdColumn"].Value);

                    // Display debugging messages
                    MessageBox.Show("Cell clicked. SupplierId: " + supplierId);

                    // Set the value of either txtPSSupplierId or txtEditSupplierId TextBox
                    if (btnEditSupplierProduct.Enabled == true)
                    {
                        txtPSSupplierId.Text = supplierId.ToString();
                    }

                    if (btnEditSupplier.Enabled == true)
                    {
                        txtEditSupplierId.Text = supplierId.ToString();
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show("An error occurred: " + ex.Message);

                    if (ex.InnerException != null)
                    {
                        MessageBox.Show("Inner Exception: " + ex.InnerException.Message);
                    }
                }
            }
        }


        // Supplier_product DataGridView event handler for clicked cells
        private void dataGVPS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "ProductSupplierId" column
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    // Get the selected ProductSupplierId from the clicked cell
                    int productSupplierId = Convert.ToInt32(dataGVPS.Rows[e.RowIndex].Cells["ProductSupplierIdColumn"].Value);

                    // Display debugging messages
                    MessageBox.Show("Cell clicked. ProductSupplierId: " + productSupplierId);

                    // Set the value of txtEditSupplierId TextBox
                    if (btnEditSupplierProduct.Enabled == true)
                    {
                        txtPSProductSupplierId.Text = productSupplierId.ToString();
                    }

                    if (btnEditPackage.Enabled == true)
                    {
                        txtProductSupplierId.Text = productSupplierId.ToString();
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show("An error occurred: " + ex.Message);

                    if (ex.InnerException != null)
                    {
                        MessageBox.Show("Inner Exception: " + ex.InnerException.Message);
                    }
                }
            }
        }


        // Clear the user input
        public void clearEntry()
        {
            txtPackageName.Text = "";
            txtProductSupplierId.Text = "";
            dateTimePickerStartDate.Value = DateTime.Now;
            dateTimePickerEndDate.Value = DateTime.Now;
            txtPackageDescription.Text = "";
            txtPackageBasePrice.Text = "";
            txtPackageCommission.Text = "";
            txtSupplierName.Text = "";
            txtEditSupplierId.Text = "";
            txtProductName.Text = "";
            txtEditProductId.Text = "";
            txtPSProductSupplierId.Text = "";
            txtPSProductId.Text = "";
            txtPSSupplierId.Text = "";
            txtPackageName.Focus();
        }

        // reset the button states
        private void clearButton()
        {
            btnEditSupplier.Enabled = false;
            btnAddSupplier.Enabled = false;
            btnEditPackage.Enabled = false;
            btnAddPackage.Enabled = false;
            btnAddSupplierProduct.Enabled = false;
            btnEditSupplierProduct.Enabled = false;
            btnEditProduct.Enabled = false;
            btnAddProduct.Enabled = false;
        }

        // Package Management Activation Button
        private void btnMgPackages_Click(object sender, EventArgs e)
        {
            btnEditSupplier.Enabled = false;
            btnAddSupplier.Enabled = false;
            btnEditPackage.Enabled = true;
            btnAddPackage.Enabled = true;
            btnAddSupplierProduct.Enabled = false;
            btnEditSupplierProduct.Enabled = false;
            btnEditProduct.Enabled = false;
            btnAddProduct.Enabled = false;
        }

        // Package_Supplier Management Activation Button
        private void btnMgPS_Click(object sender, EventArgs e)
        {
            btnEditSupplier.Enabled = false;
            btnAddSupplier.Enabled = false;
            btnEditPackage.Enabled = false;
            btnAddPackage.Enabled = false;
            btnAddSupplierProduct.Enabled = true;
            btnEditSupplierProduct.Enabled = true;
            btnEditProduct.Enabled = false;
            btnAddProduct.Enabled = false;
        }

        // Supplier Management Activation Button
        private void btnMgSuppliers_Click(object sender, EventArgs e)
        {
            btnEditSupplier.Enabled = true;
            btnAddSupplier.Enabled = true;
            btnEditPackage.Enabled = false;
            btnAddPackage.Enabled = false;
            btnAddSupplierProduct.Enabled = false;
            btnEditSupplierProduct.Enabled = false;
            btnEditProduct.Enabled = false;
            btnAddProduct.Enabled = false;
        }

        // Product Management Activation Button
        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            btnEditSupplier.Enabled = false;
            btnAddSupplier.Enabled = false;
            btnEditPackage.Enabled = false;
            btnAddPackage.Enabled = false;
            btnAddSupplierProduct.Enabled = false;
            btnEditSupplierProduct.Enabled = false;
            btnEditProduct.Enabled = true;
            btnAddProduct.Enabled = true;
        }

        // Screen and database refresh button 
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearEntry();
            clearButton();
            LoadData();
        }
    }
}