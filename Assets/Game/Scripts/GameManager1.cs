using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game.Systems
{
public class GameManager1 : MonoBehaviour
{
    public static GameManager1 instance;
    public int numbercar = 0;
    public bool iscamera = true;
    public bool iscontroller = true;
    // Start is called before the first frame update
      void Awake()
    {
       if (instance == null)
            instance = this;

            return;
        
    }
   
       
       
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}