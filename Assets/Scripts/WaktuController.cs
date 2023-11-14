using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaktuController : MonoBehaviour
{

    public Text textTimer;

    public float waktu;
    float sec;

    //public string sceneKalah;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetText();

        sec += Time.deltaTime;

        if (sec >= 1 && waktu > 0)
        {
            waktu--;
            sec = 0;
        }

        if (waktu <= 0)
        {
            HealthManager.nyawa = 0;
        }

    }

    void SetText()
    {
        int menit = Mathf.FloorToInt(waktu / 60);
        int detik = Mathf.FloorToInt(waktu % 60);
        textTimer.text = menit.ToString("00") +":" + detik.ToString("00");
    }
}
