using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInventory
{
    class Program
    {
        static void Main(string[] args)
        {

            List<IRentable> things = new List<IRentable>();

            things.Add(new Book1());
            things.Add(new Book2());
            things.Add(new Book3());
            things.Add(new Book4());
            foreach (IRentable thing in things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
public interface IRentable
{

    int getDailyRate();

    string getDescription();

}
public class Book1 : IRentable
{
    public int HourlyRate = 24;
    public string description = "House of Leaves";
    public Book1()
    {

    }
    public string getDescription()
    {
        return description;
    }
    public int getDailyRate()
    {
        return HourlyRate * 1;
    }
    public override string ToString()
    {
        return getDescription() + ": " + getDailyRate();
    }
}
public class Book2 : IRentable
{
    public int HourlyRate = 28;
    public string description = "The Lesser Key of Solomon: Lemegeton Clavicula Salomonis";
    public Book2()
    {

    }
    public string getDescription()
    {
        return description;
    }
    public int getDailyRate()
    {
        return HourlyRate * 1;
    }
    public override string ToString()
    {
        return getDescription() + ": " + getDailyRate();
    }
}
public class Book3 : IRentable
{
    public int HourlyRate = 10;
    public string description = "The Great Mental Models: General Thinking Concepts";
    public Book3()
    {

    }
    public string getDescription()
    {
        return description;
    }
    public int getDailyRate()
    {
        return HourlyRate * 1;
    }
    public override string ToString()
    {
        return getDescription() + ": " + getDailyRate();
    }
}

public class Book4 : IRentable
{
    public int HourlyRate = 60;
    public string description = "Almost Transparent Blue";
    public Book4()
    {

    }
    public string getDescription()
    {
        return description;
    }
    public int getDailyRate()
    {
        return HourlyRate * 1;
    }
    public override string ToString()
    {
        return getDescription() + ": " + getDailyRate();

    }


}

