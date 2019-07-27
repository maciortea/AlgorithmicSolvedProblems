namespace Contacts
{
    public class Contacts
    {
        private const char EndOfNameMarker = '\0';

        private TrieNode _rootNode = new TrieNode();

        public bool Add(string contactName)
        {
            TrieNode currentNode = _rootNode;
            bool isNewContact = false;

            foreach (char character in contactName)
            {
                if (!currentNode.HasChildNode(character))
                {
                    isNewContact = true;
                    currentNode.MakeChildNode(character);
                }

                currentNode = currentNode.GetChildNode(character);
                currentNode.IncrementCount();
            }

            if (!currentNode.HasChildNode(EndOfNameMarker))
            {
                isNewContact = true;
                currentNode.MakeChildNode(EndOfNameMarker);
            }

            return isNewContact;
        }

        public int FindContactsStartingWith(string name)
        {
            TrieNode currentNode = _rootNode;

            foreach (char character in name)
            {
                if (!currentNode.HasChildNode(character))
                {
                    return 0;
                }

                currentNode = currentNode.GetChildNode(character);
            }

            return currentNode.Count;
        }
    }
}
