namespace DesignPatterns.Builder.ProductClass;

public class Hamburguer
{
    public string Bread { get; set; } = string.Empty;
    public string Meat { get; set; } = string.Empty;
    public bool Cheese { get; set; }
    public bool Salad { get; set; }
    public bool Sauce { get; set; }

    public bool Bacon { get; set; }

    public override string ToString()
    {
        return $"Bread: {Bread}, Meat: {Meat}, Cheese: {YesOrNot(Cheese)}, Salad: {YesOrNot(Salad)}, " +
            $"Sauce: {YesOrNot(Sauce)}, Bacon: {YesOrNot(Bacon)}";
    }

    private string YesOrNot(bool value) => value ? "Yes" : "No";
}
