using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    public float interval = 1f;
    public int Money;
    public Text text;

    private float timeStart = 5f;
    public Text gameCounter;

    private string round2 = "Round1";

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
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 2"))
            {
                SceneManager.LoadScene(2);
            }
        }
        else if (Money >= 10000 & Money <= 100000)//1000
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 1"))
            {
                SceneManager.LoadScene(3);
            }
        }
        else if (Money >= 100000 & Money <= 1000000)//10000
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 2"))
            {
                SceneManager.LoadScene(4);
            }
        }
        else if (Money >= 1000000 & Money <= 10000000)//100000
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 3"))
            {
                SceneManager.LoadScene(5);
            }
        }
        else if (Money >= 10000000 & Money <= 100000000)//1000000
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 4"))
            {
                SceneManager.LoadScene(6);
            }
        }
        else if (Money >= 100000000 & Money <= 500000000)//10000000
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 5"))
            {
                SceneManager.LoadScene(7);
            }
        }
        else if (Money >= 500000000 & Money <= 1000000000)//50000000
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 6"))
            {
                SceneManager.LoadScene(8);
            }
        }
        else if (Money >= 1000000000 & Money <= 2000000000)//100000000
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 7"))
            {
                SceneManager.LoadScene(9);
            }
        }
        if (Money >= 2000000000)
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 8"))
            {
                SceneManager.LoadScene(10);
            }
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(10))
        {
            Invoke("Round2", 5f);
            timeStart -= Time.deltaTime;
            gameCounter.text = timeStart.ToString("F1");
            Money = 0;
            PlayerPrefs.SetInt("money", Money);

            round2 = "Round2";
            PlayerPrefs.SetString("round2", round2);
        }
    }

    private void Round2()
    {
        SceneManager.LoadScene(11);
    }

}
