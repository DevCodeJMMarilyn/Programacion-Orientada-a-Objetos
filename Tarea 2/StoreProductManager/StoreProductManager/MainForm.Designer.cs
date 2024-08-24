namespace StoreProductManager
{
    partial class MainForm
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
            dataGridViewProducts = new DataGridView();
            labelTitle = new Label();
            buttonAddProduct = new Button();
            buttonEditProduct = new Button();
            buttonDeleteProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(117, 72);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.Size = new Size(538, 150);
            dataGridViewProducts.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(288, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(183, 25);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Gestor de Productos";
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(196, 293);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(109, 23);
            buttonAddProduct.TabIndex = 4;
            buttonAddProduct.Text = "Agregar Producto";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // buttonEditProduct
            // 
            buttonEditProduct.Location = new Point(320, 293);
            buttonEditProduct.Name = "buttonEditProduct";
            buttonEditProduct.Size = new Size(98, 23);
            buttonEditProduct.TabIndex = 5;
            buttonEditProduct.Text = "Editar Producto";
            buttonEditProduct.UseVisualStyleBackColor = true;
            buttonEditProduct.Click += buttonEditProduct_Click;
            // 
            // buttonDeleteProduct
            // 
            buttonDeleteProduct.Location = new Point(433, 293);
            buttonDeleteProduct.Name = "buttonDeleteProduct";
            buttonDeleteProduct.Size = new Size(110, 23);
            buttonDeleteProduct.TabIndex = 6;
            buttonDeleteProduct.Text = "Eliminar Producto";
            buttonDeleteProduct.UseVisualStyleBackColor = true;
            buttonDeleteProduct.Click += buttonDeleteProduct_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDeleteProduct);
            Controls.Add(buttonEditProduct);
            Controls.Add(buttonAddProduct);
            Controls.Add(labelTitle);
            Controls.Add(dataGridViewProducts);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private Label labelTitle;
        private Button buttonAddProduct;
        private Button buttonEditProduct;
        private Button buttonDeleteProduct;
    }
}