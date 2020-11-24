using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EverythingSpawner : MonoBehaviour
{
    public GameObject[] realMoney;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;

    int randRealMoney;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitFirst());
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }

    IEnumerator waitFirst()
    {
        yield return new WaitForSeconds(startWait);

        while (true)
        {
            randRealMoney = Random.Range(0, 16);
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(-spawnValues.y, spawnValues.y), 0);

            Instantiate(realMoney[randRealMoney], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }
}
