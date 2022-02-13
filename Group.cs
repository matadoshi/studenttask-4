using System;
using System.Collections.Generic;
using System.Text;

namespace Task4HW
{
    //Task - 4
    //Asagidaki parameterlerden ibret Studnet class-i yaradirsini
    //Name
    //Surname
    //Asagidaki parameterlerden ibaret Gorup class-i yaradirsiniz:
    //No - Group nomresini ifade edir
    //Limit - Group-da ola bilecek maximum telebe sayini ifade edir
    //Students - Group-unicerisindeki telebeleri ifade edir(Student typda array)
    //AddStudent() - metod prameter olaraq Student typinda obyekt qebul edir ve onu eger groupda yer varsa
    //groupun studnets arrayine elave edir
    //GetStudnets() - bu metod studnetler siyahisini geriye qaytarir
    //ps: Group obyekti uzerinde Sobyektitudnetlere birbasa value set oluna bilinmemelidir, yalnizca
    //AddStudent metodu ile group  icindeki Students arrayine deyer elave etmek mumkundur
    class Group 
    {
        public string No;
        public int Limit;
        private Student[] _students;
        public Group(string no, int limit)
        {
            No = no;
            Limit = limit;
            _students = new Student[0];
        }
        public void AddStudent(Student std)
        {
            if (_students.Length < Limit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = std;
            }
            else
            {
                Console.WriteLine("Yer Doludur");
            }
        }
        
        public void GetStudents()
        {
            foreach (var std in _students)
            {
                Console.WriteLine($"Adiniz: {std.Name} Soyadiniz: {std.Surname} {No}");
            }
        }
    } 
}
