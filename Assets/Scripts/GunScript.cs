using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GunScript : MonoBehaviour
{

    public GameObject bullet;
    public float bulletSpeed;
    public Transform ShootPoint;

    public static Vector2 Direction;

    public LineRenderer line;

    GameObject target;
    public SpringJoint2D spring;

    Animator anim;

    int arah = 1;
    public int makSkor;
    public int skor;

    public static int iDEnemy = 0;

    public Transform[] enemy;

    public static Vector2 arahGun;

    // Start is called before the first frame update
    void Start()
    {
        line.enabled = false;
        spring.enabled = false;
        anim = GetComponent<Animator>();

        spring = GetComponent<SpringJoint2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(iDEnemy);
        arahGun = (Vector2) enemy[iDEnemy].transform.position - (Vector2)transform.position; 
        if (skor == makSkor)
        {
            SceneManager.LoadScene("KondisiMenang");
        }
        spring.connectedAnchor = arahGun * 10;

        Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Direction = MousePos - (Vector2) transform.position;
           //FaceMouse();
   
        if(Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Idle", false);
            anim.SetBool("jump", true);
            //anim.SetTrigger("Lompat");
            arah = 1;
        }else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            //anim.ResetTrigger("Lompat");
            anim.SetBool("Idle", true);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            arah = -1;
            anim.SetBool("jump", true);
            anim.SetBool("Idle", false);
           // anim.SetTrigger("Lompat");
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
           // anim.ResetTrigger("Lompat");
            anim.SetBool("Idle", true);
        }

        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("Makan", false);
            anim.SetBool("Idle", false);
            anim.ResetTrigger("Lompat");
            anim.SetBool("jump", false);
            anim.SetTrigger("jilat");
            Shoot();

        }else if (Input.GetMouseButtonUp(0))
        {
            Released();
            anim.ResetTrigger("jilat");
            anim.SetBool("Idle", true);
        }

        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            Released();
            anim.ResetTrigger("jilat");
            anim.SetBool("Idle", true);

        }*/

        if(target != null)
        {
            line.SetPosition(0, ShootPoint.position);
            line.SetPosition(1, target.transform.position);
        }
    }

    void FaceMouse()
    {
        transform.right = Direction;
    }
    void Shoot()
    {

        
            GameObject bulletIns = Instantiate(bullet, ShootPoint.position, Quaternion.identity);

            bulletIns.GetComponent<Rigidbody2D>().AddForce(transform.right * bulletSpeed * arah);
        
        
    }
    public void TargetHit(GameObject hit)
    {
        target = hit;
        line.enabled=true;
        spring.enabled=true;
        spring.connectedBody = target.GetComponent<Rigidbody2D>();
       // arahGun = (Vector2) target.transform.position;
    }

    public void Released()
    {
        line.enabled=false;
        spring.enabled = false;
        target = null;
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("box"))
        {
            skor++;
            Released();
            other.gameObject.SetActive(false);
            anim.ResetTrigger("Lompat");
            anim.SetBool("jump", false);
            anim.SetBool("Idle", false);
            anim.ResetTrigger("jilat");
            anim.SetBool("Makan", true);
        }
        if (other.gameObject.CompareTag("box1"))
        {
            skor++;
            Released();
            other.gameObject.SetActive(false);
            anim.ResetTrigger("Lompat");
            anim.SetBool("jump", false);
            anim.SetBool("Idle", false);
            anim.ResetTrigger("jilat");
            anim.SetBool("Makan", true);
        }
        if (other.gameObject.CompareTag("box2"))
        {
            skor++;
            Released();
            other.gameObject.SetActive(false);
            anim.ResetTrigger("Lompat");
            anim.SetBool("jump", false);
            anim.SetBool("Idle", false);
            anim.ResetTrigger("jilat");
            anim.SetBool("Makan", true);
        }
    }



}
