﻿using DesignPatterns.FactoryMethod.Product;
using DesignPatterns.FactoryMethod.Product.ProductCroncrete;

namespace DesignPatterns.FactoryMethod.Creator.CreatorConcrete
{
    public class CreatorScreenWeb : ICreatorScreen
    {
        public Screen FactoryMethod()
        {
            return new ScreenWeb("White", "Hello World");
        }
    }
}
