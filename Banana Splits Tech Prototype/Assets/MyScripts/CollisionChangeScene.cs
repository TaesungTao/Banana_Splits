using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollisionChangeScene : MonoBehaviour
{
    public int sceneID; 
    public Image DoorChange;
    // Start is called before the first frame update
    // followed a unity tutorial on scene change
    void Start()
    {
        DoorChange.enabled = false;
    }
    
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.attachedRigidbody){
            DoorChange.enabled = true;
            if (Input.GetKey(KeyCode.Return)){
                DoorChange.enabled = false;
        ChangeScenes(sceneID);
        }
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.attachedRigidbody){
            DoorChange.enabled = false;
        }
    }
    public void ChangeScenes(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}