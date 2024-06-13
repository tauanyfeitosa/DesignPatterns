using DesignPatterns.Builder.BuilderInterface;
using DesignPatterns.Builder.ProductClass;

namespace DesignPatterns.Builder.ConcretBuilder;

public class HamburguerBuilder: IHamburguerBuilder
{
    private readonly Hamburguer _hamburguer;

    /// <summary>
    /// Embora não seja uma boa prática, no padrão Builder, acoplar um objeto no construtoir é essencial para que
    /// o usuário não precise criar a instancia do objeto, mas apenas utilizar o builder para construir e retornar.
    /// Exemplo de uso no program deste projeto.
    /// </summary>
    public HamburguerBuilder()
    {
        _hamburguer = new Hamburguer();
    }

    public HamburguerBuilder WithBread(string bread)
    {
        _hamburguer.Bread = bread;
        return this;
    }

    public HamburguerBuilder WithMeat(string meat)
    {
        _hamburguer.Meat = meat;
        return this;
    }

    public HamburguerBuilder WithCheese()
    {
        _hamburguer.Cheese = true;
        return this;
    }

    public HamburguerBuilder WithSalad()
    {
        _hamburguer.Salad = true;
        return this;
    }

    public HamburguerBuilder WithSauce()
    {
        _hamburguer.Sauce = true;
        return this;
    }

    public HamburguerBuilder WithBacon()
    {
        _hamburguer.Bacon = true;
        return this;
    }

    public Hamburguer Build() => _hamburguer;
}
