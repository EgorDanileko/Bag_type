using System;

namespace Bags
{
    class Menu
    {
        private Bag bag = new Bag();

        public void Run()
        {
            int m;
            do
            {
                m = GetMenu();
                switch(m)
                {
                    case 1:
                        Insert();
                        ToPrintBag();
                        break;
                    case 2:
                        Remove();
                        ToPrintBag();
                        break;
                    case 3:
                        FrequencyElement();
                        ToPrintBag();
                        break;
                    case 4:
                        MostFrequentElement();
                        ToPrintBag();
                        break;
                    case 5:
                        ToPrintBag();                       
                        break;
                    default:
                        Console.WriteLine("Bye!!!");
                        break;
                }
            }while (m != 0);


        }

        private static int GetMenu()
        {
            int m;
            do
            {              
                Console.WriteLine("\n\n=================================================");
                Console.WriteLine("0) Exit");
                Console.WriteLine("1) Insert element");
                Console.WriteLine("2) Remove element");
                Console.WriteLine("3) Get the frequency of an element");
                Console.WriteLine("4) Get the most frequent element from the bag");
                Console.WriteLine("5) Print Bag");
                Console.WriteLine("=================================================\n\n");
                
                try
                {
                    m = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException) { m = -1; }

            } while (m < 0 || m > 5);
            return m;
        }

        private void Insert()
        {
            int el;
            Console.WriteLine("Input element to insert");
            el = int.Parse(Console.ReadLine());
            bag.Insert(el);
        }

        private void Remove()
        {
            int num;
            try
            {
                Console.WriteLine("Input element to remove");
                num = int.Parse(Console.ReadLine());
                bag.Remove(num);
            }
            catch (Bag.noSuchElementInTheBag) 
            {
                Console.WriteLine("Can't remove! Element is not in Bag.\n");
            }
        }

        private void FrequencyElement()
        {
            int num;
            try
            {
                Console.WriteLine("Input element to know him frequency");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine($"Frequency number {num} is " + bag.GetFrequencyOfElement(num));
            }
            catch (Bag.noSuchElementInTheBag)
            {
                Console.WriteLine("Can't get a frequency! Element is not in Bag.\n");
            }
        }

        private void MostFrequentElement()
        {
            try
            {
                Console.WriteLine("The Most Frequent Element: " + bag.GetTheMostFrequentElement());
            }
            catch(Bag.noSuchElementInTheBag)
            {
                Console.WriteLine("The bag is empty!");
            }
        }

        private void ToPrintBag()
        {
            try
            {
                bag.BagPrint();
            }
            catch(Bag.noSuchElementInTheBag)
            {
                Console.WriteLine("Bag is empty");
            }
        }

    }
}