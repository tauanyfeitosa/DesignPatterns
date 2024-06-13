using DesignPatterns.Builder.ConcretBuilder;
using DesignPatterns.Builder.ProductClass;

namespace DesignPatterns.Builder.BuilderInterface;

public interface IHamburguerBuilder
{
    HamburguerBuilder WithBread(string bread);

    HamburguerBuilder WithMeat(string meat);

    HamburguerBuilder WithCheese();

    HamburguerBuilder WithSalad();

    HamburguerBuilder WithSauce();

    HamburguerBuilder WithBacon();

    Hamburguer Build();
}
