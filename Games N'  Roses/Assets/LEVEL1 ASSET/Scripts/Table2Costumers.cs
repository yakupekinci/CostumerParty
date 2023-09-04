using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table2Costumers: MonoBehaviour
{

    public bool LEVEL1;
    public bool LEVEL2;
    public bool tabl2ordernumbercanvas;
    [SerializeField] private CostumerControllers _creator;
    [SerializeField] private PlayerJoytick _player;
    public List<Transform> waypoints = new List<Transform>();
    private Transform targetwaypoint;
    private int targetWaypointIndex = 0;
    private float minDistance = 0.01f;
    private int lastWaypointIndex;
    public float counterC1;
    private float rotationSpeed = 3.0f;
    public float movementSpeed = 10.0f;
    public static bool starttable1;
    public static bool starttable2;
    public static bool starttable3;
    public static bool startdonut1;
    public static bool startdestroy1;
    public bool walking1;
    public bool startcounterC1;
    public GameObject player;
    public Transform orderPoints;
    public static Transform orderPoint;
    public bool isTabletrigger1;
    public int Order1Number;
    public string Order1Name;
    private int Order1Nameindex;
    private int Order2Nameindex;
    public int Order2Number;
    public string Order2Name;
    public string[] OrderNames = { "Donut", "Cola", "Pizza", "IceCream" };
    public GameObject COÝNS;
    public Vector3[] tabl2coinpoints;
    public GameObject tabl2coinpoint;
    public int coinNum;
    private int a = 0;
    public GameObject[] coinstable2;



    // Start is called before the first frame update
    void Start()
    {

        LEVEL1 = true;
        orderPoint = orderPoints;
        lastWaypointIndex = waypoints.Count - 1;
        targetwaypoint = waypoints[targetWaypointIndex];
        walking1 = true;


        if (LEVEL1 == true)
        {
            Order1Number = Random.Range(3, 7);
            Order1Name = "Donut";
            coinNum = Order1Number * 2;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        /////////////
        float movementStep = movementSpeed * Time.deltaTime;
        float rotationStep = rotationSpeed * Time.deltaTime;
        Vector3 directionToTarget = targetwaypoint.position - transform.position;
        if (directionToTarget != Vector3.zero)
        {
            Quaternion rotatioToTarget = Quaternion.LookRotation(directionToTarget * Time.deltaTime);
            transform.rotation = rotatioToTarget;
        }
        float distance = Vector3.Distance(transform.position, targetwaypoint.position);
        CheckDistanceToWaypoint(distance);
        ////////////////


       




        
        if (PlayerJoytick.table2 == true)
        {
            if (walking1 == true)
            {

                if (waypoints[2].tag == "Table2")
                {
                    player.GetComponent<Animator>().SetBool("walking", true);
                    transform.position = Vector3.MoveTowards(transform.position, targetwaypoint.position, movementStep);
                }

            }
        }

       


        if (PlayerJoytick.walkingbool2 == true)
        {

            walking1 = true;
        }






        if (startcounterC1 == true)
        {
            counterC1 += 0.1f * Time.deltaTime;


        }


        if (counterC1> 0.5f)
        {
            player.GetComponent<Animator>().SetBool("eating", false);
            counterC1 = 0;
            startcounterC1 = false;

        }


        if (Order1Number == 0)
        {
            spawnCoin2();

        }


    }
    public void spawnCoin2()
    {


        float x = tabl2coinpoint.transform.position.x;
        float y = tabl2coinpoint.transform.position.y;
        float z = tabl2coinpoint.transform.position.z;


        tabl2coinpoints[0] = new Vector3(x, y, z);
        tabl2coinpoints[1] = new Vector3(x, y + 2, z);
        tabl2coinpoints[2] = new Vector3(x, y + 4, z);
        tabl2coinpoints[3] = new Vector3(x, y + 6, z);
        tabl2coinpoints[4] = new Vector3(x, y + 8, z);
        tabl2coinpoints[5] = new Vector3(x, y + 10, z);
        tabl2coinpoints[6] = new Vector3(x, y + 12, z);
        tabl2coinpoints[7] = new Vector3(x, y + 14, z);
        tabl2coinpoints[8] = new Vector3(x, y + 16, z);
        tabl2coinpoints[9] = new Vector3(x, y + 18, z);
        tabl2coinpoints[10] = new Vector3(x, y + 20, z);
        tabl2coinpoints[11] = new Vector3(x, y + 22, z);
        tabl2coinpoints[12] = new Vector3(x, y + 24, z);
        tabl2coinpoints[13] = new Vector3(x, y + 26, z);



        if (a < 1)
        {
            for (int i = 0; i < coinNum; i++)
            {
                coinstable2[i] = Instantiate(COÝNS, tabl2coinpoints[i], Quaternion.identity);
            }
            a++;
        }

    }

    private void OnTriggerExit(Collider other)
     {
          if (other.gameObject.tag == "Table2")
          {
              isTabletrigger1 = false;
              tabl2ordernumbercanvas = false;

          }

     }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Table2")
        {
            tabl2ordernumbercanvas = true;
            isTabletrigger1 = true;
            if (PlayerJoytick.eatingbool2 == true)
            {
                startcounterC1 = true;
                if (Order1Number > 0)
                {
                    player.GetComponent<Animator>().SetBool("eating", true);

                }

            }

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Table2")
        {
            isTabletrigger1 = true;
            walking1 = false;

            player.GetComponent<Animator>().SetBool("walking", false);
            player.transform.rotation = orderPoints.transform.rotation;

        }


        if (other.gameObject.tag == "DestroyCostumer")
        {
            Destroy(this.gameObject);
            startdestroy1 = true;
            isTabletrigger1 = false;
            PlayerJoytick.walkingbool2 = false;
            CostumerControllers.firsttable2costumer = true;
           
        }

    }

    void CheckDistanceToWaypoint(float currentDistance)
    {
        if (currentDistance <= minDistance)
        {
            targetWaypointIndex++;
            UpdateTargetWaypoint();
        }
    }
    void UpdateTargetWaypoint()
    {
        if (targetWaypointIndex > lastWaypointIndex)
        {
            targetWaypointIndex = 0;
        }
        targetwaypoint = waypoints[targetWaypointIndex];
    }

}

