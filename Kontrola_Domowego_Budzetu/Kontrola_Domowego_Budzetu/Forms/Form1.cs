using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kontrola_Domowego_Budzetu.Forms;
using Kontrola_Domowego_Budzetu.Methods;

namespace Kontrola_Domowego_Budzetu
{

    public partial class Form1 : Form
    {
        
        Summary sumarry = new Summary();
        ShoppingList shoppingList = new ShoppingList();
        FormAddShoppingList formAddShoppingList = new FormAddShoppingList();
        FormPaymentDetails1 formDetails = new FormPaymentDetails1();
        Label label = new Label();
        public Form1()
        {
            InitializeComponent();
        }
        public static string userLogin;
        public void GetName(string login)
        {
            userLogin = login;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Imcones.ColumnsListViewIncome(listViewIncome);
            Imcones.DisplayIncomeDB(listViewIncome);
            Payments.ColumnsListViewPayment(listViewPayment);
            Payments.DisplayPaymentDB(listViewPayment);
            Payments.ComboBoxTitleElements(comBoxTitle);
            ShoppingList.ColumnsShoppingList(listViewShoppingList);
            ShoppingList.DisplayShoppingList(listViewShoppingList);
            Summary.IncomeDisplayThree(lblIncomeName1, lblIncomeName2, lblIncomeName3, lblIncomeData1, lblIncomeData2, lblIncomeData3, lblIncomeValue1, lblIncomeValue2, lblIncomeValue3);
            Summary.PaymentDisplayThree(lblPaymentName1, lblPaymentName2, lblPaymentName3, lblPaymentDate1, lblPaymentDate2, lblPaymentDate3, lblPaymentValue1, lblPaymentValue2, lblPaymentValue3);
            Summary.IncomeDisplayPeriod(lblIncomeMonth, lblIncomeYear, lblIncomeAll);
            Summary.PaymentDisplayPeriod(lblPaymentMonth, lblPaymentYear, lblPaymentAll);
            lblLoggedUser.Text = userLogin;
            txtName.Text = userLogin;
            txtBuyerName.Text = userLogin;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            Imcones.SumIncome(lblBudget);
            Summary.MoneyToSpend(lblPaymentValue1, lblIncomeValue1, lblMoneyToSpend);
        }
        #region TAB WPŁATY

        private void btnDodajKwote_Click(object sender, EventArgs e)
        {
            Imcones.AddIncomeDB(txtName, txtIncome, txtDescription);
            Imcones.CleanListViewIncome(listViewIncome);
            Imcones.ColumnsListViewIncome(listViewIncome);
            Imcones.DisplayIncomeDB(listViewIncome);
            txtDescription.Clear();
            txtIncome.Clear();
            txtName.Clear();
            Summary.IncomeDisplayThree(lblIncomeName1, lblIncomeName2, lblIncomeName3, lblIncomeData1, lblIncomeData2, lblIncomeData3, lblIncomeValue1, lblIncomeValue2, lblIncomeValue3);
            Summary.IncomeDisplayPeriod(lblIncomeMonth, lblIncomeYear, lblIncomeAll);
        }
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            Imcones.RemoveIncomeDB(listViewIncome);
        }
        #endregion

        #region TAB WYDATKI
        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            Payments.AddPaymentDB(txtPaymentDescription, txtShopName,
                txtBillNo, txtBuyerName, lblPaymentDate, lblPurchaseDate, comBoxTitle, lblBillFile, txtPrice, lblBillFile.Text);
            Payments.CleanListViewPayment(listViewPayment);
            Payments.ColumnsListViewPayment(listViewPayment);
            Payments.DisplayPaymentDB(listViewPayment);
            Summary.PaymentDisplayThree(lblPaymentName1, lblPaymentName2, lblPaymentName3, lblPaymentDate1, lblPaymentDate2, lblPaymentDate3, lblPaymentValue1, lblPaymentValue2, lblPaymentValue3);
            Summary.PaymentDisplayPeriod(lblPaymentMonth, lblPaymentYear, lblPaymentAll);
            txtPaymentDescription.Clear();
            txtShopName.Clear();
            txtBillNo.Clear();
            txtBuyerName.Clear();
            lblPaymentDate.Refresh();
            lblPurchaseDate.Refresh();
            comBoxTitle.Refresh();
            lblBillFile.Refresh();
            txtPrice.Clear();
        }

        private void btnRemovePayment_Click(object sender, EventArgs e)
        {
            Payments.RemovePaymentDB(listViewPayment);
            Payments.CleanListViewPayment(listViewPayment);
            Payments.ColumnsListViewPayment(listViewPayment);
            Payments.DisplayPaymentDB(listViewPayment);
        }
        private void lblPaymentDate_Click(object sender, EventArgs e)
        {
            Payments.CalendarDisplay(CalChooseDay);
            label = lblPaymentDate;
        }

        private void lblPurchaseDate_Click(object sender, EventArgs e)
        {
            Payments.CalendarDisplay(CalChooseDay);
            label = lblPurchaseDate;

        }

        private void CalChooseDay_DateChanged(object sender, DateRangeEventArgs e)
        {
            Payments.ChooseDay(CalChooseDay, label);
        }
        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                lblBillFile.Text = openFileDialog1.FileName;
        }
        private void btnPaymentDetails_Click(object sender, EventArgs e)
        {
            if (listViewPayment.SelectedItems.Count > 0)
            {
                formDetails.Update(listViewPayment);
                formDetails.ShowDialog();
            }
            else
            {
                string wiadomosc = "Nie wybrano żadnego elementu.";
                string title = "Error";
                DialogResult popUp;
                popUp = MessageBox.Show(wiadomosc, title);
            }
        }
        #endregion
        #region TAB LISTA ZAKUPÓW
        private void btnDeleteShoppingList_Click(object sender, EventArgs e)
        {
            ShoppingList.DeleteShoppingListItem(listViewShoppingList);
            ShoppingList.ClearShoppingList(listViewShoppingList);
            ShoppingList.ColumnsShoppingList(listViewShoppingList);
            ShoppingList.DisplayShoppingList(listViewShoppingList);
        }

        private void btnNewShoppingList_Click(object sender, EventArgs e)
        {
            formAddShoppingList.EnableButtons();
            formAddShoppingList.ShowDialog();
            formAddShoppingList.GetShoppingListData(listViewShoppingList);
        }
        private void btnDetailsShoppingList_Click(object sender, EventArgs e)
        {
            formAddShoppingList.DisableButtons();
            formAddShoppingList.ClearList();
            formAddShoppingList.DisplayListFromDb(listViewShoppingList);
            formAddShoppingList.ShowDialog();
        }
        #endregion
    }
}

