using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator canvascoin = null;
    public GameObject Coin;
    void Start()
    {
        canvascoin = GameObject.FindGameObjectWithTag("CoinAN").GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Player")
       {
            canvascoin.Play("coins", 0, 0.0f);
      
              Destroy(this.gameObject);
              PlayerJoytick.coin += 1;
       }
    }
}
