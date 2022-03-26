using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineChecker : MonoBehaviour
{   
    GameManager myManager;
    GameObject Panel;
    bool AmIPutin;

    void Start ()
    {
        myManager = GameManager.FindInstance();
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        Debug.Log("col entered!");
        myManager.CurrentState = GameManager.State.Unvote;
    }

}
