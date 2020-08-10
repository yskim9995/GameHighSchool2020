using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour
{
    public  Text M_Score;
    public float gameSocre;
    public Enemy enemy;
    public GameObject M_bullet;
    public GameObject M_bullet2;
    public GameObject M_bullet3;


    public float Speed = 10f;
    public float CreateTime = 2f;
    public GameManager manager;
      
    void Start()
    {
        manager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        float yMove = Input.GetAxis("Vertical") * Speed * Time.deltaTime;

        this.transform.Translate(new Vector3(xMove, yMove, 0));

        CreateTime += Time.deltaTime;
         if (CreateTime > 0.2f && Input.GetKey(KeyCode.Space))
          {
          var gobj = GameObject.Instantiate(M_bullet);
            gobj.transform.position = transform.position + new Vector3(0, 1, 0);

          var gobj2 = GameObject.Instantiate(M_bullet2);
            gobj2.transform.position = transform.position + new Vector3(1, 1, 0);
            gobj2.transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0, -45);

          var  gobj3 = GameObject.Instantiate(M_bullet3);
            gobj3.transform.position = transform.position + new Vector3(-1, 1, 0);
            gobj3.transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0,45);

            gobj.gameObject.tag = "Player_M";
            gobj2.gameObject.tag = "Player_M";
            gobj3.gameObject.tag = "Player_M";
            CreateTime = 0;
        }
       


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy_M")
        {
            //  Debug.Log("적 미사일에 맞음");
            Destroy(gameObject);
            manager.Isplay = false;
        }
    }

}
