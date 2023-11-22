using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class prueba : MonoBehaviour
{  

    Button elmnt_1,elmnt_2,elmnt_3,elmnt_4;
    float t_1,t_2,t_3,t_4;
    bool status_1, status_2, status_3, status_4;
    public StyleSheet uss;
    int count;
    float intl_left, intl_height, intl_width,  intl_pddng_lft, intl_pddng_rght, intl_font_size, intl_top;
    float intl_top_1, intl_width_2, intl_padding_left_2, intl_padding_right_2;
    
    float intl_style_width_4, intl_style_height_4, intl_style_fontSize_4;
    float intl_style_borderRightWidth_4, intl_style_borderTopWidth_4, intl_style_borderBottomWidth_4, intl_style_borderLeftWidth_4;
    float intl_style_paddingRight_4, intl_style_paddingTop_4, intl_style_paddingBottom_4, intl_style_paddingLeft_4;  
  
    
       
    StyleRotate intl_rotate_3;
    bool ctrl;

    // Start is called before the first frame update
   
   
   void Awake() {
   
    UIDocument uid = gameObject.GetComponent<UIDocument>();
    VisualElement root = uid.rootVisualElement;
    
    elmnt_1= root.Query<Button>("prueba_1");
    elmnt_2= root.Query<Button>("prueba_2");
    elmnt_3= root.Query<Button>("prueba_3");
    elmnt_4= root.Query<Button>("prueba_4");
    
    //uss = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/Scenes/prueba.uss");
   // bttn.styleSheets.Add(uss);
   }
   
   void Start()
    {
                     
         /* Initial settings */
         
         t_1=0; t_2=0; t_3=0; t_4=0;
         count = 0;
         
         intl_height = 0;
         intl_left = 0;
         intl_width_2 = 0;
         intl_pddng_lft = 0;
         intl_pddng_rght = 0;
         intl_font_size = 0;
         intl_top = 0;
         
         intl_padding_left_2 = 0;
         intl_padding_right_2 = 0;
         intl_rotate_3 = new StyleRotate(new Rotate(new Angle(0f, AngleUnit.Degree)));
         
          
         ctrl = true;
         
         status_1 = false; 
         status_2 = false;
         status_3 = false;
         status_4 = false;
        
        
        /* Assign trigger functions for each button */
        
        elmnt_1.clicked += () => click_function_1(); 
        elmnt_2.clicked += () => click_function_2(); 
        elmnt_3.clicked += () => click_function_3(); 
        elmnt_4.clicked += () => click_function_4(); 
        
           } 
     
   
        // Update is called once per frame
    void Update()
    {
    
     
     count += 1;
     
         
     if (count > 1 && ctrl) { // wait for the first frame to be rendered in order to save initial style properties of interest for each button */
     
     /* Initial style for elmnt_1 */
     
     intl_top_1 = elmnt_1.resolvedStyle.top;
     
      /* Initial style for elmnt_2 */
     
     intl_width_2 = elmnt_2.resolvedStyle.width;
     intl_padding_left_2 = elmnt_2.resolvedStyle.paddingLeft;
     intl_padding_right_2 = elmnt_2.resolvedStyle.paddingRight;
    
    
     /* Initial style for elmnt_4 */
    
    intl_rotate_3 = elmnt_3.resolvedStyle.rotate;
          
     /* Initial style for elmnt_4 */
    
    intl_style_width_4 = elmnt_4.resolvedStyle.width;
    intl_style_height_4 = elmnt_4.resolvedStyle.height;
    intl_style_fontSize_4 = elmnt_4.resolvedStyle.fontSize;
    
    intl_style_borderLeftWidth_4 = elmnt_4.resolvedStyle.borderLeftWidth;
    intl_style_borderRightWidth_4 = elmnt_4.resolvedStyle.borderRightWidth;
    intl_style_borderTopWidth_4 = elmnt_4.resolvedStyle.borderTopWidth;
    intl_style_borderBottomWidth_4 = elmnt_4.resolvedStyle.borderBottomWidth;
    
    intl_style_paddingLeft_4 = elmnt_4.resolvedStyle.paddingLeft;
    intl_style_paddingRight_4= elmnt_4.resolvedStyle.paddingRight;
    intl_style_paddingTop_4 = elmnt_4.resolvedStyle.paddingTop;
    intl_style_paddingBottom_4 = elmnt_4.resolvedStyle.paddingBottom; 
    
                    }
     
            
    if (count > 1) {ctrl = false; print(intl_padding_left_2); }// keep initial style property saved values constant over time
    
      
   
     if (status_1) {
    
     elmnt_1.style.top = new Length(intl_top_1 + intl_top_1*4f*(1f - Mathf.Exp(-t_1))); 
     t_1 += Time.deltaTime;
                   }
 
    if (status_2) {
 
 
    elmnt_2.style.paddingLeft = new Length(intl_padding_left_2*(1f + 8f*Mathf.Cos(8f*t_2)));
    elmnt_2.style.paddingRight = new Length(intl_padding_right_2*(1f + 8f*Mathf.Cos(8f*t_2)));
    
    
    t_2 += Time.deltaTime;
                  }
                  
    if (status_3) {
    
    elmnt_3.style.rotate = new StyleRotate(new Rotate(new Angle(60f*Mathf.Cos(6f*t_3),AngleUnit.Degree)));  
    t_3 += Time.deltaTime;
                  }
                 
 
     if (status_4) {
       
    float alpha = 1f;
    float beta = 2f;
    
      
    elmnt_4.style.borderLeftWidth = intl_style_borderLeftWidth_4*Mathf.Exp(-alpha*t_4);
    elmnt_4.style.borderRightWidth = intl_style_borderRightWidth_4*Mathf.Exp(-alpha*t_4);
    elmnt_4.style.borderTopWidth =  intl_style_borderTopWidth_4*Mathf.Exp(-alpha*t_4);
    elmnt_4.style.borderBottomWidth = intl_style_borderBottomWidth_4*Mathf.Exp(-alpha*t_4);
                                                                  
       
     elmnt_4.style.fontSize = new Length(intl_style_fontSize_4*Mathf.Exp(-alpha*t_4)); 
     
  
     elmnt_4.style.width = new Length(intl_style_width_4*Mathf.Exp(-alpha*t_4));
     elmnt_4.style.height = new Length(intl_style_height_4*Mathf.Exp(-alpha*t_4));
                
    elmnt_4.style.paddingLeft= new Length(intl_style_paddingLeft_4*Mathf.Exp(-alpha*t_4));
    elmnt_4.style.paddingRight= new Length(intl_style_paddingRight_4*Mathf.Exp(-alpha*t_4));
    elmnt_4.style.paddingTop= new Length(intl_style_paddingTop_4*Mathf.Exp(-alpha*t_4));
    elmnt_4.style.paddingBottom = new Length(intl_style_paddingBottom_4*Mathf.Exp(-alpha*t_4));                                     
     
                                                     
    
    t_4 += Time.deltaTime;
                
                }
              
     } //end of Update()
     
    void click_function_1() {status_1 = !status_1; t_1 = 0; } // sets the conditions for the animation to begin once click event has taken place
    
    void click_function_2() {status_2 = !status_2; t_2 = 0; } // sets the conditions for the animation to begin once click event has taken place
    
    void click_function_3() {status_3 = !status_3; t_3 = 0; } // sets the conditions for the animation to begin once click event has taken place
    
    void click_function_4() {status_4 = !status_4; t_4 = 0; } // sets the conditions for the animation to begin once click event has taken place
    
    } 
   
    
    
   
    
       
    










