/******************************************************************************
Author: Chin Wai Lun

Name of Class: Teleport

Description of Class: This class will teleport player back when they touched
                      the traps.

Date Created: 16/07/2021
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform teleportTarget;

    public GameObject thePlayer;

    public void OnCollisionEnter(Collision collision)
    {
        thePlayer.transform.position = teleportTarget.transform.position;

    }


}
