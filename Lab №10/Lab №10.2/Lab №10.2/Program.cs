using System;

namespace Lab__10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(-185%60);
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            string repit = "no";
            Console.Write("Введіть секунди: ");
            int sec = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть хвилини: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть години: ");
            int hou = Convert.ToInt32(Console.ReadLine());
            var time = new Time(hou, min, sec);
            do
            {
                Console.Write("Зміна секунд на: ");
                time.ChangeSeconds(Convert.ToInt32(Console.ReadLine()));
                time.PrintTime();
                Console.Write("Зміна хвилин на: ");
                time.ChangeMinutes(Convert.ToInt32(Console.ReadLine()));
                time.PrintTime();
                Console.Write("Зміна годин на : ");
                time.ChangeHours(Convert.ToInt32(Console.ReadLine()));
                time.PrintTime();
                Console.Write("Введіть exit для закінчення: ");
                repit = Console.ReadLine();
            } while (repit!="exit");
            repit = "no";
            do
            {
                Console.Write("Зміна секунд: ");
                time.Seconds = Convert.ToInt32(Console.ReadLine());
                time.PrintTime();
                Console.Write("Зміна хвилин: ");
                time.Minutes = Convert.ToInt32(Console.ReadLine());
                time.PrintTime();
                Console.Write("Зміна годин: ");
                time.Hours = Convert.ToInt32(Console.ReadLine());
                time.PrintTime();
                Console.Write("Введіть exit для закінчення: ");
                repit = Console.ReadLine();
            } while (repit != "exit");

            var time2 = new Time();
            time2.PrintTime();
            var arr = time2.GetTime;
            foreach (var item in arr)
            {
                Console.Write($"{item} | ");
            }
        }
    }
    public class Time
    {
        private int hours;
        private int minutes;
        private int seconds;

        public Time(int hours, int minute, int seconds)
        {
            this.hours = (hours < 24 && hours >= 0 ? hours : throw new InvalidFormat("Неправильний формат")); ;
            this.minutes = (minute < 60 && minute >= 0 ? minute : throw new InvalidFormat("Неправильний формат")); ;
            this.seconds = (seconds < 60 && seconds >= 0) ? seconds : throw new InvalidFormat("Неправильний формат");;
        }
        public Time()
        {
            this.hours = 0;
            this.minutes = 0;
            this.seconds = 0;
        }

        public int Hours
        {
            set => hours = (value < 24 && value >= 0 ? value : throw new InvalidFormat("Неправильний формат"));
        }
        public int Minutes
        {
            set => minutes = (value < 60 && value >= 0 ? value : throw new InvalidFormat("Неправильний формат"));
        }
        public int Seconds
        {
            set => seconds = (value < 60 && value >= 0) ? value : throw new InvalidFormat("Неправильний формат");
        }
        public void ChangeSeconds(int change)
        {
            int perenos = change / 60;
            if (seconds + (change%60) > 59)
            {
                if (change > 0)
                {
                    perenos++;
                    seconds = seconds + change % 60 - 60;
                }
                else
                {
                    perenos--;
                    seconds = Math.Abs(Math.Abs(seconds - change % 60) - 60);
                }
            }
            else
            {
                seconds += change % 60;
            }
            if (perenos != 0)
            {
                ChangeMinutes(perenos);
            }
        }
        public void ChangeMinutes(int change)
        {
            int perenos = change / 60;
            if (minutes + (change % 60) > 59)
            {
                if (change > 0)
                {
                    perenos++;
                    minutes = minutes + change % 60 - 60;
                }
                else
                {
                    perenos--;
                    minutes = Math.Abs(Math.Abs(minutes - change % 60) - 60);
                }
                
            }
            else
            {
                minutes += change % 60;
            }
            if (perenos != 0)
            {
                ChangeHours(perenos);
            }
        }
        public void ChangeHours(int change)
        {
            if (hours + change%24 >23)
            {
                hours = hours + change % 24 - 24;
            }
            else
            {
                hours += change % 24;
            }
        }
        
        public void PrintTime()
        {
            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }

        public int[] GetTime
        {
            get => new int[] {hours, minutes, seconds};
        }
    }

    class InvalidFormat : Exception
    {
        public InvalidFormat(string message)
            : base(message)
        { }
    }
}
