using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missilescript : MonoBehaviour
{
    public float speed;
    public GameObject scorekeeper;
    public GameObject missileexplosion;

    private void Start()
    {
        missileexplosion = GameObject.Find("missile_explosion");
        
    }
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed); 
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Invader")
        {
            GameObject.Find("scorekeeper").GetComponent<scorekeeperscript>().Changescore();
        }
        

        if (other.gameObject.tag == "Bunker")
        {
            missileexplosion.GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Invader")
        {
            missileexplosion.GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
