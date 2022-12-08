using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombscript : MonoBehaviour
{
    public GameObject bombsound;
    public float speed;

    private void Start()
    {
        bombsound = GameObject.Find("bomb_explosion");
    }
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bunker")
        {
            
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Defender")
        {
            bombsound.GetComponent<AudioSource>().Play();
            Destroy(gameObject);
            GameObject.Find("Defender").GetComponent<health>().Changehealth();
        }

       
    }
}
