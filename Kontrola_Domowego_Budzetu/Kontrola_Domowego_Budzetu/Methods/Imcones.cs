using Kontrola_Domowego_Budzetu.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrola_Domowego_Budzetu.Methods

{
    public class Imcones
    {
        #region WPŁATY
        public static void DisplayIncomeDB(ListView listView)
        {
            using (var context = new BCEntities())
            {
                var incomeList = context.Incomes.ToList();
                for (int i = 0; i < context.Incomes.Count(); i++)
                {
                    ListViewItem item = new ListViewItem(incomeList[i].IncomeId.ToString());
                    item.SubItems.Add(incomeList[i].Name);
                    item.SubItems.Add(Math.Round(Convert.ToDecimal(incomeList[i].Value), 2) + "zł");
                    item.SubItems.Add(Convert.ToDateTime(incomeList[i].Date).ToString("yyyy-MM-dd"));
                    item.SubItems.Add(incomeList[i].Description);
                    listView.Items.Add(item);
                }
                context.SaveChanges();
            }
        }
        public static void ColumnsListViewIncome(ListView listView)
        {
            listView.Columns.Add("ID:", 40);
            listView.Columns.Add("Imię:", 70);
            listView.Columns.Add("Kwota:", 80);
            listView.Columns.Add("Data", 80);
            listView.Columns.Add("Opis:", -2);
            listView.GridLines = true;
        }
        public static void CleanListViewIncome(ListView listView)
        {
            listView.Clear();
        }
        public static void AddIncomeDB(TextBox name, TextBox value, RichTextBox Description)
        {
            using (var context = new BCEntities())
            {
                var item = new Income
                {
                    Name = name.Text,
                    Value = Convert.ToDecimal(value.Text),
                    Description = Description.Text,
                    Date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"))
                };
                context.Incomes.Add(item);
                context.SaveChanges();
            }
        }
        public static void RemoveIncomeDB(ListView listView)
        {
            using (var context = new BCEntities())
            {
                if (listView.SelectedItems.Count > 0)
                {
                    int i = listView.SelectedIndices[0];
                    string removeTest = listView.Items[i].Text;
                    int removeDB = int.Parse(removeTest);
                    listView.Items.Remove(listView.Items[i]);
                    context.Incomes.Remove(context.Incomes.First(x => x.IncomeId == removeDB));
                    context.SaveChanges();
                }
                else
                {
                    string message = "Musi być zaznaczone conajmniej 1 wiersz.";
                    string title = "Błąd usuwania";
                    DialogResult popUp;
                    popUp = MessageBox.Show(message, title);
                }
            }
        }
        public static void SumIncome(Label lblBudget)
        {
            using (var context = new BCEntities())
            {
                decimal? suma = 0;
                var listOfIncomes = context.Incomes.ToList();
                foreach (var item in listOfIncomes)
                {
                    suma = suma + item.Value;
                }
                lblBudget.Text = Math.Round(Convert.ToDecimal(suma), 2).ToString() + "zł";
                context.SaveChanges();
            }
        }
        #endregion
    }
}
