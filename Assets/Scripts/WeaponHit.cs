using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Button"))
       {
            other.GetComponent<ButtonTrigger>().PressButton();
       }
    }
}
