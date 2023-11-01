using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAppearDoubleJump : MonoBehaviour
{
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
            Manager.Instance.DoubleJumpUp++;
            Destroy(gameObject);
        }
    }
}
