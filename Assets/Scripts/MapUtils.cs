


using System;

public enum Directions
{
    Left,
    Right,
    Top,
    Bottom
}

public class HeroSpawner
{
    public Hero CreateHero(Map map, int positionX, int positionY)
    {
        var hero = new Hero();
        map.AddHero(hero, positionX, positionY);
        hero.SetPosition(positionX, positionY); 
        //hero.SetPosition()
        return null;
    }
    //public Hero CreateHero()


}


public class MapUtils
{
    public void AddheroToMap(Hero hero, Map map, int positionX, int positionY)
    {
        
    }


    public void Move(Hero hero, Map map, Directions right)
    {
        //hero.Pos
        //map.RemoveHero(positionX, positionY);
        //map.Move(oldPosition, newPosition);
     
    }
}
