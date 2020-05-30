using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//使用事件机制，模拟实现一个闹钟功能。闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。
//在闹钟走时时或者响铃时，在控制台显示提示信息。

namespace AlarmClock
{
    public delegate void Handler(object sender, DateTime dateTime);
    public class AlarmClock
    {
        public event Handler Tick;
        public event Handler Alarm;
        public DateTime alarmTime;
        public void run()
        {
            Console.WriteLine("开始运行！");
            while (true)
            {
                Tick(this, DateTime.Now);
                Alarm(this, DateTime.Now);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
    public class Form
    {
        public AlarmClock alarm=new AlarmClock();
        public Form()
        {
            alarm.Tick += Alarm_tick;
            alarm.Alarm += Alarm_alarm;

        }
        void Alarm_tick(object sender,DateTime dateTime)
        {
            Console.WriteLine($"tick... present time:{dateTime.ToString()}");
        }
        void Alarm_alarm(object sender, DateTime dateTime)
        {
            if (dateTime.ToString() == alarm.alarmTime.ToString())
            {
                Console.WriteLine($"alarm... present time:{dateTime.ToString()}");
            }
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.alarm.alarmTime = new DateTime(2020,03,19,18,26,00);
            form.alarm.run();
        }
    }
}
