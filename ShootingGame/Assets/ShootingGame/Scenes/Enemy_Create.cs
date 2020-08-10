using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy_Create : MonoBehaviour
{
    public GameObject Enemy;
    public GameManager manager;
    public float Createtime;
    public float rand;
    public float Enemyrand;
    void Start()
    {
        manager = FindObjectOfType<GameManager>();
    }
    void Update()
    {
        if (!manager.Isplay)
            return;
        rand = Random.Range(0, Enemyrand);
        Createtime += Time.deltaTime;
        if(Createtime > 0.5)
        {
          var asd =   GameObject.Instantiate(Enemy);
            asd.transform.position = new Vector3(rand * 3, 10,0);
            asd.transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0, 360);
            Createtime = 0;
        }
    }
}
