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
    public Text PrizesText;
    // Start is called before the first frame update
    void Start()
    {
        LivesText.text = ("Lives: ") + Manager.Instance.livesHad.ToString();
        PrizesText.text = ("Prizes: ") + Manager.Instance.prizesCounted.ToString();
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
        if (other.gameObject.tag == "Prize")
        {
            //Respawn here
            Destroy(other.gameObject);
            Manager.Instance.prizesCounted++;
            //coded purely from memory- started reading more into Unity tutorials 
            //and attempting to memorize simple code such as destroy, instantiate, ints and more
            PrizesText.text = ("Prizes: ") + Manager.Instance.prizesCounted.ToString();
 
        }
        if (other.gameObject.tag == "Enemy")
        {
            //Player loses a life
            Manager.Instance.livesHad--;
            LivesText.text = ("Lives: ") + Manager.Instance.livesHad.ToString();

        }
    }
    public void MoveScenes(int sceneID){
        SceneManager.LoadScene(sceneID);
    }

}
 