using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace info_motor
{
	interface KWT
	{
		double Max_KWT();
		double KWT();
	}
	class Motor : KWT
	{
		/*
		 public static Motor operator +(Motor mot1, Motor mot2)
        {

			Motor novii = new Motor();
			novii = mot1;
			novii.koni = novii.koni + mot2.koni;
			novii.rab_obem = novii.rab_obem + mot2.rab_obem;
			return (novii);
        }
		*/

		public static double operator +(Motor mot1, Motor mot2)
		{
			return (mot1.koni + mot2.koni);
		}

		public double Max_KWT()	//вывод максимально возможной мощности (в квтч) после апгрейда
        {
			if (this.rab_obem > 2.0)
            {
				return (this.koni * 1.2 / 1.3596);
			}
			else
            {
				return (this.koni * 1.1 / 1.3596);
			}
			
        }

		public double KWT()	//вывод текущей мощности (в квтч)
		{
			return (this.koni / 1.3596);
		}

		public void New_Motor_Info()
		{
			Console.Write("Добавление информации о двигателе\n\nВведите маркировку двигателя: ");
			do
			{
				name = Console.ReadLine();
				if (name.Length == 0)
				{
					Console.Write("Неверно введена маркировка двигателя, попробуйте еще: ");
				}
			} while (name.Length == 0);

			Console.Write("Введите рабочий объем двигателя в литрах: ");
			do
			{
				rab_obem = Convert.ToDouble(Console.ReadLine());
				if (rab_obem < 0)
				{
					Console.Write("Неверно введено значение объема двигателя, попробуйте еще: ");
				}
			} while (rab_obem < 0);

			Console.Write("Введите количество лошадинных сил: ");
			do
			{
				koni = Convert.ToDouble(Console.ReadLine());
				if (koni < 0)
				{
					Console.Write("Неверно введено значение количества лошадиных сил, попробуйте еще: ");
				}
			} while (koni < 0);

			Console.Write("Введите средний расход топлива на 100км в литрах: ");
			do
			{
				rasxod = Convert.ToDouble(Console.ReadLine());
				if (rasxod < 0)
				{
					Console.Write("Неверно введено значение расхода на 100км, попробуйте еще: ");
				}
			} while (rasxod < 0);


			Console.Write("Введите количество цилиндров: ");
			do
			{
				kol_vo_cilindr = Convert.ToDouble(Console.ReadLine());
				if (kol_vo_cilindr < 0)
				{
					Console.Write("Неверно введено значение количества цилиндров, попробуйте еще: ");
				}
			} while (kol_vo_cilindr < 0);

			Console.Write("Введите количество клапанов на один цилиндр: ");
			do
			{
				klapan = Convert.ToDouble(Console.ReadLine());
				if (klapan < 0)
				{
					Console.Write("Неверно введено значение количества клапанов, попробуйте еще: ");
				}
			} while (klapan < 0);
		}

		public void prosmotr_motor()
		{
			if (koni > 0)
			{
				Console.Write("ИНФОРМАЦИЯ О ДВИГАТЕЛЕ:\n\nМаркировка двигателя: " + name + "\nРабочий объем: " + rab_obem + "\nМощность (л.с.): " + koni + "\nСредний расход на 100км: " + rasxod + "\nКоличество цилиндров: " + kol_vo_cilindr + "\nКоличество клапанов на 1 цилиндр: " + klapan);
			}
			else
			{
				Console.WriteLine("Информация о двигателе отсутствует");
			}
		}

		public void new_motor(string name, double koni, double rab_obem, double klapan, double rasxod, double kol_vo_cilindr)
		{
			if (koni != 0)
			{
				this.koni = koni;
			}
			if (kol_vo_cilindr != 0)
            {
				this.kol_vo_cilindr = kol_vo_cilindr;
			}
			if (name != " ")
			{
				this.name = name;
			}
			if (rab_obem != 0)
			{
				this.rab_obem = rab_obem;
			}
			if (rasxod != 0)
			{
				this.rasxod = rasxod;
			}
			if (klapan != 0)
			{
				this.klapan = klapan;
			}
        }


        private string name = "";
		private double koni = -1;
		private double rab_obem = -1;
		private double rasxod = -1;
		private double kol_vo_cilindr = -1;
		private double klapan = -1;
		
	}
}
