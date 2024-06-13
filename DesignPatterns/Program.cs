using DesignPatterns.Builder.BuilderInterface;
using DesignPatterns.Builder.ConcretBuilder;
using DesignPatterns.Builder.Diretor__Opcional_;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHamburguerBuilder builder = new HamburguerBuilder();
            var director = new HamburguesDirector(builder);

            director.MakeHamburguerXTudo();
            var xTudo = builder.Build();
            Console.WriteLine(xTudo);

            builder = new HamburguerBuilder();
            director = new HamburguesDirector(builder);

            director.MakeHamburguerWithoutBacon();
            var withoutBacon = builder.Build();
            Console.WriteLine(withoutBacon);
        }
    }
}
