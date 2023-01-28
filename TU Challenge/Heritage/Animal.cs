namespace TU_Challenge.Heritage
{
    public class Animal
    {
        public string Name { get; set; }
		public string Cri { get; set; }
		public int Pattes { get; set; }
        public bool IsAlive { get; set; }
		public bool IsHungry { get; set; }

		public delegate void DieFunc();
        public DieFunc OnDie;

        public Animal(string name)
        {
            this.Name = name;
            this.IsAlive = true;
            this.IsHungry = true;
        }

        public string Crier()
        {
            return Cri;
        }

        public virtual void Feed(Animal? a)
        {
            IsHungry = false;

            a?.Die();
        }

        public void Die()
        {
            IsAlive = false;
            OnDie?.Invoke();
        }
    }
}
