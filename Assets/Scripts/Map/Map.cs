
using UnityEngine;

public class Map 
{

    public readonly int columnDimension = 0;
    public readonly int rowDimension = 1;


    public int NumberOfColumns { get => cells.GetLength(columnDimension);}
    public int NumberOfRows { get => cells.GetLength(rowDimension);}

    private readonly int[,] cells;


    public Map(int width, int height)
    {
        cells = new int[width, height];

        //NumberOfColumns = width;
        //NumberOfRows = height;
    }

    // Start is called before the first frame update
  
}
