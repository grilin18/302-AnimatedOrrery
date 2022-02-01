using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitScript : MonoBehaviour
{
    public GameObject target;
    public float radius;
    public float speed;
    private float age = 0;
    private float roty = 0;
    public float direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = AnimMath.SpotOnCircleXZ(radius, age, speed);
        transform.position = target.transform.position + offset;
        age += Time.deltaTime * direction;
        roty += Time.deltaTime * speed;
        transform.rotation = Quaternion.Euler(0, roty, 0); 
    }
}
