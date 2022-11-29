using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Game.Systems
{
public class rotatecar : MonoBehaviour
{ 
    public Rigidbody rigidbody;
    public GameObject camera;
    public string scene1 = "SampleScene";
    public string scene2 = "Shop";
    // Start is called before the first frame update
    void Start()
    {
         RotateShop car1 = GetComponent<RotateShop>();
         CarController car = GetComponent<CarController>();
        if(SceneManager.GetActiveScene().name==scene1){
            GameManager1.instance.iscamera = true;
            GameManager1.instance.iscontroller  = true;
            car.enabled = GameManager1.instance.iscontroller ;
            camera.SetActive(GameManager1.instance.iscamera);
            rigidbody.isKinematic =  false;
            car1.enabled = false;
        } 
        if(SceneManager.GetActiveScene().name==scene2){
            GameManager1.instance.iscamera = false;
            GameManager1.instance.iscontroller  = false;
            car.enabled =GameManager1.instance.iscontroller ;
            camera.SetActive(GameManager1.instance.iscamera);
            rigidbody.isKinematic =  true;
            car1.enabled = true;
           
        } 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}