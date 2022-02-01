using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]

public class LineRender : MonoBehaviour
{
    [Range(10, 60)] public int numb = 10;
    [Range(1, 65)] public float radius = 5;
    LineRenderer line;

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
        float rad = 0;
        Vector3[] pts = new Vector3[numb];
        for (int i = 0; i < numb; i++)
        {
            pts[i] = new Vector3(Mathf.Cos(rad), 0, Mathf.Sin(rad)) * radius;
            rad += Mathf.PI * 2 / numb;

        }
        line.positionCount = numb;
        line.SetPositions(pts); 
    }

  
}
