using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLogic : MonoBehaviour
{

    private GameObject mainMenu;
    private GameObject optionsMenu;
    private GameObject loading;

    public AudioSource buttonSound;

    // Start is called before the first frame update
    void Start()
    {
        mainMenu = GameObject.Find("MainMenuCanvas");
        optionsMenu = GameObject.Find("OptionsCanvas");
        loading = GameObject.Find("LoadingCanvas");

        mainMenu.GetComponent<Canvas>().enabled = true;
        optionsMenu.GetComponent<Canvas>().enabled = false;
        loading.GetComponent<Canvas>().enabled = false;
    }

    public void PlayGame()
    {
       Debug.Log("Starting");
        SceneManager.LoadScene("Scene_01");
    }

    public void Options()
    {
        buttonSound.Play();
        mainMenu.GetComponent<Canvas>().enabled = false;
        optionsMenu.GetComponent<Canvas>().enabled = true;
    }

    public void ExtrasButton(){
        buttonSound.Play();
        mainMenu.GetComponent<Canvas>().enabled = false;
        optionsMenu.GetComponent<Canvas>().enabled = false;
        loading.GetComponent<Canvas>().enabled = true;
    }

    public void Quit(){
        buttonSound.Play();
        Application.Quit();
    }

    public void ReturnToMainMenuButton(){
        buttonSound.Play();
        mainMenu.GetComponent<Canvas>().enabled = true;
        optionsMenu.GetComponent<Canvas>().enabled = false;
        loading.GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
