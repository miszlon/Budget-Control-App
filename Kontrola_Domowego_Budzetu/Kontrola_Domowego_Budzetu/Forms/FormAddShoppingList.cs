using Kontrola_Domowego_Budzetu.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kontrola_Domowego_Budzetu.DataBase;

namespace Kontrola_Domowego_Budzetu.Forms
{
    public partial class FormAddShoppingList : Form
    {
        ListView shoppingList = new ListView();

        private List<Button> Buttons()
        {
            List<Button> buttonsShopListForm = this.Controls.OfType<Button>().Where(x => x.Name.StartsWith("btn")).ToList();

            return buttonsShopListForm;
        }

        private List<TextBox> TextBoxes()
        {
            List<TextBox> textBoxShopListForm = this.Controls.OfType<TextBox>().Where(x => x.Name.StartsWith("txt")).ToList();
            return textBoxShopListForm;
        }
        public void GetShoppingListData(ListView listView)
        {
            shoppingList = listView;
        }
        public FormAddShoppingList()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Methods.ShoppingList.AddProductToList(listShoppingList, txtProductName);
        }

        private void btnSaveShoppingList_Click(object sender, EventArgs e)
        {
            Methods.ShoppingList.AddShoppingListDB(listShoppingList, txtListName, txtProductName);
            this.Close();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            Methods.ShoppingList.DeleteProductFromList(listShoppingList);
        }

        private void FormAddShoppingList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Methods.ShoppingList.ClearShoppingList(shoppingList);
            Methods.ShoppingList.ColumnsShoppingList(shoppingList);
            Methods.ShoppingList.DisplayShoppingList(shoppingList);
        }

        public void EnableButtons()
        {
            //List<Button> buttonsShopListForm = this.Controls.OfType<Button>().Where(x => x.Name.StartsWith("btn")).ToList();
            //List<TextBox> textBoxShopListForm = this.Controls.OfType<TextBox>().Where(x => x.Name.StartsWith("txt")).ToList();
            //foreach (var item in buttonsShopListForm)
            //{
            //    item.Enabled = true;
            //    item.Refresh();
            //}
            //foreach (var item in textBoxShopListForm)
            //{
            //    item.Enabled = true;
            //    item.Refresh();
            //}

            btnSaveShoppingList.Enabled = true;
            btnDeleteProduct.Enabled = true;
            btnAddProduct.Enabled = true;
            txtListName.Enabled = true;
            txtProductName.Enabled = true;
        }

        public void DisableButtons()
        {

            btnSaveShoppingList.Enabled = false;
            btnDeleteProduct.Enabled = false;
            btnAddProduct.Enabled = false;
            txtListName.Enabled = false;
            txtProductName.Enabled = false;
        }

        public void DisplayListFromDb(ListView listViewShoppingList)
        {
            if (listViewShoppingList.SelectedItems.Count > 0)
            {
                using (var context = new BCEntities())
                {
                    int selectedIndex = listViewShoppingList.SelectedIndices[0];
                    string searchingFraze = listViewShoppingList.SelectedItems[0].Text;
                    var shoppingList = context.ShoppingLists.ToList();
                    string[] name = shoppingList.Where(x => x.ParentCategory == searchingFraze).Select(x => x.Product).ToArray();
                    txtListName.Text = searchingFraze;
                    listShoppingList.Items.AddRange(name);
                }
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć pozycję", "Brak zaznaczenia");
            }
        }

        public void ClearList()
        {
            listShoppingList.Items.Clear();
        }
    }
}

