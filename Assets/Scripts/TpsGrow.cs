using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TpsGrow : MonoBehaviour
{
    public GameObject arrow;
    public GameObject monster;
    public GameObject goodJobBg;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    { // OnCollisionEnter 
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Terrain")
        {
           
            if (other.tag == "CatBots")
            {
                transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
                Debug.Log(transform.localScale.x);
                if(transform.localScale.x == 3.5)
                {
                    arrow.SetActive(true);
                    monster.SetActive(true);
                    
                }
               
                /*                Destroy(other.gameObject);
                */
            }
            if (other.tag == "Monster")
            {
                goodJobBg.SetActive(true);
                arrow.SetActive(false);
                audioSource.Play(0);
                Time.timeScale = 0;
            }
        }
    }
}
