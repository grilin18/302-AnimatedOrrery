using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudController : MonoBehaviour
{
    RigScript rig;
    public GameObject cam;
    OrbitScript orbit1;
    SunRevolve srevo;
    public GameObject orbiters1;
    public GameObject sun;

    OrbitScript orbit2;
    public GameObject orbiters2;

    OrbitScript orbit3;
    public GameObject orbiters3;

    OrbitScript orbit4;
    public GameObject orbiters4;

    OrbitScript orbit5;
    public GameObject orbiters5;

    OrbitScript orbit6;
    public GameObject orbiters6;

    OrbitScript orbit7;
    public GameObject orbiters7;

    OrbitScript orbit8;
    public GameObject orbiters8;

    OrbitScript orbit9;
    public GameObject orbiters9;

    OrbitScript orbit10;
    public GameObject orbiters10;

    OrbitScript orbit11;
    public GameObject orbiters11;

    OrbitScript orbit12;
    public GameObject orbiters12;

    OrbitScript orbit13;
    public GameObject orbiters13;

    // Start is called before the first frame update
    void Start()
    {
        orbit1 = orbiters1.GetComponent<OrbitScript>();
        orbit2 = orbiters2.GetComponent<OrbitScript>();
        orbit3 = orbiters3.GetComponent<OrbitScript>();
        orbit4 = orbiters4.GetComponent<OrbitScript>();
        orbit5 = orbiters5.GetComponent<OrbitScript>();
        orbit6 = orbiters6.GetComponent<OrbitScript>();
        orbit7 = orbiters7.GetComponent<OrbitScript>();
        orbit8 = orbiters8.GetComponent<OrbitScript>();
        orbit9 = orbiters9.GetComponent<OrbitScript>();
        orbit10 = orbiters10.GetComponent<OrbitScript>();
        orbit11 = orbiters11.GetComponent<OrbitScript>();
        orbit12 = orbiters12.GetComponent<OrbitScript>();
        orbit13 = orbiters13.GetComponent<OrbitScript>();
        srevo = sun.GetComponent<SunRevolve>();
        rig = cam.GetComponent<RigScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sunButton()
    {
        rig.lookAtValue = 0;
    }

    public void planet1Button()
    {
        rig.lookAtValue = 1;
    }

    public void planet2Button()
    {
        rig.lookAtValue = 2;
    }

    public void planet3Button()
    {
        rig.lookAtValue = 3;
    }

    public void planet4Button()
    {
        rig.lookAtValue = 4;
    }

    public void planet5Button()
    {
        rig.lookAtValue = 5;
    }

    public void fastForward()
    {
        orbit1.direction = 1;
        orbit2.direction = 1;
        orbit3.direction = 1;
        orbit4.direction = 1;
        orbit5.direction = 1;
        orbit6.direction = 1;
        orbit7.direction = 1;
        orbit8.direction = 1;
        orbit9.direction = 1;
        orbit10.direction = 1;
        orbit11.direction = 1;
        orbit12.direction = 1;
        orbit13.direction = 1;
        srevo.direction = 1;
        Time.timeScale = 3;
    }

    public void play()
    {
        orbit1.direction = 1;
        orbit2.direction = 1;
        orbit3.direction = 1;
        orbit4.direction = 1;
        orbit5.direction = 1;
        orbit6.direction = 1;
        orbit7.direction = 1;
        orbit8.direction = 1;
        orbit9.direction = 1;
        orbit10.direction = 1;
        orbit11.direction = 1;
        orbit12.direction = 1;
        orbit13.direction = 1;
        srevo.direction = 1;
        Time.timeScale = 1;
    }

    public void rewind()
    {
        orbit1.direction = -1;
        orbit2.direction = -1;
        orbit3.direction = -1;
        orbit4.direction = -1;
        orbit5.direction = -1;
        orbit6.direction = -1;
        orbit7.direction = -1;
        orbit8.direction = -1;
        orbit9.direction = -1;
        orbit10.direction = -1;
        orbit11.direction = -1;
        orbit12.direction = -1;
        orbit13.direction = -1;
        srevo.direction = -1;
    }

    public void pause()
    {
        orbit1.direction = 1;
        orbit2.direction = 1;
        orbit3.direction = 1;
        orbit4.direction = 1;
        orbit5.direction = 1;
        orbit6.direction = 1;
        orbit7.direction = 1;
        orbit8.direction = 1;
        orbit9.direction = 1;
        orbit10.direction = 1;
        orbit11.direction = 1;
        orbit12.direction = 1;
        orbit13.direction = 1;
        srevo.direction = 1;
        Time.timeScale = 0;
    }
}
