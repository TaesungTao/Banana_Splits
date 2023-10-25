using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgress : MonoBehaviour
{
    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "WallClimb")
        {
            Manager.Instance.WallUp++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Dash")
        {
            Manager.Instance.DashUp++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "DoubleJump")
        {
            Manager.Instance.DoubleJumpUp++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "GateOneFinish")
        {
            Manager.Instance.FinishOne++;
        }
        if (collision.gameObject.tag == "GameTwoFinish")
        {
            Manager.Instance.FinishTwo++;
        }
        if (collision.gameObject.tag == "GameThreeFinish")
        {
            Manager.Instance.FinishThree++;
        }
    }
}
