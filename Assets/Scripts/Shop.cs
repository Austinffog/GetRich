using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public int Money;

    public void Reset()
    {
        Money = 0;
        PlayerPrefs.SetInt("money", Money);
    }
}
