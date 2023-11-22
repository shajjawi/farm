using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class buttton : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.transform.position = GameObject.Find("Camera").GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.5f,0.5f,10f));

       
       gameObject.GetComponent<Button>().onClick.AddListener(() => OnClick(gameObject));
       
       
       
     GameObject.Find("button_1").GetComponent<Button>().GetComponentInChildren<TextMeshProUGUI>().text= "Action 1";
     GameObject.Find("button_2").GetComponent<Button>().GetComponentInChildren<TextMeshProUGUI>().text= "Action 2";
     GameObject.Find("button_3").GetComponent<Button>().GetComponentInChildren<TextMeshProUGUI>().text= "Action 3";
     GameObject.Find("button_4").GetComponent<Button>().GetComponentInChildren<TextMeshProUGUI>().text= "Action 4";
     
       
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButton(2)) print("HELLO");
      if (Input.GetMouseButton(0)) print("HELLO");
      if (Input.GetMouseButton(1)) print("HELLO");
       
    } //end of Update
    
    void OnClick(GameObject go) { 
    
    
     LeanTween.moveY(go,new Vector3(-100f,-100f, 0f).y,1f).setDelay(0.5f);
    
    
    }
    
}
