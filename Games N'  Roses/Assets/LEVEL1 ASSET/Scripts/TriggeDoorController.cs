using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeDoorController : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;
    [SerializeField] private bool openbackTrigger = false;
    [SerializeField] private bool closebackTrigger = false;

    [SerializeField] private string dorrOpen = "DorrOpen";
    [SerializeField] private string doorClose = "DoorClose";
    [SerializeField] private string doorbackOpen = "DoorbackOpen";
    [SerializeField] private string doorbackClose = "DoorbackClose";
    public bool _log=false;
    public bool _out=false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                myDoor.Play(dorrOpen, 0, 0.0f);
                gameObject.SetActive(false);
                _log = true;  
                _out = true;

            }
          
             if (closeTrigger)
            {  
                myDoor.Play(doorClose, 0, 0f);
                gameObject.SetActive(false);

                _log = true;
                _out = true;
            }
              if (openbackTrigger && _out)
            {
        
                myDoor.Play(doorbackOpen, 0, 0.0f);
                gameObject.SetActive(false);
               
            }
                if (closebackTrigger && _log)
            {
             
                myDoor.Play(doorbackClose, 0, 0f);
                gameObject.SetActive(false);
               
            }
        }
    } 
}
