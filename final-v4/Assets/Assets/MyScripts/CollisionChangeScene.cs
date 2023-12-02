using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollisionChangeScene : MonoBehaviour
{
    public int sceneID; 
    public Image DoorChange;
    public bool canEnter = false;

    public Animator anim;

    // Start is called before the first frame update
    // followed a unity tutorial on scene change
    void Start()
    {
        DoorChange.enabled = false;
        anim = GetComponent<Animator>();
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.attachedRigidbody){
            DoorChange.enabled = false;
            canEnter = false;
            anim.SetFloat("DoorOpen", 1f);
    }
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.attachedRigidbody){
            DoorChange.enabled = true;
            canEnter = true;
            anim.SetFloat("DoorOpen", 2f);
    }
    }

    void Update()
    {
        if (canEnter == true && Input.GetKey(KeyCode.Return))
        {
            ChangeScenes(sceneID);
            DoorChange.enabled = false;
        }
    }
    
    public void ChangeScenes(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}