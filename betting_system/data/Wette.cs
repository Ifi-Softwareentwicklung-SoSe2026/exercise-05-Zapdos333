namespace data;

public record Wette(string Typ, decimal Einsatz);

public class Benutzer(string name)
{
    public string Name { get; } = name;
    public decimal Guthaben { get; set; }
    public Dictionary<uint, List<Wette>> Wetten { get; } = new();
}

public abstract class Wetttyp(string name, decimal quote)
{
    public string Name { get; } = name;
    public decimal Quote { get; } = quote;
    public abstract bool HatGewonnen(SpielErgebnis ergebnis);
}

public class SiegWette(bool heim, decimal quote) : Wetttyp("SiegWette", quote)
{
    public bool AufHeim { get; } = heim;
    public override bool HatGewonnen(SpielErgebnis ergebnis)
    {
        if (AufHeim)
        {
            return ergebnis.ToreHeim > ergebnis.ToreAuswärts;
        }
        return ergebnis.ToreAuswärts > ergebnis.ToreHeim;
    }
}

public class ErgebnisWette(SpielErgebnis ergebnis, decimal quote) : Wetttyp("ErgebnisWette", quote)
{
    public SpielErgebnis Ziel { get; } = ergebnis;
    public override bool HatGewonnen(SpielErgebnis ergebnis)
    {
        return ergebnis == Ziel;
    }
}
