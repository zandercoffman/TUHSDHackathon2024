using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NPCInteract : MonoBehaviour
{
    public TextMeshProUGUI text;
    public string[] textToShow = { "NPC:Don't tell anyone I told you this, but Neptune can provide a lot of powerful winds.", "anyone ", "anyone 2"};
    private List<GameObject> npcs = new List<GameObject>();

    void Start() {
        foreach (GameObject npc in GameObject.FindGameObjectsWithTag("NPC")) {
            npcs.Add(npc);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) {
                if (hit.collider.CompareTag("NPC")){
                    for (int i = 0; i < npcs.Count; i++) {
                        if (npcs[i] == hit.collider.gameObject) {
                            text.text = textToShow[i];
                            return;
                        }
                    }
                    text.text = "An error has occured";
                }
            }
        }
    }
}
