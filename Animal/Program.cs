namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.MakeSound();

            Dog dog = new Dog();
            dog.MakeSound();
        }
    }
}