
using DesignPatterns.AbstractFactory.Products;
using DesignPatterns.AbstractFactory.Products.VictorianFamily;

namespace DesignPatterns.AbstractFactory.Factory
{
    public class VictorianFactory : IFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
