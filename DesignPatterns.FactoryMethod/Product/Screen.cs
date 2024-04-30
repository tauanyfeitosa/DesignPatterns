namespace DesignPatterns.FactoryMethod.Product
{
    public abstract class Screen
    {
        public string BackGroundColor { get; set; }
        public string Message { get; set; }

        public Screen(string backGroundColor, string message)
        {
            BackGroundColor = backGroundColor;
            Message = message;
        }
    }
}
