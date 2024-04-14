using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class planetSwitcher : MonoBehaviour
{
    public Camera mainCamera;

    public Rigidbody shuttle;
    public Rigidbody mercury;
    public Rigidbody venus;
    public Rigidbody earth;
    public Rigidbody mars;
    public Rigidbody jupiter;
    public Rigidbody saturn;
    public Rigidbody uranus;
    public Rigidbody neptune;

    void showObjects(int index) {
        for (int i = 0; i < SceneManager.sceneCount; i++) {
            if (i == index) {
                GameObject[] objectsInScene = SceneManager.GetSceneAt(i).GetRootGameObjects();
                foreach (GameObject obj in objectsInScene) {
                    obj.SetActive(true);
                }
            } else {
                GameObject[] objectsInScene = SceneManager.GetSceneAt(i).GetRootGameObjects();
                foreach (GameObject obj in objectsInScene) {
                    obj.SetActive(false);
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    { 
        showObjects(0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(mercury.position);
        Debug.Log(Vector3.Distance(mercury.position, shuttle.position));
            
        if (Vector3.Distance(mercury.position, shuttle.position)<.5*48.79) {
            showObjects(1);
            SceneManager.LoadScene(1);
        }
        else if (Vector3.Distance(venus.position, shuttle.position)<.5*121.04) {
            showObjects(2);
            SceneManager.LoadScene(2);
        }
        else if (Vector3.Distance(earth.position, shuttle.position)<.5*127.56) {
            showObjects(3);
            SceneManager.LoadScene(3);
        }
        else if (Vector3.Distance(mars.position, shuttle.position)<.5*67.92) {
            showObjects(4);
            SceneManager.LoadScene(4);
        }
        else if (Vector3.Distance(jupiter.position, shuttle.position)<.5*1429.84) {
            showObjects(5);
            SceneManager.LoadScene(5);
        }
        else if (Vector3.Distance(saturn.position, shuttle.position)<.5*1205.36) {
            showObjects(6);
            SceneManager.LoadScene(6);
        }
        else if (Vector3.Distance(uranus.position, shuttle.position)<.5*511.18) {
            showObjects(7);
            SceneManager.LoadScene(7);
        }
        else if (Vector3.Distance(neptune.position, shuttle.position)<.5*495.28) {
            showObjects(8);
            SceneManager.LoadScene(8);
        }
    }
}
