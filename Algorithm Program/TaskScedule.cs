using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Program
{
    public class TaskScedule
    {
        public int noDays { get; set; }
        public int min { get; set; } = 0;
        public int maxDays { get; set; } = 0;

        public bool taskCompleted { get; set; } = false;
    }
    public class Task:TaskScedule
    {
        public void TaskSceduleing(int tasks)
        {
            bool taskCompleted = false;

            List<TaskScedule> list = new List<TaskScedule>();

            for (int k = 1; k <= tasks; k++)
            {
                Console.WriteLine($"Enter the deadline for {k} in Days");
                int days = Convert.ToInt32(Console.ReadLine());
                list.Add(new Task() { noDays = days });
            }
            int task = 0;
            for(int i=0;i<list.Count;i++)
            {
                while (!list[i].taskCompleted)
                {
                    if ((list[i].noDays * 9 * 60) >= list[i].min)
                    {
                        Random random = new Random();
                        int minutes = random.Next(0, (list[i].noDays * 9 * 60));
                        list[i].min = list[i].min + minutes;
                        list[i].maxDays++;
                    }
                    else if (list[i].maxDays > list[i].noDays && !list[i].taskCompleted)
                    {
                        list[i].taskCompleted = true;
                        list[i].maxDays = list[i].maxDays - list[i].noDays;
                        Console.WriteLine($"no of Days overshoot deadline of task {task} is {list[i].maxDays} ");
                        task++;
                    }
                }
            }
        }
    }
}
