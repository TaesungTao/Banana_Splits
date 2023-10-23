using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    // followed a unity tutorial on scene change
    public void MoveScenes(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
