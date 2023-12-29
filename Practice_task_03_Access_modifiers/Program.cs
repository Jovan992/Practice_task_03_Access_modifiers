namespace Practice_task_03_Access_modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();

            cat.SetLimbs(4);
            cat.ShowLimbs();

            cat.SetTail(true);
            cat.ShowTail();

            Console.ReadLine();
        }
    }

    public class Animal
    {
        protected int Limbs { get; set; }
        protected bool Tail { get; set; }
    }
    public class Cat : Animal
    {
        public void SetLimbs(int a)
        {
            Limbs = a;
        }

        public void ShowLimbs()
        {
            if (Limbs > 0)
            {
                Console.WriteLine($"This cat has {Limbs} limbs");
            }
            else
            {
                Console.WriteLine("Number of cats limbs is not provided.");
            }
        }

        public void SetTail(bool tail)
        {
            Tail = tail;
        }

        public void ShowTail()
        {
            if (Tail)
            {
                Console.WriteLine($"This cat has a tail.");
            }
            else
            {
                Console.WriteLine($"This cat doesn't have a tail.");
            }
        }
    }
}
