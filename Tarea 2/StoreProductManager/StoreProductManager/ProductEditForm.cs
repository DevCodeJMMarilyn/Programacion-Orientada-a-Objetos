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
    public partial class ProductEditForm : Form
    {
        private ProductModel currentProduct;
        public ProductEditForm()
        {
            InitializeComponent();
            LoadCategories();
            ConfigureControl();

            
        }
        private void LoadCategories()
        {
            comboBoxCategory.Items.AddRange(new string[]
            {
            "Electrónica",
            "Ropa",
            "Alimentos",
            "Muebles"
            });
        }
        private void ConfigureControl()
        {
            numericUpDownPrice.DecimalPlaces = 2;  
            numericUpDownPrice.Increment = 0.01m;  
            numericUpDownPrice.Maximum = 10000;


            numericUpDownQuantity.Minimum = 1;
            numericUpDownQuantity.Maximum = 10000;
            numericUpDownQuantity.Increment = 1;
        }
        public void SetProduct(ProductModel product)
        {
            currentProduct = product;

            textBoxName.Text = product.Name;
            numericUpDownPrice.Value = product.Price;

            try
            {
                numericUpDownQuantity.Value = Math.Max(numericUpDownQuantity.Minimum, Math.Min(numericUpDownQuantity.Maximum, product.Quantity));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Error al establecer la cantidad: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDownQuantity.Value = numericUpDownQuantity.Minimum;
            }

            comboBoxCategory.SelectedItem = product.Category; 
        }

        public ProductModel GetProduct()
        {
            if (currentProduct == null)
            {
                throw new InvalidOperationException("El producto no está establecido.");
            }

            return new ProductModel(
                currentProduct.Id,
                textBoxName.Text,
                numericUpDownPrice.Value,
                (int)numericUpDownQuantity.Value,
                comboBoxCategory.SelectedItem?.ToString()
            );
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("El nombre del producto no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxCategory.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

