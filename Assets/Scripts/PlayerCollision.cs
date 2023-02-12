using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript playerScript;
  private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collactable")
        {
            Destroy(other.gameObject);

        }
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Obstacle")
        {
            playerScript.enabled = false;
        }

    }


}
