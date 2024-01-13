namespace ConsoleApp2;

public class DaraiiNezami
{
    private List<Vizhe> _vizhes = new();
    public DaraiiNezami(int soldier , int tank , int jet ,List<Vizhe> vizhes)
    {
        Soldier = soldier;
        Tank = tank;
        Jet = jet;
        Vizhes = vizhes;
    }

    public int Soldier { get; set; }
    public int Tank{ get; set; }
    public int Jet{ get; set; }
    public List<Vizhe> Vizhes { get; set; }
}