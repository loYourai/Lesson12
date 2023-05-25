
//var dog = new Dog("Jack", "white", 15);
////var cat = new Cat("Sally", "black", 10);

//var cat1 = new Cat("Mary", "white", 12, false);
//var cat2 = new Cat("Mary", "white", 10, true);


//var catEquals = cat2.Equals(cat1);
//var dogEquals = cat2.Equals(dog);
//var stringEquals = cat2.Equals("cat");

//var code = cat2.GetHashCode();

//Console.WriteLine("Cat equals: " + catEquals);
//Console.WriteLine("Dog equals: " + dogEquals);
//Console.WriteLine("String equals: " + stringEquals);

//cat.SaySmth();
//dog.SaySmth();


//MakeNoise(cat);
//MakeNoise(dog);

//Console.WriteLine(cat.ToString());









public class ToyCat : Cat
{
    public ToyCat(string name, string color, decimal weight, bool isLazy) : base(name, color, weight, isLazy)
    {
        IsLazy = false;
    }

    public new void SaySmth()
    {
        Console.WriteLine("Toy cat!");
    }

    //public override string ToString()
    //{
    //    var isLazy = IsLazy ? "lazy" : "not lazy";

    //    return $"I'm a toy cat! My name is {Name}";
    //}
}