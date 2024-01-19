using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class CountDownTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText ;
    [SerializeField] float _remainingTime;
     float remainingTime;
     bool start=false;
     int Respawn;
     [SerializeField] TextMeshProUGUI visaDay;
    private  int visa=3;
    bool IsGameWon = true;
    private  int gameLevel;
    
  

void Start(){
     timerText.text ="";
     remainingTime = _remainingTime;
     
}

    void Update(){
    
       if(start){
        remainingTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingTime /60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}",minutes,seconds);
        
        
        if(remainingTime <=0){
        timerText.text ="";
        SceneManager.LoadScene(1);
        IsGameWon = false; 
        start = false;
        remainingTime = _remainingTime;
        }

      
      }
     if (!IsGameWon)
     visaDay.text = "2";
      
    }

  void OnTriggerEnter(Collider other)
    {
        
        if(other){
        start = true;
        remainingTime = _remainingTime;
        }
       
        }
       
    

 void OnTriggerExit(Collider other){

    timerText.text ="";
    start = false;
    
}

}
