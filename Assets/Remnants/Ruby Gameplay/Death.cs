using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death
   : MonoBehaviour
{

    public Transform respawnPoint;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Death"))
        {
            transform.position = respawnPoint.position;
        }
      
      
    }
}
