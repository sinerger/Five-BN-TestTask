using System.Collections.Generic;

namespace Five_BN_TestTask
{
    public class SearchEngine
    {
        public int FindLastElement(List<object> elements, int numberRemovedElement)
        {
            var indexes = GetListIndexes(elements);
            
            return FindLastElement(indexes, numberRemovedElement, 1);
        }

        private int FindLastElement(List<int> elements, int numberRemovedElement, int counter)
        {
            if (elements.Count == 1)
            {
                return elements[0];
            }

            List<int> newElements = new List<int>();
            for (int i = 0; i < elements.Count; i++)
            {
                if (counter != numberRemovedElement)
                {
                    newElements.Add(elements[i]);
                    counter++;
                }
                else
                {
                    counter = 1;
                }
            }

            return FindLastElement(newElements, numberRemovedElement, counter);
        }

        private List<int> GetListIndexes(List<object> list)
        {
            var indexes = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                indexes.Add(i);
            }

            return indexes;
        }
    }
}