using System;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;

namespace CreeX.RiverSailor
{
    [Serializable]
    [CreateAssetMenu]
    public class AdjacencyList : SerializedScriptableObject
    {
        [SerializeField] 
        private NodeData _firstNode;
        
        [OdinSerialize]
        private Dictionary<NodeData, List<WeightedEdge>> _adjacency;

        public Graph ToGraph()
        {
            var nodes = new List<Node>();
            
            foreach (var node in _adjacency)
            {
                var currentNode = nodes.First(x => x.Value == node.Key);
                foreach (var edge in node.Value)
                {
                    if (nodes.Any(x => x.Value == edge.Value) == false)
                        nodes.Add(new Node(edge.Value));

                    currentNode.AddEdge(nodes.First(x => x.Value == edge.Value), edge.Weight);
                }
            }

            var firstNode = nodes.First(x => x.Value == _firstNode);
            
            return new Graph(firstNode, nodes.ToArray());
        }

        [Serializable]
        private class WeightedEdge
        {
            public NodeData Value;
            public int Weight;
        }
    }
}