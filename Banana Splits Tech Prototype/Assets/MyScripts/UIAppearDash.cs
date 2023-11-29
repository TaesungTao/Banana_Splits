using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAppearDash : MonoBehaviour
{

    public Canvas PowerUpImage;

    void Start()
    {
        PowerUpImage.enabled = false;
    }

   void OnTriggerEnter2D(Collider2D collision)
   {
    if (collision.attachedRigidbody)
    {
        PowerUpImage.enabled = true;
        Manager.Instance.DashUp++;
        Destroy(gameObject);
    }
   }
}
