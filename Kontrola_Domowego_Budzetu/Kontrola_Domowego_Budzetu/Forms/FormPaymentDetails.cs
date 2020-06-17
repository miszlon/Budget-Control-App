using Kontrola_Domowego_Budzetu.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kontrola_Domowego_Budzetu.Methods;


namespace Kontrola_Domowego_Budzetu
{
    public partial class FormPaymentDetails1 : Form
    {
        int selectedIndex = 0;
        bool buttonsEdit;
        int clickCount = 0;
        #region BUTTONS % LABELS % TEXT LISTS
        public FormPaymentDetails1()
        {
            InitializeComponent();
            PaymentDetails.ButtonsEditEnabled(ButtonsPayment(), LabelsPayment(), TextBoxesPayment(), 
                RichTextBoxesPayment(), ComboBoxPayment(), buttonsEdit = false); ;
            Payments.ComboBoxTitleElements(comBoxTitle);
        }
        private List<Button> ButtonsPayment()
        {
            List<Button> buttonsPayment = this.Controls.OfType<Button>().Where(x => x.Name.StartsWith("btn")).ToList();
            return buttonsPayment;
        }
        private List<Label> LabelsPayment()
        {
            List<Label> labelsPayment = this.Controls.OfType<Label>().Where(x => x.Name.StartsWith("lbl")).Where(x => x.Name.EndsWith("Date")).ToList();
            return labelsPayment;
        }
        private List<TextBox> TextBoxesPayment()
        {
            List<TextBox> textBoxesPayment = this.Controls.OfType<TextBox>().Where(x => x.Name.StartsWith("txt")).ToList();
            return textBoxesPayment;
        }
        private List<RichTextBox> RichTextBoxesPayment()
        {
            List<RichTextBox> richTextBoxes = this.Controls.OfType<RichTextBox>().Where(x => x.Name.StartsWith("richTxt")).ToList();
            return richTextBoxes;
        }
        private List<ComboBox> ComboBoxPayment()
        {
            List<ComboBox> ComboBoxPayment = this.Controls.OfType<ComboBox>().Where(x => x.Name.StartsWith("comBox")).ToList();
            return ComboBoxPayment;
        }
        #endregion
        ListView lista = new ListView();
        Label label = new Label();
        public void Update(ListView listViewPayment)
        {
            lista = listViewPayment;
            int i = listViewPayment.SelectedIndices[0];
            selectedIndex = i;
            using (var context = new BCEntities())
            {
                List<Button> buttons = this.Controls.OfType<Button>().Where(a => a.Name.StartsWith("btn")).ToList();
                var paymentList = context.Payments.ToList();
                comBoxTitle.Text = paymentList[i].Title;
                txtPrice.Text = Math.Round(Convert.ToDecimal(paymentList[i].Price), 2).ToString();
                txtBuyerName.Text = paymentList[i].BuyerName;
                txtShopName.Text = paymentList[i].ShopName;
                richTxtPaymentDescription.Text = paymentList[i].Description;
                lblPaymentDate.Text = paymentList[i].PaymentDay.ToString();
                lblPurchaseDate.Text = paymentList[i].PurchaseDate.ToString();
                txtBillNo.Text = paymentList[i].InvoiceNo;
                if (paymentList[i].Scan != null)
                    pbxBillScan.Image = PaymentDetails.ConvertBinaryToImage(paymentList[i].Scan);
                else pbxBillScan.Image = null;
            }
        }

        private void btnEnableEdit_Click(object sender, EventArgs e)
        {
            if (clickCount == 0)
            {
                PaymentDetails.ButtonsEditEnabled(ButtonsPayment(), LabelsPayment(), TextBoxesPayment(), 
                    RichTextBoxesPayment(), ComboBoxPayment(), buttonsEdit = true);
                clickCount = 1;
                specBtnEnableEdit.Text = "Wyłącz edycję";
            }
            else
            {
                PaymentDetails.ButtonsEditEnabled(ButtonsPayment(), LabelsPayment(), TextBoxesPayment(), 
                    RichTextBoxesPayment(), ComboBoxPayment(), buttonsEdit = false);
                clickCount = 0;
                specBtnEnableEdit.Text = "Włącz edycję";
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            PaymentDetails.UpdatePaymentDB(richTxtPaymentDescription, txtShopName, txtBillNo, txtBuyerName, 
                lblPaymentDate, lblPurchaseDate, comBoxTitle, lblBillFile, txtPrice, lblBillFile.Text, selectedIndex);
            this.Close();
        }

        private void FormPaymentDetails1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Payments.CleanListViewPayment(lista);
            Payments.ColumnsListViewPayment(lista);
            Payments.DisplayPaymentDB(lista);
            PaymentDetails.ButtonsEditEnabled(ButtonsPayment(), LabelsPayment(), TextBoxesPayment(), 
                RichTextBoxesPayment(), ComboBoxPayment(), buttonsEdit = false);
            clickCount = 0;
            specBtnEnableEdit.Text = "Włącz edycję";
        }

        private void lblPaymentDate_Click(object sender, EventArgs e)
        {
            
            Payments.CalendarDisplay(calPaymentEdit);
            label = lblPaymentDate;
        }

        private void lblPurchaseDate_Click(object sender, EventArgs e)
        {
            Payments.CalendarDisplay(calPaymentEdit);
            label = lblPurchaseDate;
        }

        private void calPaymentEdit_DateChanged(object sender, DateRangeEventArgs e)
        {
            Payments.ChooseDay(calPaymentEdit, label);
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                lblBillFile.Text = openFileDialog1.FileName;
            pbxBillScan.Image = new Bitmap(openFileDialog1.FileName);
        }
    }
}
