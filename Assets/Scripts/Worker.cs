using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{
    public CabelRender CabelRender;
    public Transform StartPosition;
    public Transform EndPosition;
    public float Length;
    public bool IsActive = false;

    public int CountManager = 0;

    public void AddCount()
    {
        if (CountManager < 2)
        {
            CountManager++;
            if (CountManager == 2)
            {
                IsActive = true;

            }
            else
            {
                IsActive = false;
            }
        }
        
    }

    public void UnAddCount()
    {
        CountManager--;
        IsActive = CountManager == 2;
    }

}
