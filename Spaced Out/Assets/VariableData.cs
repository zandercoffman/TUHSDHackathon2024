using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VariableData : MonoBehaviour
{
    public static VariableData data = null;
    public static bool[] planetsCompleted = new bool[8];
    public static int curIndex = 0;
    public static Dictionary<string, string> questionsAndAnswers = new  Dictionary<string, string>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 8; i++) {
            planetsCompleted[i] = false;
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Big") {

        }
    }

    private void Awake() {
        if (data == null) {
            data = this;
        } else if (data != this) {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }
}
