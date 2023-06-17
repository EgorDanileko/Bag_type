using System;
using System.Runtime.CompilerServices;

namespace Bags 
{
    public class Element
    {
        public int element;
        public int frequency;

        public Element(int el) {
            element = el; 
            frequency = 1;
        }

        public override string ToString()
        {
            return $"({element}, {frequency})";
        }
    }

    public class Bag
    {
        public class noSuchElementInTheBag : Exception { }
        public class EmptyBag : Exception { }

        private List<Element> elements = new List<Element>();
        private int amount;
        private int mostFreqEl;
        public Bag()
        {
            amount = elements.Count;
        }
        
        public bool isEmptyBag()
        {
            return elements.Count == 0;
        }

        public void Insert(int x)
        {
            bool InBag = false;
            for(int i = 0; i < elements.Count; i++)
            {
                if (elements[i].element == x)
                {
                    elements[i].frequency++;
                    if (elements[i].frequency > GetFrequencyOfElement(mostFreqEl))
                    {
                        mostFreqEl = elements[i].element;
                    }
                    InBag = true;
                }
            }
            if (!InBag)
            {
                elements.Add(new Element(x));
                amount++;
                if(amount == 1)
                {
                    mostFreqEl = x;
                }
            }
        }

        public void Remove(int x)
        {
            
            if (amount == 0) { throw new noSuchElementInTheBag(); }
            int c = 0;
            for(int i = 0; i<elements.Count; i++)
            {
                if (elements[i].element == x)
                {
                    c++;
                    if (elements[i].frequency != 1)
                    {
                        elements[i].frequency--;
                    }
                    else
                    {
                        
                        if (elements[i].element == mostFreqEl)
                        {
                            elements.Remove(elements[i]);                            
                            if (elements.Count != 0) {
                                mostFreqEl = elements[0].element;
                            }                                                                            
                        }
                        else
                        {
                            elements.Remove(elements[i]);
                        }
                        amount--;
                    }                  
                }                
            }
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].frequency >= GetFrequencyOfElement(mostFreqEl))
                {
                    mostFreqEl = elements[i].element;
                }
            }
            
            if(amount == 1) { mostFreqEl = elements[0].element; }
            if(elements.Count == 0) { amount = 0; }
            if (c == 0) { throw new noSuchElementInTheBag();  }
        }

        public int GetFrequencyOfElement(int x)
        {
            if(amount == 0) { throw new noSuchElementInTheBag();  }
            for(int i=0; i<elements.Count; i++)
            {
                if (elements[i].element == x)
                {
                    return elements[i].frequency;
                }
            }

            throw new noSuchElementInTheBag();
        }

        public int GetTheMostFrequentElement()
        {
            if (amount == 0) { throw new noSuchElementInTheBag(); }
            return mostFreqEl;
        }

        public void BagPrint() 
        {
            if(amount == 0) throw new noSuchElementInTheBag();
            foreach(Element e in elements)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}