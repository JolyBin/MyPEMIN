using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Port1 : MonoBehaviour
{
    public GameObject Cabel5;
    public Transform PositionCabel5;
    public Worker Worker;

    protected bool _isCabel = true;
    protected bool _isActiv;

    protected GameObject _newPort;

    public virtual void InputCabel()
    {
        if (_isActiv)
        {
            if (_isCabel && Worker.CountManager < 2)
            {
                _newPort = Instantiate(Cabel5, PositionCabel5);
                _newPort.transform.position = PositionCabel5.position;
                _newPort.transform.rotation = PositionCabel5.rotation;
                _isCabel = false;
                Worker.AddCount();
            }
            else
            {
                Destroy(_newPort);
                _isCabel = true;
                Worker.UnAddCount();
            }
        }
    }

    public void SetActiveCabel5(bool isActiv)
    {
        _isActiv = isActiv;
    }
}
