using Microsoft.VisualStudio.TestTools.UnitTesting;
using Races;


namespace UnitTestRaces
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Gamble_GiveCash_Test()
        {
            //Set
            Gamble g = new Gamble(50, 1, new Person("Pari", 50, null, null));
            // act
           int result= g.GiveCash(1);
            //asset
            Assert.AreEqual(result, 100);


        }

        [TestMethod]
        public void Person_SetBet_Test()
        {
            Person p1 = new Person("Pari", 50, null, null);
          
            bool result =p1.SetBet(50, 1);

            Assert.IsTrue(!result);
        }
        
    }
}
