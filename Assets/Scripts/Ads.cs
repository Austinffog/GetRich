using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour
{
    private string storeID = "3509358";
    private string videoID = "video";

    private float adTime = 180f;

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(storeID, false);
        StartCoroutine(AdPlay());
    }

    IEnumerator AdPlay()
    {
        yield return new WaitForSeconds(adTime);

        while (true)
        {
            if (Advertisement.IsReady(videoID))
            {
                Advertisement.Show(videoID);
            }

            yield return new WaitForSeconds(adTime);  
        }  
    }
}
