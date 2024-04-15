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
    public RawImage learnMoreImage;
    public TMP_Dropdown dropdown1;
    public TMP_Dropdown dropdown2;
    void Start()
    {
        questionImage.gameObject.SetActive(false);
        learnMoreImage.gameObject.SetActive(false);
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
            if (learnMoreImage.gameObject.activeSelf == true) {
                learnMoreImage.gameObject.SetActive(false);
            }
            questionImage.gameObject.SetActive(false);
        } else {
            questionImage.gameObject.SetActive(true);
        }
    }

    public void toggleInformation() {
        if (learnMoreImage.gameObject.activeSelf == true) {
            learnMoreImage.gameObject.SetActive(false);
        } else {
            if (questionImage.gameObject.activeSelf == true) {
                questionImage.gameObject.SetActive(false);
            }
             learnMoreImage.gameObject.SetActive(true);
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
                if (drop1 == "5,431.04 m/s" && drop2 == "165.08 years") {
                    VariableData.planetsCompleted[VariableData.curIndex] = true;
                    VariableData.curIndex++;
                    SceneManager.LoadScene("Big");
                }
                break;
            case "Saturn":
                if (drop1 == "9,668.19 m/s" && drop2 == "29.26 years") {
                    VariableData.planetsCompleted[VariableData.curIndex] = true;
                    VariableData.curIndex++;
                    SceneManager.LoadScene("Big");
                }
                break;
            case "Uranus":
                if (drop1 == "6,800.62 m/s" && drop2 == "84.08 years") {
                   VariableData.planetsCompleted[VariableData.curIndex] = true;
                    VariableData.curIndex++;
                    SceneManager.LoadScene("Big"); 
                }
                break;
            case "Jupiter":
                if (drop1 == "13,061.70 m/s" && drop2 == "11.87 years") {
                    VariableData.planetsCompleted[VariableData.curIndex] = true;
                    VariableData.curIndex++;
                    SceneManager.LoadScene("Big");
                }
                break;
            case "Mars":
                if (drop1 == "24,128.04 m/s" && drop2 == "1.88 years") {
                    VariableData.planetsCompleted[VariableData.curIndex] = true;
                    VariableData.curIndex++;
                    SceneManager.LoadScene("Big");
                }
                break;
            case "Earth":
                if (drop1 == "29.747.04 m/s" && drop2 == "1 year") {
                    VariableData.planetsCompleted[VariableData.curIndex] = true;
                    VariableData.curIndex++;
                    SceneManager.LoadScene("Big");
                }
                break;
            case "Venus":
                if (drop1 == "35,057.23 m/s" && drop2 == "0.61 years") {
                    VariableData.planetsCompleted[VariableData.curIndex] = true;
                    VariableData.curIndex++;
                    SceneManager.LoadScene("Big");
                }
                break;
            case "Mercury":
                if (drop1 == "47,875.43 m/s" && drop2 == "0.24 years") {
                    VariableData.planetsCompleted[VariableData.curIndex] = true;
                    VariableData.curIndex++;
                    SceneManager.LoadScene("Big");
                }
                break;
        } 
    }
}
