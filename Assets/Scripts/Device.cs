using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Device : MonoBehaviour
{
    public Transform PositionCamera;

    public Transform GetPositionCamera()
    {
        return PositionCamera;
    }
}
