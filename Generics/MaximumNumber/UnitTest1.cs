using NUnit.Framework;
using Generics;
namespace MaximumNumber
{
    
    public class Tests
    {
        public void UnitTest1()
        {
              public class UnitTest1
        {
            //TC1.1
            [TestMethod]
            public void Maximum_Value_PassedAt_First_Parameter_Should_Return_Maximum_Value()
            {
                int Number1 = 30, Number2 = 20, thirdValue = 10;
                int expected = 30;
                FindMaximum find = new FindMaximum();
                int actual = find.MaxNumber(Number1, Number2, Number3);
                Assert.AreEqual(expected, actual);
            }
            //TC1.2
            [TestMethod]
            public void Maximum_Value_PassedAt_Second_Parameter_Should_Return_Maximum_Value()
            {
                int Number1 = 20, Number2 = 30, Number3 = 10;
                int expected = 30;
                FindMaximum find = new FindMaximum();
                int actual = find.MaxNumber(Number1, Number2, Number3);
                Assert.AreEqual(expected, actual);
            }
            //TC1.3
            [TestMethod]
            public void Maximum_Value_PassedAt_Third_Parameter_Should_Return_Maximum_Value()
            {
                int Number1 = 20, Number2 = 10, Number3 = 30;
                int expected = 30;
                FindMaximum find = new FindMaximum();
                int actual = find.MaxNumber(Number1, Number2, Number3);
                Assert.AreEqual(expected, actual);
            }
        }

    }
    }
}