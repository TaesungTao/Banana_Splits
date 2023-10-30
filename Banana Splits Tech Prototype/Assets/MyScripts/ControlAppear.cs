using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAppear : MonoBehaviour
{  
    public Canvas ControlCanvas;

    void Start()
    {
        
        ControlCanvas.enabled = false;
    }
    // Start is called before the first frame update
    public void ControlAppearUI()
    {
        ControlCanvas.enabled = true;
    }
}
