using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float player_score;
    public float Speed;
    public float M_Createtime;
    public GameObject M_bullet;
    public Player_Controller pplayer;
    public Animator m_Animator;
    public GameManager manager;
    float Turntime;

    public bool isdead = true;
    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<GameManager>();

        transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0, -180);
    }
    void Update()
    {
        if (!manager.Isplay)
            return;
        Turntime += Time.deltaTime;
        //if(Turntime >0.5)
    //          {
         //   transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0, -90);
         //   Turntime = 0;
      //  }
        transform.position += transform.up * Speed* Time.deltaTime;
        M_Createtime += Time.deltaTime;
        if (M_Createtime > 2)
        {
            var bullet = GameObject.Instantiate(M_bullet);
            bullet.transform.position = transform.position;
            bullet.transform.eulerAngles = transform.eulerAngles;

            bullet.gameObject.tag = "Enemy_M";
            M_Createtime = 0;
        }
        if(transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player_M")
        {
          //  Debug.Log("주인공 미사일에 맞음");
            m_Animator.SetBool("Die", true);
        }
    }
    public void Die()
    {
        manager.Gameplus();
        Destroy(gameObject);
    }
}
