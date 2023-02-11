using System.Linq;

namespace _61_LINQ
{
    public class StudentDatabase
    {
        static IQueryable<Student> GetStudentsFromDb()
        {
            return new[] {
                new Student() {StudentId = 1, StudentName = "John Bross", Score = 45, StudentCity = "NYC"},
                new Student() {StudentId = 2, StudentName = "Jasmine Curly", Score = 78, StudentCity = "Berlin"},
                new Student() {StudentId = 4, StudentName = "Sam Wild", Score = 65, StudentCity = "CA"},
                new Student() {StudentId = 6, StudentName = "Sara Ride", Score = 24, StudentCity = "LA"},
                new Student() {StudentId = 7, StudentName = "Leo Aniston", Score = 87, StudentCity = "Florida"},
            }.AsQueryable();
        }
    }
}
