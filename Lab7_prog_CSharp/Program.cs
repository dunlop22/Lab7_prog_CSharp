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
				Console.WriteLine("1) Общее\n2) Двигатель\n3) Коробка\n4) Колеса\n5) Out ref\n6) Свойства полей\n7) Классы\n8) Массив\n9) Перегрузки\n0) Строки\n\nESC - выход");
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
						string s;
						Console.WriteLine("Последний уникальный ID: " + (s = Koleso.id_return().ToString("000000")));
						Console.WriteLine("\nОбщее количество созданных колес: " + Koleso.kolvo_koles());

						Console.WriteLine("\n\n1) Ввод собственных данных о колесах\n2) Создание по конструктору\n3) Удаление");
						menu = Console.ReadKey().KeyChar;
					} while (menu < '1' || menu > '3');
					if (menu == '1')
					{
						Kolesiko.new_koleso_info();
						Kolesiko.prosmotr_koleso();
						Console.WriteLine("Информация о колесах успешно добавлена");
					}
					else if (menu == '2')
					{
						Kolesiko.new_koleso(225, 55, 17, "Литье");
						Kolesiko.prosmotr_koleso();
						Console.WriteLine("Информация о колесах успешно добавлена");
					}
					else if (menu == '3')
                    {
						Koleso.koleso_del();
                    }
					Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
					Console.ReadKey(true);
				}
				else if (glmenu == '5')
                {
					Console.Clear();
					double Massa;
					Obchie.Massa_Obch(out Massa);
					Console.WriteLine("Масса (out): " + Massa);

					double Benzo;
					Benzo = 0;
					Obchie.Benzobak_Obch_1(ref Benzo);
					Console.WriteLine("\n\nОбъем бензобака (ref): " + Benzo);
					
					Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
					Console.ReadKey(true);
				}
				/*else if (glmenu == '5')
				{
					Console.Clear();
					Obchie.new_obchee(1500, 65, 7, 5, "Subaru", "Бензин", "4WD");
					Motorishe.new_motor("stok", 150, 2, 4, 10, 4);
					Korobas.korobka_new("АКПП", 6);
					Kolesiko.new_koleso(225, 55, 17, "Литье");
					Avt.new_avto(Motorishe, Obchie, Korobas, Kolesiko);
					Console.WriteLine("Автомобиль успешно собран");
					Avt.prosmotr_avto();
				}*/
				else if (glmenu == '6')
                {
					Console.Clear();
					int a, b, c;
					Console.Write("Введите ширину колеса: ");
					a = Convert.ToInt32(Console.ReadLine());
					Console.Write("Введите диаметр колеса: ");
					b = Convert.ToInt32(Console.ReadLine());
					Console.Write("Введите высоту колеса: ");
					c = Convert.ToInt32(Console.ReadLine());
					Kolesiko.Shirina = a;
					Kolesiko.Diametr = b;
					Kolesiko.Visota = c;
					Console.WriteLine("Ширина: " + Kolesiko.Shirina + "       Изначальное значение: " + a);
					Console.WriteLine("Диаметр: " + Kolesiko.Diametr + "       Изначальное значение: " + b);
					Console.WriteLine("Высота: " + Kolesiko.Visota + "       Изначальное значение: " + c);
					Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
					Console.ReadKey(true);
				}
				else if (glmenu == '7')
                {
					Console.Clear();
					Koleso Koles1 = new Koleso();
					Koleso Koles2 = new Koleso();
					Koles1.new_koleso(17, 55, 225, "Литье");
					Koles2 = Koles1;
					Console.WriteLine("Колесо №1:");
					Koles1.prosmotr_koleso();
					Console.WriteLine("\nКолесо №2:");
					Koles2.prosmotr_koleso();
					Koles1.Shirina = 100;
					Koles1.Visota = 30;
					Koles1.Diametr = 13;
					Console.WriteLine("\n\nКолесо №1:");
					Koles1.prosmotr_koleso();
					Console.WriteLine("\nКолесо №2:");
					Koles2.prosmotr_koleso();
					Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
					Console.ReadKey(true);
				}
				else if (glmenu == '8')
                {
					Console.Clear();
					Console.Write("Введите количество коробок передач для создания массива: ");
					int n;
					do
					{
						n = Convert.ToInt32(Console.ReadLine());
						if (n < 0)
						{
							Console.Write("Неверно введено значение, попробуйте еще: ");
						}
					} while (n < 0);
					Korobas.korobka_new("АКПП", 6);
					Korobka Korobka_Mass = new Korobka();
					for (int i = 0 ; i < n; i++)
                    {
						Korobka_Mass.Korobka_Massiv(Korobas);
					}
					Korobka_Mass.Korobka_Massiv_Prosmotr();
					Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
					Console.ReadKey(true);
				}
				else if (glmenu == '9')
                {
					do
					{
						Console.Clear();
						Console.WriteLine("1) +\n2) ++ (префиксный)\n3) ++ (постфиксный)");
						menu = Console.ReadKey().KeyChar;
					} while (menu < '1' && menu > '3');
					Console.Clear();
					if (menu == '1')
					{
						
						Motor Mot1 = new Motor();
						Motor Mot2 = new Motor();
						Motor Mot3 = new Motor();
						Mot1.new_motor("stok", 150, 2, 4, 10, 4);
						Console.WriteLine("Двигатель №1");
						Mot1.prosmotr_motor();
						Mot2.new_motor("stok", 249, 3.5, 4, 10, 4);
						Console.WriteLine("\n\nДвигатель №2");
						Mot2.prosmotr_motor();
						Mot3 = Mot1 + Mot2;
						Console.WriteLine("\n\nДвигатель №3");
						Mot3.prosmotr_motor();
						Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
						Console.ReadKey(true);
					} 
					if (menu == '2' || menu == '3')
                    {
						Koleso Kol1 = new Koleso();
						Koleso Kol2 = new Koleso();
						Console.WriteLine("Колесо №1 ДО: ");
						Kol1.prosmotr_koleso();
						if (menu == '2')
						{
							Kol2 = ++Kol1;
						}
                        else
                        {
							Kol2 = Kol1++;
                        }
						Console.WriteLine("Колесо №1 ПОСЛЕ : ");
						Kol1.prosmotr_koleso();
						Console.WriteLine("Колесо №2 ПОСЛЕ: ");
						Kol2.prosmotr_koleso();
					}
					Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
					Console.ReadKey(true);
				}
				else if (glmenu == '0')
                {
					Console.Clear();
					int n;
					string country = "Japan";
					Console.Write("Введите количество создаваемых колес: ");
					do
					{
							n = Convert.ToInt32(Console.ReadLine());
							if (n < 0)
							{
								Console.Write("Неверно введено значение, попробуйте еще: ");
							}
					} while (n <= 0 && n > 20);
					Koleso Kolesiko1 = new Koleso();
					//Koleso Kolesiko1 = new Koleso();
					Koleso Koles1 = new Koleso();
					
					for (int i = 0; i < n; i++)
					{
						Koles1.new_koleso(30 , 120, 55, "Литье " + country);
						Kolesiko1.Koleso_Massiv(i, Koles1);
					}
					Kolesiko1.Koleso_Massiv_Prosmotr(n);
					
					Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
					Console.ReadKey(true);
				}
			} while (glmenu != 27);
		}
    }
}
