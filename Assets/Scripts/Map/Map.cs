
using System;
using UnityEngine;

public class Map 
{

    public readonly int columnDimension = 0;
    public readonly int rowDimension = 1;


    public int NumberOfColumns { get => cells.GetLength(columnDimension);}
    public int NumberOfRows { get => cells.GetLength(rowDimension);}

    private readonly Hero[,] cells;


    public Map(int width, int height)
    {
        cells = new Hero[width, height];

        //NumberOfColumns = width;
        //NumberOfRows = height;
    }

    public void AddHero(int positionX, int positionY, Hero hero)
    {
        cells[positionX, positionY] = hero;
    }

    public bool ContainsHero(int positionX, int positionY)
    {
        return cells[positionX, positionY] != null;
    }

    // Start is called before the first frame update

}
