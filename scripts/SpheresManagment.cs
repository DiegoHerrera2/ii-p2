using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpheresManagment : MonoBehaviour
{
    private GameObject[] gameObjects;
    // Start is called before the first frame update
    void Start()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("GrupoEsfera2");

        float[] distances = new float[gameObjects.Length];

        for (int i = 0; i < gameObjects.Length; i++) {
            distances[i] = Vector3.Distance(transform.position, gameObjects[i].transform.position);
        }

        int furthestIndex = 0;
        int nearestIndex = 0;

        for (int i = 0; i < distances.Length; i++) {
            if (distances[i] > distances[furthestIndex]) furthestIndex = i;
            if (distances[i] < distances[nearestIndex]) nearestIndex = i;
        }

        gameObjects[furthestIndex].GetComponent<Renderer>().material.color = Color.green;
        gameObjects[nearestIndex].transform.position += Vector3.up * 1;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
