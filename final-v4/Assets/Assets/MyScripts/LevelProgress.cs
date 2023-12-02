using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgress : MonoBehaviour
{
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("WallClimb"))
        {
            Manager.Instance.WallUp++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Dash"))
        {
            Manager.Instance.DashUp++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("DoubleJump"))
        {
            Manager.Instance.DoubleJumpUp++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("GateOneFinish"))
        {
            Manager.Instance.FinishOne++;
        }
        if (collision.gameObject.CompareTag("GateTwoFinish"))
        {
            Manager.Instance.FinishTwo++;
        }
        if (collision.gameObject.CompareTag("GateThreeFinish"))
        {
            Manager.Instance.FinishThree++;
        }
    }
}
