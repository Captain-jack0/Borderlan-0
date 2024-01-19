using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up_button : MonoBehaviour
{
    [SerializeField] LiftController LinkedController;
    [SerializeField] LiftFloor Floor;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        LinkedController.CallLift(Floor,true);
                
    }
    
     private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        Floor.OnLiftArrived(LinkedController.ActiveLift);
        
    }  
}
