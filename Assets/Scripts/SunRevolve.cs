using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRevolve : MonoBehaviour
{
    public float speed;
    private float roty;
    public float direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        roty += Time.deltaTime * speed * direction;
        transform.rotation = Quaternion.Euler(0, roty, 0);
    }
}
