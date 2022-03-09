using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Port : Port1
{
    public Worker Worker2;
    

    public override void InputCabel()
    {
        if (_isActiv)
        {
            if (_isCabel)
            {
                _newPort = Instantiate(Cabel5, PositionCabel5);
                _newPort.transform.position = PositionCabel5.position;
                _newPort.transform.rotation = PositionCabel5.rotation;
                _isCabel = false;
                if (Worker.CountManager < 2 && Worker2.CountManager < 2)
                {
                    Worker.AddCount();
                    Worker2.AddCount();
                }
            }
            else
            {
                Destroy(_newPort);
                _isCabel = true;
                Worker.UnAddCount();
                Worker2.UnAddCount();
            }
        }
    }
}
