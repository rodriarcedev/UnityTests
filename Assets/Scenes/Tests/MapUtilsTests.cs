using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;









public class HeroSpawnerTests : HeroSpawnerTestsBase
{
}








public class MapUtilsTests
{

    [Test]
    public void WhenAddHeroInTheMap_ThenUpdateTheHeroPosition()
    {
        Hero hero = new Hero();
        int positionX = 5;
        int positionY = 5;
        var map = MapFactory.AMap().Build();
        var mapUtils = new MapUtils();
        mapUtils.AddheroToMap(hero, map, positionX, positionY);
    }

    [Test]
    public void WhenAddHeroInTheMap_ThenSaveTheHeroInTheMap()
    {

    }


    // A Test behaves as an ordinary method
    [Test]
    public void WhenMove_ThenUpdateThePositionInTheMap()
    {

        //Arrange
        Map map = new Map(10, 10);
        var hero = new Hero();
        map.AddHero(hero, 5, 5);

        var heroMovement = new MapUtils();


        //Act
        heroMovement.Move(hero, map, Directions.Right);





        //Assert
        Assert.IsTrue(map.ContainsHero(6, 5), "The Hero Dosen't move to the Right");




        //Assert.IsTrue(map.a)
        // Use the Assert class to test conditions
    }



    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
 
}
