using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCoins : MonoBehaviour
{
    private float interval = 1f;
    public Text text;

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
}
