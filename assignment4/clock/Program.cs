using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alarm
{
    class Program
    { 
        static void Main(string[] args)
        {
            AlarmClock alarm = new AlarmClock();
            DateTime datetime = new DateTime();
            datetime = DateTime.Now.AddSeconds(5);
            System.Console.WriteLine("设定闹钟时间为：" + datetime);
            alarm.SetAlarmClock(datetime);
            alarm.Start();
            
        }
    }
}
