using Bojovnik_Hra;

class Bojovnik
{
    protected string meno;
    protected int zivot;
    protected int maxZivot;
    protected int utok;
    protected int obrana;
    protected Kocka kocka;
    private string sprava;

    public Bojovnik(string meno, int zivot, int utok, int obrana, Kocka kocka)
    {
        this.meno = meno;
        this.zivot = zivot;
        this.maxZivot = zivot;
        this.utok = utok;
        this.obrana = obrana;
        this.kocka = kocka;
    }

    public bool Nazive()
    {
        return (zivot > 0);
    }

    protected string GrafickyUkazatel(int aktualny,  int maximalny)
    {
        string s = "[";
        int celkom = 20;
        double pocet = Math.Round(((double)aktualny / maximalny) * celkom);
        if ((pocet == 0) && (Nazive()))
            pocet = 1;
        for (int i = 0; i < pocet; i++)
            s += "#";
        s = s.PadRight(celkom + 1);
        s += "]";
        return s;
    }

    public string GrafickyZivot()

    {
        return GrafickyUkazatel(zivot, maxZivot);
    }


    public virtual void Utok (Bojovnik super)
    {
        int uder = utok + kocka.hod();
        NastavSpravu(String.Format($"{meno} utoci s uderom za {uder} hp"));
        super.BranSa(uder);
    }

    public void BranSa(int uder)
    {
        int zranenie = uder - (obrana + kocka.hod());
        if (zranenie > 0)
        {
            zivot -= zranenie;
            sprava = String.Format($"{meno} utrpel poskodenie {zranenie} hp");
            if (zivot <= 0)
            {
                zivot = 0;
                sprava += " a zomrel";
            }   
        }
        else
            sprava = String.Format($"{meno} odrazil utok");
        NastavSpravu(sprava);
    }

    public override string ToString()
    {
        return meno;
    }


    protected void NastavSpravu(string sprava)
    {
        this.sprava = sprava;
    }

    public string VratPosldnuSpravu()
    {
        return sprava;
    }
}