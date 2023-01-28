using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class Chat : Animal
    {
        public Chat(string name) : base(name)
        {
            Pattes = 4;
            Cri = "Miaou (j'ai faim)";
		}

        public void OnAddAnimal(Animal a)
        {
            if (a is Poisson)
            {
                this.Feed(a);
            }
        }

		public override void Feed(Animal? a)
		{
            base.Feed(a);

            if (a == null)
            {
                Cri = "Miaou (c'est bon laisse moi tranquille humain)";
			}
            else if (a is Poisson)
            {
                Cri = "Miaou (Le poisson etait bon)";
			}
		}
	}
}
