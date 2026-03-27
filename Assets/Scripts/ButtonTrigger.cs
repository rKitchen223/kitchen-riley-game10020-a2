using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
  public WallController[] walls;
    private bool isPressed = false;
    

    public void PressButton()
    {
        if (isPressed) return;

        isPressed = true;

        Debug.Log("Button Pressed!");

        foreach (var wall in walls)
        {
            wall.LowerWall();
        }
    }
}
