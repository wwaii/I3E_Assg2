/******************************************************************************
Author: Chin Wai Lun

Name of Class: IntObject

Description of Class: This class will control the actions of interactable object
                      after interacting.

Date Created: 14/07/2021
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntObject : MonoBehaviour
{
    public bool collectable;
    public GameObject PlayerUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Interact()
    {
        if (collectable == true)
        {
            Debug.Log("take");
            gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("talk");
            PlayerUI.SetActive(true);
        }
    }
}
