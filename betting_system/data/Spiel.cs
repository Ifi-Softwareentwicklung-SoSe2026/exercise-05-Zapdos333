namespace data;

public class Spiel(DateTime zeit, Mannschaft heim, Mannschaft auswärts)
{
    private static uint ids = 0;
    public uint SpielId { get; } = Interlocked.Increment(ref ids) - 1;
    public DateTime SpielZeit { get; } = zeit;
    public SpielErgebnis? Ergebnis { get; set; }
    public Dictionary<string, decimal> Quoten { get; } = new();
    public Mannschaft HeimMannschaft { get;} = heim;
    public Mannschaft AuswärtsMannschaft { get; } = auswärts;
    private Dictionary<string, Wetttyp> Wetttypen { get; } = new();

    public void RegistriereWetttyp(Wetttyp wettyp)
    {
        Wetttypen.Add(wettyp.Name, wettyp);
    }

    public void WerteWettenAus(Benutzer nutzer)
    {
        if (Ergebnis == null)
            return;
        List<Wette> wetten;
        if (!nutzer.Wetten.Remove(SpielId, out wetten))
            return;
        foreach (var wette in wetten)
        {
            Wetttyp typ = Wetttypen[wette.Typ];
            if (typ.HatGewonnen(Ergebnis))
                nutzer.Guthaben += typ.Quote * wette.Einsatz;
        }
    }
}


public record Mannschaft(string Name);
public record Gruppe(string Name, List<Mannschaft> Teams);
public record SpielErgebnis(uint ToreHeim, uint ToreAuswärts);
