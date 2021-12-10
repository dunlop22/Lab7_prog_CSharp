using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

		public void set (int diametr, int visota, int shirina, string tip_diska)
        {
			this.diametr = diametr;
			this.visota = visota;
			this.shirina = shirina;
			this.tip_diska = tip_diska;
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

		public String dannii()
        {
			return (this.shirina + "/" + this.visota + "/" + this.diametr);
        }

		public int diametr_info()
        {
			return (this.diametr);
        }

		public int auto_othoshenie()
        {
			if (visota == 0)
            {
				throw new Exception("\nВысота равна 0. Подсчет невозможен\n");
			}
			return (shirina * visota / 100);
        }

		public int check_param(int min, int max, ref int orig)
        {
			int temp;
			try
			{
				temp = Convert.ToInt32(Console.ReadLine());
				if (temp < min)
				{
					throw new Exception ("Введено отрицательное значение.");
				}
				else if (temp > max)
				{
					throw new Exception("Введено слишком большое значение.");
				}
				Console.Write("Значение удовлетворяет условию. \n\n");
				orig = temp;
				return 1;
			}
			catch (Exception e)
            {
				Console.Write(e.Message + "\nПовторите попытку: ");
			}
			return 0;
		}

		public void new_koleso_info()
		{
			Console.Clear();
			Console.Write("Добавление информации о колесах автомобиля\n\nВведите ширину колеса: ");

			do { } while (check_param(0, 300, ref shirina) == 0);

			Console.Write("Введите высоту колеса: ");
			do { } while (check_param(0, 70, ref visota) == 0);

			Console.Write("Введите диаметр колеса в дюймах: ");
			do { } while (check_param(0, 25, ref diametr) == 0);
			
			Console.Write("Введите тип колесного диска (штамповка/литье/ковка): ");
			do
			{
				tip_diska = Console.ReadLine();
				if (tip_diska == "")
				{
					Console.Write("Неверно введен тип колесного диска, попробуйте еще: ");
				}
			} while (tip_diska == "");

			try
			{
				othoschenie = auto_othoshenie();
			}
			catch (Exception e)
			{
				Console.Write(e.Message + "\nПовторите попытку: ");
			}

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


		public override string ToString()
		{
			string s = "";
			s += "\nШирина колеса: " + Convert.ToString(shirina) + "\nДиаметр колеса: " + Convert.ToString(diametr) + "\nВысота колеса: " + Convert.ToString(visota) + "\nТип диска: " + Convert.ToString(tip_diska);
			return s;
		}

		public void prosmotr_koleso()
		{
			string s;
			Console.WriteLine("\nИНФОРМАЦИЯ О КОЛЕСАХ\n\nШирина колеса: " + shirina + "\nДиаметр колеса: " + diametr + "\nВысота колеса: " + visota + "\nТип диска: " + tip_diska + "\nКоличество проколов в шине: " + kolvo_prokolov);
			if (this.othoschenie != 0)
			{
				Console.WriteLine("Высота колеса (мм): " + othoschenie);
			}
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

		//конструктор без параметров
		public Koleso()
        {
			this.diametr = 17;
			this.shirina = 225;
			this.visota = 55;
			this.tip_diska = "Литье";
			this.id = 050120 + kolvo_kolesa;
			kolvo_kolesa = kolvo_kolesa + 1;
			this.othoschenie = 0;
		}

		//Конструктор с одним параметром
		public Koleso(int diametr)
        {
			this.diametr = diametr;
			this.shirina = 225;
			this.visota = 55;
			this.tip_diska = "Литье";
			this.id = 050120 + kolvo_kolesa;
			kolvo_kolesa = kolvo_kolesa + 1;
			this.othoschenie = 0;
		}

		public Koleso(int diametr, int visota, int shirina, string tip_diska)
        {
			this.diametr = diametr;
			this.visota = visota;
			this.shirina = shirina;
			this.tip_diska = tip_diska;
        }
		public void izm_prokol(int prok)
        {
			this.kolvo_prokolov = prok;
        }

		protected int kolvo_prokolov = 0;
		public int visota = 55;
		public int shirina = 225;
		public int diametr = 17;
		private int othoschenie;
		public string tip_diska = "Литье";
		private Koleso[] Koleso_Mass = new Koleso[1];
		private int id;
		private static int kolvo_kolesa = 0;
		private static int id_kolesa = 0;

	}
}
