/******************************************************************************
Author: Chin Wai Lun

Name of Class: CountingApple

Description of Class: This class will control the number count of apple player
                      collected.

Date Created: 16/07/2021
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountingApple : MonoBehaviour
{
    public static int appleCount = 0;

    Text score;


    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + appleCount;
    }

    public void giveAuntie()
    {
        appleCount -= 3;
    }
}
