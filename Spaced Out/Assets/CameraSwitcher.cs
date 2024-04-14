using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraSwitcher : MonoBehaviour
{
    public Camera mainCamera;

//Make in order of the planets - neputune,,,,,, ...
    bool[] cameraIsInView = new bool[] { true };

    void Start()
    {
        mainCamera.gameObject.SetActive(true); 
        showObjects(0);
    }

    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space)) {
            setNeptuneScene();
         } else if (Input.GetKeyDown(KeyCode.R)) {
            setDefault();
         } else if (Input.GetKeyDown(KeyCode.P)) {
            setSaturn();
         }
    }

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


    void setNeptuneScene() {
        //float[] values = new float[] { 17.29f, 30f, 8.99f };
        //float[] rotationValues = new float[] { 90f, 45f, 0f };

        //mainCamera.transform.position = new Vector3(values[0], values[1], values[2]);
        //mainCamera.transform.rotation = Quaternion.Euler(rotationValues[0], rotationValues[1], rotationValues[2]);

        showObjects(1);
        SceneManager.LoadScene(1);
    }

    void setDefault() {
        showObjects(0);
        SceneManager.LoadScene(0);
        //float[] values = new float[] { 4.566703f, 9.765378f, -4.990725f };
        //float[] rotationValues = new float[] { 0f, 0f, 0f };

        //mainCamera.transform.position = new Vector3(values[0], values[1], values[2]);
        //mainCamera.transform.rotation = Quaternion.Euler(rotationValues[0], rotationValues[1], rotationValues[2]);
    }

    void setSaturn() {
        showObjects(2);
        SceneManager.LoadScene(2);
    }
}
