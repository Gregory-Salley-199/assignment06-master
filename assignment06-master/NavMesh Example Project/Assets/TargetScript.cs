using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetScript : MonoBehaviour
{
    public GameObject Player;
    public static int TargetsDestroyed = 0;
    public Text ScoreText;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        ScoreText.text = "";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            this.gameObject.SetActive(false);
            TargetsDestroyed += 1;
            Debug.Log("destroyed: " + TargetsDestroyed);
            ScoreText.text = "Targets destroyed: " + TargetsDestroyed;
            
        }
    }
}
