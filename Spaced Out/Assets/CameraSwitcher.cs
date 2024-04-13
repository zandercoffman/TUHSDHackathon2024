using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera mainCamera;
    public Camera neptuneCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera.gameObject.SetActive(true);
        neptuneCamera.gameObject.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space)) {
            mainCamera.gameObject.SetActive(!mainCamera.gameObject.activeSelf);
            neptuneCamera.gameObject.SetActive(!neptuneCamera.gameObject.activeSelf);
         }
    }
}
