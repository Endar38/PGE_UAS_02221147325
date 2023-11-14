using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bulletScript : MonoBehaviour
{

    GunScript gun;
    // Start is called before the first frame update
    void Start()
    {
        gun = GameObject.FindGameObjectWithTag("Gun").GetComponent<GunScript>();
    }

    // Update is called once per frame



    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "box")
        {
            gun.TargetHit(col.gameObject);
            Destroy(gameObject);
            //Debug.Log ((Vector2) col.gameObject.transform.position);
            GunScript.iDEnemy = 0;
        }
        if (col.gameObject.tag == "box1")
        {
            gun.TargetHit(col.gameObject);
            Destroy(gameObject);
            Debug.Log((Vector2)col.gameObject.transform.position);
            GunScript.iDEnemy = 1;
        }
        if (col.gameObject.tag == "box2")
        {
            gun.TargetHit(col.gameObject);
            Destroy(gameObject);
            Debug.Log((Vector2)col.gameObject.transform.position);
            GunScript.iDEnemy = 2;
        }

    }
}
