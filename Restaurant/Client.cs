namespace Restaurant
{
    public class Client
    {
        public double Happiness { get; set; }
        public string Name { get; }
        public Client(string name, double happiness)
        {
            Name = name;
            Happiness = happiness;
        }
        public void Eat(IFood food)
        {
            Happiness = food.CalculateHappiness(Happiness);
        }
    }
}
