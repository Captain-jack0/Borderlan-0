using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;



public class MainMenu : MonoBehaviour
{
    UIDocument document;
    Button button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable(){
        document = GetComponent<UIDocument>();

        if (document== null)
        {
            Debug.LogError("No button document found");

        }
        

        if(button != null){
            Debug.LogError("Button found ");
        }

       
    }
    void StartGame(ClickEvent evt){
        Debug.LogError("Game started");
        SceneManager.LoadScene("Scene_01");

    }
}
