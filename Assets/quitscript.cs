using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitscript : MonoBehaviour
{
    public void gameQuit()
    {
        Application.Quit();
        Debug.Log("i quit");
    }
}
