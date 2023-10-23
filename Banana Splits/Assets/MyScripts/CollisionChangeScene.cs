using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionChangeScene : MonoBehaviour
{
    public int sceneID; 
    // Start is called before the first frame update
    // followed a unity tutorial on scene change
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GateOne"){
        ChangeScenes(sceneID);
        }
        if (collision.gameObject.tag == "GateTwo"){
            ChangeScenes(sceneID);
        }
        if (collision.gameObject.tag == "GateThree"){
            ChangeScenes(sceneID);
        }
    }
    public void ChangeScenes(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}