using NUnit.Framework;

public class HeroSpawnerTestsBase
{


    [Test]
    public void WHenCreateAHero_ThenSaveTheHeroInTheMap()
    {

        var map = MapFactory.AMap().Build();

       
        var subjectUnderTest = new HeroSpawner();
        int positionX = 5;
        int positionY = 5;
        subjectUnderTest.CreateHero(map, positionX, positionY);

        Assert.IsTrue(map.ContainsHero(positionX, positionY));
      
        //mapUtils.AddheroToMap(hero, map, positionX, positionY);

    }









    [Test]
    public void WhenCreateAHeroInTheMap_ThenTheHeroPositionIsCorrect()
    {


        var map = MapFactory.AMap().Build();
        var subjectUnderTest = new HeroSpawner();
        int positionX = 5;
        int positionY = 5;
        var hero = subjectUnderTest.CreateHero(map, positionX, positionY);

        Assert.AreEqual(positionX, hero.PositionX);
        Assert.AreEqual(positionY, hero.PositionY);



    }
    
}