using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform teleportTarget;

    public GameObject thePlayer;

    private void OnCollisionEnter(Collision collision)
    {
        thePlayer.transform.position = teleportTarget.transform.position;
    }
}
