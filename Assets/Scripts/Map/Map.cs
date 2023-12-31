
using System;
using UnityEngine;
using UnityEngine.UIElements;

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

    public void AddHero(Hero hero,int positionX, int positionY)
    {

        if (ContainsHero(positionX, positionY))
        {
            throw new Exception("Contains Hero");
        }

        cells[positionX, positionY] = hero;
    }

    public bool ContainsHero(int positionX, int positionY)
    {
        return cells[positionX, positionY] != null;
    }

    public void RemoveHero(int positionX, int positionY)
    {
        cells[positionX, positionY] = null;
    }

    // Start is called before the first frame update

}
