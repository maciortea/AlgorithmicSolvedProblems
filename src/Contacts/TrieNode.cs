using System.Collections.Generic;

namespace Contacts
{
    public class TrieNode
    {
        private Dictionary<char, TrieNode> _nodeChildren;
        private int _count;

        public TrieNode()
        {
            _nodeChildren = new Dictionary<char, TrieNode>();
            _count = 0;
        }

        public int Count
        {
            get { return _count; }
        }

        public bool HasChildNode(char character)
        {
            return _nodeChildren.ContainsKey(character);
        }

        public void MakeChildNode(char character)
        {
            _nodeChildren[character] = new TrieNode();
        }

        public void IncrementCount()
        {
            _count++;
        }

        public TrieNode GetChildNode(char character)
        {
            return _nodeChildren[character];
        }
    }
}
