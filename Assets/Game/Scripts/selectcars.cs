using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game.Systems
{
public class selectcars : MonoBehaviour
{
    private Vector3 startpoz = new Vector3(24.81f,1.07f,8.7f);
    public GameObject startcar;

	public List<GameObject> cars = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        startcar = Instantiate(cars[GameManager1.instance.numbercar],  startpoz, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}