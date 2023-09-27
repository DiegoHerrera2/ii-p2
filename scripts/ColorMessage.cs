using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMessage : MonoBehaviour
{
    Renderer rd;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Renderer>();
        Debug.Log("Soy " + gameObject.name + " con color " + rd.material.color);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
