using System;
using System.Linq;

namespace _64_LINQ_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentList = StudentDatabase.GetStudentsFromDb();
            var activityStatus = studentList.Where(x => x.StudentActvity == true)
                                .Select(x => x.StudentName);

            var scoreMoreThan80 = studentList.Where(x => x.Score > 80)
                                .Select(x => x.StudentName);

            var liveInNyc = studentList.Where(x => x.StudentCity == "NYC")
                                .Select(x => x.StudentName);

            foreach (var item in activityStatus)
            {
                Console.WriteLine(item);
            }
        }
    }
}
