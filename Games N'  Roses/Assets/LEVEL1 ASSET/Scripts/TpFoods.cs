using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpFoods : MonoBehaviour
{
    public static bool  startTP;

    public  static bool a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EndSlide")
        {
            Destroy(this.gameObject);
             a = true;
        }
    
}
}
