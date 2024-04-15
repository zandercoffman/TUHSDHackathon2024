using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    Rigidbody PlayerRB;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(0);
            gameObject.transform.position = new Vector3(0, 0, 2400);
            gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
            PlayerRB.velocity = Vector3.zero;
        }
    }
}
