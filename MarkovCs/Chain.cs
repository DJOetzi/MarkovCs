using System.Text;

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

    public void add(string str)
    {
        var startToken = new StringBuilder()
            .Insert(0, GlobalConstants.START_TOKEN, MarkovOrder).ToString();
        var endToken = new StringBuilder()
            .Insert(0, GlobalConstants.END_TOKEN, MarkovOrder).ToString();

        str = new StringBuilder()
            .Append(startToken)
            .Append("")
            .Append(str)
            .Append(" ")
            .Append(endToken)
            .ToString();
    }
}