/******************************************************************************
Author: Chin Wai Lun

Name of Class: Boader

Description of Class: This class will print out a message when player is trying
                      to leave the areas.

Date Created: 14/07/2021
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boader : MonoBehaviour
{
    public GameObject warningUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        warningUI.SetActive(true);
    }


}
