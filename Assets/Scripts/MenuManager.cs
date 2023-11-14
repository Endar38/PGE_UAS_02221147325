using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update

    public string scene;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void RestartClicked()
    {
        SceneManager.LoadScene(scene);
    }

    public void PlayClicked()
    {
        SceneManager.LoadScene("PilihLevel");
    }

    public void ExitClicked()
    {
        Application.Quit();
    }

    public void Level1Clicked()
    {
        SceneManager.LoadScene("Gameplay_Lv1");
    }

    public void Level2Clicked()
    {
        SceneManager.LoadScene("Gameplay_Lv2");
    }

    public void MenuClicked()
    {
        SceneManager.LoadScene("Menu");
    }
}
