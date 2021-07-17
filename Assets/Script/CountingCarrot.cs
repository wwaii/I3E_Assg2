/******************************************************************************
Author: Chin Wai Lun

Name of Class: CountingCarrot

Description of Class: This class will control the number count of carrot player
                      collected.

Date Created: 16/07/2021
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountingCarrot : MonoBehaviour
{
    public static int carrotCount = 0;

    Text score;


    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + carrotCount;
    }

    public void giveUncle()
    {
        carrotCount -= 1;
    }
}
