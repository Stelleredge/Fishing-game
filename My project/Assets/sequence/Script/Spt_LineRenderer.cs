using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spt_LineRenderer : MonoBehaviour
{
    public GameObject secondObject;
    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, secondObject.transform.position);
    }
}