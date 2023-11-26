
using NUnit.Framework;


public class DamageCalculatorTest
{
  
    [Test]
    public void SetsDamateMitigation()
    {
        //Acting Part
        int finalDamage = DamageCalculator.CalculateDamage(10, 0.5f);
        // Use the Assert class to test conditions

        //Assert part
        Assert.AreEqual(5, finalDamage);

    }


    [Test]
    public void SecondTest()
    {
        //Acting Part
        int finalDamage = DamageCalculator.CalculateDamage(2, 0.8f);
        // Use the Assert class to test conditions

        //Assert part
        Assert.AreEqual(5, finalDamage);

    }



    [Test]
    public void ThirdTest()
    {
        //Acting Part
        int finalDamage = DamageCalculator.CalculateDamage(3, 0.7f);
        // Use the Assert class to test conditions

        //Assert part
        Assert.AreEqual(5, finalDamage);

    }




}
