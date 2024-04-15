using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SharedData : MonoBehaviour
{
    public static SharedData Instance;
    
    private Vector3 landingCoordinates;

    public void setLandingCoordinates(Vector3 coords)
    {
        Instance.landingCoordinates = coords;
    }
    public Vector3 getLandingCoordinates()
    {
        return Instance.landingCoordinates;
    }
    // Start is called before the first frame update
    void Awake()
    {
        

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

}