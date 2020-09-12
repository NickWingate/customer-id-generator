using System;


namespace CustomerIDGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            do 
            {
                string fName;
                string sName;
                string date;
                (fName, sName, date) = GetInfo();
                
                Console.WriteLine(FormatDate(date) + sName.Substring(0, 3) + fName[0] + fName.Length.ToString());
            } while (true);


        }
        static (string, string, string)GetInfo()
        {
            Console.Write("First Name:");
            string fName = ReadString(Console.ReadLine()).ToUpper();

            Console.Write("Second Name:");
            string sName = ReadString(Console.ReadLine()).ToUpper();

            string userDate;
            do
            {
                Console.Write("Date(dd/mm/yyyy):");
                userDate = ReadString(Console.ReadLine());
                if (userDate[2] == '/' && userDate[5] == '/' && Convert.ToInt32(userDate.Substring(0, 2)) <= 31 && Convert.ToInt32(userDate.Substring(3, 2)) <= 12)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid date");
                }
            } while (true);

            return (fName, sName, userDate);
        }
        static string FormatDate(string _date)  // dd/mm/yyyy --> yyyymmdd
        {
            string[] listDate = _date.Split("/");
            Array.Reverse(listDate);
            return (string.Join("", listDate));
        }

        static string ReadString(string _string)  //checks each input for "quit"
        {
            if (_string == "quit")
            {
                Environment.Exit(0);
                return "null";
            }
            else
            {
                return _string;
            }
        }
    }
}

    

