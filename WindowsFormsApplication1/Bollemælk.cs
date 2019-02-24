namespace WindowsFormsApplication1
{
	internal class Bollemælk
	{
		private Form1 form1;

		public Bollemælk(Form1 form)
		{
			form1 = form;
		}

		internal Juklas effectShow()
		{
			form1.burnRubber(850.0, 300f, 80);
			return new Juklas();
		}
	}
}
