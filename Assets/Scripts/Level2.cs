using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level2 : MonoBehaviour
{
    public float interval = 1f;
    public int Money;
    public Text text;

    private float timeStart = 5f;
    public Text gameCounter;

    private string round2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Disable());
    }

    // Update is called once per frame
    void Update()
    {
        Money = PlayerPrefs.GetInt("money");
        round2 = PlayerPrefs.GetString("round2", round2);
        Scene();
    }

    public IEnumerator Disable()
    {
        yield return new WaitForSeconds(interval);
        text.enabled = false;
    }

    public void Scene()
    {

        if (Money < 10000)//100
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 11"))
            {
                SceneManager.LoadScene(11);
            }
        }
        else if (Money >= 10000 & Money <= 100000)//1000
        {

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 10"))
            {
                SceneManager.LoadScene(12);
            }

        }
        else if (Money >= 100000 & Money <= 1000000)//10000
        {

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 11"))
            {
                SceneManager.LoadScene(13);
            }

        }
        else if (Money >= 1000000 & Money <= 10000000)//100000
        {

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 12"))
            {
                SceneManager.LoadScene(14);
            }
        }
        else if (Money >= 10000000 & Money <= 100000000)//1000000
        {

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 13"))
            {
                SceneManager.LoadScene(15);
            }

        }
        else if (Money >= 100000000 & Money <= 500000000)//10000000
        {

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 14"))
            {
                SceneManager.LoadScene(16);
            }

        }
        else if (Money >= 500000000 & Money <= 1000000000)//50000000
        {

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 15"))
            {
                SceneManager.LoadScene(17);
            }

        }
        else if (Money >= 1000000000 & Money <= 2000000000)//100000000
        {

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 16"))
            {
                SceneManager.LoadScene(18);
            }

        }
        if (Money >= 2000000000)
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 17"))
            {
                SceneManager.LoadScene(19);
            }
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(19))
        {
            Invoke("Round3", 5f);
            timeStart -= Time.deltaTime;
            gameCounter.text = timeStart.ToString("F1");
            Money = 0;
            PlayerPrefs.SetInt("money", Money);

            round2 = "Round3";
            PlayerPrefs.SetString("round2", round2);
        }
    }

    private void Round3()
    {
        SceneManager.LoadScene(20);
    }

}