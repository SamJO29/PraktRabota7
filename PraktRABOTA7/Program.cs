using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktRABOTA7
{
    internal class Program
    {
    


    }
}





// Задача 1




/*
delegate string Days();
static void Main(string[] args)
{
    string[] days =
    {

        "Понедельник",
        "Вторник",
        "Среда",
        "Четверг",
        "Пятница",
        "Суббота",
        "Воскресенье"


    };


    int nowDAY = 0;

    Days GetNextDay = () =>
    {
        string result = days[nowDAY];
        nowDAY=(nowDAY+1)% days.Length;
        return result;
    };

    for (int i = 0; i < 10; i++)
    {

        Console.WriteLine(GetNextDay());



    }

}




// Задача 2

public static Func<double, double>
   GetQUADRATFunc(double a, double b, double c)
{

    return x => a * x * x + b * x + c;

}

static void Main(string[] args)
{

    var quadrat = GetQUADRATFunc(2, 4, 3);

    double result = quadrat(5);
    Console.WriteLine(result);

}

*/