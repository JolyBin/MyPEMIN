using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public PC Monitor;
    public TestManager TestManager;
    public void GetButton()
    {
        Monitor.RotateTable();
        TestManager.Clear();
    }
}
