using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorGawang : MonoBehaviour
{
    private Vector2 originalPosition;
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gawang"))
        {
            transform.position = originalPosition;
        }
    }
}
