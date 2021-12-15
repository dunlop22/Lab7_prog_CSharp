﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using info_koleso;
using info_motor;
using info_korobka;
using info_obchee;
using info_avto;
using info_koleso_zapaska;

namespace Lab7_prog_CSharp
{
	class Sravnenie<T> where T : Koleso
	{
		public Sravnenie()
		{
		}
		public int Bolshe(T t1, T t2)
		{
			if (t1 > t2)
			{
				return 1;
			}

			else
			{
				return 0;
			}
        }
        public int Menshe(T t1, T t2)
		{
			if (t1 < t2)
			{
				return 1;
			}
			else
			{
				return 0;
			}
		}
	}

	class Summa<T> where T : Motor
	{
		public Summa()
		{
		}
		public double Sum(T t1, T t2)
		{
			return (t1 + t2);
		}
	}
	class Program
    {
		

		static void table_print(Koleso[,] Kol_Massiv)
        {
			for (int i = 0; i < 4; i++)
			{
				Console.WriteLine("*************************************************");
				for (int j = 0; j < 4; j++)
				{
					if (Kol_Massiv[i, j].diametr_info() != -1)
					{
						Console.Write("* " + Kol_Massiv[i,j].dannii() + " ");
					}
					else
					{
						Console.Write("*           ");
					}
				}
				Console.WriteLine("*");
			}
			Console.WriteLine("*************************************************");
		}
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
				Console.WriteLine("1) Общее\n2) Двигатель\n3) Коробка\n4) Колеса\n5) Конст\n6) Сравнение (Шаблон)\n7) Сумма (Шаблон)\n8) Делегат\n9) Интерфейс\n0) Строки\n\nESC - выход");
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

						Console.WriteLine("\n\n1) Ввод собственных данных о колесах\n2) Создание по конструктору");
						menu = Console.ReadKey().KeyChar;
					} while (menu < '1' || menu > '3');
					if (menu == '1')
					{
						Kolesiko.new_koleso_info();
					}
					else if (menu == '2')
					{
						Kolesiko.new_koleso(225, 55, 17, "Литье");
					}
					Console.Clear();
					Kolesiko.prosmotr_koleso();
					Console.WriteLine("Информация о колесах успешно добавлена");
					Console.Write("\n\nВыберите тип запасного колеса: \n1) Полноразмерное\n2) Докатка\n3) Отсутствует");
					
