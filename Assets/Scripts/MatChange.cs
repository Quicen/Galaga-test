using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatChange : MonoBehaviour
{
    public Material[] materials;
    Renderer render;
    
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("1")) 
        { 
            render.material = materials[0];
        }
        if (Input.GetKey("2"))
        {
            render.material = materials[1];
        }
        if (Input.GetKey("3"))
        {
            render.material = materials[2];
        }
        if (Input.GetKey(KeyCode.Space))
        {
            render.material = materials[3];
        }
    }
}
