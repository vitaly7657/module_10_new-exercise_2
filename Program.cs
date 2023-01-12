﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace module_10_new_exercise_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Выберите уровень доступа: \n1 - консультант\n2 - менеджер");
            int choiseAccess = Convert.ToInt32(Console.ReadLine());
            if(choiseAccess == 1)
            {
                //формируем пустой список
                List<Consultant> consultant = new List<Consultant>();

                //добавляем новых клиентов 
                Consultant cons_1 = new Consultant(1, "Иванов", "Василий", "Васильевич", "79546845126", "2011546845");
                Consultant cons_2 = new Consultant(2, "Висильев", "Пётр", "Иванович", "79524521155", "2010156422");
                Consultant cons_3 = new Consultant(3, "Петров", "Иван", "Петрович", "79535554565", "");

                //заполняем список
                consultant.Add(cons_1);
                consultant.Add(cons_2);
                consultant.Add(cons_3);

                Console.WriteLine("---Список клиентов---");
                Console.WriteLine("{0,3} {1,11} {2,11} {3,14} {4,14} {5,11}", "ID", "Фамилия", "Имя", "Отчество", "Телефон", "Паспорт");
                foreach (Consultant c in consultant) Console.WriteLine(c.Print()); //печать в консоль списка

                int idChoise; //переменная выбора ID
                int menuChoise; //переменная выбора пункта меню

                while (true) //бесконечный цикл смены данных
                {
                    Console.WriteLine("Введите ID клиента для редактирования:");
                    idChoise = Convert.ToInt32(Console.ReadLine());
                    if (cons_1.GetType().Name == "Consultant") //проверка класса на доступность пунктов меню
                    {
                        Console.WriteLine("Выберете какие данные будете изменять" +
                        "\n4 - номер телефона"
                        );
                    }
                    else
                    {
                        Console.WriteLine("Выберете какие данные будете изменять" +
                        "\n1 - фамилия" +
                        "\n2 - имя" +
                        "\n3 - отчество" +
                        "\n4 - номер телефона" +
                        "\n5 - серия, номер паспорта");
                    }

                    menuChoise = Convert.ToInt32(Console.ReadLine()); //переменная выбора меню

                    Console.WriteLine("Введите данные:");
                    string dataChange = Console.ReadLine();
                    if (dataChange == "") dataChange = "не задан"; //заглушка если данные не заданы

                    //if (menuChoise == 1) consultant.FindAll(a => a.ID == idChoise) .ForEach(b => b.Name = dataChange); //у конcультанта нет доступа
                    //if (menuChoise == 2) consultant.FindAll(a => a.ID == idChoise) .ForEach(b => b.Surname = dataChange); //у конcультанта нет доступа
                    //if (menuChoise == 3) consultant.FindAll(a => a.ID == idChoise) .ForEach(b => b.Patronymic = dataChange); //у конcультанта нет доступа
                    if (menuChoise == 4) consultant.FindAll(a => a.ID == idChoise).ForEach(b => b.PhoneNumber = dataChange); //поиск в списке по ID и замена данных
                    //if (menuChoise == 5) consultant.FindAll(a => a.ID == idChoise) .ForEach(b => b.Passport = dataChange); //у конcультанта нет доступа

                    Console.WriteLine("{0,3} {1,11} {2,11} {3,14} {4,14} {5,11}", "ID", "Фамилия", "Имя", "Отчество", "Телефон", "Паспорт");
                    foreach (Consultant c in consultant) Console.WriteLine(c.Print());
                }               
            }
            if (choiseAccess == 2)
            {
                //формируем пустой список
                List<Manager> manager = new List<Manager>();

                //добавляем новых клиентов 
                Manager man_1 = new Manager(1, "Иванов", "Василий", "Васильевич", "79546845126", "2011546845");
                Manager man_2 = new Manager(2, "Висильев", "Пётр", "Иванович", "79524521155", "2010156422");
                Manager man_3 = new Manager(3, "Петров", "Иван", "Петрович", "79535554565", "");

                //заполняем список
                manager.Add(man_1);
                manager.Add(man_2);
                manager.Add(man_3);

                Console.WriteLine("---Список клиентов---");
                Console.WriteLine("{0,3} {1,11} {2,11} {3,14} {4,14} {5,11}", "ID", "Фамилия", "Имя", "Отчество", "Телефон", "Паспорт");
                foreach (Manager c in manager) Console.WriteLine(c.Print()); //печать в консоль списка

                int idChoise; //переменная выбора ID
                int menuChoise; //переменная выбора пункта меню

                while (true) //бесконечный цикл смены данных
                {
                    Console.WriteLine("Введите ID клиента для редактирования:");
                    idChoise = Convert.ToInt32(Console.ReadLine());
                    if (man_1.GetType().Name == "Consultant") //проверка класса на доступность пунктов меню
                    {
                        Console.WriteLine("Выберете какие данные будете изменять" +
                        "\n4 - номер телефона"
                        );
                    }
                    if (man_1.GetType().Name == "Manager")
                    {
                        Console.WriteLine("Выберете какие данные будете изменять" +
                        "\n1 - фамилия" +
                        "\n2 - имя" +
                        "\n3 - отчество" +
                        "\n4 - номер телефона" +
                        "\n5 - серия, номер паспорта");
                    }

                    menuChoise = Convert.ToInt32(Console.ReadLine()); //переменная выбора меню

                    Console.WriteLine("Введите данные:");
                    string dataChange = Console.ReadLine();
                    if (dataChange == "") dataChange = "не задан"; //заглушка если данные не заданы

                    if (menuChoise == 1) manager.FindAll(a => a.ID == idChoise).ForEach(b => b.Surname = dataChange);
                    if (menuChoise == 2) manager.FindAll(a => a.ID == idChoise).ForEach(b => b.Name = dataChange);
                    if (menuChoise == 3) manager.FindAll(a => a.ID == idChoise).ForEach(b => b.Patronymic = dataChange);
                    if (menuChoise == 4) manager.FindAll(a => a.ID == idChoise).ForEach(b => b.PhoneNumber = dataChange);
                    if (menuChoise == 5) manager.FindAll(a => a.ID == idChoise).ForEach(b => b.Passport = dataChange);

                    Console.WriteLine("{0,3} {1,11} {2,11} {3,14} {4,14} {5,11}", "ID", "Фамилия", "Имя", "Отчество", "Телефон", "Паспорт");
                    foreach (Manager c in manager) Console.WriteLine(c.Print());
                }
            }
        }
    }
}
