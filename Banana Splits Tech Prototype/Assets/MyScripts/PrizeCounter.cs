using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PrizeCounter : MonoBehaviour
{
    public int sceneID;
    public GameObject player;
    public Text LivesText;
    public bool TimeUp = true;
   // public Text PrizesText;
    // Start is called before the first frame update
    void Start()
    {
        LivesText.text = ("Lives: ") + Manager.Instance.livesHad.ToString();
        //PrizesText.text = ("Prizes: ") + Manager.Instance.prizesCounted.ToString();
    }

    void Update()
    {
        if (Manager.Instance.livesHad == 0){
            MoveScenes(sceneID);
            Manager.Instance.livesHad = 3;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        //if (other.gameObject.tag == "Prize")
        //{
       //     //Respawn here
       //     Destroy(other.gameObject);
        //    Manager.Instance.prizesCounted++;
            
       //     PrizesText.text = ("Prizes: ") + Manager.Instance.prizesCounted.ToString();
 
      //  }
        if (other.gameObject.tag == "Enemy" && TimeUp == true)
        {
            //Player loses a life
            TimeUp = false;
            Manager.Instance.livesHad--;
            LivesText.text = ("Lives: ") + Manager.Instance.livesHad.ToString();
            SecondsWaiting();

        }
    }
    public void MoveScenes(int sceneID){
        SceneManager.LoadScene(sceneID);
    }
    public void SecondsWaiting()
    {
        StartCoroutine(WaitCouple());
    }
    
    IEnumerator WaitCouple()
    {
        yield return new WaitForSeconds(1);
       TimeUp = true;
    
    }


}
 