using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kontrola_Domowego_Budzetu.DataBase;

namespace Kontrola_Domowego_Budzetu.Methods
{
    public class ShoppingList
    {
        public static void ClearTextBox(TextBox textBox)
        {
            textBox.Clear();
        }
        
        public static void ColumnsShoppingList(ListView listViewShoppingList)
        {
            listViewShoppingList.Columns.Add("Nazwa listy:", 100);
            listViewShoppingList.Columns.Add("Ilość produktów:", 80);
            listViewShoppingList.GridLines = true;
        }

        public static void AddProductToList(ListBox shoppingList, TextBox product)
        {
            if (product.Text != "")
                shoppingList.Items.Add(product.Text); ClearTextBox(product);
        }

        public static void DeleteProductFromList(ListBox shoppingList)
        {
            shoppingList.Items.Remove(shoppingList.SelectedItem);
        }

        public static void AddShoppingListDB(ListBox shoppingList, TextBox txtListName, TextBox txtProduct)
        {
            using (var context = new BCEntities())
            {
                for (int i = 0; i < shoppingList.Items.Count; i++)
                {
                    var newShoppingList = new DataBase.ShoppingList()
                    {
                        ParentCategory = txtListName.Text,
                        Product = shoppingList.Items[i].ToString()
                    };
                    context.ShoppingLists.Add(newShoppingList);
                    context.SaveChanges();
                }
            };
        }

        public static void DisplayShoppingList(ListView shoppingList)
        {
            using (var context = new BCEntities())
            {
                var shoppingListDb = context.ShoppingLists.ToList();
                var listName = shoppingListDb.GroupBy(x => x.ParentCategory).Select(a => new { parentCategory = a.Key, count = a.Count() }).ToList();

                for (int i = 0; i < listName.Count; i++)
                {
                    ListViewItem listViewItem = new ListViewItem(listName[i].parentCategory);
                    listViewItem.SubItems.Add(listName[i].count.ToString());
                    shoppingList.Items.Add(listViewItem);
                }
                context.SaveChanges();
            }
        }

        public static void ClearShoppingList(ListView shoppingList)
        {
            shoppingList.Clear();
        }
        public static void DeleteShoppingListItem(ListView shoppingList)
        {
            using (var context = new BCEntities())
            {
                string test = shoppingList.SelectedItems[0].Text;
                var lista = context.ShoppingLists.Where(x => x.ParentCategory == test).ToList();

                context.ShoppingLists.RemoveRange(lista);

                context.SaveChanges();
            }
        }
        
    }
}

