using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour, Interactable
{
    bool interacted;



    public void Interact()
    {
        if (interacted)
        {
            interacted = false;
            transform.SetParent(null);

        }
        else
        {
            interacted = true;
            transform.SetParent(GameManager.Instance.PC.transform);

        }



    }

   
}
