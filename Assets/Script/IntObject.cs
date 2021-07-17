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

    public GameObject borderUI;
    public GameObject kidUI;
    public GameObject zeroGuardUI;
    public GameObject zeroAuntieUI;
    public GameObject zeroUncleUI;
    public GameObject zeroChiefUI;
    public GameObject oneGuardUI;
    public GameObject oneAuntieUI;
    public GameObject oneUncleUI;
    public GameObject oneChiefUI; 
    public GameObject twoAuntieUI;
    public GameObject twoUncleUI;
    public GameObject twoChiefUI;
    public GameObject threeChiefUI;
    public GameObject ChiefInHouseUI;

    public bool guard;
    public bool aunite;
    public bool uncle;
    public bool kid;
    public bool chief;
    public bool chiefInHouse;
    private bool phaseOneChecking;
    private bool phaseTwoChecking;
    private bool phaseThreeChecking;

    private void Update()
    {
        phaseOneChecking = GameObject.Find("PlayerBody").GetComponent<Controll>().phaseOne;
        phaseTwoChecking = GameObject.Find("PlayerBody").GetComponent<Controll>().phaseTwo;
        phaseThreeChecking = GameObject.Find("PlayerBody").GetComponent<Controll>().phaseThree;
    }


    public void Interact()
    {
        if (collectable == true)
        {
            gameObject.SetActive(false);
            
        }
        else
        {
            if (guard == true)
            {
               if (phaseOneChecking)
                {
                    oneGuardUI.SetActive(true);
                }
               else 
                {
                    zeroGuardUI.SetActive(true);
                }
            }

            else if (aunite == true)
            {
                if (phaseTwoChecking)
                {
                    twoAuntieUI.SetActive(true);
                }

                else if (phaseOneChecking)
                {
                    oneAuntieUI.SetActive(true);
                }

                else
                {
                    zeroAuntieUI.SetActive(true);
                }
            }

            else if (uncle == true)
            {
                if (phaseTwoChecking)
                {
                    twoUncleUI.SetActive(true);
                }

                else if (phaseOneChecking)
                {
                    oneUncleUI.SetActive(true);
                }

                else
                {
                    zeroUncleUI.SetActive(true);
                }
            }

            else if (kid == true)
            {
                kidUI.SetActive(true);
            }

            else if (chief == true)
            {
                if (phaseThreeChecking)
                {
                    threeChiefUI.SetActive(true);
                }

                else if (phaseTwoChecking)
                {
                    twoChiefUI.SetActive(true);
                }

                else if (phaseOneChecking)
                {
                    oneChiefUI.SetActive(true);
                }

                else
                {
                    zeroChiefUI.SetActive(true);
                }
            }

            else if (chiefInHouse == true)
            {
                threeChiefUI.SetActive(true);
            }
        }
    }
}
