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
    }

    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space)) {
            setNeptuneScene();
         } else if (Input.GetKeyDown(KeyCode.W)) {
            setDefault();
         }
    }

    void setNeptuneScene() {
        //float[] values = new float[] { 17.29f, 30f, 8.99f };
        //float[] rotationValues = new float[] { 90f, 45f, 0f };

        //mainCamera.transform.position = new Vector3(values[0], values[1], values[2]);
        //mainCamera.transform.rotation = Quaternion.Euler(rotationValues[0], rotationValues[1], rotationValues[2]);

        SceneManager.LoadScene(1);
    }

    void setDefault() {
        SceneManager.LoadScene(0);
        //float[] values = new float[] { 4.566703f, 9.765378f, -4.990725f };
        //float[] rotationValues = new float[] { 0f, 0f, 0f };

        //mainCamera.transform.position = new Vector3(values[0], values[1], values[2]);
        //mainCamera.transform.rotation = Quaternion.Euler(rotationValues[0], rotationValues[1], rotationValues[2]);
    }
}
