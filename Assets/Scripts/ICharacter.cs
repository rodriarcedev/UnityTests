using System;

public interface ICharacter
{
    public Inventory Inventory { get; set; }
    public int Health { get; set; }
    
    public int Level { get; set; }
    void OnItemEquipped(Items item);

}
