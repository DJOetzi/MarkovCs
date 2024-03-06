namespace MarkovCs;

public class Chain
{
    public Dictionary<Pair, int> TransitionMatrix;
    public Dictionary<int, Pair> IndexPairMap;
    public bool Computed;
    public int MarkovOrder;
    public List<double> Probabilities;

    public static int Increment;

    public Chain(int order) => this.MarkovOrder = order;
    
    
}