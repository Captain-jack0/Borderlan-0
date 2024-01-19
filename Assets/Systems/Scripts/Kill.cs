using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{[SerializeField] TextMeshProUGUI visaDay;
    private  int visa=3;
    bool IsGameWon = true;
    private  int gameLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!IsGameWon) 
        visaDay.text = "2";
    }
     private void OnTriggerEnter(Collider other)
    { 
        IsGameWon = false; 
        SceneManager.LoadScene(1);
        
    }
}
