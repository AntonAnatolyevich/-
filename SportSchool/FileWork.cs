using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Text.Encodings.Web;
using System.ComponentModel;

namespace SportSchool
{
    public class FileWork
    {
        public static string PathStudent
        {
            get
            {
                return (@"Student.json");
            }
        }
        public static string PathDeleteStudent
        {
            get
            {
                return (@"DeleteStudent.json");
            }
        }

        static JsonSerializerOptions options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true
        };
        public static string Serializer<T>(List<T> list)
        {
            return JsonSerializer.Serialize(list, options);
        }
        //public static string Serializer<T>(Dictionary<T, T> dictionary)
        //{
        //    return JsonSerializer.Serialize(dictionary);
        //}
        public static List<T> Deserializer<T>(string path)
        {
            string jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<T>>(jsonString);
        }

        public static List<T> ReadFile<T>(string path)
        {
            List<T> list = new List<T>();
            if (File.Exists(path))
            {
                list = Deserializer<T>(path);
            }
            return list;
        }

        public static void WriteFile<T>(List<T> list, string path)
        {
            File.WriteAllText(path, Serializer(list));
        }

        public static List<Student> AddStudent(List<Student> list,
         string textSurname,
         string textName,
         string textPatronymic,
         DateTime dateBirthDate,
         string textSportType,
         string textGender,
         string textCoach,
         DateTime dateDateOfAdd,
         string textOfice)
        {
            int id = 0;
            int aIndex;
            if (list.Count != 0)
            {
                aIndex = (list.Count - 1) + 1;
            }
            else
            {
                aIndex = id;
            }

            Random rnd = new Random();
            int aGoldPlaces = rnd.Next(20);
            int aSilverPlaces = rnd.Next(20);
            int aBronzePlaces = rnd.Next(20);

            list.Add(new Student()
            {
                Surname = textSurname,
                Name = textName,
                Patronymic = textPatronymic,
                BirthDate = dateBirthDate,
                SportType = textSportType,
                Gender = textGender,
                Coach = textCoach,
                GoldPlaces = aGoldPlaces,
                SilverPlaces = aSilverPlaces,
                BronzePlaces = aBronzePlaces,
                DateOfAdd = dateDateOfAdd,
                Index = aIndex,
                Ofice = textOfice,

            });

            return list;

        }
        public static void DeleteFile(string path)
        {
            File.Delete(path);
        }

        //public static List<Student> TransferStudent(List<Student> list,
        // string textSurname,
        // string textName,
        // string textPatronymic,
        // DateTime dateDateOfDelete)
        //{
        //    int id = 0;
        //    int aIndex;
        //    if (list.Count != 0)
        //    {
        //        aIndex = (list.Count - 1) + 1;
        //    }
        //    else
        //    {
        //        aIndex = id;
        //    }
        //    list.Add(new Student()
        //    {
        //        Surname = textSurname,
        //        Name = textName,
        //        Patronymic = textPatronymic,
        //        DateOfDelete = dateDateOfDelete,
        //        Index = aIndex,
        //    });

        //    return list;
        //}
    }
}