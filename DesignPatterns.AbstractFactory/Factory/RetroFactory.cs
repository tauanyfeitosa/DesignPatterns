
using DesignPatterns.AbstractFactory.Products;
using DesignPatterns.AbstractFactory.Products.RetroFamily;

namespace DesignPatterns.AbstractFactory.Factory
{
    public class RetroFactory : IFactory
    {
        public IChair CreateChair()
        {
            return new RetroChair();
        }

        public ISofa CreateSofa()
        {
            return new RetroSofa();
        }
    }
}
