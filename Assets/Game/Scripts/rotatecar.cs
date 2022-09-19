using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Systems
{
public class rotatecar : MonoBehaviour
{ 
    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        CarConrtoller car = GetComponent<CarConrtoller>();
      car.enabled = false;
        rigidbody.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0.25f,0f);
    }
}
}