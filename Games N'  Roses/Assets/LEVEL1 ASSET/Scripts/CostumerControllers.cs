 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostumerControllers : MonoBehaviour
{
    [SerializeField] private PlayerJoytick _player;
    public bool LEVEL1;
    public bool LEVEL2;
    public float counterC;
    public bool startcounterC;
    public bool stop;
    public bool walking;    
    public bool ýdle;
    public static bool firsttable1costumer;
    public static bool firsttable2costumer;
    public static bool firsttable3costumer;
    public int i=0;
    public int h = 0;
    public GameObject[] Costumers;
    public GameObject[] Table1;
    public GameObject[] lvl1table1;
    public GameObject[] Table2;
    public GameObject[] lvl1table2;
    public GameObject[] Table3;
    public GameObject[] lvl1table3;
    public GameObject costumerSpawnPoint;
    public Vector3[] CostumerSpawnPoints;


    // Start is called before the first frame update
    void Start()
    {
        LEVEL1 = true;
        LEVEL2 = false;
        //////////
        float x = costumerSpawnPoint.transform.position.x;
        float y = costumerSpawnPoint.transform.position.y;
        float z = costumerSpawnPoint.transform.position.z;

        CostumerSpawnPoints[0] = new Vector3(x, y, z);
        CostumerSpawnPoints[1] = new Vector3(x + 25, y, z-35);
        CostumerSpawnPoints[2] = new Vector3(x-25, y, z + 25);
        CostumerSpawnPoints[3] = new Vector3(x+25, y, z + 25);
        CostumerSpawnPoints[4] = new Vector3(x+35, y, z + 25);
        CostumerSpawnPoints[5] = new Vector3(x-50, y, z + 25);
      

        if (LEVEL1 == true)
        {
            Table1[0] = Instantiate(Costumers[5], CostumerSpawnPoints[4], Quaternion.identity);
            Table2[0] = Instantiate(Costumers[0], CostumerSpawnPoints[1], Quaternion.identity);
            Table3[0] = Instantiate(Costumers[10], CostumerSpawnPoints[2], Quaternion.identity);
        }
     

    }

  
    // Update is called once per frame
    void Update()
    {
        ////////////////
        if (LEVEL1 == true && firsttable1costumer == true)
        {
            if (PlayerJoytick.table1 == true)
            {
                if (Table1[0]==null)
                {
                    int randomCostumerIndex = Random.Range(0, lvl1table1.Length);
                    int randomLocationIndex = Random.Range(0, CostumerSpawnPoints.Length);

                    Table1[0] = Instantiate(lvl1table1[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                    firsttable1costumer = false;
                }
                

            }     
        }


        if (LEVEL1 == true && firsttable2costumer == true)
        {

            if (PlayerJoytick.table2 == true)
            {
                if (Table2[0]==null)
                {
                    int randomCostumerIndex = Random.Range(0, lvl1table2.Length);
                    int randomLocationIndex = Random.Range(0, CostumerSpawnPoints.Length);

                    Table2[0] = Instantiate(lvl1table2[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                    firsttable2costumer = false;
                }
             
            }
        }


        if (LEVEL1 == true && firsttable3costumer == true)
        {

            if (PlayerJoytick.table3 == true)
            {
                if (Table3[0] == null)
                {
                    int randomCostumerIndex = Random.Range(0, lvl1table3.Length);
                    int randomLocationIndex = Random.Range(0, CostumerSpawnPoints.Length);

                    Table3[0] = Instantiate(lvl1table3[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                    firsttable3costumer = false;
                }
                

            }
        }





       /* if (LEVEL2 ==true)
        {

           if (PlayerJoytick.table1 == true)
           {
              for(int i = 0; i < 2; i++)
              {
                  if (Table1[i] == null && h<1)
                  {
                      int randomCostumerIndex = Random.Range(0, Costumers.Length);
                      int randomLocationIndex = Random.Range(0, CostumerSpawnPoints.Length);
                      if (randomCostumerIndex < 7)
                      {
                          if (randomLocationIndex < 5)
                          {
                              Table1[1] = Instantiate(Costumers[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                              Table2[1] = Instantiate(Costumers[randomCostumerIndex + 1], CostumerSpawnPoints[randomLocationIndex + 1], Quaternion.identity);
                              Table3[1] = Instantiate(Costumers[randomCostumerIndex + 2], CostumerSpawnPoints[randomLocationIndex + 2], Quaternion.identity);

                          }

                          if (randomLocationIndex >= 5)
                          {
                              Table1[1] = Instantiate(Costumers[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                              Table2[1] = Instantiate(Costumers[randomCostumerIndex + 1], CostumerSpawnPoints[randomLocationIndex - 1], Quaternion.identity);
                              Table3[1] = Instantiate(Costumers[randomCostumerIndex + 2], CostumerSpawnPoints[randomLocationIndex - 2], Quaternion.identity);

                          }

                      }
                      if (randomCostumerIndex >= 7)
                      {
                          if (randomLocationIndex < 5)
                          {
                              Table1[1] = Instantiate(Costumers[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                              Table2[1] = Instantiate(Costumers[randomCostumerIndex - 1], CostumerSpawnPoints[randomLocationIndex + 1], Quaternion.identity);
                              Table3[1] = Instantiate(Costumers[randomCostumerIndex - 2], CostumerSpawnPoints[randomLocationIndex + 2], Quaternion.identity);

                          }

                          if (randomLocationIndex >= 5)
                          {
                              Table1[1] = Instantiate(Costumers[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                              Table2[1] = Instantiate(Costumers[randomCostumerIndex - 1], CostumerSpawnPoints[randomLocationIndex - 1], Quaternion.identity);
                              Table3[1] = Instantiate(Costumers[randomCostumerIndex - 2], CostumerSpawnPoints[randomLocationIndex - 2], Quaternion.identity);

                          }
                      }

                      h++;

                  }       
              }


           }
        } */

        ////////////////////




       /*if (LEVEL1 == true)
         {
            if (CostumersMovement.startdestroy == true)
            {
               
                int randomCostumerIndex = Random.Range(0, Costumers.Length);
                int randomLocationIndex = Random.Range(0, CostumerSpawnPoints.Length);

                if (Table1[0] == null && Table1[1]==null)
                { 

                    if (i == 0)
                    {
                        if (randomCostumerIndex < 7)
                        {
                            if (randomLocationIndex < 5)
                            {
                                Table1[1] = Instantiate(Costumers[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                                Table2[1] = Instantiate(Costumers[randomCostumerIndex + 1], CostumerSpawnPoints[randomLocationIndex + 1], Quaternion.identity);
                                Table3[1] = Instantiate(Costumers[randomCostumerIndex + 2], CostumerSpawnPoints[randomLocationIndex + 2], Quaternion.identity);
                            }

                            if (randomLocationIndex >= 5)
                            {
                                Table1[1] = Instantiate(Costumers[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                                Table2[1] = Instantiate(Costumers[randomCostumerIndex + 1], CostumerSpawnPoints[randomLocationIndex - 1], Quaternion.identity);
                                Table3[1] = Instantiate(Costumers[randomCostumerIndex + 2], CostumerSpawnPoints[randomLocationIndex - 2], Quaternion.identity);
                            }

                        }
                        if (randomCostumerIndex >= 7)
                        {
                            if (randomLocationIndex < 5)
                            {
                                Table1[1] = Instantiate(Costumers[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                                Table2[1] = Instantiate(Costumers[randomCostumerIndex - 1], CostumerSpawnPoints[randomLocationIndex + 1], Quaternion.identity);
                                Table3[1] = Instantiate(Costumers[randomCostumerIndex - 2], CostumerSpawnPoints[randomLocationIndex + 2], Quaternion.identity);

                            }

                            if (randomLocationIndex >= 5)
                            {
                                Table1[1] = Instantiate(Costumers[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                                Table2[1] = Instantiate(Costumers[randomCostumerIndex - 1], CostumerSpawnPoints[randomLocationIndex - 1], Quaternion.identity);
                                Table3[1] = Instantiate(Costumers[randomCostumerIndex - 2], CostumerSpawnPoints[randomLocationIndex - 2], Quaternion.identity);

                            }
                        }

                    }
                    if (i == 1)
                    {
                        if (randomCostumerIndex < 7)
                        {
                            if (randomLocationIndex < 5)
                            {
                                Table1[0] = Instantiate(Costumers[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                                Table2[0] = Instantiate(Costumers[randomCostumerIndex + 1], CostumerSpawnPoints[randomLocationIndex + 1], Quaternion.identity);
                                Table3[0] = Instantiate(Costumers[randomCostumerIndex + 2], CostumerSpawnPoints[randomLocationIndex + 2], Quaternion.identity);

                            }

                            if (randomLocationIndex >= 5)
                            {
                                Table1[0] = Instantiate(Costumers[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                                Table2[0] = Instantiate(Costumers[randomCostumerIndex + 1], CostumerSpawnPoints[randomLocationIndex - 1], Quaternion.identity);
                                Table3[0] = Instantiate(Costumers[randomCostumerIndex + 2], CostumerSpawnPoints[randomLocationIndex - 2], Quaternion.identity);

                            }

                        }
                        if (randomCostumerIndex >= 7)
                        {
                            if (randomLocationIndex < 5)
                            {
                                Table1[0] = Instantiate(Costumers[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                                Table2[0] = Instantiate(Costumers[randomCostumerIndex - 1], CostumerSpawnPoints[randomLocationIndex + 1], Quaternion.identity);
                                Table3[0] = Instantiate(Costumers[randomCostumerIndex - 2], CostumerSpawnPoints[randomLocationIndex + 2], Quaternion.identity);

                            }

                            if (randomLocationIndex >= 5)
                            {
                                Table1[0] = Instantiate(Costumers[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                                Table2[0] = Instantiate(Costumers[randomCostumerIndex - 1], CostumerSpawnPoints[randomLocationIndex - 1], Quaternion.identity);
                                Table3[0] = Instantiate(Costumers[randomCostumerIndex - 2], CostumerSpawnPoints[randomLocationIndex - 2], Quaternion.identity);

                            }
                        }
                    }
                    i++;
                    if (i == 2)
                    {
                        i = 0;
                    }
                    CostumersMovement.startdestroy = false;
                }

            }
        }*/

        ////////LVL2 /////////
      /*  if (LEVEL2 == true)
        {
            if (CostumersMovement.startdestroy == true)
            {
                
                int randomCostumerIndex = Random.Range(0, Costumers.Length);
                int randomLocationIndex = Random.Range(0, CostumerSpawnPoints.Length);

                if (Table1[i] == null)
                {

                    if (i == 0)
                    {
                        if (randomCostumerIndex < 7)
                        {
                            if (randomLocationIndex < 5)
                            {
                                Table1[1] = Instantiate(Costumers[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                                Table2[1] = Instantiate(Costumers[randomCostumerIndex + 1], CostumerSpawnPoints[randomLocationIndex + 1], Quaternion.identity);
                                Table3[1] = Instantiate(Costumers[randomCostumerIndex + 2], CostumerSpawnPoints[randomLocationIndex + 2], Quaternion.identity);
                            }

                            if (randomLocationIndex >= 5)
                            {
                                Table1[1] = Instantiate(Costumers[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                                Table2[1] = Instantiate(Costumers[randomCostumerIndex + 1], CostumerSpawnPoints[randomLocationIndex - 1], Quaternion.identity);
                                Table3[1] = Instantiate(Costumers[randomCostumerIndex + 2], CostumerSpawnPoints[randomLocationIndex - 2], Quaternion.identity);
                            }

                        }
                        if (randomCostumerIndex >= 7)
                        {
                            if (randomLocationIndex < 5)
                            {
                                Table1[1] = Instantiate(Costumers[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                                Table2[1] = Instantiate(Costumers[randomCostumerIndex - 1], CostumerSpawnPoints[randomLocationIndex + 1], Quaternion.identity);
                                Table3[1] = Instantiate(Costumers[randomCostumerIndex - 2], CostumerSpawnPoints[randomLocationIndex + 2], Quaternion.identity);

                            }

                            if (randomLocationIndex >= 5)
                            {
                                Table1[1] = Instantiate(Costumers[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                                Table2[1] = Instantiate(Costumers[randomCostumerIndex - 1], CostumerSpawnPoints[randomLocationIndex - 1], Quaternion.identity);
                                Table3[1] = Instantiate(Costumers[randomCostumerIndex - 2], CostumerSpawnPoints[randomLocationIndex - 2], Quaternion.identity);

                            }
                        }

                    }
                    if (i == 1)
                    {
                        if (randomCostumerIndex < 7)
                        {
                            if (randomLocationIndex < 5)
                            {
                                Table1[0] = Instantiate(Costumers[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                                Table2[0] = Instantiate(Costumers[randomCostumerIndex + 1], CostumerSpawnPoints[randomLocationIndex + 1], Quaternion.identity);
                                Table3[0] = Instantiate(Costumers[randomCostumerIndex + 2], CostumerSpawnPoints[randomLocationIndex + 2], Quaternion.identity);

                            }

                            if (randomLocationIndex >= 5)
                            {
                                Table1[0] = Instantiate(Costumers[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                                Table2[0] = Instantiate(Costumers[randomCostumerIndex + 1], CostumerSpawnPoints[randomLocationIndex - 1], Quaternion.identity);
                                Table3[0] = Instantiate(Costumers[randomCostumerIndex + 2], CostumerSpawnPoints[randomLocationIndex - 2], Quaternion.identity);

                            }

                        }
                        if (randomCostumerIndex >= 7)
                        {
                            if (randomLocationIndex < 5)
                            {
                                Table1[0] = Instantiate(Costumers[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                                Table2[0] = Instantiate(Costumers[randomCostumerIndex - 1], CostumerSpawnPoints[randomLocationIndex + 1], Quaternion.identity);
                                Table3[0] = Instantiate(Costumers[randomCostumerIndex - 2], CostumerSpawnPoints[randomLocationIndex + 2], Quaternion.identity);

                            }

                            if (randomLocationIndex >= 5)
                            {
                                Table1[0] = Instantiate(Costumers[randomCostumerIndex], CostumerSpawnPoints[randomLocationIndex], Quaternion.identity);
                                Table2[0] = Instantiate(Costumers[randomCostumerIndex - 1], CostumerSpawnPoints[randomLocationIndex - 1], Quaternion.identity);
                                Table3[0] = Instantiate(Costumers[randomCostumerIndex - 2], CostumerSpawnPoints[randomLocationIndex - 2], Quaternion.identity);

                            }
                        }
                    }
                    i++;
                    if (i == 2)
                    {
                        i = 0;
                    }
                    CostumersMovement.startdestroy = false;
                }

            }
        }*/

    }
    private void OnTriggerEnter(Collider other)
    {


     




    }

  




}
