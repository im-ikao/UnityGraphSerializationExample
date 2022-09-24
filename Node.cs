using System;
using System.Collections.Generic;
using System.Linq;

namespace CreeX.RiverSailor
{
    public class Node
    {
        private NodeData _value;
        public NodeData Value => _value;

        private List<NodeEdge> _edges;
        public IReadOnlyList<NodeEdge> Edges => _edges;
        
        public Node(NodeData value)
        {
            _edges = new List<NodeEdge>();
            _value = value;
        }

        public void AddEdge(Node to, int weight)
        {
            if (_edges.Any(x => x.To == to) == true)
                throw new ArgumentException("End Node Exists");

            if (weight <= 0)
                throw new ArgumentException("Bad Weight");
            
            _edges.Add(new NodeEdge(this, to, weight));
        }
    }
}