namespace StoreProductManager
{
    partial class ProductEditForm
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
            labelTitle = new Label();
            labelName = new Label();
            labelPrice = new Label();
            labelQuantity = new Label();
            labelCategory = new Label();
            textBoxName = new TextBox();
            numericUpDownPrice = new NumericUpDown();
            numericUpDownQuantity = new NumericUpDown();
            comboBoxCategory = new ComboBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(333, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(97, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Productos";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(232, 94);
            labelName.Name = "labelName";
            labelName.Size = new Size(51, 15);
            labelName.TabIndex = 1;
            labelName.Text = "Nombre";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(232, 149);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(40, 15);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "Precio";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(232, 209);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(55, 15);
            labelQuantity.TabIndex = 3;
            labelQuantity.Text = "Cantidad";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(232, 259);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(58, 15);
            labelCategory.TabIndex = 4;
            labelCategory.Text = "Categoria";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(307, 91);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(210, 23);
            textBoxName.TabIndex = 5;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(307, 150);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(210, 23);
            numericUpDownPrice.TabIndex = 6;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(307, 209);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(210, 23);
            numericUpDownQuantity.TabIndex = 7;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(307, 259);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(210, 23);
            comboBoxCategory.TabIndex = 8;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(292, 364);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Guardar";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(421, 364);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // ProductEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxCategory);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(numericUpDownPrice);
            Controls.Add(textBoxName);
            Controls.Add(labelCategory);
            Controls.Add(labelQuantity);
            Controls.Add(labelPrice);
            Controls.Add(labelName);
            Controls.Add(labelTitle);
            Name = "ProductEditForm";
            Text = "ProductEditForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Label labelName;
        private Label labelPrice;
        private Label labelQuantity;
        private Label labelCategory;
        private TextBox textBoxName;
        private NumericUpDown numericUpDownPrice;
        private NumericUpDown numericUpDownQuantity;
        private ComboBox comboBoxCategory;
        private Button buttonSave;
        private Button buttonCancel;
    }
}