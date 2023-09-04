using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineController : MonoBehaviour
{
    
    public float sayac;
    public bool startsayac;
    public bool startmachine;
    private int t = 0;
    private int i=0;
    public GameObject convertFoodPoint;
    public GameObject food;
    public static bool startfoodanimation;
    public Vector3[] arrayfood;
    public GameObject[] foods;
    //public Vector3[] carryPoints;
    public GameObject carryPoints;
    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {


        if (startsayac == true)
        {

            sayac += 0.5f*Time.deltaTime;
            Debug.Log("machinesayac:" + sayac);
        }


        if (startmachine == true)
        {
    
            for (int k = 0; k < 9; k++)

            {
                if (foods[k] == null)
                {
                    if (GetComponent<PlayerJoytick>().MachineCarryBoxPoints[i] != null && i < 8)
                    {
                        if (sayac > 0.3F)
                        {
                         
                                Destroy(GetComponent<PlayerJoytick>().MachineCarryBoxPoints[i]);
                                GetComponent<PlayerJoytick>().MachineCarryBoxPoints[i] = null;
                                SpawnFood();
                                startfoodanimation = true;
                                i++;
                                sayac = 0;
                            if (i== 8)
                            {
                                i = 0;
                            }
                            
                        }
                    }
                }

            }
        }
        /*      kutular[t].transform.position = Vector3.Lerp(array[k], startTrasform.position, 0.01f);
              kutular[t].transform.SetParent(TpBoxpointtt);
              boxes[k] = kutular[t];
              kutular[t] = null;
              t++;
              sayac = 0;*/


    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Box")
        {
            startsayac = true;
            startmachine = true;
        }
        
        if (other.gameObject.tag == "a ")
        {
            for (int i = 5; i >= 0; i--)
            {
                if (foods[i] != null)
                {
                    foods[i].transform.position = carryPoints.transform.position;
                    
                }

            }
        }
    }
            

    void SpawnFood()
    {

      
        float x = convertFoodPoint.transform.position.x;
        float y = convertFoodPoint.transform.position.y;
        float z = convertFoodPoint.transform.position.z;

        arrayfood[0] = new Vector3(x ,y, z);
       

        if (i < 18)
        {
           foods[t] = Instantiate(food, arrayfood[0], Quaternion.identity);

        }

        t++;

    }
    void TpFood()
    {


        float x = convertFoodPoint.transform.position.x;
        float y = convertFoodPoint.transform.position.y;
        float z = convertFoodPoint.transform.position.z;

        arrayfood[0] = new Vector3(x, y, z);
        arrayfood[1] = new Vector3(x + 3.5f, y, z);
        arrayfood[2] = new Vector3(x, y, z + 3.5f);
        arrayfood[3] = new Vector3(x + 3.5f, y, z + 3.5f);
        arrayfood[4] = new Vector3(x, y, z + 7.5f);
        arrayfood[5] = new Vector3(x + 3.5f, y, z + 7.5f);

        

    }

}
