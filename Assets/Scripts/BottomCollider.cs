using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BottomCollider : MonoBehaviour
{
    private int Money;

    // Start is called before the first frame update
    void Start()
    {
        Money = PlayerPrefs.GetInt("money", Money);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Money") || other.gameObject.CompareTag("Fake")
            || other.gameObject.CompareTag("Silver") || other.gameObject.CompareTag("FakeSilver")
            || other.gameObject.CompareTag("Diamond") || other.gameObject.CompareTag("FakeDiamond")
            || other.gameObject.CompareTag("Gold") || other.gameObject.CompareTag("FakeGold")
            || other.gameObject.CompareTag("Car") || other.gameObject.CompareTag("FakeCar")
            || other.gameObject.CompareTag("Cure") || other.gameObject.CompareTag("FakeCure")
            || other.gameObject.CompareTag("Island") || other.gameObject.CompareTag("FakeIsland")
            || other.gameObject.CompareTag("MonaLisa") || other.gameObject.CompareTag("FakeMonaLisa")
            )
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Coins"))
        {
            if (Money < 10000)//100
            {
                Destroy(other.gameObject);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 10);
            }
            else if (Money >= 10000 & Money <= 100000)//1000
            {
                Destroy(other.gameObject);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 100);
            }
            else if (Money >= 100000 & Money <= 1000000)//10000
            {
                Destroy(other.gameObject);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 500);
            }
            else if (Money >= 1000000 & Money <= 10000000)//100000
            {
                Destroy(other.gameObject);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 2500);
            }
            else if (Money >= 10000000 & Money <= 100000000)//1000000
            {
                Destroy(other.gameObject);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 10000);
            }
            else if (Money >= 100000000 & Money <= 500000000)//10000000
            {
                Destroy(other.gameObject);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 25000);
            }
            else if (Money >= 500000000 & Money <= 1000000000)//50000000
            {
                Destroy(other.gameObject);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 50000);
            }
            else if (Money >= 1000000000 & (long)Money <= 10000000000)//100000000
            {
                Destroy(other.gameObject);
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 75000);
            }

        }
    }
}
