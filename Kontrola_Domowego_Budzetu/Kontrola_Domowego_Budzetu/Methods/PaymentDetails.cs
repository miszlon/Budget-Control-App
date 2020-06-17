using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kontrola_Domowego_Budzetu.Methods;
using Kontrola_Domowego_Budzetu.DataBase;

namespace Kontrola_Domowego_Budzetu.Methods
{
    public class PaymentDetails
    {
        public static Image ConvertBinaryToImage(byte[] Data)
        {
            using (MemoryStream ms = new MemoryStream(Data))
                return Image.FromStream(ms);
        }
        public static void ButtonsEditEnabled(List<Button> listButton, List<Label> listLabel,List<TextBox> listTextBox, List<RichTextBox> richTextBox,List<ComboBox> listComboBox, bool enable)
        {
            if (enable == true)
            {
                foreach (var item in listButton)
                {
                    item.Enabled = true;
                }
                foreach (var item in listLabel)
                {
                    item.Enabled = true;
                }
                foreach (var item in listTextBox)
                {
                    item.Enabled = true;
                }
                foreach (var item in richTextBox)
                {
                    item.Enabled = true;
                }
                foreach (var item in listComboBox)
                {
                    item.Enabled = true;
                }
            }
            else
            {
                foreach (var item in listButton)
                {
                    item.Enabled = false;
                }
                foreach (var item in listLabel)
                {
                    item.Enabled = false;
                }
                foreach (var item in listTextBox)
                {
                    item.Enabled = false;
                }
                foreach (var item in richTextBox)
                {
                    item.Enabled = false;
                }
                foreach (var item in listComboBox)
                {
                    item.Enabled = false;
                }
            }
        }
        public static void UpdatePaymentDB(RichTextBox description, TextBox shopName,
            TextBox invoiceNo, TextBox buyerName, Label paymentDate, Label purchaseDay, ComboBox title, Label filePath, TextBox price, string image, int selectedIndex)
        {
            if (filePath.Text != "")
            {
                FileStream fs = new FileStream(filePath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                using (var context = new BCEntities())
                {
                    var paymentList = context.Payments.ToList();
                    paymentList[selectedIndex].Title = title.Text;
                    paymentList[selectedIndex].Price = Math.Round(Convert.ToDecimal(price.Text), 2);
                    paymentList[selectedIndex].BuyerName = buyerName.Text;
                    paymentList[selectedIndex].ShopName = shopName.Text;
                    paymentList[selectedIndex].Description = description.Text;
                    paymentList[selectedIndex].PurchaseDate = Convert.ToDateTime(purchaseDay.Text);
                    paymentList[selectedIndex].InvoiceNo = invoiceNo.Text;
                    paymentList[selectedIndex].PaymentDay = Convert.ToDateTime(paymentDate.Text);
                    paymentList[selectedIndex].Scan = br.ReadBytes((int)fs.Length);

                    context.SaveChanges();
                }
            }
            else
            {
                using (var context = new BCEntities())
                {
                    var paymentList = context.Payments.ToList();
                    paymentList[selectedIndex].Title = title.Text;
                    paymentList[selectedIndex].Price = Math.Round(Convert.ToDecimal(price.Text), 2);
                    paymentList[selectedIndex].BuyerName = buyerName.Text;
                    paymentList[selectedIndex].ShopName = shopName.Text;
                    paymentList[selectedIndex].Description = description.Text;
                    paymentList[selectedIndex].PurchaseDate = Convert.ToDateTime(purchaseDay.Text);
                    paymentList[selectedIndex].InvoiceNo = invoiceNo.Text;
                    paymentList[selectedIndex].PaymentDay = Convert.ToDateTime(paymentDate.Text);

                    context.SaveChanges();
                }
            }
        }
    }
}
