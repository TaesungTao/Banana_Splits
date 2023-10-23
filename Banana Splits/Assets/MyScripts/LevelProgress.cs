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
        }
        if (collision.gameObject.tag == "Dash")
        {
            Manager.Instance.DashUp++;
        }
        if (collision.gameObject.tag == "DoubleJump")
        {
            Manager.Instance.JumpUp++;
        }
    }
}
