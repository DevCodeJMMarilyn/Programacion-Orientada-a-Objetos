using StoreProductManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreProductManager
{
    public partial class MainForm : Form
    {
        private ProductManager productManager;
        public MainForm()
        {
            InitializeComponent();
            productManager = new ProductManager();
            productManager.ProductAdded += ProductManager_ProductAdded;
            productManager.ProductUpdated += ProductManager_ProductUpdated;
            Load += MainForm_Load;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridViewProducts.Columns.Add("Id", "ID");
            dataGridViewProducts.Columns.Add("Name", "Nombre");
            dataGridViewProducts.Columns.Add("Price", "Precio");
            dataGridViewProducts.Columns.Add("Quantity", "Cantidad");
            dataGridViewProducts.Columns.Add("Category", "Categoría");

            buttonEditProduct.Enabled = false;
            buttonDeleteProduct.Enabled = false;

            dataGridViewProducts.SelectionChanged += DataGridViewProducts_SelectionChanged;
        }

        private void ProductManager_ProductAdded(object sender, ProductEventArgs e)
        {
            AddProductToGrid(e.Product);
        }

        private void ProductManager_ProductUpdated(object sender, ProductEventArgs e)
        {
            string originalProductName = e.OriginalProductName;
            UpdateProductInGrid(e.Product, originalProductName);

        }

        private void AddProductToGrid(ProductModel product)
        {
            dataGridViewProducts.Rows.Add(product.Id, product.Name, product.Price.ToString("C"), product.Quantity, product.Category);
        }
        //Actualiza un producto
        private void UpdateProductInGrid(ProductModel updatedProduct, string originalProductName)
        {
            foreach (DataGridViewRow row in dataGridViewProducts.Rows)
            {
                var cellValue = row.Cells["Name"].Value;

                if (cellValue != null && cellValue.ToString() == originalProductName)
                {
                  
                    dataGridViewProducts.Rows.Remove(row);

                   
                    AddProductToGrid(updatedProduct);
                    break;
                }
            }
        }

        private void DataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            bool isRowSelected = dataGridViewProducts.SelectedRows.Count > 0;
            buttonEditProduct.Enabled = isRowSelected;
            buttonDeleteProduct.Enabled = isRowSelected;
        }

        //Boton para agregar un producto 
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            int newId = productManager.GetProducts().Count > 0 ? productManager.GetProducts().Max(p => p.Id) + 1 : 1;

            using (var productForm = new ProductEditForm())
            {
                
                productForm.SetProduct(new ProductModel(newId, "", 0, 1, "")); 

                if (productForm.ShowDialog() == DialogResult.OK)
                {
                    ProductModel newProduct = productForm.GetProduct();
                    newProduct.Id = newId;

                    if (productManager.AddProduct(newProduct))
                    {
                        MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        //Boton para editar un producto
        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0)
                return;

            foreach (DataGridViewRow selectedRow in dataGridViewProducts.SelectedRows)
            {
               
                if (selectedRow.Cells["Id"].Value == null || !int.TryParse(selectedRow.Cells["Id"].Value.ToString(), out int productId))
                {
                    MessageBox.Show("La celda de ID no contiene un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ProductModel productToEdit = productManager.GetProducts().FirstOrDefault(p => p.Id == productId);

                if (productToEdit != null)
                {
                    using (var productForm = new ProductEditForm())
                    {
                        productForm.SetProduct(productToEdit);

                        if (productForm.ShowDialog() == DialogResult.OK)
                        {
                            ProductModel updatedProduct = productForm.GetProduct();
                            updatedProduct.Id = productId; 

                            productManager.UpdateProduct(updatedProduct);
                            UpdateProductInGrid(updatedProduct, productToEdit.Name);

                            MessageBox.Show("Producto actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Producto con ID '{productId}' no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Boton para eliminar un producto
        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0)
                return;

            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow selectedRow = dataGridViewProducts.SelectedRows[0];
                int productId = (int)selectedRow.Cells["Id"].Value;

                productManager.GetProducts().RemoveAll(p => p.Id == productId);
                dataGridViewProducts.Rows.Remove(selectedRow);
                MessageBox.Show("Producto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
