using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_open : InteractSystem
{
    Animator animator;
    [SerializeField] float isOpen;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    if (Interact() == "Door")
        {
            if (isOpen == 0)
            {
                Debug.Log("Open");
                animator.Play("Open");
            }
            if (isOpen == 1)
            {
                Debug.Log("Closed");
                animator.Play("Close");
            }
        }
    }

   
      
    
}
