using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceFrom : MonoBehaviour
{
    public GameObject cube;
    public GameObject cylinder;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("La distancia con el cubo es: " + Vector3.Distance(transform.position, cube.transform.position));
        Debug.Log("La distancia con el cilindro es: " + Vector3.Distance(transform.position, cylinder.transform.position));    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
