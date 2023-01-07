internal class Program
{
    static void Main(string[] args) //0'dan 6'ya kadar num gireceğiz ve o numaralar bizi haftanın
                                    //günlerinden birine götürecek. O yüzden yeni static.Switch-case kullan.
                                    // if-else yapısında daha karmasık ve uzun olur.
    {
        /* 0 -> "Sunday"
         1 -> "Monday"
         2-> "Tuesday"
         3-> "Wednesday"
         4-> "Thursday"
         5-> "Friday"
         6-> "Saturday" */

        Console.WriteLine(GetDay(3));

        Console.ReadLine();

    }

    static string GetDay(int DayNum)       // int DayNum = sayı gireceğiz ve günlere götürecek o yüzden
                                           // methodumuz numaralardır. 
    {
        string dayName;

        switch (dayNum)
        {
            case 0:
                dayName = "Sunday";
                break;
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;
            case 6:
                dayName = "Saturday";
                break;

            default:
                dayName = "Invalid Day Number."; 
        }


        return dayName;
    } 

}