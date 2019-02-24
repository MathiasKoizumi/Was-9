using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
	internal class Tegneserie
	{
		private Lingo børnemuseum;

		private Jingo juklas;

		private JoyRomeo jongo;

		private string s;

		private Random k = new Random();

		private Form1 form1;

		public static int Hugo
		{
			get;
			set;
		}

		public Tegneserie(JoyRomeo romeo, Form1 form)
		{
			form1 = form;
			børnemuseum = new Lingo(new Børneleg(form1).passMeTheSugar(320), new Børnetid(new Afmagt(700.0, 440f, form), form1), 350, form1);
			juklas = romeo.partyTime();
			jongo = romeo;
			new Afmagt(200.0, 5000f, form1).buildUP(300);
		}

		public Tegneserie(string s)
		{
			this.s = s;
		}

		internal IEnumerable<Mood> farvedeFolk()
		{
			yield return new Mood(form1).affectMood(k.Next(300));
			yield return new Mood(form1).affectMood(k.Next(300));
			yield return new Mood(form1).affectMood(k.Next(200));
			yield return new Mood(form1).affectMood(k.Next(300));
			yield return new Mood(form1).affectMood(k.Next(400));
			yield return new Mood(form1).affectMood(k.Next(300));
			yield return new Mood(form1).affectMood(k.Next(100));
			yield return new Mood(form1).affectMood(k.Next(300));
			yield return new Mood(form1).affectMood(k.Next(300));
			yield return new Mood(form1).affectMood(k.Next(2000));
		}

		internal void lineUpSi(double p, double p_2)
		{
			throw new NotImplementedException();
		}
	}
}
