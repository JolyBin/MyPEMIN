using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabelRender : MonoBehaviour
{
    public LineRenderer LineRenderer;
    public int Segments = 10;
    public Vector3 Vector3;
    public Vector3 Vector31;

    public void DrawLine(Vector3 startPoint, Vector3 endPoint, float length)
    {
        float interpolant = Vector3.Distance(startPoint, endPoint) / length;
        float offset = Mathf.Lerp(length / 2f, 0f, interpolant);

        Vector3 startPointDown = startPoint + Vector3.down * offset + Vector3;
        Vector3 endPointDown = endPoint + Vector3.down * offset + Vector31;

        LineRenderer.positionCount = Segments + 1;

        for (int i = 0; i < LineRenderer.positionCount; i++)
        {
            LineRenderer.SetPosition(i, Bezier.GetPoint(startPoint, startPointDown, endPointDown, endPoint, (float)i / Segments));
        }
    }

    public void Active(bool isActive)
    {
        LineRenderer.enabled = isActive;
    }
}
