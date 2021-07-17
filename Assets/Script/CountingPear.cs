/******************************************************************************
Author: Chin Wai Lun

Name of Class: CountingPear

Description of Class: This class will control the number count of pear player
                      collected.

Date Created: 16/07/2021
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountingPear : MonoBehaviour
{
    public static int pearCount = 0;

    Text score;


    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + pearCount;
    }

    public void giveAuntie()
    {
        pearCount -= 3;
    }
}
