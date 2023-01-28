using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
	public class Chien : Animal
	{
		public Chien(string name) : base(name)
		{
			Cri = "Ouaf (j'ai faim)";
		}

		public override void Feed(Animal? a)
		{
			if (a != null) throw new ArgumentException(); // Just in case...

			base.Feed(a);
			Cri = "Ouaf (viens on joue ?)";
		}
	}
}
