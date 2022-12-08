using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class invaderscript : MonoBehaviour
{
      public GameObject bomb;
    public int InvaderAmount;

    private void Start()
    {
        StartCoroutine(Dropthembombs());
    }

    IEnumerator Dropthembombs()
    {
        while (gameObject)
        {
            float randomDelay;
            randomDelay = Random.Range(1f, 30f);
            yield return new WaitForSeconds(randomDelay);

            Instantiate(bomb, transform.position, Quaternion.identity);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bunker")
        {
            SceneManager.LoadScene("Game_over_scene", LoadSceneMode.Single);
        }
    }
}
