using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    public GameObject TestMenu;
    public static bool IsActiveMenu = false;
    public List<GameObject> ListDialogs;
    public List<GameObject> ListBlinks;

    void Start()
    {
        TestMenu.SetActive(IsActiveMenu);
    }

    public void StartDialog(int i)
    {
        ListDialogs[i - 1].SetActive(false);
        ListDialogs[i].SetActive(true);
    }

    public void Blink(int j)
    {
            ListBlinks[j].SetActive(true);
    }

    public void Clear()
    {
        foreach (GameObject blink in ListBlinks)
        {
            blink.SetActive(false);
        }
    }

    public void Blink()
    {
        foreach (GameObject blink in ListBlinks)
        {
            blink.SetActive(true);
        }
    }
}
