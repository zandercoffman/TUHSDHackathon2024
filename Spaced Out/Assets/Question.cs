using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Question : MonoBehaviour
{
    // Start is called before the first frame update
    public RawImage questionImage;
    public TMP_Dropdown dropdown1;
    public TMP_Dropdown dropdown2;
    void Start()
    {
        questionImage.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Leave thie function as public - Unity can't see
    //the function without it
    public void toggleImage() {
        Debug.Log("hello");
        if (questionImage.gameObject.activeSelf == true) {
            questionImage.gameObject.SetActive(false);
        } else {
            questionImage.gameObject.SetActive(true);
        }
    }

    //Again, this function needs to be public to function 
    public void checkQuestions() {
        Scene currentScene = SceneManager.GetActiveScene();
        //Goes through all the selections in the dropdown
        //and finds the text that the value is located in the array
        string drop1 = dropdown1.options[dropdown1.value].text; 
        string drop2 = dropdown2.options[dropdown2.value].text;
        switch (currentScene.name) {
            //For each person: add your cases here
            case "Neptune":
                if (drop1 == "7" && drop2 == "True") {
                    VariableData.planetsCompleted[0] = true;
                    VariableData.curIndex++;
                    SceneManager.LoadScene("Big");
                }
                break;
        } 
    }
}
