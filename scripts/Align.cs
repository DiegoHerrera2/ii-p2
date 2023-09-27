using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Align : MonoBehaviour
{
    public GameObject cube;
    public GameObject cylinder;
    // Start is called before the first frame update
    void Start()
    {
        cube.transform.position = transform.position - Vector3.right * 5;
        cylinder.transform.position = transform.position + Vector3.right * 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
