using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomArray : MonoBehaviour
{
    public int minimum;
    public int maximum;
    private int[] array = new int[5];
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < array.Length; i++) {
            array[i] = Random.Range(minimum, maximum);
        }
    }

    // Update is called once per frame
    void Update()
    {
        array[Random.Range(0, array.Length)] = Random.Range(minimum, maximum);

        for (int i = 0; i < array.Length; i++) {
            if (array[i] > 15) Debug.Log(array[i]);
        }
    }
}
