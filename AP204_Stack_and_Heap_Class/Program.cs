using System;

namespace AP204_Stack_and_Heap_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Memory Allocation
            //byte number = 10;
            //byte number2 = number;
            //number2 = 20;
            //Console.WriteLine(number);


            //int[] arr1 = { 1, 4, 6, 18, 20, 39, 40 };
            //int[] arr2 = arr1;
            //arr2[0] = 10;

            //foreach (int item in arr1)
            //{
            //    Console.WriteLine(item);
            //}

            //int num=10;
            //Change(ref num);
            //Change(ref num);
            //Change(out num);

            //Console.WriteLine(num);

            #endregion


            //string student1name = "Kamal";
            //string student1surname = "Ebishli";
            //byte student1age = 20;

            //string student2name = "Rashid";
            //string student2surname = "Mammadov";
            //byte student2age = 19;

            //var student = new
            //{
            //    name = "Kamal",
            //    surname = "Ebishli",
            //    age = 20
            //};

            //var student2 = new
            //{
            //    name = "Rashid",
            //    surname = "Mammadov",
            //    age = 19
            //};

            //Console.WriteLine(student2.name + " " + student.surname + " " + student.age);

            //Student student = new Student("Tural","Hamidzade",20);
            //student.Name = "Tural";
            //student.Surname = "Hamidzade";
            //Console.WriteLine(student.Age);
            //student.Fullname();
            //student.Info();


            //Student student1 = new Student("Baxshali","Nazarov",19);
            //student1.Age = 19;
            //student1.Name = "Baxshali";
            //student1.Surname = "Nazarov";

            //student1.Info();

            Student student2 = new Student("Ilkin", "Yusufov", 21);
            Student student3 = new Student("Ilkin", "Yusufov", 22);
            Student student4 = new Student("Ilkin", "Yusufov", 23);
            Student student5 = new Student("Ilkin", "Yusufov", 24);
            student2.Info();

            //Student student3 = new Student();
            //student3.Info();

            //Student student4 = new Student(20);
        }
        #region Ref and Out
        //public static void Change(ref int num)
        //{
        //    num = 100; //num = num+100
        //    Console.WriteLine(num);
        //}

        //public static void Change(out int num)
        //{
        //    num = 100;
        //}
        #endregion

        public void Test()
        {
            Console.WriteLine("Test");
        }
    }

    class Student
    {
        public string Name;
        public string Surname;
        public byte Age;

        public Student()
        {
            Console.WriteLine("Student yaradildi");
        }
        public Student(string Name,string Surname, byte age):this(age)
        {
            this.Name = Name;
            this.Surname = Surname;
            Age = age;
        }
        public Student(byte age):this()
        {
            Console.WriteLine($"Age: {age}");
        }



        public void Fullname()
        {
            Console.WriteLine(Name + " " + Surname);
        }

        public void Info()
        {
            //Console.WriteLine("Name: " + Name + ", Surname: " + Surname  + ", Age: " + Age);
            //Console.WriteLine("Name:{0}, Surname:{2}, Age:{1}",Name,Age,Surname);
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}");
        }
    }
}
