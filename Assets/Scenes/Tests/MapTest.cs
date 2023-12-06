using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class MapTest
{
    // A Test behaves as an ordinary method
    [TestCase(2, 5)]
    [TestCase(5, 5)]
    public void WhenCreateMapWithWidthAndHeight_ThenCreateAMapWithTheCorrectNumberofRowsAndCols(int width, int height)
    {
        // Arrenge
        // Creacion Del Mapa

        //var width = 5;
        //var height = 2;

        var map = new Map(width, height);


        // Act 
        // Comprobar que tenga columnas y filas adecuadas
       
        //Assert Comprobaciones
        Assert.AreEqual(width, map.NumberOfColumns, "Wrong Number of Columns");
        Assert.AreEqual(height, map.NumberOfRows, "Wrong Nunmber of Rows");
        // Use the Assert class to test conditions
    }
    [Test]
    public void WhenAddNewHero_SaveInCorrectCell()
    {

        //Arrange

        var map = new Map(20, 20);

        var hero = new Hero();

        var heroPositionX = 10;
        var heroPositionY = 10;

        map.AddHero(heroPositionX, heroPositionY, hero);

        //Act

        //Assert
            Assert.IsTrue( map.ContainsHero(heroPositionX, heroPositionY), "it Dosen´t have an Hero"); // Check if Hereo is in that Cell

        


    }

    [Test]

    public void WhenAddNewHeroAndThereisAHeroInTheSameCell_ThrowException()
    {
        // Arrange

        var map = new Map(20, 20);

        var hero = new Hero();
        map.AddHero(5, 5, hero);
        var hero2 = new Hero();
        //Act
       

        //Asserts
        Assert.Throws<Exception>(() => {

            map.AddHero(5, 5, hero2);
        });

    }



 
  
}
