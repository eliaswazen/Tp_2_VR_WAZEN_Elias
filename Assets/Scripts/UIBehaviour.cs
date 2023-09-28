using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBehaviour : MonoBehaviour
{
    TMP_Text headText,timerText;
    int nbCats = 0;
    public GameObject arrow;
    public GameObject smoke;
    public GameObject gameOverBg;
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if(scene.name == "dragonHouse")
        {
            headText = GameObject.Find("lblCats").GetComponent<TMPro.TMP_Text>();
        }
        timerText = GameObject.Find("lblTime").GetComponent<TMPro.TMP_Text>();
        StartCoroutine(TimerTick());
    }
    void Update()
    {
    }
    public void AddHit()
    {
        nbCats++;
        Debug.Log(GameObject.FindWithTag("lblCats"));

        headText.text = "BobHeads: " + nbCats;
        if(nbCats == 4)
        {
            arrow.SetActive(true);
            smoke.SetActive(true);
            /*SceneManager.LoadScene("Terrain");*/ // le nom de votre scene
        }
    }

    IEnumerator TimerTick()
    {
        int currentTime = GameVariables.currentTime;
        while (currentTime > 0)
        {
            // attendre une seconde
            yield return new WaitForSeconds(1);
            currentTime--;
            timerText.text = "Time :" + currentTime.ToString();
        }
        // game over
        gameOverBg.SetActive(true);
        Time.timeScale = 0;
        /* SceneManager.LoadScene("dragonHouse");*/ // le nom de votre scene
    }

    

    public void restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("dragonHouse");
    }

}