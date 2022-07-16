using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTrap : MonoBehaviour
{
    public GameObject GTrap;

    public float timer = 0;
    public float TimeDiff; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > TimeDiff)
        {
            GameObject newGTrap = Instantiate(GTrap);
            newGTrap.transform.position = new Vector3(Random.Range(-8.83f, 8.69f), 5 , 0);
            timer = 0;
            Destroy(newGTrap, 5.0f);
        }
        

        
            
        
    }
}
