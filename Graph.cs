using System.Collections.Generic;

namespace CreeX.RiverSailor
{
    public class Graph
    {
        private Node _first;
        public Node First => _first;

        private Node[] _nodes;
        public IReadOnlyCollection<Node> Nodes => _nodes;
        
        public Graph(Node first, Node[] nodes)
        {
            _first = first;
            _nodes = nodes;
        }
    }
}
