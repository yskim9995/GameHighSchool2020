using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float m_speed = 25;
    // Update is called once per frame
    void Update()
    {

        Rigidbody rigidbody = GetComponent<Rigidbody>();

        float xAxia = Input.GetAxis("Horizontal");
        float yAxia = Input.GetAxis("Vertical");

        rigidbody.AddForce(new Vector3(xAxia, 0, yAxia) * m_speed);


        float fireAxis = Input.GetAxis("Fire1");

        if (fireAxis > 0.95f)
            Die();


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(Vector3.left * 10f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(Vector3.right * 10f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce(Vector3.up * 10f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddForce(Vector3.down * 15f);
        }


        if (Input.GetKey(KeyCode.Space))
            Die();



    }

    public void Die()
    {
        Debug.Log("Die");
        gameObject.SetActive(false);
    }




}
