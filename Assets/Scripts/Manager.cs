using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public List<Worker> Workers;
    public List<WorkerAntenn> WorkerAntenns;
    public int Count = 0;
    public GameObject DialogOk;
    public GameObject DialogNotOk;


    private void Update()
    {
        foreach (Worker worker in Workers)
        {
            worker.CabelRender.DrawLine(worker.StartPosition.position, worker.EndPosition.position, worker.Length);
            worker.CabelRender.Active(worker.IsActive);
        }

        foreach (WorkerAntenn worker in WorkerAntenns)
        {
            worker.CabelRender.DrawLine(worker.StartPosition.position, worker.EndPosition.position, worker.Length);
        }
    }

    public void Valid()
    {
        int count = 0;
        foreach (Worker worker in Workers)
        {
            if (worker.IsActive)
            {
                count++;
            }
        }
        if (count >= 4 && !DialogOk.activeSelf && !DialogNotOk.activeSelf)
        {
            DialogOk.SetActive(true);
        }
        else
        {
            DialogNotOk.SetActive(true);
        }
    }
}
