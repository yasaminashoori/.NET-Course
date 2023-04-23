using System.Linq;

namespace _64_LINQ_Practice
{
    public class StudentDatabase
    {
        public static IQueryable<Student> GetStudentsFromDb()
        {
            return new[] {
                new Student() {StudentId = 1, StudentName = "John Bross", Score = 82, StudentCity = "NYC", StudentActvity = true},
                new Student() {StudentId = 2, StudentName = "Jasmine Curly", Score = 84, StudentCity = "NYC", StudentActvity = false},
                new Student() {StudentId = 4, StudentName = "Ben Wild", Score = 65, StudentCity = "CA", StudentActvity = true},
                new Student() {StudentId = 6, StudentName = "Sara Ride", Score = 81, StudentCity = "CA", StudentActvity = true},
                new Student() {StudentId = 7, StudentName = "Bonnie Brooklyn", Score = 80, StudentCity = "LA", StudentActvity = false},
                new Student() {StudentId = 8, StudentName = "Loren Gibson", Score = 88, StudentCity = "CA", StudentActvity = false},
            }.AsQueryable();
        }
    }
}
