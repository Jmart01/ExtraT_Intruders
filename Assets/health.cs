using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    public int healthamount;
    public Text healthUI;
    public GameObject playerdeath;

    // Start is called before the first frame update
    void Start()
    {
        healthamount = 100;
        playerdeath = GameObject.Find("player_Death");
    }

    public void Changehealth()
    {
        healthamount = healthamount -10;
        healthUI.text = healthamount.ToString();

        if (healthamount == 0)
        {
            playerdeath.GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }
        if(healthamount <= 0)
        {
            int myScore;
            myScore = GameObject.Find("scorekeeper").GetComponent<scorekeeperscript>().score;

            PlayerPrefs.SetInt("Score", myScore);
            SceneManager.LoadScene("Game_over_scene", LoadSceneMode.Single);

        }
    }


}
