using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class box_animation : MonoBehaviour
{

    Box hor_box;
    Box vert_box;
    Button menu_1, menu_2, menu_3, menu_4, submenu_1, submenu_2, submenu_3, submenu_4;
    
    int count;
     bool ctrl;
      bool status;
       float t;
    
    float intl_left_vert, intl_top_hor;

    // Start is called before the first frame update
    void Start()
    {
         UIDocument uid = gameObject.GetComponent<UIDocument>();
         VisualElement root = uid.rootVisualElement;
         hor_box = root.Query<Box>("horizontal_box");
         vert_box = root.Query<Box>("vertical_box");
         
         menu_1 = root.Query<Button>("menu_1");
         menu_2 = root.Query<Button>("menu_2");
         menu_3 = root.Query<Button>("menu_3");
         menu_4 = root.Query<Button>("menu_4");
         
         menu_1.clicked += () => clicked_function();
          menu_2.clicked += () => clicked_function();
           menu_3.clicked += () => clicked_function();
            menu_4.clicked += () => clicked_function();
         
         count = 0;
         ctrl = true;
         t = 0;
         status = false;
         
         intl_left_vert = 0;
         intl_top_hor = 0;
         
    }

    // Update is called once per frame
    void Update()
    {
        count += 1;
        
       
        
        if (count > 1 && ctrl) {
        
        intl_left_vert = vert_box.resolvedStyle.left;
        intl_top_hor = hor_box.resolvedStyle.top;
        
       
        }
        
        if (count > 1) ctrl = false;
        
        if (status && hor_box.resolvedStyle.top > -100) {
        
        hor_box.style.top = new Length(intl_top_hor + 200*t);
        if (t > 1 && t < 1.5) vert_box.style.left = new Length(intl_left_vert*(1 - 0.8f*Mathf.Sin(0.2f*t)));
        
                                           }
                                           
                                   
        
        
        t += Time.deltaTime;
        
    } // end of Update()
    
    void clicked_function() { status = !status; t = 0; }
    
      
   // hor_box.style.top = new Length(intl_top_hor - 200*t);
    //hor_box.style.top = new Length(intl_top_hor + intl_top_hor*(1f - Mathf.Exp(-t))); 
    
                           
    
}
