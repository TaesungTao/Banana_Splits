using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class Manager : MonoBehaviour
{
    public int livesHad = 3;
    public int prizesCounted = 0;
    public int Speed = 50;
    public int WallUp = 0;
    public int DashUp = 0;
    public int DoubleJumpUp = 0;
    public int FinishOne = 0;
    public int FinishTwo = 0;
    public int FinishThree = 0;
    public float moveFactor;
    public float vertFactor;
    public bool MovementEnabled = true;
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
 