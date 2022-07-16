using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currect_Score : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text = "Score : " + ((int)(Score.score)).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