					menu = Console.ReadKey().KeyChar;
					Koleso_Zapaska zapaska = new Koleso_Zapaska();
					if (menu == '1')
                    {
						zapaska.set_new();
						zapaska.vid_set("Полноразмерное");
                    }
					else if (menu == '2')
                    {
						zapaska.new_koleso_info();
						zapaska.vid_set("Докатка");
					}
					else if (menu == '3')
                    {
						zapaska.vid_set("Отсутствует");
					}
					if (menu != '3')
                    {
						Console.Clear();
						Console.Write("Введите количество проколов в шине: ");
						int prokol;
						do
						{
							prokol = Convert.ToInt32(Console.ReadLine());
						} while (prokol < 0);
						zapaska.izm_prokol(prokol);
					}
					Console.Clear();
					zapaska.print();
					if (menu != '3')
                    {
						zapaska.prosmotr_koleso();
					}

					Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
					Console.ReadKey(true);
				}


				else if (glmenu == '5')
                {
					
					Console.Clear();
					Koleso_Zapaska Zapaska = new Koleso_Zapaska();
					
					
					Zapaska.new_koleso(55, 225, 17, "Литье");
					Zapaska.prosmotr_koleso();
					/*
					Koleso koli1 = new Koleso();
					Koleso koli = new Koleso(12);
					Console.WriteLine("Конструктор без параметров: ");
					koli1.prosmotr_koleso();
					Console.WriteLine("\n\nКонструктор с параметром: ");
					koli.prosmotr_koleso();
					Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
					Console.ReadKey(true);
					*/
				}


                /*{
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
					/*Лабораторная работа 12*/

					Koleso kol1 = new Koleso();
					Koleso kol2 = new Koleso();
					kol1.new_koleso(55, 265, 18, "Литье");
					kol2.new_koleso(65, 185, 15, "Ковка");
					Console.WriteLine("Колесо №1");
					kol1.prosmotr_koleso();
					Console.WriteLine("\n\nКолесо №2");
					kol2.prosmotr_koleso();
					Sravnenie<Koleso> Sravni = new Sravnenie<Koleso>();
					Console.WriteLine("\n\n\nКолесо с большей окружностью:");
					if (Sravni.Bolshe(kol1, kol2) == 1)
                    {
						kol1.prosmotr_koleso();
                    }
                    else
                    {
						kol2.prosmotr_koleso();
                    }

					Console.WriteLine("\n\n\nКолесо с меньшей окружностью:");
					if (Sravni.Menshe(kol1, kol2) == 1)
					{
						kol1.prosmotr_koleso();
					}
					else
					{
						kol2.prosmotr_koleso();
					}

					/*
					Koleso_Zapaska Zapaska = new Koleso_Zapaska();
					Koleso kol1 = new Koleso();
					Zapaska.set(13, 75, 185, "Литье", "Докатка");
					kol1.set(17, 55, 255, "Литье");
					Zapaska.print();
					Zapaska.prosmotr_koleso();
					Console.WriteLine("\n\n");
					kol1.prosmotr_koleso();
					*/
					/*
					Koleso[] koleso_mass = new Koleso[3];
					for (int i = 0;i < 3;  i++)
                    {
						koleso_mass[i] = new Koleso(12);
						Console.WriteLine("\nКолесо №" + (i + 1));
						koleso_mass[i].prosmotr_koleso();
                    }
					*/
					Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
					Console.ReadKey(true);
				}
                /*{
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
				*/


				else if (glmenu == '7')
                {
					Console.Clear();
					/*Лабораторная работа 13*/
					
					Motor mot1 = new Motor();
					Motor mot2 = new Motor();

					mot1.new_motor("2GR-FE", 249, 3.5, 4, 10, 6);
					mot2.new_motor("FB20", 150, 2.0, 4, 10, 4);
					Console.WriteLine("Двигатель №1:");
					mot1.prosmotr_motor();
					Console.WriteLine("\n\nДвигатель №2:");
					mot2.prosmotr_motor();

					Summa<Motor> Vsego = new Summa<Motor>();
					Console.WriteLine("\n\nОбщее количество лошадиных сил в 2-х двигателя: " + Vsego.Sum(mot1, mot2));

					/*
					Koleso_Zapaska Zapaska = new Koleso_Zapaska(17, 45, 265, "Литье", "Полноразмерное");
					Zapaska.print();
					Console.WriteLine(Zapaska);
					*/
					//Zapaska.prosmotr_koleso();
					/*Koleso Koles1 = new Koleso();
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
					*/
					Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
					Console.ReadKey(true);
				}
				else if (glmenu == '8')
                {
					Console.Clear();
					Koleso kol = new Koleso(17, 55, 225, "Литье");

					Console.WriteLine("Периметр колеса: " + kol.perimetr() + "мм");
					Console.WriteLine("Объем колеса: " + Math.Round(kol.obem(), 2) + "м^3\n");
					kol.prosmotr_koleso();
					/*
					Console.Write("Введите количество колес для создания массива: ");
					Koleso[] Kol_Massiv = new Koleso[10];
					Koleso temp = new Koleso();
					int n;
					do
					{
						n = Convert.ToInt32(Console.ReadLine());
						if (n < 0)
						{
							Console.Write("Неверно введено значение, попробуйте еще: ");
						}
					} while (n < 0 || n > 10);
					
					for (int i = 0 ; i < n; i++)
                    {
						temp.new_koleso(30 + i * 5, 130 + i * 5, 13 + i * 2, "Enkei №"  + (i + 1) + " Japan");
						Kol_Massiv[i] = temp;
						Kol_Massiv[i].prosmotr_koleso();
					}
					*/
					Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
					Console.ReadKey(true);
				}
				else if (glmenu == '9')
                {

					Console.Clear();
					Motor mot1 = new Motor();
					Motor mot2 = new Motor();
					mot1.new_motor("2GR-FE", 249, 3.5, 4, 10, 6);
					mot2.new_motor("FB20", 150, 2, 4, 7, 4);
					Console.WriteLine("Двигатель №1");
					Console.WriteLine("Максимальное значение мощности в кВТ: " + Math.Round(mot1.Max_KWT(), 1));
					Console.WriteLine("Текущее значение мощности в кВТ: " + Math.Round(mot1.KWT()), 1);

					Console.WriteLine("\n\nДвигатель №2");
					Console.WriteLine("Максимальное значение мощности в кВТ: " + Math.Round(mot2.Max_KWT()), 1);
					Console.WriteLine("Текущее значение мощности в кВТ: " + Math.Round(mot2.KWT()), 1); 
					/*//Koleso Kol_Mass[4][4];
					int podmenu;
					Koleso[,] Kol_Massiv = new Koleso[4,4];
					Koleso temp = new Koleso();
					for (int i =0;i<4;i++)
                    {
						for (int j = 0; j < 4; j++)
                        {
							Kol_Massiv[i, j] = new Koleso(-1);
                        }

					}
					do
					{
						temp.new_koleso_info();
						Console.Clear();
						table_print(Kol_Massiv);
						temp.prosmotr_koleso();
						int m, k;
						do
						{
							Console.Write("Введите номер строки: ");
							m = Convert.ToInt32(Console.ReadLine());
						} while (m < 1 || m > 4);

						do
						{
							Console.Write("Введите номер столбца: ");
							k = Convert.ToInt32(Console.ReadLine());
						} while (k < 1 || k > 4);

						Kol_Massiv[m - 1, k - 1] = temp;
						Console.Clear();
						table_print(Kol_Massiv);
						Console.WriteLine("\n\n0) Выход в меню\n Любая клавиша - продолжение");
						podmenu = Convert.ToInt32(Console.ReadLine());
					} while (podmenu != 0);
					/*
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
					}*/
					Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
					Console.ReadKey(true);
				}
				else if (glmenu == '0')
                {
					Console.Clear();
					Koleso kol1 = new Koleso();
					Koleso kol2 = new Koleso();
					kol1.new_koleso(55, 225, 17, "Литье");
					kol2.new_koleso(55, 245, 19, "Литье");
					Console.WriteLine("Колесо №1 до мелкого копирования:");
					kol1.prosmotr_koleso();
					Console.WriteLine("Колесо №2 до мелкого копирования:");
					kol2.prosmotr_koleso();
					kol2 = kol1;
					kol2.new_koleso(35, 285, 21, "Ковка");

					Console.WriteLine("\n\n**********************************************\nКолесо №1 после мелкого копирования:");
					kol1.prosmotr_koleso();
					Console.WriteLine("Колесо №2 после мелкого копирования:");
					kol2.prosmotr_koleso();


					Console.WriteLine("\n\n****************************************************************\n\n");

					Koleso kol3 = new Koleso();
					Koleso kol4 = new Koleso();
					kol3.new_koleso(55, 225, 17, "Литье");
					kol4.new_koleso(55, 245, 19, "Литье");
					Console.WriteLine("Колесо №1 до глубоко копирования:");
					kol3.prosmotr_koleso();
					Console.WriteLine("Колесо №2 до глубоко копирования:");
					kol4.prosmotr_koleso();
					kol4 = (Koleso)kol3.Copy();
					kol4.new_koleso(55, 265, 21, "Ковка");
					Console.WriteLine("\n\n**********************************************\nКолесо №1 после глубоко копирования:");
					kol3.prosmotr_koleso();
					Console.WriteLine("Колесо №2 после глубоко копирования:");
					kol4.prosmotr_koleso();
					/*int n;
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
					*/
					Console.WriteLine("\n\nНажмите любую клавишу для возврата в меню.");
					Console.ReadKey(true);
				}
			} while (glmenu != 27);
		}
    }
}
