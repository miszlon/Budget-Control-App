namespace Kontrola_Domowego_Budzetu
{
    partial class FormPaymentDetails1
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
            this.components = new System.ComponentModel.Container();
            this.lblTitleText = new System.Windows.Forms.Label();
            this.lblDescriptionText = new System.Windows.Forms.Label();
            this.lblScanText = new System.Windows.Forms.Label();
            this.lblPurchaseDateText = new System.Windows.Forms.Label();
            this.lblBuyerNameText = new System.Windows.Forms.Label();
            this.lblPriceText = new System.Windows.Forms.Label();
            this.txtBuyerName = new System.Windows.Forms.TextBox();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.lblShopNameText = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.comBoxTitle = new System.Windows.Forms.ComboBox();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.lblBillNoText = new System.Windows.Forms.Label();
            this.richTxtPaymentDescription = new System.Windows.Forms.RichTextBox();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.lblPaymentDateText = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.lblCurrencyText = new System.Windows.Forms.Label();
            this.lblBillFile = new System.Windows.Forms.Label();
            this.pbxBillScan = new System.Windows.Forms.PictureBox();
            this.specBtnEnableEdit = new System.Windows.Forms.Button();
            this.specBtnSaveChanges = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.calPaymentEdit = new System.Windows.Forms.MonthCalendar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBillScan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleText
            // 
            this.lblTitleText.AutoSize = true;
            this.lblTitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitleText.Location = new System.Drawing.Point(12, 9);
            this.lblTitleText.Name = "lblTitleText";
            this.lblTitleText.Size = new System.Drawing.Size(49, 18);
            this.lblTitleText.TabIndex = 21;
            this.lblTitleText.Text = "Tytuł:";
            // 
            // lblDescriptionText
            // 
            this.lblDescriptionText.AutoSize = true;
            this.lblDescriptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDescriptionText.Location = new System.Drawing.Point(12, 450);
            this.lblDescriptionText.Name = "lblDescriptionText";
            this.lblDescriptionText.Size = new System.Drawing.Size(95, 18);
            this.lblDescriptionText.TabIndex = 22;
            this.lblDescriptionText.Text = "Krótki opis:";
            // 
            // lblScanText
            // 
            this.lblScanText.AutoSize = true;
            this.lblScanText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblScanText.Location = new System.Drawing.Point(12, 553);
            this.lblScanText.Name = "lblScanText";
            this.lblScanText.Size = new System.Drawing.Size(110, 18);
            this.lblScanText.TabIndex = 23;
            this.lblScanText.Text = "Zdjęcie/Skan:";
            // 
            // lblPurchaseDateText
            // 
            this.lblPurchaseDateText.AutoSize = true;
            this.lblPurchaseDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPurchaseDateText.Location = new System.Drawing.Point(12, 264);
            this.lblPurchaseDateText.Name = "lblPurchaseDateText";
            this.lblPurchaseDateText.Size = new System.Drawing.Size(107, 18);
            this.lblPurchaseDateText.TabIndex = 25;
            this.lblPurchaseDateText.Text = "Data zakupu:";
            // 
            // lblBuyerNameText
            // 
            this.lblBuyerNameText.AutoSize = true;
            this.lblBuyerNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBuyerNameText.Location = new System.Drawing.Point(12, 137);
            this.lblBuyerNameText.Name = "lblBuyerNameText";
            this.lblBuyerNameText.Size = new System.Drawing.Size(135, 18);
            this.lblBuyerNameText.TabIndex = 30;
            this.lblBuyerNameText.Text = "Imię kupującego:";
            // 
            // lblPriceText
            // 
            this.lblPriceText.AutoSize = true;
            this.lblPriceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPriceText.Location = new System.Drawing.Point(12, 74);
            this.lblPriceText.Name = "lblPriceText";
            this.lblPriceText.Size = new System.Drawing.Size(60, 18);
            this.lblPriceText.TabIndex = 26;
            this.lblPriceText.Text = "Kwota:";
            // 
            // txtBuyerName
            // 
            this.txtBuyerName.Location = new System.Drawing.Point(15, 158);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.Size = new System.Drawing.Size(132, 22);
            this.txtBuyerName.TabIndex = 33;
            // 
            // txtBillNo
            // 
            this.txtBillNo.Location = new System.Drawing.Point(15, 399);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(157, 22);
            this.txtBillNo.TabIndex = 32;
            // 
            // lblShopNameText
            // 
            this.lblShopNameText.AutoSize = true;
            this.lblShopNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblShopNameText.Location = new System.Drawing.Point(12, 201);
            this.lblShopNameText.Name = "lblShopNameText";
            this.lblShopNameText.Size = new System.Drawing.Size(118, 18);
            this.lblShopNameText.TabIndex = 27;
            this.lblShopNameText.Text = "Nazwa sklepu:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(15, 95);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(85, 22);
            this.txtPrice.TabIndex = 34;
            // 
            // comBoxTitle
            // 
            this.comBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comBoxTitle.FormattingEnabled = true;
            this.comBoxTitle.Location = new System.Drawing.Point(15, 30);
            this.comBoxTitle.Name = "comBoxTitle";
            this.comBoxTitle.Size = new System.Drawing.Size(182, 23);
            this.comBoxTitle.TabIndex = 38;
            // 
            // txtShopName
            // 
            this.txtShopName.Location = new System.Drawing.Point(15, 222);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(115, 22);
            this.txtShopName.TabIndex = 31;
            // 
            // lblBillNoText
            // 
            this.lblBillNoText.AutoSize = true;
            this.lblBillNoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBillNoText.Location = new System.Drawing.Point(12, 378);
            this.lblBillNoText.Name = "lblBillNoText";
            this.lblBillNoText.Size = new System.Drawing.Size(162, 18);
            this.lblBillNoText.TabIndex = 28;
            this.lblBillNoText.Text = "Nr paragonu/faktury:";
            // 
            // richTxtPaymentDescription
            // 
            this.richTxtPaymentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTxtPaymentDescription.Location = new System.Drawing.Point(15, 471);
            this.richTxtPaymentDescription.Name = "richTxtPaymentDescription";
            this.richTxtPaymentDescription.Size = new System.Drawing.Size(456, 61);
            this.richTxtPaymentDescription.TabIndex = 35;
            this.richTxtPaymentDescription.Text = "";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(12, 340);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(103, 17);
            this.lblPaymentDate.TabIndex = 37;
            this.lblPaymentDate.Text = "Wybierz datę...";
            this.lblPaymentDate.Click += new System.EventHandler(this.lblPaymentDate_Click);
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Location = new System.Drawing.Point(12, 282);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(103, 17);
            this.lblPurchaseDate.TabIndex = 36;
            this.lblPurchaseDate.Text = "Wybierz datę...";
            this.lblPurchaseDate.Click += new System.EventHandler(this.lblPurchaseDate_Click);
            // 
            // lblPaymentDateText
            // 
            this.lblPaymentDateText.AutoSize = true;
            this.lblPaymentDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPaymentDateText.Location = new System.Drawing.Point(12, 322);
            this.lblPaymentDateText.Name = "lblPaymentDateText";
            this.lblPaymentDateText.Size = new System.Drawing.Size(121, 18);
            this.lblPaymentDateText.TabIndex = 29;
            this.lblPaymentDateText.Text = "Data płatności:";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(15, 574);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(107, 24);
            this.btnChooseFile.TabIndex = 42;
            this.btnChooseFile.Text = "Wybierz plik:";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // lblCurrencyText
            // 
            this.lblCurrencyText.AutoSize = true;
            this.lblCurrencyText.Location = new System.Drawing.Point(104, 98);
            this.lblCurrencyText.Name = "lblCurrencyText";
            this.lblCurrencyText.Size = new System.Drawing.Size(18, 17);
            this.lblCurrencyText.TabIndex = 24;
            this.lblCurrencyText.Text = "zł";
            // 
            // lblBillFile
            // 
            this.lblBillFile.Location = new System.Drawing.Point(128, 574);
            this.lblBillFile.Name = "lblBillFile";
            this.lblBillFile.Size = new System.Drawing.Size(58, 27);
            this.lblBillFile.TabIndex = 40;
            this.lblBillFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxBillScan
            // 
            this.pbxBillScan.Location = new System.Drawing.Point(519, 9);
            this.pbxBillScan.Name = "pbxBillScan";
            this.pbxBillScan.Size = new System.Drawing.Size(554, 600);
            this.pbxBillScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxBillScan.TabIndex = 43;
            this.pbxBillScan.TabStop = false;
            // 
            // specBtnEnableEdit
            // 
            this.specBtnEnableEdit.AutoSize = true;
            this.specBtnEnableEdit.Location = new System.Drawing.Point(399, 656);
            this.specBtnEnableEdit.Name = "specBtnEnableEdit";
            this.specBtnEnableEdit.Size = new System.Drawing.Size(101, 27);
            this.specBtnEnableEdit.TabIndex = 44;
            this.specBtnEnableEdit.Text = "Włącz edycje";
            this.specBtnEnableEdit.UseVisualStyleBackColor = true;
            this.specBtnEnableEdit.Click += new System.EventHandler(this.btnEnableEdit_Click);
            // 
            // specBtnSaveChanges
            // 
            this.specBtnSaveChanges.AutoSize = true;
            this.specBtnSaveChanges.Location = new System.Drawing.Point(533, 656);
            this.specBtnSaveChanges.Name = "specBtnSaveChanges";
            this.specBtnSaveChanges.Size = new System.Drawing.Size(108, 27);
            this.specBtnSaveChanges.TabIndex = 45;
            this.specBtnSaveChanges.Text = "Zapisz zmiany";
            this.specBtnSaveChanges.UseVisualStyleBackColor = true;
            this.specBtnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // calPaymentEdit
            // 
            this.calPaymentEdit.Location = new System.Drawing.Point(146, 322);
            this.calPaymentEdit.MaxSelectionCount = 1;
            this.calPaymentEdit.Name = "calPaymentEdit";
            this.calPaymentEdit.TabIndex = 46;
            this.calPaymentEdit.Visible = false;
            this.calPaymentEdit.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calPaymentEdit_DateChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormPaymentDetails1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 691);
            this.Controls.Add(this.calPaymentEdit);
            this.Controls.Add(this.specBtnSaveChanges);
            this.Controls.Add(this.specBtnEnableEdit);
            this.Controls.Add(this.pbxBillScan);
            this.Controls.Add(this.lblBillFile);
            this.Controls.Add(this.lblTitleText);
            this.Controls.Add(this.lblCurrencyText);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.lblShopNameText);
            this.Controls.Add(this.comBoxTitle);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.lblScanText);
            this.Controls.Add(this.lblPaymentDateText);
            this.Controls.Add(this.lblDescriptionText);
            this.Controls.Add(this.txtShopName);
            this.Controls.Add(this.txtBuyerName);
            this.Controls.Add(this.richTxtPaymentDescription);
            this.Controls.Add(this.lblBuyerNameText);
            this.Controls.Add(this.lblPriceText);
            this.Controls.Add(this.lblBillNoText);
            this.Controls.Add(this.lblPurchaseDateText);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtBillNo);
            this.Name = "FormPaymentDetails1";
            this.Text = "FormPaymentDetails";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPaymentDetails1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBillScan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitleText;
        private System.Windows.Forms.Label lblDescriptionText;
        private System.Windows.Forms.Label lblScanText;
        private System.Windows.Forms.Label lblPurchaseDateText;
        private System.Windows.Forms.Label lblBuyerNameText;
        private System.Windows.Forms.Label lblPriceText;
        private System.Windows.Forms.TextBox txtBuyerName;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label lblShopNameText;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox comBoxTitle;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.Label lblBillNoText;
        private System.Windows.Forms.RichTextBox richTxtPaymentDescription;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Label lblPaymentDateText;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label lblCurrencyText;
        private System.Windows.Forms.Label lblBillFile;
        private System.Windows.Forms.PictureBox pbxBillScan;
        private System.Windows.Forms.Button specBtnEnableEdit;
        private System.Windows.Forms.Button specBtnSaveChanges;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MonthCalendar calPaymentEdit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}