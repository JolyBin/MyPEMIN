using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC : Device
{
    public Transform Table;
    public Vector3 SpeedRotate = new Vector3(0, 0.2f, 0);

    public void RotateTable()
    {
        Table.Rotate(SpeedRotate * Time.deltaTime);
    }
}
