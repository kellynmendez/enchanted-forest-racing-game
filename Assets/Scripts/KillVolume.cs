using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillVolume : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player has entered");
        PlayerController playerController = other.GetComponent<PlayerController>();

        if (playerController != null)
        {
            playerController.Die();
        }
    }
}
