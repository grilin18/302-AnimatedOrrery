using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class OrbitScript : MonoBehaviour
{
    public GameObject target;
    public float radius;
    public float speed;
    private float age = 0;
    private float roty = 0;
    public float direction = 1;

    public float xMod = 1;

    public float zMod = 1;

    public int pathResolution = 32;

    private LineRenderer path;

    // Start is called before the first frame update
    void Start()
    {
        path = GetComponent<LineRenderer>();
        UpdateOrbitPath();
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null) return;

        Vector3 offset = AnimMath.SpotOnEllipseXZ(radius, xMod, zMod, age, speed);
        transform.position = target.transform.position + offset;
        age += Time.deltaTime * direction;
        roty += Time.deltaTime * speed;
        transform.rotation = Quaternion.Euler(0, roty, 0); 

        if(target.transform.hasChanged) UpdateOrbitPath();
    }

    void UpdateOrbitPath(){
        if (target == null) return;

        Vector3[] pts = new Vector3[pathResolution];

        for (int i = 0; i < pts.Length; i++){
            float x = radius * Mathf.Cos(i * 2 * Mathf.PI / pathResolution);
            float z = radius * Mathf.Sin(i * 2 * Mathf.PI / pathResolution);

            Vector3 pt = new Vector3(x, 0, z) + target.transform.position;
            pts[i] = pt;
        }
        path.positionCount = pathResolution;
        path.SetPositions(pts);
    }

}
