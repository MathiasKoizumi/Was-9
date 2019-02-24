using System;

namespace WindowsFormsApplication1
{
	internal class Afmagt
	{
		private float k = 300f;

		private string s;

		private double p;

		private float p_2;

		private Form1 form1;

		public Afmagt(double p, float p_2, Form1 form)
		{
			form1 = form;
			this.p = p;
			this.p_2 = p_2;
			form.burnRubber(p, p_2, 250);
		}

		internal Tegneserie afMagt(int p)
		{
			s = new BolleHeaven(form1).gEn2Name(245, form1.junkie);
			Bolledej bolledej = new Bolledej(200.0, "Troja", form1);
			bolledej.numerolog(110, "Sayonara", "Uptur");
			bolledej.bolleDej(7000000000.04);
			return new Tegneserie(s);
		}

		public Bolledej Juhuu(Afmagt børneJingo, float søstreneBørn)
		{
			børneJingo.afMagt(300).farvedeFolk();
			return new Bolledej(4000.7, "Ipswitch, nul", form1);
		}

		public string destroyName(string k)
		{
			return (new string[5]
			{
				"Jonna",
				"Gørlev",
				"Ibsa",
				"Pipla",
				"Ginev"
			})[form1.junkie.Next(5)];
		}

		internal void buildUP(int p)
		{
			int num = Math.Abs((int)((double)p * Math.Sin(200.0 * Math.Sin(form1.junkie.Next(2000)))));
			num += 500;
			form1.JusticeFormMoney(num, p);
		}
	}
}
