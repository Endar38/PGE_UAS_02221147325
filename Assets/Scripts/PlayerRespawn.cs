using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{

    Vector2 posAwal;

    public int maxpoint;
    public int point;

    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        posAwal = transform.position;

       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            Die();
            HealthManager.nyawa--;
         //   starController.point--;
        }
    }

    void Die()
    {
        StartCoroutine(Respawn(0.5f));
    }
    IEnumerator Respawn(float duration)
    {
        transform.localScale = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(duration);
        transform.position = posAwal;
        transform.localScale = new Vector3(1, 1, 1);
    }


}
