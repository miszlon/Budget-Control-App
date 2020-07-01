using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kontrola_Domowego_Budzetu.DataBase;

namespace Kontrola_Domowego_Budzetu.Methods
{
    public class Summary
    {
        public static int CurrentYear()
        {
            return DateTime.Now.Year;
        }
        public static int CurrentMonth()
        {
            return DateTime.Now.Month;
        }

        public static List<Kontrola_Domowego_Budzetu.DataBase.Income> IncomeList()
        {
            using (var context = new BCEntities())
            {
                var lista = context.Incomes.OrderByDescending(x => x.IncomeId).ToList();
                return lista;
            }
        }
        public static List<Kontrola_Domowego_Budzetu.DataBase.Payment> PaymentList()
        {
            using (var context = new BCEntities())
            {
                var lista = context.Payments.OrderByDescending(x => x.PaymentId).ToList();
                return lista;
            }
        }
        public static List<Kontrola_Domowego_Budzetu.DataBase.ShoppingList> ShoppingList()
        {
            using (var context = new BCEntities())
            {
                var lista = context.ShoppingLists.OrderByDescending(x => x.ProductId).ToList();
                return lista;
            }
        }
        public static void PaymentTopNames(Label first, Label second, Label third)
        {
            if (PaymentList().Count > 0)
                first.Text = PaymentList()[0].BuyerName;
            if (PaymentList().Count > 1)
                second.Text = PaymentList()[1].BuyerName;
            if (PaymentList().Count > 2)
                third.Text = PaymentList()[2].BuyerName;

        }
        public static void PaymentTopDates(Label first, Label second, Label third)
        {
            if (PaymentList().Count > 0)
                first.Text = Convert.ToDateTime(PaymentList()[0].PurchaseDate).ToString("yyyy-MM-dd");
            if (PaymentList().Count > 1)
                second.Text = Convert.ToDateTime(PaymentList()[1].PurchaseDate).ToString("yyyy-MM-dd");
            if (PaymentList().Count > 2)
                third.Text = Convert.ToDateTime(PaymentList()[2].PurchaseDate).ToString("yyyy-MM-dd");
        }
        public static void PaymentTopValues(Label first, Label second, Label third)
        {

            if (PaymentList().Count > 0)
                first.Text = Math.Round(Convert.ToDecimal(PaymentList()[0].Price), 2).ToString() + "zł";
            if (PaymentList().Count > 1)
                second.Text = Math.Round(Convert.ToDecimal(PaymentList()[1].Price), 2).ToString() + "zł";
            if (PaymentList().Count > 2)
                third.Text = Math.Round(Convert.ToDecimal(PaymentList()[2].Price), 2).ToString() + "zł";
        }
        public static void IncomeTopNames(Label first, Label second, Label third)
        {
            if (IncomeList().Count > 0)
                first.Text = IncomeList()[0].Name;
            if (IncomeList().Count > 1)
                second.Text = IncomeList()[1].Name;
            if (IncomeList().Count > 2)
                third.Text = IncomeList()[2].Name;
        }
        public static void IncomeTopDates(Label first, Label second, Label third)
        {
            if (IncomeList().Count > 0)
                first.Text = Convert.ToDateTime(IncomeList()[0].Date).ToString("yyyy-MM-dd");
            if (IncomeList().Count > 1)
                second.Text = Convert.ToDateTime(IncomeList()[1].Date).ToString("yyyy-MM-dd");
            if (IncomeList().Count > 2)
                third.Text = Convert.ToDateTime(IncomeList()[2].Date).ToString("yyyy-MM-dd");
        }
        public static void IncomeTopValues(Label first, Label second, Label third)
        {
            if (IncomeList().Count > 0)
                first.Text = Math.Round(Convert.ToDecimal(IncomeList()[0].Value), 2).ToString() + "zł";
            if (IncomeList().Count > 1)
                second.Text = Math.Round(Convert.ToDecimal(IncomeList()[1].Value), 2).ToString() + "zł";
            if (IncomeList().Count > 2)
                third.Text = Math.Round(Convert.ToDecimal(IncomeList()[2].Value), 2).ToString() + "zł";
        }
        public static decimal IncomeCurrentYear()
        {
            decimal suma = 0m;
            if (IncomeList().Count > 0)
                for (int i = 0; i < IncomeList().Count; i++)
                {
                    if (Convert.ToDateTime(IncomeList()[i].Date).Year == CurrentYear())
                        suma = suma + Convert.ToDecimal(IncomeList()[i].Value);
                }
            return Math.Round(suma, 2);
        }
        public static decimal IncomeCurrentMonth()
        {
            decimal suma = 0m;
            if (IncomeList().Count > 0)
                for (int i = 0; i < IncomeList().Count; i++)
                {
                    if (Convert.ToDateTime(IncomeList()[i].Date).Month == CurrentMonth())
                        suma = suma + Convert.ToDecimal(IncomeList()[i].Value);
                }
            return Math.Round(suma, 2);
        }
        public static decimal IncomeAllValues()
        {
            decimal suma = 0m;
            if (IncomeList().Count > 0)
                for (int i = 0; i < IncomeList().Count; i++)
                {
                    suma = suma + Convert.ToDecimal(IncomeList()[i].Value);
                }
            return Math.Round(suma, 2);
        }
        public static decimal PaymentCurrentYear()
        {
            decimal suma = 0m;
            if (PaymentList().Count > 0)
                for (int i = 0; i < PaymentList().Count; i++)
                {
                    if (Convert.ToDateTime(PaymentList()[i].PurchaseDate).Year == CurrentYear())
                        suma = suma + Convert.ToDecimal(PaymentList()[i].Price);
                }
            return Math.Round(suma, 2);
        }
        public static decimal PaymentCurrentMonth()
        {
            decimal suma = 0m;
            if (PaymentList().Count > 0)
                for (int i = 0; i < PaymentList().Count; i++)
                {
                    if (Convert.ToDateTime(PaymentList()[i].PurchaseDate).Month == CurrentMonth())
                        suma = suma + Convert.ToDecimal(PaymentList()[i].Price);
                }
            return Math.Round(suma, 2);
        }
        public static decimal PaymentAllValues()
        {
            decimal suma = 0m;
            if (PaymentList().Count > 0)
                for (int i = 0; i < PaymentList().Count; i++)
                {
                    suma = suma + Convert.ToDecimal(PaymentList()[i].Price);
                }
            return Math.Round(suma, 2);
        }

