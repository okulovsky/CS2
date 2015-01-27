using L3S10;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UsefulClassTest
{
    [TestMethod]
    public void TestSum()
    {
        var instance = new L3S10.UsefulClass();
        var result = instance.Sum(1, 2, 3);
        Assert.AreEqual(6, result);
    }
}