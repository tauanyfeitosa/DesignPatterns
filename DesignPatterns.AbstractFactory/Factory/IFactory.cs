
using DesignPatterns.AbstractFactory.Products;

namespace DesignPatterns.AbstractFactory.Factory
{
    public interface IFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
    }
}
