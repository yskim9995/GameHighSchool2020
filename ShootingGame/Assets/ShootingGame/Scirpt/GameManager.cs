using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public float GameScore;
    public bool Isplay;
    public Text asd;
    public GameObject player;
    public Text Restart;
    // Start is called before the first frame update
    void Start()
    {
        Isplay = true;
        Restart.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!Isplay)
        {
          //  Time.timeScale = 0;
            Restart.text = "죽었어요. 다시 시작할려면 R";
            Restart.gameObject.SetActive(true);
            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene(0);
            }
        }
    }
    public void Gameplus()
    {
        GameScore++;
        asd.text = "Score :" + GameScore;
    }
}
