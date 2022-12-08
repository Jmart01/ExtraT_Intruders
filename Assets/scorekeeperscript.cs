using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scorekeeperscript : MonoBehaviour
{
    public int score;
    public Text scoreValueUI;
    public int Highscore;
    public GameObject highscoreValueUI;
    public int InvaderAmount;

    
    private void Start()
    {
        Highscore = PlayerPrefs.GetInt("Highscore");
        highscoreValueUI.GetComponent<Text>().text = Highscore.ToString();
        InvaderAmount = 126;
    }
    public void Changescore()
    {
        score = score + 25;
        scoreValueUI.text = score.ToString();
        PlayerPrefs.SetInt("Score", score);

        if (score >= Highscore)
        {
            Highscore = score;
            highscoreValueUI.GetComponent<Text>().text = Highscore.ToString();
            PlayerPrefs.SetInt("Highscore", Highscore);
        }
        InvaderAmount = InvaderAmount - 1;
        if(InvaderAmount <= 0)
        {
            SceneManager.LoadScene("You_win_scene", LoadSceneMode.Single);
        }
    }
    
    
    
}
