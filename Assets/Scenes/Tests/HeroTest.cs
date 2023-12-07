using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class HeroTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void WhenMove_ThenUpdateThePositionInTheMap()
    {

        //Arrange
        Map map = new Map(10, 10);
        var hero = new Hero();
        map.AddHero(5, 5, hero);

        var heroMovement = new HeroMovement();


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
