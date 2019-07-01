using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChangeName : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI myText = GetComponent<TextMeshProUGUI>();
       if (Input.GetKeyDown("space"))
       {
           myText.SetText("Hello World! My name is Kaitlyn Monroe!");
           print ("Space key was pressed");
       } 
       if (Input.GetKeyDown(KeyCode.Escape)){
           Application.Quit();
       }
       
    
    }
}
