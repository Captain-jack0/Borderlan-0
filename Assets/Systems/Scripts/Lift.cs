using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    
    [SerializeField] LiftFloor StartingFloor;
    [SerializeField] float LiftSpeed=10f;
     
    
    public LiftFloor CurrentFloor{ get; private set; } = null;
    public bool IsMoving { get; private set; } = false;
    public LiftFloor TargetFloor {get; private set; } = null;
    Animator LinkedAnimator;

    private void Awake(){
        LinkedAnimator = GetComponent<Animator>();
    } 

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, StartingFloor.TargetY,transform.position.z);
        CurrentFloor = StartingFloor;
    }

    // Update is called once per frame
    void Update()
    {
        // Lift Moning ?
        if(IsMoving){
            Vector3 targetLocation = transform.position;
            targetLocation.y = TargetFloor.TargetY;
            transform.position = Vector3.MoveTowards(transform.position, targetLocation,LiftSpeed*Time.deltaTime);
            CurrentFloor.OnLiftDeparted(this);
        if(Vector3.Distance(transform.position, targetLocation)< float.Epsilon){
            IsMoving = false;
            CurrentFloor = TargetFloor;
            TargetFloor = CurrentFloor;   

            CurrentFloor.OnLiftArrived(this); 
        }
        
        }
    }
    public void MoveTo(LiftFloor targetFloor){
       IsMoving =true; 
       TargetFloor = targetFloor;
       CurrentFloor.OnLiftDeparted(this);
    }


    public void OpenDoors(){
        LinkedAnimator.ResetTrigger("Close");
        LinkedAnimator.SetTrigger("Open");
    }

    public void CloseDoors(){
        LinkedAnimator.ResetTrigger("Open");
        LinkedAnimator.SetTrigger("Close");
    }
}
