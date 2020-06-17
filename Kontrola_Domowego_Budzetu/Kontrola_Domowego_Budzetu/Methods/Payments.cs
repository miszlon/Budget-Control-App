using Kontrola_Domowego_Budzetu.DataBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrola_Domowego_Budzetu.Methods
{
    
    public class Payments
    {
        public static void ComboBoxTitleElements(ComboBox title)
        {
            string[] titles =
            {
                "Zakupy spożywcze",
                "Odzież",
                "RTV/AGD",
                "Rachunki",
                "Inne"
            };
            title.Items.AddRange(titles);
        }
        public static void ColumnsListViewPayment(ListView listViewPayment)
        {
            listViewPayment.Columns.Add("ID:", 40);
            listViewPayment.Columns.Add("Tytuł:", 105);
            listViewPayment.Columns.Add("Kwota:", 80);
            listViewPayment.Columns.Add("Kupujący:", 60);
            listViewPayment.Columns.Add("Sklep:", 80);
            listViewPayment.Columns.Add("Data zakupu:", 90);
            listViewPayment.Columns.Add("Data płatności:", 90);
            listViewPayment.Columns.Add("Nr faktury:", 80);
            listViewPayment.Columns.Add("Opis:", -2);
            listViewPayment.GridLines = true;
        }
        public static void CleanListViewPayment(ListView listViewPayment)
        {
            listViewPayment.Clear();
        }
        public static void AddPaymentDB(RichTextBox description, TextBox shopName,
            TextBox invoiceNo, TextBox buyerName, Label paymentDate, Label purchaseDay, ComboBox title, Label filePath, TextBox price, string image)
        {
            if (image != "")//With image
            {
                FileStream stream = new FileStream(image, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                using (var context = new BCEntities())
                {
                    var newPayment = new Payment
                    {
                        Description = description.Text,
                        ShopName = shopName.Text,
                        InvoiceNo = invoiceNo.Text,
                        BuyerName = buyerName.Text,
                        PaymentDay = Convert.ToDateTime(paymentDate.Text),
                        PurchaseDate = Convert.ToDateTime(purchaseDay.Text),
                        Title = title.Text,
                        Price = Convert.ToDecimal(price.Text),
                        Scan = brs.ReadBytes((int)stream.Length)
                    };
                    context.Payments.Add(newPayment);
                    context.SaveChanges();
                }
            }
            else //Without image
            {
                using (var context = new BCEntities())
                {
                    var newPayment = new Payment
                    {
                        Description = description.Text,
                        ShopName = shopName.Text,
                        InvoiceNo = invoiceNo.Text,
                        BuyerName = buyerName.Text,
                        PaymentDay = Convert.ToDateTime(paymentDate.Text),
                        PurchaseDate = Convert.ToDateTime(purchaseDay.Text),
                        Title = title.Text,
                        Price = Convert.ToDecimal(price.Text)
                    };
                    context.Payments.Add(newPayment);
                    context.SaveChanges();
                }
            }
        }
        public static void DisplayPaymentDB(ListView listViePayment)
        {
            using (var context = new BCEntities())
            {
                var purchaseList = context.Payments.ToList();

                for (int i = 0; i < purchaseList.Count; i++)
                {
                    ListViewItem item = new ListViewItem(purchaseList[i].PaymentId.ToString());
                    item.SubItems.Add(purchaseList[i].Title);
                    item.SubItems.Add(Math.Round(Convert.ToDecimal(purchaseList[i].Price), 2).ToString());
                    item.SubItems.Add(purchaseList[i].BuyerName);
                    item.SubItems.Add(purchaseList[i].ShopName);
                    item.SubItems.Add(Convert.ToDateTime(purchaseList[i].PurchaseDate).ToString("yyyy-MM-dd"));
                    item.SubItems.Add(Convert.ToDateTime(purchaseList[i].PaymentDay).ToString("yyyy-MM-dd"));
                    item.SubItems.Add(purchaseList[i].InvoiceNo);
                    item.SubItems.Add(purchaseList[i].Description);
                    listViePayment.Items.Add(item);
                }
                context.SaveChanges();
            }
        }
        public static void RemovePaymentDB(ListView listViewPayment)
        {
            using (var context = new BCEntities())
            {
                if (listViewPayment.SelectedItems.Count > 0)
                {
                    int i = listViewPayment.SelectedIndices[0];
                    string remove = listViewPayment.Items[i].Text;
                    int removeDb = int.Parse(remove);
                    listViewPayment.Items.Remove(listViewPayment.Items[i]);
                    context.Payments.Remove(context.Payments.First(x => x.PaymentId == removeDb));

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
        public static void CalendarDisplay(MonthCalendar calendar)
        {
            if (calendar.Visible == false)
                calendar.Visible = true;
        }
        public static string ChooseDay(MonthCalendar calendar, Label label)
        {
            calendar.Visible = false;
            return label.Text = calendar.SelectionStart.ToString("yyyy-MM-dd");
        }
        public static int SelectedItem(ListView listViewPayment)
        {
            int itemIndex = listViewPayment.SelectedIndices[0];
            return itemIndex;
        }
    }
}
