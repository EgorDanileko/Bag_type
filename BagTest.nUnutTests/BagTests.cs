namespace Bags
{
    public class BagTests
    {
        private Bag _bag = new Bag();

        [SetUp]
        public void Setup()
        {
            _bag = new Bag();
        }    

        [Test]
        public void GetFrequencyOfElement_Test1()
        {
            // Arrange
            int elem1 = 5;
            int elem2 = 4;

            // Action
            _bag.Insert(elem1);
            _bag.Insert(elem1);
            _bag.Insert(elem1);
            _bag.Insert(elem1);
            _bag.Insert(elem2);
            _bag.Insert(elem2);
            int FreqElem = _bag.GetFrequencyOfElement(elem1);

            // Assert
            Assert.AreEqual(4, FreqElem);
        }

        [Test]
        public void GetFrequencyOfElement_Test2()
        {
            // Arrange
            int elem1 = 5;
            int elem2 = 4;

            // Action
            _bag.Insert(elem1);
            _bag.Insert(elem1);
            _bag.Insert(elem1);
            _bag.Insert(elem1);
            _bag.Insert(elem2);
            _bag.Insert(elem2);
            _bag.Remove(elem1);
            int FreqElem = _bag.GetFrequencyOfElement(elem1);

            // Assert
            Assert.AreEqual(3, FreqElem);
        }

        [Test]
        public void Inesrt_Test1() 
        {
            // Arrange
            int elem = 3;

            // Action 
            _bag.Insert(elem);
            _bag.Insert(elem);
            _bag.Insert(elem);

            // Assert
            Assert.AreEqual(3, _bag.GetFrequencyOfElement(elem));
        }

        [Test]
        public void Inesrt_Test2()
        {
            // Arrange
            int elem = 3;
            int elem2 = 4;
            // Action 
            _bag.Insert(elem);
            _bag.Insert(elem);
            _bag.Insert(elem);
            _bag.Insert(elem2);
            _bag.Insert(elem2);



            // Assert            
            Assert.AreEqual(2, _bag.GetFrequencyOfElement(elem2));
        }

        [Test]
        public void Remove_Test()
        {
            int elem = 1;

            _bag.Insert(elem);
            _bag.Insert(elem);
            _bag.Insert(elem);
            _bag.Remove(elem);

            Assert.AreEqual(2, _bag.GetFrequencyOfElement(elem));
        }

        [Test]
        public void MostFreq_Test2()
        {
            // Arrange 
            int elem1 = 2;
            int elem2 = 7;
            int elem3 = 4;

            // Action
            _bag.Insert(elem1);
            _bag.Insert(elem1);
            _bag.Insert(elem2);
            _bag.Insert(elem2);
            _bag.Insert(elem2);
            _bag.Insert(elem2);
            _bag.Insert(elem3);
            _bag.Insert(elem3);
            _bag.Insert(elem3);
            _bag.Remove(elem2);
            _bag.Remove(elem2);
            int MostFreqEl = _bag.GetTheMostFrequentElement();

            // Assert
            Assert.AreEqual(4, MostFreqEl);
        }

        [Test]
        public void MostFreqElem_Test1()
        {
            // Arrange 
            int elem1 = 2;
            int elem2 = 7;
            int elem3 = 4;

            // Action
            _bag.Insert(elem1);
            _bag.Insert(elem1);
            _bag.Insert(elem2);
            _bag.Insert(elem2);
            _bag.Insert(elem2);
            _bag.Insert(elem2);
            _bag.Insert(elem3);
            _bag.Insert(elem3);
            _bag.Insert(elem3);
            int MostFreqEl = _bag.GetTheMostFrequentElement();

            // Assert
            Assert.AreEqual(7, MostFreqEl);
        }
    }
}