using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameoverscript : MonoBehaviour
{
    public GameObject scoreValueUI;
    public GameObject highscoreValueUI;
    
    private void Start()
    {
        scoreValueUI.GetComponent<Text>().text = PlayerPrefs.GetInt("Score").ToString();
        highscoreValueUI.GetComponent<Text>().text = PlayerPrefs.GetInt("Highscore").ToString();
    }
   
    
}
