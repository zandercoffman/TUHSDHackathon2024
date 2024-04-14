using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Function to switch to a new scene by name
    public void SwitchToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the 'S' key is pressed
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Call the switch function with the desired scene name
            SwitchToScene("SampleScene");
        }
    }
}
