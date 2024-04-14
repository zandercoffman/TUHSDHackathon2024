using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectionPlanet : MonoBehaviour
{
    // Start is called before the first frame update
    public string name;
    public int index;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) {
        Debug.Log(collision + " RAN!");
        if (collision.gameObject.CompareTag("Player") && index <= VariableData.curIndex) {
            //Insert logic here
            SceneManager.LoadScene(index);
        }
    }
}
