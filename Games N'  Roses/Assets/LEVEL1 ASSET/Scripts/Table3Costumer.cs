using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table3Costumer : MonoBehaviour
{
    public bool LEVEL1;
    public bool LEVEL2;
    public bool tabl3ordernumbercanvas;
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
    public Vector3[] tabl3coinpoints;
    public GameObject tabl3coinpoint;
    public int coinNum;
    private int a = 0;
    public GameObject[] coinstable3;    


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








        if (PlayerJoytick.table3 == true)
        {
            if (walking1 == true)
            {

                if (waypoints[2].tag == "Table3")
                {
                    player.GetComponent<Animator>().SetBool("walking", true);
                    transform.position = Vector3.MoveTowards(transform.position, targetwaypoint.position, movementStep);
                }

            }
        }




        if (PlayerJoytick.walkingbool3 == true)
        {

            walking1 = true;
        }






        if (startcounterC1 == true)
        {
            counterC1 += 0.1f * Time.deltaTime;


        }


        if (counterC1 > 0.5f)
        {
            player.GetComponent<Animator>().SetBool("eating", false);
            counterC1 = 0;
            startcounterC1 = false;

        }

        if (Order1Number == 0)
        {
            spawnCoin3();

        }



    }
     public void spawnCoin3()
     {
       

            float x = tabl3coinpoint.transform.position.x;
            float y = tabl3coinpoint.transform.position.y;
            float z = tabl3coinpoint.transform.position.z;


            tabl3coinpoints[0] = new Vector3(x, y, z);
            tabl3coinpoints[1] = new Vector3(x, y + 2, z);
            tabl3coinpoints[2] = new Vector3(x, y + 4, z);
            tabl3coinpoints[3] = new Vector3(x, y + 6, z);
            tabl3coinpoints[4] = new Vector3(x, y + 8, z);
            tabl3coinpoints[5] = new Vector3(x, y + 10, z);
            tabl3coinpoints[6] = new Vector3(x, y + 12, z);
            tabl3coinpoints[7] = new Vector3(x, y + 14, z);
            tabl3coinpoints[8] = new Vector3(x, y + 16, z);
            tabl3coinpoints[9] = new Vector3(x, y + 18, z);
            tabl3coinpoints[10] = new Vector3(x, y + 20, z);
            tabl3coinpoints[11] = new Vector3(x, y + 22, z);
            tabl3coinpoints[12] = new Vector3(x, y + 24, z);
            tabl3coinpoints[13] = new Vector3(x, y + 26, z);



        if (a < 1)
        {
            for (int i = 0; i < coinNum; i++)
            {
                coinstable3[i] = Instantiate(COÝNS, tabl3coinpoints[i], Quaternion.identity);
            }
            a++;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Table3")
        {
            isTabletrigger1 = false;
            tabl3ordernumbercanvas = false;

        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Table3")
        {
            tabl3ordernumbercanvas = true;
            isTabletrigger1 = true;
            if (PlayerJoytick.eatingbool3 == true)
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
        if (other.gameObject.tag == "Table3")
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
            PlayerJoytick.walkingbool3 = false;
            CostumerControllers.firsttable3costumer = true;

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
