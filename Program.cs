using System;

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
//AddStudent() - metod prameter olaraq Student typinda obyekt qebul edir ve onu eger groupda
//yer varsa groupun studnets arrayine elave edir
//GetStudnets() - bu metod studnetler siyahisini geriye qaytarir
//ps: Group obyekti uzerinde Studnetlere birbasa value set oluna bilinmemelidir, yalnizca
//AddStudent metodu ile group obyekti icindeki Students arrayine deyer elave etmek mumkundur
    class Program
    {
        static void Main(string[] args)
        {
            Group P225 = new Group("P225", 3);
            Student stu1 = new Student("Onur", "Ismailov");
            Student stu2 = new Student("Tural", "Aliyev");
            Student stu3 = new Student("Vusal", "ALiyev");
            Student stu4 = new Student("Vusal", "ALiyev");

            P225.AddStudent(stu1);
            P225.AddStudent(stu2);
            P225.AddStudent(stu3);

            P225.GetStudents();
            P225.AddStudent(stu4);


        }

      
    }
}
