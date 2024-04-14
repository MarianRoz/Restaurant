namespace Restaurant
{
    public interface IFood
    {
        double CalculateHappiness(double happiness);
    }
    abstract class Food : IFood
    {
        public abstract double CalculateHappiness(double happiness);
        protected Food()
        { }
    }
}
