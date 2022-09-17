using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatecar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0.25f,0f);
    }
}
