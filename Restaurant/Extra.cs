namespace Restaurant
{
    public abstract class Extra : IFood
    {
        protected IFood Food { get; set; }
        public abstract double CalculateHappiness(double happiness);
        internal Extra(IFood food)
        {
            Food = food;
        }
    }
}
