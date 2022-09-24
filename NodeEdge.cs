namespace CreeX.RiverSailor
{
    public class NodeEdge
    {
        private Node _from;
        public Node From => _from;
        
        private Node _to;
        public Node To => _to;
        
        private int _weight;
        public int Weight => _weight;

        public NodeEdge(Node from, Node to, int weight)
        {
            _from = from;
            _to = to;
            _weight = weight;
        }
    }
}