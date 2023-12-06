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

 
  
}
