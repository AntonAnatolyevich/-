using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchool
{
    public class StatOperations
    {
        public static List<string> AddCoaches()
        {
            List<string> coaches = new List<string>() { "Колесникова Ника Егоровна",
                "Александрова Виктория Кирилловна",
                "Березина Ульяна Данииловна",
                "Ушаков Тимур Сергеевич",
                "Аникин Михаил Владиславович",
                "Рубцов Михаил Львович",
                "Белякова Елизавета Михайловна",
                "Галкина Анастасия Егоровна",
                "Мещеряков Кирилл Владимирович",
                "Глебова Марина Дмитриевна",
                "Новиков Иван Александрович",
                "Макеев Ярослав Даниилович",
                "Винокуров Даниил Михайлович",
                "Симонова Арина Максимовна",
                "Кириллов Максим Даниилович" };
            return coaches;
        }
        public static List<string> AddSpotTypes()
        {
            List<string> sporttype = new List<string>() { "Плавание",
                "Каратэ",
                "Дзюдо",
                "Самбо",
                "Футбол",
                "Хоккей" };
            return sporttype;
        }
        public static List<string> AddMedalTypes()
        {
            List<string> sporttype = new List<string>() { "Gold", "Silver", "Bronze" };
            return sporttype;
        }
        public static string CountStudetnsCoach(string coach, string sporttype)
        {

            List<Student> students = new List<Student>();
            students = FileWork.Deserializer<Student>(FileWork.PathStudent);
            var tempStudent = from student in students
                              where student.Coach == coach
                              where student.SportType == sporttype
                              select student;
            string count = tempStudent.ToList().Count().ToString();
            return count;

        }
        public static List<Student> SortByMedals(string typemedals)
        {
            
            List<Student> students = new List<Student>();
            students = FileWork.Deserializer<Student>(FileWork.PathStudent);
            if (typemedals == "Gold")
            {
                var result = from student in students
                             orderby student.GoldPlaces descending
                             select student;

                return result.ToList();
            }
            else if (typemedals == "Silver")
            {
                var result = from student in students
                             orderby student.SilverPlaces descending
                             select student;

                return result.ToList();
            }
            else 
            {
                var result = from student in students
                             orderby student.BronzePlaces descending
                             select student;

                return result.ToList();
            }
        }
        public static List<Student> SortByCountOfMedals()
        {

            List<Student> students = new List<Student>();
            students = FileWork.Deserializer<Student>(FileWork.PathStudent);
                var result = from student in students
                             orderby student.MedalsCount descending
                             select student;
                return result.ToList();
           
            
        }
        //public static IEnumerable<(string Coach, int goldStudent)> CountChart()
        //{
        //    List<Student> students = new List<Student>();
        //    students = FileWork.Deserializer<Student>(FileWork.PathStudent);
        //    var tempStudent = students.GroupBy(p => p.GoldPlaces)
        //        .Select(g => (Coach:g.Key, goldStudent:g.Count()));
        //    return tempStudent;
        //}
    }
}
