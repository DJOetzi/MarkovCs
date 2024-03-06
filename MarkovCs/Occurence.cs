namespace MarkovCs;

public struct Occurence
{
    private int _occurence;

    public Occurence() => this._occurence = 1;
    private Occurence(int val) => this._occurence = val;

    public static implicit operator Occurence(int value) => new Occurence(value);

    public static implicit operator int(Occurence occ) => occ._occurence;

    public static Occurence operator ++ (Occurence occ)
    {
        ++occ._occurence;

        return occ;
    }
}