/******************************************************************************
Author: Chin Wai Lun

Name of Class: InvWall

Description of Class: This class will control the messages being printed out and 
                      actions being triggered when player tounches the invinsible 
                      walls.

Date Created: 14/07/2021
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvWall : MonoBehaviour
{
    
    public Transform teleportForest;
    public Transform teleportHouse;
    public GameObject thePlayer;
    public GameObject warningUI;
    public GameObject houseWarningUI;
    public bool chiefHouse;
    private bool phaseTwoChecking;
    private bool phaseOneChecking;

    private void Update()
    {
        phaseOneChecking = GameObject.Find("PlayerBody").GetComponent<Controll>().phaseOne;
        phaseTwoChecking = GameObject.Find("PlayerBody").GetComponent<Controll>().phaseTwo;

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("touched");
        if (chiefHouse == true)
        {
            if (phaseTwoChecking)
            {
                thePlayer.transform.position = teleportHouse.transform.position;
            }

            else
            {
                houseWarningUI.SetActive(true);
            }
        }

        else
        {
            if (phaseOneChecking)
            {
                thePlayer.transform.position = teleportForest.transform.position;
            }

            else
            {
                warningUI.SetActive(true);
            }
            
        }
    }
}
