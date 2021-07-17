/******************************************************************************
Author: Chin Wai Lun

Name of Class: Ending

Description of Class: This class will show the ending screen of the game.

Date Created: 17/07/2021
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public GameObject ending;

    private void OnCollisionEnter(Collision collision)
    {
        ending.SetActive(true);
    }

}
