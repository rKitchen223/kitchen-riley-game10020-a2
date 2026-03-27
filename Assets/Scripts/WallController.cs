using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public Vector3 loweredPosition;
    public float speed = 2f;


    private bool lowering = false;

    public void Update()
    {
        if (lowering)
        {
            transform.position = Vector3.Lerp(transform.position, loweredPosition, speed * Time.deltaTime);
        }
    }

    public void LowerWall()
    {
        lowering = true;
    }

}
