using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatBehaviour : MonoBehaviour
{
    private AudioSource collisionSound;
    public GameObject fx;
    public GameObject worldObject;

    void Start()
    {
        worldObject = GameObject.Find("World");
    }
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    { // OnCollisionEnter 
        collisionSound = GameObject.Find("World").GetComponent<AudioSource>();
        if (collisionSound)
        {
            collisionSound.Play();
        }
        Scene scene = SceneManager.GetActiveScene();
        
        if (other.tag == "Player")
        {
            Instantiate(fx, transform.position, Quaternion.identity);
            if (scene.name == "dragonHouse")
            {
                worldObject.SendMessage("AddHit");
               
            }
            Destroy(gameObject);
        }
    }
}
