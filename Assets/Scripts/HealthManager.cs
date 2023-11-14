using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{

    public static int nyawa;
    public Image[] hearts;
    float waktu;
    public Sprite nyawaIsi;
    public Sprite nyawaKosong;
    // Start is called before the first frame update
    public string sceneKalah;
    void Awake()
    {
        nyawa = 3;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Image img in hearts)
        {
            img.sprite = nyawaKosong;
        }
        for(int i = 0; i <  nyawa; i++)
        {
            hearts[i].sprite = nyawaIsi;
        }
        if (nyawa <= 0)
        {
            SceneManager.LoadScene(sceneKalah);
        }
    }
}
