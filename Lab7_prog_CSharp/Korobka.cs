using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace info_korobka
{
	class Korobka
	{
		public double kolvo_peredach = -1;
		public string tip_korobki = "";


		public void new_korobka_info()
		{
			Console.Write("Добавление информации о коробке передач автомобиля\n\nВведите тип коробки передач (АКПП/МКПП): ");
			do
			{
				tip_korobki = Console.ReadLine();
				if (tip_korobki == "")
				{
					Console.Write("Неверно введена модель автомобиля, попробуйте еще: ");
				}
			} while (tip_korobki == "");

			Console.Write("Введите количество передач коробки: ");
			do
			{
				kolvo_peredach = Convert.ToDouble(Console.ReadLine());
				if (kolvo_peredach < 0)
				{
					Console.Write("Неверно введено значение количества передач, попробуйте еще: ");
				}
			} while (kolvo_peredach < 0);
		}

		public void korobka_new(string tip_korobki, double kolvo_peredach)
		{
			this.kolvo_peredach = kolvo_peredach;
			this.tip_korobki = tip_korobki;
		}

		public void prosmotr_korobka()
		{
			if (kolvo_peredach >= 0)
			{
				Console.Write("\nИНФОРМАЦИЯ О КОРОБКЕ ПЕРЕКЛЮЧЕНИЯ ПЕРЕДАЧ\n\nТип коробки переключения передач: " + tip_korobki + "\nКоличество передач коробки: " + kolvo_peredach);
			}
			else
			{
				Console.WriteLine("Информация о коробке передач отсутствует");
			}
		}
	}
}
