using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppearPowerUp : MonoBehaviour
{
    // coding using previous knowledge of coroutines from the last project,
    // plus a brief tutorial on unity.com about the UI interface 
    public Canvas PowerUpImage;
    // Start is called before the first frame update

    void Start()
    {
        PowerUpImage.enabled = false;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.attachedRigidbody)
        {
            PowerUpImage.enabled = true;
            Manager.Instance.MovementEnabled = false;
            Destroy(gameObject);
        }
    }
}

