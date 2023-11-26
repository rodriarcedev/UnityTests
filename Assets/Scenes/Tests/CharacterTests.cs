using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using NSubstitute;


public class CharacterTests
{
    [Test]
    public void TestDamage()
    { 
        // Arrange
        ICharacter character = Substitute.For<ICharacter>();
        Inventory inventory = new Inventory(character);  
        Items item = new Items() { EquipSlots = EquipSlots.Legs, ArmorAmount = 40};
        Items secondItem = new Items() { EquipSlots = EquipSlots.RightHand, ArmorAmount = 50 };

        inventory.EquipItem(item);
        inventory.EquipItem(secondItem);
        character.Inventory.Returns(inventory);
        //character.Inventory = inventory;
        // Act
        int damage = DamageCalculator.CalculateDamage(1000, character);
        //Assert
        Assert.AreEqual(100, damage);

    }
}
