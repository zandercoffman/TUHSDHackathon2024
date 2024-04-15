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
        Debug.Log("fjlskjdlkfs");
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
        

        //if the user is returning from a planet, restore the previous coordinates
        Vector3 landingCoordinates = SharedData.Instance.getLandingCoordinates();

    }
    void switchToPlanet(int planetNumber)
    {
        showObjects(planetNumber);
        SceneManager.LoadScene(planetNumber);

        //store landing coordinates (store the position a little bit above (relative to the planet) from the true landing position)
        //SharedData.Instance.setLandingCoordinates(shuttle.position);
    }
    // Update is called once per frame
    void Update()
    {   
    
            
        if (Vector3.Distance(mercury.position, shuttle.position)<.5*48.79) {
            switchToPlanet(1);
        }
        else if (Vector3.Distance(venus.position, shuttle.position)<.5*121.04) {
            switchToPlanet(2);
        }
        else if (Vector3.Distance(earth.position, shuttle.position)<.5*127.56) {
            switchToPlanet(3);
        }
        else if (Vector3.Distance(mars.position, shuttle.position)<.5*67.92) {
            switchToPlanet(4);
        }
        else if (Vector3.Distance(jupiter.position, shuttle.position)<.5*1429.84) {
            switchToPlanet(5);
        }
        else if (Vector3.Distance(saturn.position, shuttle.position)<.5*1205.36) {
            switchToPlanet(6);
        }
        else if (Vector3.Distance(uranus.position, shuttle.position)<.5*511.18) {
            switchToPlanet(7);
        }
        else if (Vector3.Distance(neptune.position, shuttle.position)<.5*495.28) {
            Debug.Log(Vector3.Distance(neptune.position, shuttle.position));
            switchToPlanet(8);
        }
    }
}
