using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace info_koleso
{
	class Koleso
	{
		
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
		}

		public void new_koleso(Int32 visota, Int32 shirina, Int32 diametr, string tip_diska)
		{
			this.tip_diska = tip_diska;
			this.shirina = shirina;
			this.visota = visota;
			this.diametr = diametr;
		}

		public void prosmotr_koleso()
		{
			if (visota >= 0)
			{
				Console.WriteLine("\nИНФОРМАЦИЯ О КОЛЕСАХ\n\nШирина колеса: " + shirina + "\nДиаметр колеса: " + diametr + "\nВысота колеса: " + visota + "\nТип диска: " + tip_diska);
			}
			else
			{
				Console.WriteLine("Информация о колесе еще не была добавлена");
			}
		}

		public void koleso_diametr()
		{
			if (visota >= 0)
			{
				Console.Write("Введите новый диаметр колеса: ");
				do
				{
					diametr = Convert.ToInt32(Console.ReadLine());
					if (diametr < 0)
					{
						Console.Write("Неверно введено значение диаметра, попробуйте еще: ");
					}
				} while (diametr < 0);
				Console.WriteLine("Диаметр колеса успешно изменен");
			}
			else
			{
				Console.WriteLine("Информация о колесе еще не была добавлена");
			}
		}
		public Int32 koleso_get()
		{
			if (this.diametr >= 0)
			{
				return 1;
			}
			else
			{
				return 0;
			}
		}

		private int visota = -1;
		private int shirina = -1;
		private int diametr = -1;
		private string tip_diska = "";
	}
}
