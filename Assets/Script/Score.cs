using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
   float Time1 = 1.0f;
   float Time2 = 1.0f; 
    public static float score = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
         

        GetComponent<Text>().text = ((int)(score)).ToString() ;   

         
        
          score += (Time.deltaTime * 10); //반복시간// Time2 = Time1 + Time.time; }
            

      
        
    }
   
}
