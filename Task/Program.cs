using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace Task
{
    
    public class Program
    {
        public static DateTime Date;
        public static DateTime Date2;
         private static void ConvertDate()
        {

            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine("Enter the first date: ");
                string enteredDate = Console.ReadLine();
                Console.WriteLine("Enter the second date: ");
                string enteredDate2 = Console.ReadLine();
                
                isValid = formatValidation(enteredDate,enteredDate2);
            }

            string result = printDate(Date, Date2);
            Console.Write(result);
            Console.Read();
        }
         // Validation if format is correct
         public static bool formatValidation(string enteredDate, string enteredDate2)
         {
             DateTime date = new DateTime();
             DateTime date2 = new DateTime();

             bool checkDate = DateTime.TryParse(enteredDate, out date);
             bool checkDate2 = DateTime.TryParse(enteredDate2, out date2);
             Date = date;
             Date2 = date2;
             if (checkDate && checkDate2) return true;

             else Console.WriteLine("Incorect format, format is: dd.mm.rrrr or dd-mm-rrrr");
   
             return false;
         }
          // show mesage 
    public static string printDate(DateTime date,DateTime date2)
         {
             string outputDate;
             if (date.Month == date2.Month && date.Year == date2.Year)
                 outputDate = string.Format("{0} - {1}", date.ToString("dd"), date2.ToString("dd.MM.yyyy"));

             else if (date.Month != date2.Month && date.Year == date2.Year)
                 outputDate = string.Format("{0} - {1}", date.ToString("dd.MM"), date2.ToString("dd.MM.yyyy"));

             else
                 outputDate = string.Format("{0} - {1}", date.ToString("dd.MM.yyyy"), date2.ToString("dd.MM.yyyy"));
             
            return outputDate;
         }

        public static void Main()
        {
            ConvertDate();
        }
       

    }
}
