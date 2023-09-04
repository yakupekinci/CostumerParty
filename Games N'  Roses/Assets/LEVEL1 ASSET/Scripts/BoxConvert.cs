using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxConvert : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool controlbox=true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DestroyBox")
        {
           
            Destroy(this.gameObject);
            controlbox = true;

        }



    }


}



