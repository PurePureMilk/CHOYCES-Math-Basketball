using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button startButton;
    public Button optionsButton;
    public Button exitButton;
    void Start()
    {
        startButton.onClick.AddListener(StartButton);
        optionsButton.onClick.AddListener(OptionsButton);
        exitButton.onClick.AddListener(ExitButton);


    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void StartButton()
    {
        SceneManager.LoadScene("Levels");
        
    }

    void OptionsButton()
    {

    }

    void ExitButton()
    {
        Application.Quit();
    }
}
