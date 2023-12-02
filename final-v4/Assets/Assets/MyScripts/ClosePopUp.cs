using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClosePopUp : MonoBehaviour
{
    public Canvas PowerUpImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Close()
    {
        PowerUpImage.enabled = false;
        Manager.Instance.MovementEnabled = true;
    }
}
