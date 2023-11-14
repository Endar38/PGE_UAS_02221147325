using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class starController : MonoBehaviour
{
    public int maxpoint;
    public int point;

    public Image[] points;

    public Sprite star;
    public Sprite starKosong;
    // Start is called before the first frame update
    void Start()
    {
        point = HealthManager.nyawa;
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Image img in points)
        {
            img.sprite = starKosong;
        }
        for (int i = 0; i < point; i++)
        {
            points[i].sprite = star;
        }
    }
}
