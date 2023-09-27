using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereVector : MonoBehaviour
{
    public Vector3 vector1;
    public Vector3 vector2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Magnitud vector 1: " + vector1.magnitude);
        Debug.Log("Magnitud vector 2: " + vector2.magnitude);

        Debug.Log("Ángulo entre los vectores: " + Vector3.Angle(vector1, vector2));
        Debug.Log("Distancia entre los vectores: " + Vector3.Distance(vector1, vector2));

        Debug.Log("El vector a mayor altura es " + ((vector1.y > vector2.y) ? "Vector 1" : "Vector 2"));

        Debug.Log("Posición de la esfera: " + transform.position);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
