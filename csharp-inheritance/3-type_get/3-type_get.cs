public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Happiness { get; set; }

    // Constructor
    public Dog()
    {
        Name = string.Empty; // or null if it's appropriate for Name to be nullable
        Age = 0;
        Happiness = 0;
    }

    // Methods...
}
