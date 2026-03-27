using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject Door;
    private bool IsOpen = false;

   public Animator animator;
    public Animator animLogo;

    private Character keys;

    public void Start()
    {
        keys = FindAnyObjectByType<Character>();
        animator = GetComponent<Animator>();
    }

    public void Update()
    {
       if (IsOpen == true && (Input.GetKey(KeyCode.E)) && keys.KeyAmount >= 1)
       {
            keys.KeyAmount -= 1;
            animator.SetTrigger("OpenDoor");
            IsOpen = false;
       }
    }

    public void OpenDoor()
    {
        Debug.Log("Door Opened!");

            if (animator != null )
            {
            GetComponent<Animator>().SetTrigger("Open");
            }
            else
            {
            transform.Rotate(0, 90, 0);
            }
        Door.SetActive(false);
    }
   

}
