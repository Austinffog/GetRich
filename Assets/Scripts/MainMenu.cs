using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int Money;

    private string round2 = "Round1";

    // Start is called before the first frame update
    void Start()
    {
        Money = PlayerPrefs.GetInt("money", Money);

        round2 = PlayerPrefs.GetString("round2", round2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Coin()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Scene()
    {
        if (Money < 10000 & round2.Equals("Round1"))//100
        {
            SceneManager.LoadScene(2);
        }
        else if (Money >= 10000 & Money <= 100000 & round2.Equals("Round1"))//1000
        {
            SceneManager.LoadScene(3);
        }
        else if (Money >= 100000 & Money <= 1000000 & round2.Equals("Round1"))//10000
        {
            SceneManager.LoadScene(4);
        }
        else if (Money >= 1000000 & Money <= 10000000 & round2.Equals("Round1"))//100000
        {
            SceneManager.LoadScene(5);
        }
        else if (Money >= 10000000 & Money <= 100000000 & round2.Equals("Round1"))//1000000
        {
            SceneManager.LoadScene(6);
        }
        else if (Money >= 100000000 & Money <= 500000000 & round2.Equals("Round1"))//10000000
        {
            SceneManager.LoadScene(7);
        }
        else if (Money >= 500000000 & Money <= 1000000000 & round2.Equals("Round1"))//50000000
        {
            SceneManager.LoadScene(8);
        }
        else if (Money >= 1000000000 & Money <= 2000000000 & round2.Equals("Round1"))//100000000
        {
            SceneManager.LoadScene(9);
        }
        else if (Money >= 2000000000 & round2.Equals("Round1"))
        {
            SceneManager.LoadScene(10);
        }

        if (round2.Equals("Round2") & Money < 10000)//100
        {
            SceneManager.LoadScene(11);
        }
        else if (round2.Equals("Round2") & Money >= 10000 & Money <= 100000)//1000
        {
            SceneManager.LoadScene(12);
        }
        else if (round2.Equals("Round2") & Money >= 100000 & Money <= 1000000)//10000
        {
            SceneManager.LoadScene(13);
        }
        else if (round2.Equals("Round2") & Money >= 1000000 & Money <= 10000000)//100000
        {
            SceneManager.LoadScene(14);
        }
        else if (round2.Equals("Round2") & Money >= 10000000 & Money <= 100000000)//1000000
        {
            SceneManager.LoadScene(15);
        }
        else if (round2.Equals("Round2") & Money >= 100000000 & Money <= 500000000)//10000000
        {
            SceneManager.LoadScene(16);
        }
        else if (round2.Equals("Round2") & Money >= 500000000 & Money <= 1000000000)//50000000
        {
            SceneManager.LoadScene(17);
        }
        else if (round2.Equals("Round2") & Money >= 1000000000 & Money <= 2000000000)//100000000
        {
            SceneManager.LoadScene(18);
        }
        if (round2.Equals("Round2") & Money >= 2000000000)
        {
            SceneManager.LoadScene(19);
        }


        if (round2.Equals("Round3"))
        {
            SceneManager.LoadScene(20);
        }
    }
}