using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneTrap : MakeTrap
{
   
    
    
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
            newGTrap.transform.position = new Vector3(8.59f, Random.Range(-2.5f, 3.56f), 0);
            timer = 0;
            Destroy(newGTrap, 5.0f);
    }
    }
}
