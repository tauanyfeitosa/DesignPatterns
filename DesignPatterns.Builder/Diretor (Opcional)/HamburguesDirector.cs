using DesignPatterns.Builder.BuilderInterface;

namespace DesignPatterns.Builder.Diretor__Opcional_;

public class HamburguesDirector
{
    private readonly IHamburguerBuilder _builder;

    public HamburguesDirector(IHamburguerBuilder builder)
    {
        _builder = builder;
    }

    public void MakeHamburguerXTudo()
    {
        _builder
            .WithBread("Integral")
            .WithMeat("Chicken")
            .WithCheese()
            .WithSalad()
            .WithSauce()
            .WithBacon();
    }

    public void MakeHamburguerWithoutBacon()
    {
        _builder
            .WithBread("White")
            .WithMeat("Beef")
            .WithCheese()
            .WithSalad()
            .WithSauce();
    }

    public void MakeHamburguerWithoutSalad()
    {
        _builder
            .WithBread("White")
            .WithMeat("Beef")
            .WithCheese()
            .WithSauce();
    }
}
