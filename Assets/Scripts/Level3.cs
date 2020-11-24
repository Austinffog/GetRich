using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level3 : MonoBehaviour
{
    public float interval = 1f;
    public int Money;
    public Text text;

    private string round2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Disable());
    }

    public IEnumerator Disable()
    {
        yield return new WaitForSeconds(interval);
        text.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Money = PlayerPrefs.GetInt("money");

        round2 = PlayerPrefs.GetString("round2");

        if (Money >= 2000000000)
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level 19")) //change scene by name
            {
                SceneManager.LoadScene(21);
            }
        }
    }
}
