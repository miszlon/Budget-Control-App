namespace Kontrola_Domowego_Budzetu.Forms
{
    partial class FormAddShoppingList
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtListName = new System.Windows.Forms.TextBox();
            this.lblListNameText = new System.Windows.Forms.Label();
            this.lblProductNameText = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnSaveShoppingList = new System.Windows.Forms.Button();
            this.listShoppingList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtListName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblListNameText, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblProductNameText, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtProductName, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnAddProduct, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnDeleteProduct, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnSaveShoppingList, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.274905F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.274902F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.274902F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.274902F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.45796F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.45796F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.45796F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.52652F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(392, 683);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txtListName
            // 
            this.txtListName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtListName.Location = new System.Drawing.Point(3, 39);
            this.txtListName.Name = "txtListName";
            this.txtListName.Size = new System.Drawing.Size(386, 22);
            this.txtListName.TabIndex = 1;
            // 
            // lblListNameText
            // 
            this.lblListNameText.AutoSize = true;
            this.lblListNameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblListNameText.Location = new System.Drawing.Point(3, 0);
            this.lblListNameText.Name = "lblListNameText";
            this.lblListNameText.Size = new System.Drawing.Size(386, 36);
            this.lblListNameText.TabIndex = 0;
            this.lblListNameText.Text = "Nazwa listy:";
            this.lblListNameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductNameText
            // 
            this.lblProductNameText.AutoSize = true;
            this.lblProductNameText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductNameText.Location = new System.Drawing.Point(3, 72);
            this.lblProductNameText.Name = "lblProductNameText";
            this.lblProductNameText.Size = new System.Drawing.Size(386, 36);
            this.lblProductNameText.TabIndex = 2;
            this.lblProductNameText.Text = "Nazwa produktu:";
            this.lblProductNameText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProductName
            // 
            this.txtProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProductName.Location = new System.Drawing.Point(3, 111);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(386, 22);
            this.txtProductName.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddProduct.Location = new System.Drawing.Point(3, 147);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(386, 79);
            this.btnAddProduct.TabIndex = 6;
            this.btnAddProduct.Text = "Dodaj produkt";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeleteProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteProduct.Location = new System.Drawing.Point(3, 232);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(386, 79);
            this.btnDeleteProduct.TabIndex = 7;
            this.btnDeleteProduct.Text = "Usuń produkt";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnSaveShoppingList
            // 
            this.btnSaveShoppingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveShoppingList.Location = new System.Drawing.Point(3, 317);
            this.btnSaveShoppingList.Name = "btnSaveShoppingList";
            this.btnSaveShoppingList.Size = new System.Drawing.Size(386, 79);
            this.btnSaveShoppingList.TabIndex = 1;
            this.btnSaveShoppingList.Text = "Zapisz listę";
            this.btnSaveShoppingList.UseVisualStyleBackColor = true;
            this.btnSaveShoppingList.Click += new System.EventHandler(this.btnSaveShoppingList_Click);
            // 
            // listShoppingList
            // 
            this.listShoppingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listShoppingList.FormattingEnabled = true;
            this.listShoppingList.ItemHeight = 16;
            this.listShoppingList.Location = new System.Drawing.Point(401, 3);
            this.listShoppingList.Name = "listShoppingList";
            this.listShoppingList.Size = new System.Drawing.Size(754, 683);
            this.listShoppingList.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.625F));
            this.tableLayoutPanel1.Controls.Add(this.listShoppingList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1158, 689);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FormAddShoppingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 689);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormAddShoppingList";
            this.Text = "AddShoppingListForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddShoppingList_FormClosed);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblListNameText;
        private System.Windows.Forms.ListBox listShoppingList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtListName;
        private System.Windows.Forms.Label lblProductNameText;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnSaveShoppingList;
        private System.Windows.Forms.Button btnDeleteProduct;
    }
}