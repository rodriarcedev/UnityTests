

using System.Security.Policy;

public class MapBuilder 
{
    private int width;
    private int height;

    public MapBuilder WithWidth(int width)
    {
        this.width = width;
        return this;
    }

    public MapBuilder WithHeight(int height)
    {
        this.height = height;
        return this;
    }



    public Map Build()
    {
        return  new Map(width, height);
    }
}

public static class MapFactory
{
    public static MapBuilder AMap()
    {
        return new MapBuilder();
    }
}
