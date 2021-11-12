using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using info_koleso;
using info_motor;
using info_korobka;
using info_obchee;
using info_avto;

namespace Lab7_prog_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Clear();
			Motor Motorishe = new Motor();
			Obchee Obchie = new Obchee();
			Koleso Kolesiko = new Koleso();
			Korobka Korobas = new Korobka();
			Avto Avt = new Avto();
			int glmenu;
			int menu;
			do
			{
				Console.Clear();
				Console.WriteLine("1) Общее\n2) Двигатель\n3) Коробка\n4) Колеса\n5) Автомобиль\n6) Свойства полей\n\nESC - выход");
				glmenu = Console.ReadKey().KeyChar;
				//Console.ReadKey(true);			ожидание нажатия
				if (glmenu == '1')
				{
					Console.Clear();
					do
					{
						Console.Clear();
						Console.WriteLine("1) Ввод собственных данных об общем\n2) Создание по конструктору");
						menu = Console.ReadKey().KeyChar;
					} while (menu != '1' && menu != '2');

					Console.Clear();
					if (menu == '1')
					{
						Obchie.new_obchee_info();
						Console.Clear();
					}
					else
					{
						Obchie.new_obchee(1500, 65, 7, 5, "Subaru", "Бензин", "4WD");
					}
					Obchie.prosmotr_obchee();
					Console.Write("\n\nОбщая информация успешно добавлена.");
					Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
					Console.ReadKey(true);
				}
				else if (glmenu == '2')
				{
					Console.Clear();
					do
					{
						Console.Clear();
						Console.WriteLine("1) Ввод собственных данных о двигателе\n2) Создание по конструктору");
						menu = Console.ReadKey().KeyChar;
					} while (menu != '1' && menu != '2');
					Console.Clear();
					if (menu == '1')
					{
						Motorishe.New_Motor_Info();
					}
					else
					{
						Motorishe.new_motor("stok", 150, 2, 4, 10, 4);
					}
					Console.Clear();
					Motorishe.prosmotr_motor();
					Console.Write("\n\nИнформацияо двигателе успешно добавлена.");
				}

				else if (glmenu == '3')
				{
					do
					{
						Console.Clear();
						Console.WriteLine("1) Ввод собственных данных о коробке\n2) Создание по конструктору");
						menu = Console.ReadKey().KeyChar;
					} while (menu != '1' && menu != '2');
					Console.Clear();
					if (menu == '1')
					{
						Korobas.new_korobka_info();
					}
					else
					{
						Korobas.korobka_new("АКПП", 6);
					}
					Console.Clear();
					Korobas.prosmotr_korobka();
					Console.WriteLine("\n\nИнформация о коробке передач успешно добавлена");
					Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
					Console.ReadKey(true);
				}
				else if (glmenu == '4')
				{
					do
					{
						Console.Clear();
						Console.WriteLine("1) Ввод собственных данных о колесах\n2) Создание по конструктору");
						menu = Console.ReadKey().KeyChar;
					} while (menu != '1' && menu != '2');
					Console.Clear();
					if (menu == '1')
					{
						Kolesiko.new_koleso_info();
					}
					else
					{
						Kolesiko.new_koleso(225, 55, 17, "Литье");
					}
					Console.Clear();
					Kolesiko.prosmotr_koleso();
					Console.WriteLine("Информация о колесах успешно добавлена");
				}
				else if (glmenu == '5')
				{
					Console.Clear();
					Obchie.new_obchee(1500, 65, 7, 5, "Subaru", "Бензин", "4WD");
					Motorishe.new_motor("stok", 150, 2, 4, 10, 4);
					Korobas.korobka_new("АКПП", 6);
					Kolesiko.new_koleso(225, 55, 17, "Литье");
					Avt.new_avto(Motorishe, Obchie, Korobas, Kolesiko);
					Console.WriteLine("Автомобиль успешно собран");
					Avt.prosmotr_avto();
				}
				else if (glmenu == '6')
                {
					Console.Clear();
					int a, b, c;
					a = 100;
					b = -10;
					c = 95;
					Kolesiko.Shirina = a;
					Kolesiko.Diametr = b;
					Kolesiko.Visota = c;
					Console.WriteLine("Ширина: " + Kolesiko.Shirina + "       Изначальное значение: " + a);
					Console.WriteLine("Диаметр: " + Kolesiko.Diametr + "       Изначальное значение: " + b);
					Console.WriteLine("Высота: " + Kolesiko.Visota + "       Изначальное значение: " + c);
					Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
					Console.ReadKey(true);
				}
			} while (glmenu != 27);
		}
    }
}
