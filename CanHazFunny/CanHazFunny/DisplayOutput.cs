namespace CanHazFunny
{
    public class DisplayOutput : IJokeDisplay
    {
        public void Display(string message)
        {
            Console.WriteLine(message);
        }
    }
}