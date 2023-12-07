using NUnit.Framework;

public class HeroTest 
{
    [TestCase(0, 1)]
    [TestCase(7, 4)]
    public void WhenSetPosition_ThenSetIt(int positionX, int positionY)
    {
        var hero = new Hero();
        hero.SetPosition(positionX, positionY);

        Assert.AreEqual(positionX, hero.PositionX);
        Assert.AreEqual(positionY, hero.PositionY);
    }

 
}
