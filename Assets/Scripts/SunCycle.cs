using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunCycle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sun;
    private float rot;
    public float scale;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rot = Input.GetAxis("Horizontal") * Time.deltaTime * scale;
        sun.transform.rotation = new Quaternion(sun.transform.rotation.x, sun.transform.rotation.y, sun.transform.rotation.z + rot, sun.transform.rotation.w);

    }
}
