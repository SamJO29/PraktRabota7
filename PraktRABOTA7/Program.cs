using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktRABOTA7
{
   

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

//Задача 3

 
    class EventCreator    {
        
        public event Action<string> TextEvent;

        
        private string objectName;

        
        public EventCreator(string name)
        {
            this.objectName = name;
        }

       
        public void RaiseEvent()
        {
            
            if (TextEvent != null)
            {
                TextEvent(objectName);
            }
        }
    }

   
    class EventReceiver
    {
       
        public void ShowMessage(string message)
        {
            Console.WriteLine("Получено сообщение от: " + message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            EventCreator sender1 = new EventCreator("Cаша");
            EventCreator sender2 = new EventCreator("Петя");

            
            EventReceiver receiver = new EventReceiver();

            
            sender1.TextEvent += receiver.ShowMessage;
            sender2.TextEvent += receiver.ShowMessage;

            
            sender1.RaiseEvent();
            sender2.RaiseEvent();

           
        }
    }

*/
