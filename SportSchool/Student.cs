using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSchool
{
    public class Student
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string SportType { get; set; }
        public string Gender { get; set; }
        public string Coach { get; set; }
        public  int GoldPlaces { get; set; }
        public  int SilverPlaces { get; set; }
        public  int BronzePlaces { get; set; }
        public DateTime DateOfAdd { get; set; }
        public DateTime DateOfDelete { get; set; }
        public int Index { get; set; }
        public string Ofice { get; set; }
        public string IndexInfo
        {
            get
            {
                return (Index).ToString();
            }
        }
        public string ViewInfo
        {
            get
            {
                return (Surname + " " + Name + " " + Patronymic + ", Дата рождения: " + BirthDate.ToString("dd.MM.yyyy") +", Вид спорта: " + SportType + ", Тренер: " + Coach);
            }
        }
        public int MedalsCount
        {
            get
            {
                return (GoldPlaces + SilverPlaces + BronzePlaces);
            }
        }
    }
}
