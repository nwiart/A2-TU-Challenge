using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class Animalerie
    {
		public delegate void AddAnimalDelegate(Animal a);
		public event AddAnimalDelegate? OnAddAnimal;

		private List<Animal> _animals = new List<Animal>();

        public void AddAnimal(Animal a)
        {
			_animals.Add(a);
			OnAddAnimal?.Invoke(a);

			if (a is Chat && !(a is ChatQuiBoite))
            {
                OnAddAnimal += ((Chat) a).OnAddAnimal;
                foreach (Animal a0 in _animals)
                {
                    if (a0 is Poisson)
                    {
                        a.Feed(a0);
                        break;
                    }
                }
            }
		}

        public bool Contains(Animal a)
        {
            return _animals.Contains(a);
        }

        public Animal GetAnimal(int index)
        {
            return _animals[index];
        }

        public void FeedAll()
        {
            foreach (Animal a in _animals)
            {
                a.Feed(null);
            }
        }
    }
}
