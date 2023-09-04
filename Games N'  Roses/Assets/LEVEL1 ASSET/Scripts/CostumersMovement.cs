using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CostumersMovement : MonoBehaviour
{
    public bool LEVEL1;
    public bool LEVEL2;
    public bool ordernumbercanvas;
    [SerializeField] private CostumerControllers _creator;
    [SerializeField] private PlayerJoytick _player;
    public List<Transform> waypoints = new List<Transform>();
    private Transform targetwaypoint;
    private int targetWaypointIndex = 0;
    private float minDistance = 0.01f;
    private int lastWaypointIndex;
    public float counterC;
    private float rotationSpeed = 3.0f;
    public float movementSpeed = 10.0f;
    public static bool starttable1;
    public static bool starttable2;
    public static bool starttable3;
    public static bool startdonut;
    public static bool startdestroy;
    public  bool walking;
    public bool startcounterC;
    public GameObject player;
    public  Transform orderPoints;
    public static Transform orderPoint;
    public  bool isTabletrigger;
    public  int Order1Number;
    public  string Order1Name;
    private   int Order1Nameindex;
    private  int Order2Nameindex;
    public  int Order2Number;
    public  string Order2Name;   
    public string[] OrderNames= {"Donut","Cola","Pizza","IceCream"};
    public GameObject COÝNS;
    public Vector3[] tabl1coinpoints;
    public GameObject tabl1coinpoint;
    public int coinNum;
    private int a=0;
    public int j = 0;
    public GameObject[] coinstable1;
    public GameObject ConfettiTabel1;
    // Start is called before the first frame update
    void Start()
    {

        LEVEL1 = true;
        orderPoint = orderPoints;
        lastWaypointIndex = waypoints.Count - 1;
        targetwaypoint = waypoints[targetWaypointIndex];
        walking = true;
        

        if (LEVEL1 == true)
        {
            Order1Number = Random.Range(3, 7);
            Order1Name = "Donut";
            coinNum = Order1Number*2;
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


        if (PlayerJoytick.table1 == true)
        {
            if (walking == true)
            {

                if (waypoints[2].tag =="Table1")
                {
                    player.GetComponent<Animator>().SetBool("walking", true);
                    transform.position = Vector3.MoveTowards(transform.position, targetwaypoint.position, movementStep);
                }

            }


               

        }
      
        

        if (PlayerJoytick.walkingbool == true)
        {

            walking = true;
        }



        if (startcounterC == true)
        {
            counterC += 0.1f * Time.deltaTime;
          

        }


        if (counterC > 0.5f)
        {
            player.GetComponent<Animator>().SetBool("eating", false);        
            counterC = 0;
            startcounterC = false;
            
        }

        if (Order1Number == 0)
        {
            spawnCoin();
            
        }
        

    }
    public void spawnCoin()
    {

     
        float x = tabl1coinpoint.transform.position.x;
        float y = tabl1coinpoint.transform.position.y;
        float z = tabl1coinpoint.transform.position.z;


        tabl1coinpoints[0] = new Vector3(x, y, z);
        tabl1coinpoints[1] = new Vector3(x, y + 2, z);
        tabl1coinpoints[2] = new Vector3(x, y + 4, z);
        tabl1coinpoints[3] = new Vector3(x, y + 6, z);
        tabl1coinpoints[4] = new Vector3(x, y + 8, z);
        tabl1coinpoints[5] = new Vector3(x, y +10, z);
        tabl1coinpoints[6] = new Vector3(x, y+12, z);
        tabl1coinpoints[7] = new Vector3(x, y+14, z);
        tabl1coinpoints[8] = new Vector3(x, y+16, z);
        tabl1coinpoints[9] = new Vector3(x, y+18, z);
        tabl1coinpoints[10] = new Vector3(x, y+20, z);
        tabl1coinpoints[11] = new Vector3(x, y+22, z);
        tabl1coinpoints[12] = new Vector3(x, y+24, z);
        tabl1coinpoints[13] = new Vector3(x, y+26, z);

        if (a < 1)
        {
            for (int i = 0; i < coinNum; i++)
            {
                coinstable1[i]=Instantiate(COÝNS, tabl1coinpoints[i], Quaternion.identity);
            }
            a++;
        }
        
        
       


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Table1")
        {
            isTabletrigger = true;
            ordernumbercanvas = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Table1")
        {
            ordernumbercanvas = true;
            isTabletrigger = true;
            if (PlayerJoytick.eatingbool == true)
            {
                startcounterC = true;
                if (Order1Number > 0)
                {
                 player.GetComponent<Animator>().SetBool("eating", true);

                }

            }

        }

    }

    private void OnTriggerEnter(Collider other)
    {      
        if (other.gameObject.tag == "Table1")
        {
            isTabletrigger = true;
            walking = false;
           
            player.GetComponent<Animator>().SetBool("walking", false);
            player.transform.rotation = orderPoints.transform.rotation;
            
        }


        if (other.gameObject.tag == "DestroyCostumer")
        {
            Destroy(this.gameObject);
            startdestroy = true;
            isTabletrigger = false;
            PlayerJoytick.walkingbool = false;
            CostumerControllers.firsttable1costumer = true;
          
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
