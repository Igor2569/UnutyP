using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Game.Systems
{
public class changecar : MonoBehaviour
{
    public Button btn;
   // public int numbercar = 0;
    public int maxcar = 2;
    public GameObject startcar;
    private Vector3 startpoz;

     public List<GameObject> cars = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        maxcar  = maxcar - 1;
        startpoz = startcar.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    public void ButtonClick(){
     
                GameManager1.instance.numbercar +=1;
                if(GameManager1.instance.numbercar > maxcar){
                  GameManager1.instance.numbercar = 0;
                }
                Destroy(startcar);
                startcar = Instantiate(cars[GameManager1.instance.numbercar],  startpoz, Quaternion.identity);


          //  }
           // else
          //  {
                //numbercar = 0;
             //   Destroy(startcar);
                 //startcar = Instantiate(cars[numbercar],  startpoz, Quaternion.identity);
              

           // }

    }
}
}