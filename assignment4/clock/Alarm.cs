using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alarm
{
  
    class AlarmClock
    {
        public event Action<object, DateTime> Tick;//滴答
        public event Action<object, DateTime> Alarming;//闹钟
        public DateTime alarmtime = DateTime.Now;//初始化闹钟时间
        public DateTime now;
        public AlarmClock()
        {
            Tick += IsTicking;
            Alarming += IsAlarming;
        }
        public void IsTicking(object sender,DateTime time)
        {  
                System.Console.WriteLine("现在时间为：" + time);
        }
        public void IsAlarming(object sender,DateTime time)
        {
                System.Console.WriteLine("现在是："+time+",闹钟时间到了！");
        }
        public void SetAlarmClock(DateTime time)
        {
            this.alarmtime = time;
        }
        public void Start()
        {
            while(true)
            {
                Tick(this, DateTime.Now);
                if(DateTime.Now.ToString()==alarmtime.ToString())
                {
                    Alarming(this,DateTime.Now);
                }
                System.Threading.Thread.Sleep(1000);
            }
            
        }
    }
}
