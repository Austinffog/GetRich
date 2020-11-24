using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static int Money;
    public Text Dollars;
    public GameObject particles;


    // Start is called before the first frame update
    void Start()
    {
        Dollars.text = "$" + Money.ToString();
        Money = PlayerPrefs.GetInt("money", Money);
    }

    private void OnMouseDown()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            Destroy(gameObject);
            Instantiate(particles, transform.position, Quaternion.identity);
            IncreaseMoney();
        }
    }

    private void IncreaseMoney()
    {
        if (gameObject.CompareTag("Coins"))
        {
            Money += 10;
        }

        if (gameObject.CompareTag("Money"))
        {
            Money += 100;

        }
        else if (gameObject.CompareTag("Fake"))
        {
            Money -= 100;
        }


        if (gameObject.CompareTag("Silver"))
        {
            Money += 1000;
        }
        else if (gameObject.CompareTag("FakeSilver"))
        {
            Money -= 1000;
        }

        if (gameObject.CompareTag("Diamond"))
        {
            Money += 10000;
        }
        else if (gameObject.CompareTag("FakeDiamond"))
        {
            Money -= 10000;
        }

        if (gameObject.CompareTag("Gold"))
        {
            Money += 100000;
        }
        else if (gameObject.CompareTag("FakeGold"))
        {
            Money -= 100000;
        }

        if (gameObject.CompareTag("Car"))
        {
            Money += 500000;
        }
        else if (gameObject.CompareTag("FakeCar"))
        {
            Money -= 500000;
        }

        if (gameObject.CompareTag("Cure"))
        {
            Money += 1000000;
        }
        else if (gameObject.CompareTag("FakeCure"))
        {
            Money -= 1000000;
        }

        if (gameObject.CompareTag("Island"))
        {
            Money += 5000000;
        }
        else if (gameObject.CompareTag("FakeIsland"))
        {
            Money -= 5000000;
        }

        if (gameObject.CompareTag("MonaLisa"))
        {
            Money += 10000000;
        }
        else if (gameObject.CompareTag("FakeMonaLisa"))
        {
            Money -= 10000000;
        }

        Dollars.text = "$" + Money.ToString();
        PlayerPrefs.SetInt("money", Money);
    }
}