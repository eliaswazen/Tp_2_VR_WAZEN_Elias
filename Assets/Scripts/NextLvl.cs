using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLvl : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    { // OnCollisionEnter 
        
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Terrain");
        }
    }
}

