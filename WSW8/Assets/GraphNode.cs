using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class GraphNode : MonoBehaviour
{
    private string element;
    public string Element { get => element; }
    public GraphNode(string element)
    {
        this.element = element;
    }
    public override string ToString()
    {
        return element;
    }
    public class Graph
    {
        private int size = 0;
        private LinkedList<LinkedList<GraphNode>> graph = new LinkedList<LinkedList<GraphNode>>();
        public int Size { get => size; }
        public LinkedListNode<GraphNode> CurrentPos { get => currentPos; }
        private LinkedListNode<GraphNode> currentPos;
    }
    public void Insert(string item)
    {
        GraphNode newNode = new GraphNode(item);
        LinkedList<GraphNode> temp = new LinkedList<GraphNode>();
        temp.AddLast(newNode);
        graph.AddLast(temp);
        Size++;

    }


}


