using DesignPatterns.FactoryMethod.Product;
using DesignPatterns.FactoryMethod.Product.ProductCroncrete;

namespace DesignPatterns.FactoryMethod.Creator.CreatorConcrete
{
    public class CreatorScreenPhone : ICreatorScreen
    {
        public Screen FactoryMethod()
        {
            return new ScreenPhone("Black", "Hello World! Send my Iphone");
        }
    }
}