        public static void IncomeDisplayThree(Label name1, Label name2, Label name3, Label date1, Label date2, Label date3, Label value1, Label value2, Label value3)
        {
            IncomeTopDates(date1, date2, date3);
            IncomeTopNames(name1, name2, name3);
            IncomeTopValues(value1, value2, value3);
        }

        public static void PaymentDisplayThree(Label name1, Label name2, Label name3, Label date1, Label date2, Label date3, Label value1, Label value2, Label value3)
        {
            PaymentTopDates(date1, date2, date3);
            PaymentTopNames(name1, name2, name3);
            PaymentTopValues(value1, value2, value3);
        }

        public static void PaymentDisplayPeriod(Label value1, Label value2, Label value3)
        {
            value3.Text = PaymentAllValues().ToString() + "zł";
            value1.Text = PaymentCurrentMonth().ToString() + "zł";
            value2.Text = PaymentCurrentYear().ToString() + "zł";
        }
        public static void IncomeDisplayPeriod(Label value1, Label value2, Label value3)
        {
            value3.Text = IncomeAllValues().ToString() + "zł";
            value1.Text = IncomeCurrentMonth().ToString() + "zł";
            value2.Text = IncomeCurrentYear().ToString() + "zł";
        }

        public static void MoneyToSpend(Label payment, Label income, Label moneyToSpend)
        {
            if (income.Text != "-")
            {
                if (payment.Text != "-")
                {
                    string temp1 = incone.Text;
                    string temp2 = payment.Text;
                    temp1 = temp1.Substring(0,-3);
                    temp2 = temp2.Substring(0,-3);
                    decimal sum = Convert.ToDecimal(temp1) - Convert.ToDecimal(temp2);
                    moneyToSpend.Text = sum.ToString() + "zł";
                }
                else moneyToSpend.Text = income.Text;
            }
        }
    }
}
