using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractSystem : MonoBehaviour
{

    protected string Interact()
    {
        // Raycast
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        RaycastHit hit;
        
            if (Physics.Raycast(ray, out hit, 2f))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Transform Objecthit = hit.transform;
                    Debug.Log(Objecthit.name);
                    return Objecthit.name;
                }
        }
        return "";
    }


    protected bool isGround()
    {
        RaycastHit hit;
        if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y, transform.position.z),new Vector3(0, -1, 0),out hit, 2f))
        {
            return true;
        }
        return false;
    }
}
