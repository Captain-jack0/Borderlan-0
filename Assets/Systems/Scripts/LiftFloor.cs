using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class LiftFloor : MonoBehaviour
{
    Animator LinkedAnimator;

    [SerializeField] string _DisplayName;
    [SerializeField] string SupportedTags="Player";
    [SerializeField] LiftController LinkedController;
    [SerializeField] Transform LiftTarget;
    

    List<GameObject> Openers = new List<GameObject>();

    public string DisplayName => _DisplayName;  
    public float TargetY => LiftTarget.position.y;
    public bool LiftPresent => LinkedController.ActiveLift.CurrentFloor == this;
    
    private void Awake(){
        LinkedAnimator = GetComponent<Animator>();
            }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { //open idle ve close idle durumlar eklenebilir hala trigger geliyorsa box colliderdan
       
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.CompareTag(SupportedTags)){
        Openers.Add(other.gameObject);
        if(LiftPresent){
        LinkedAnimator.ResetTrigger("Close");
        LinkedAnimator.SetTrigger("Open");
        LinkedController.ActiveLift.OpenDoors();
        }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag(SupportedTags)){
        Openers.Remove(other.gameObject);
        LinkedAnimator.ResetTrigger("Open");
        LinkedAnimator.SetTrigger("Close");
        LinkedController.ActiveLift.CloseDoors();
        }
        
    }  
    public void OnLiftDeparted(Lift activeLift ){
        LinkedAnimator.ResetTrigger("Open");
        LinkedAnimator.SetTrigger("Close");
        LinkedController.ActiveLift.CloseDoors();
    }
 public void OnLiftArrived(Lift activeLift){
    if(Openers.Count > 0 ){
        LinkedAnimator.ResetTrigger("Close");
        LinkedAnimator.SetTrigger("Open");
        LinkedController.ActiveLift.OpenDoors(); 
    }
            

 }
} 
