using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace info_koleso
{
	class Koleso
	{
		public static Koleso operator ++(Koleso Kol1)
		{
			Koleso kol = new Koleso();
			kol.diametr = Kol1.diametr + 1;
			return kol;
		}

		public void Koleso_Massiv_Prosmotr(int n)
		{
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine();
				Koleso_Mass[i].prosmotr_koleso();
			}
		}

		public void Koleso_Massiv(int n, Koleso kol1)
		{
			Array.Resize(ref Koleso_Mass, n + 1);
			Koleso_Mass[n] = kol1;
		}

		public int Diametr
        {
			get 
			{
				return diametr; 
			}
			set
            {
				if ((value > 0) && (value < 20))
                {
					diametr = value;
                }
				else if (value <= 0)
                {
					diametr = 0;
                }
				else if (value >= 20)
                {
					diametr = 20;
                }
            }
        }

		public int Visota
        {
			get
            {
				return visota;
            }
            set
            {
				if ((value > 0) && (value < 65))
				{
					visota = value;
				}
				else if (value <= 0)
				{
					visota = 0;
				}
				else if (value >= 65)
				{
					visota = 70;
				}
			}
        }

		public int Shirina
        {

			get
            {
				return shirina;
            }
            set
            {
				if ((value > 0) && (value < 200))
				{
					shirina = value;
				}
				else if (value <= 0)
				{
					shirina = 0;
				}
				else if (value >= 200)
				{
					shirina = 200;
				}
			}
        }

		public void new_koleso_info()
		{
			Console.Write("Добавление информации о колесах автомобиля\n\nВведите ширину колеса: ");

			do
			{
				shirina = Convert.ToInt32(Console.ReadLine());
				if (shirina < 0)
				{
					Console.Write("Неверно введено значение ширины колеса, попробуйте еще: ");
				}
			} while (shirina < 0);


			Console.Write("Введите высоту колеса: ");
			do
			{
				visota = Convert.ToInt32(Console.ReadLine());
				if (visota < 0)
				{
					Console.Write("Неверно введено значение высоты колеса, попробуйте еще: ");
				}
			} while (visota < 0);

			Console.Write("Введите диаметр колеса в дюймах: ");
			do
			{
				diametr = Convert.ToInt32(Console.ReadLine());
				if (diametr < 0)
				{
					Console.Write("Неверно введено значение диаметра колеса, попробуйте еще: ");
				}
			} while (diametr < 0);


			Console.Write("Введите тип колесного диска (штамповка/литье/ковка): ");
			do
			{
				tip_diska = Console.ReadLine();
				if (tip_diska == "")
				{
					Console.Write("Неверно введен тип колесного диска, попробуйте еще: ");
				}
			} while (tip_diska == "");
			kolvo_kolesa = kolvo_kolesa + 1;
			id_new(id);
		}

		public void new_koleso(Int32 visota, Int32 shirina, Int32 diametr, string tip_diska)
		{
			id_new(id);
			this.tip_diska = tip_diska;
			this.shirina = shirina;
			this.visota = visota;
			this.diametr = diametr;
			kolvo_kolesa = kolvo_kolesa + 1;
		}

		public void prosmotr_koleso()
		{
			string s;
			Console.WriteLine("\nИНФОРМАЦИЯ О КОЛЕСАХ\n\nID: " + (s = id_return().ToString("000000")) + "\nШирина колеса: " + shirina + "\nДиаметр колеса: " + diametr + "\nВысота колеса: " + visota + "\nТип диска: " + tip_diska);
		}

		public static int id_return()
        {
			return id_kolesa;
        }

		public static void id_new(int id)
        {
			id_kolesa = id_kolesa + 1;
			id = id_kolesa;
		}

		public static int kolvo_koles()
        {
			return kolvo_kolesa;
        }
		public static void koleso_del()
        {
			kolvo_kolesa = kolvo_kolesa - 1;
        }

		private int visota = 55;
		private int shirina = 225;
		private int diametr = 17;
		private string tip_diska = "Литье";
		private Koleso[] Koleso_Mass = new Koleso[1];
		private int id;
		private static int kolvo_kolesa = 0;
		private static int id_kolesa = 0;

	}
}
