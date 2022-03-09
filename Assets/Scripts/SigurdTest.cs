using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SigurdTest : MonoBehaviour
{
    public GameObject TestSignal;

    private bool _isActive = false;

    public void SetActive()
    {
        _isActive = !_isActive;
        TestSignal.SetActive(_isActive);
    }
}
