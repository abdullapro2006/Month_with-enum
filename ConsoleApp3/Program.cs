// See https://aka.ms/new-console-template for more information



public enum Month 
{
    January=1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December,
}

public class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter month number:");
        int number = int.Parse(Console.ReadLine());
        switch (number)
        {
            case  (int)Month.January:
                Console.WriteLine("January");
                break;
                case (int)Month.February: Console.WriteLine(" This month is" + " " + Month.February);
                break;
                case (int)Month.March: Console.WriteLine(" This month is" + " " + Month.March);
                    break;
                case (int)Month.April: Console.WriteLine("This month is" + " " + Month.April);
                break;
                case (int)Month.May: Console.WriteLine("This month is" + " " + Month.May);
                break;
                case (int)Month.June: Console.WriteLine("This month is" + " " + Month.June);
                break;
                case (int)Month.July: Console.WriteLine("This month is" + " " + Month.July);
                break;
                case (int)Month.August: Console.WriteLine("This month is" + " " + Month.August);
                break;
                case (int)Month.September: Console.WriteLine("This month is" + " " + Month.September);
                break;
                case(int)Month.October: Console.WriteLine("This month is " + " " + Month.October);
                break;
                case(int)Month.November: Console.WriteLine("This month is" + Month.November);
                break;
                case(int)Month.December: Console.WriteLine("This month is" + " " + Month.December);
                break;
                default: Console.WriteLine("This is not monthnumber");
                break;

        }
        
    }
}


