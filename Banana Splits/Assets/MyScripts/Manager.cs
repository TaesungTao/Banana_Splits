using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class Manager : MonoBehaviour
{
    public int livesHad = 3;
    public int prizesCounted = 0;
    public int Speed = 50;
    public int WallUp = 1;
    public int DashUp = 1;
    public int JumpUp = 1;
    public static Manager Instance { get; private set; }
    
    private void Awake()
    {
        if (Instance != null && Instance != this) {
            Destroy(this.gameObject);
        } else {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
 