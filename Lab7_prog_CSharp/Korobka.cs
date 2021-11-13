using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace info_korobka
{
	class Korobka
	{

		public void Korobka_Massiv(Korobka kor1)
		{
			if (kolvo_korobok > 0)
			{
				Array.Resize(ref Korobka_Mass, kolvo_korobok + 1);
			}
			Korobka_Mass[kolvo_korobok] = kor1;
			kolvo_korobok++;
		}

		public void Korobka_Massiv_Prosmotr()
        {
			for (int i = 0; i < kolvo_korobok; i++)
            {
				Console.WriteLine();
				Korobka_Mass[i].prosmotr_korobka();
			}
		}


		public void Massiv_plus(int n)
        {
			Korobka[] Korobka_Mass_2 = new Korobka[n + 1];
			for (int i = 0; i < n; i++)
			{
				Korobka_Mass_2[i] = Korobka_Mass[i];
			}
			Korobka_Mass = Korobka_Mass_2;

		}

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
				kolvo_peredach = Convert.ToInt32(Console.ReadLine());
				if (kolvo_peredach < 0)
				{
					Console.Write("Неверно введено значение количества передач, попробуйте еще: ");
				}
			} while (kolvo_peredach < 0);
		}

		public void korobka_new(string tip_korobki, int kolvo_peredach)
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

		private int kolvo_peredach = -1;
		private string tip_korobki = "";
		private int kolvo_korobok = 0;
		private Korobka[] Korobka_Mass = new Korobka[2];
	}
}
