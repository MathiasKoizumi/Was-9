namespace WindowsFormsApplication1
{
	internal class Børneleg
	{
		private Form1 form1;

		public Børneleg(Form1 form)
		{
			form1 = form;
		}

		internal int passMeTheSugar(int p)
		{
			new Bolledej(600.0, "FiretursindeÅrsPåske", form1).tumbeDej();
			p += p;
			p = p * p - p;
			return p / 2;
		}
	}
}
