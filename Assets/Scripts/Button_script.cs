using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_script : InteractSystem
{
    Animator animator;
    public GameObject coin ;
    // Instantiate(myPrefab, new Vector3(0, 0, 0));
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Interact() == "red_button")
        {
            animator.Play("Click");
            
            Instantiate(coin, new Vector3(11.688f, 2.46f, 27.75f), Quaternion.Euler(0,0,90));
        }
    }
}
