using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startscenescript : MonoBehaviour
{
    public void Startgame()
    {
        SceneManager.LoadScene("Scene_Game", LoadSceneMode.Single);
    }
}
