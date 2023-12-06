using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NSubstitute;

public class PlayerMovementTest
{


    

   
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestPlayerMovement()
    {

      GameObject playerObject = new GameObject("Player");
      var player =  playerObject.AddComponent<Player>();
        player.PlayerInput = Substitute.For<IPlayerInput>();
        player.PlayerInput.Vertical.Returns(1f);
     
       

        var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.SetParent(playerObject.transform);
      
        cube.transform.localPosition = Vector3.zero;
        player.transform.position = Vector3.zero;

        yield return new WaitForSecondsRealtime(0.1f);
        float xPos = player.transform.position.x;
        float yPos = player.transform.position.y;

        //player.PlayerInput = Substitu

        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return new WaitForSecondsRealtime(2f); // Coroutine looping
        Assert.IsTrue(player.transform.position.z > 0f);
        Assert.AreEqual(xPos, player.transform.position.y);
        Assert.AreEqual(yPos, player.transform.position.x);

    }
}
