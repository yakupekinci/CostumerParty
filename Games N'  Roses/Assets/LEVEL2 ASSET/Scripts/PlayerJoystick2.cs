using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody), typeof(CapsuleCollider))]

public class PlayerJoystick2 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] private TruckController _dur;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private VariableJoystick _joystick;
    [SerializeField] private float _moveSpeed = 60;
    public GameObject Chef;


    //creator 
    public bool Machinecreatoranimation;
    public bool Machinecreatoranimation2;
    public bool MachineUpgraderanimation;
    public bool Table1creatoranimation;
    public bool Table2creatoranimation;
    public bool Table3creatoranimation;
    public bool Table4creatoranimation;
    public bool TruckUpgraderanimation;
    public bool Level2Teleporteranimation;
    public static bool table1;
    public static bool table2;
    public static bool table3;
    public static bool table4;
    public bool startefectcounter;
    public bool machineishere;
    [SerializeField] private Animator table1Spawner = null;
    [SerializeField] private Animator table2Spawner = null;
    [SerializeField] private Animator table3Spawner = null;
    [SerializeField] private Animator table4Spawner = null;
    [SerializeField] private Animator machineSpawner = null;
    [SerializeField] private Animator machineSpawner2 = null;
    [SerializeField] private Animator TruckUpgrader = null;
    [SerializeField] private Animator MachineUpgrader = null;
    //confetti
    public GameObject ConfettiTabel1;
    public GameObject ConfettiTabel2;
    public GameObject ConfettiTabel3;
    public GameObject ConfettiTabel4;
    public GameObject ConfettiTruck;
    public GameObject ConfettiCookerPizza;
    public GameObject ConfettiCookerPizzaUp;
    public GameObject ConfettiCookerDonut;
    public GameObject ConfettiCookerDonutUp;
    public GameObject ConfettiLvl2;
    public GameObject Level3Telporter;
    //counters
    public bool startordercounter;
    public float ordercounter;

    //coins
    public static int coin = 0;
    public static int Machinecoin = 15;
    public static int Machinecoin2 = 15;
    public static int Machinelvl1coin = 25;
    public static int Machinelvl1coin2 = 25;
    public static int Trucklvl1coin = 25;
    public static int Level2Teleportercoin = 150;
    public static int table1coin = 10;
    public static int table2coin = 10;
    public static int table3coin = 20;
    public static int table4coin = 30;
    //objects
    public GameObject Level2Telporter;
    public GameObject MachineCreatorPizza;
    public GameObject MachineCreatorDonut;
    public GameObject MachineUpgraderPizza;
    public GameObject MachineUpgraderPizzaMax;
    public GameObject MachineUpgraderDonut;
    public GameObject MachineUpgraderDonutMax;
    public GameObject TruckUpgraderp;
    public GameObject TruckUpgraderMax;
    public GameObject Table1Creator;
    public GameObject Table2Creator;
    public GameObject Table3Creator;
    public GameObject Table4Creator;
    public GameObject CookerInfoDonut;
    public GameObject CookerInfoPizza;
    public GameObject TableInfo;
    public GameObject TruckInfo;
    public GameObject CookerInfoCPizza;
    public GameObject CookerInfoCDonut;
    public GameObject TableInfoC;
    public GameObject TruckInfoC;
    public GameObject table1ordernumbercanvas;
    public GameObject table2ordernumbercanvas;
    public GameObject table3ordernumbercanvas;
    public GameObject lvl1machinenumber;
    public GameObject lvl2machinenumber;
    public GameObject lvl1machinenumber2;
    public GameObject lvl2machinenumber2;
    public GameObject table1location;
    public GameObject table2location;
    public GameObject table3location;
    public GameObject table4location;
    public GameObject table;
    public GameObject table1p;
    public GameObject table2p;
    public GameObject table3p;
    public GameObject table4p;
    public GameObject machinePizza;
    public GameObject machineDonut;
    public GameObject food;
    public GameObject donut;
    public int lvl1MacBoxNum = 0;
    public int lvl2MacBoxNum = 0;
    public GameObject machinelocationPizza;
    public GameObject machinelocationDonut;
    public float counter;
    public float efectcounter;
    public float animationcounter;
    public float sayac;
    public bool startsayac;
    public bool startcounter;
    public bool startanimationcounter;
    public bool playertpstart;
    public bool foodtpstart;
    public bool machinetpstart;
    public bool table1ordertpstart;
    public bool table2ordertpstart;
    public bool table3ordertpstart;
    public bool machinelvl1;
    public bool machinelvl2;
    public Vector3[] array;
    public void OnDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
    void Start()
    {
        machineSpawner.GetComponent<Animator>().SetBool("scale", false);
        machineSpawner2.GetComponent<Animator>().SetBool("scale", false);
        table1Spawner.GetComponent<Animator>().SetBool("scale", false);
        table2Spawner.GetComponent<Animator>().SetBool("scale", false);
        table3Spawner.GetComponent<Animator>().SetBool("scale", false);
        MachineUpgrader.GetComponent<Animator>().SetBool("scale", false);
        TruckUpgrader.GetComponent<Animator>().SetBool("scale", false);
    }

    // Update is called once per frame
    void Update()
    {
        //counters
        if (startordercounter == true)
        {
            ordercounter += 0.5f * Time.deltaTime;
            // Debug.Log("AAAA"+ordercounter);
        }
        if (startefectcounter == true)
        {
            efectcounter += 0.5f * Time.deltaTime;
            // Debug.Log("AAAA"+efectcounter);
        }
        if (efectcounter > 0.9f)
        {
            ConfettiTabel1.SetActive(false);
            ConfettiTabel2.SetActive(false);
            ConfettiTabel3.SetActive(false);
            ConfettiTabel4.SetActive(false);
            ConfettiTruck.SetActive(false);
            ConfettiCookerPizza.SetActive(false);
            ConfettiCookerPizzaUp.SetActive(false);
            ConfettiCookerDonut.SetActive(false);
            ConfettiCookerDonutUp.SetActive(false);
            ConfettiLvl2.SetActive(false);
            startefectcounter = false;
            efectcounter = 0;

        }





        _rigidbody.velocity = new Vector3(-_joystick.Horizontal * _moveSpeed + Time.deltaTime, _rigidbody.velocity.x, -_joystick.Vertical * _moveSpeed + Time.deltaTime);
        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            Chef.GetComponent<Animator>().SetBool("isWalking", true);
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);

        }

        //LEVEL2 DOOR
        if (Level2Teleporteranimation == true)
        {

            Level2Telporter.GetComponent<Animator>().SetBool("scale", true);
            if (ordercounter > 0.01f)
            {
                if (coin > 0)
                {
                    if (coin > 0)
                    {

                        Level2Teleportercoin--;
                        coin--;
                    }
                    ordercounter = 0;

                }
            }

            if (Level2Teleportercoin == 0)
            {


                ConfettiLvl2.SetActive(true);
                startefectcounter = true;
                Destroy(Level2Telporter);

                /* Level1SkipCamera.SetActive(true);
                 Chef.transform.position = TpPoint.transform.position;
                 Chef.transform.rotation = TpPoint.transform.rotation;
                 LEVEL2 = true;
                 xxxx.GetComponent<Animator>().SetBool("isWalking", true);
                 skiplevel = true;
                 joystick.SetActive(false);
                 Level2Teleporteranimation = false;*/

            }

        }
        //MachineSpawner Donut
        if (Machinecreatoranimation == true)
        {

            machineSpawner.GetComponent<Animator>().SetBool("scale", true);
            if (ordercounter > 0.05f)
            {
                if (coin > 0)
                {
                    if (Machinecoin > 0)
                    {

                        Machinecoin--;
                        coin--;
                    }
                    ordercounter = 0;

                }
            }

            if (Machinecoin == 0)
            {
                ConfettiCookerPizza.SetActive(true);
                startefectcounter = true;
                SpawnMachinePizza();
                lvl1machinenumber.SetActive(true);
                MachineUpgraderPizza.SetActive(true);
                Destroy(MachineCreatorPizza);
                Destroy(CookerInfoPizza);
                Destroy(CookerInfoCPizza);
                Table2Creator.SetActive(true);
                machineishere = true;
                Machinecreatoranimation = false;
            }

        }
        //MachineSpawner Pizza
        if (Machinecreatoranimation2 == true)
        {

            machineSpawner2.GetComponent<Animator>().SetBool("scale", true);
            if (ordercounter > 0.05f)
            {
                if (coin > 0)
                {
                    if (Machinecoin2 > 0)
                    {

                        Machinecoin2--;
                        coin--;
                    }
                    ordercounter = 0;

                }
            }

            if (Machinecoin2 == 0)
            {
                ConfettiCookerDonut.SetActive(true);
                startefectcounter = true;
                SpawnMachineDonut();
                lvl2machinenumber.SetActive(true);
                MachineUpgraderDonut.SetActive(true);
                Destroy(MachineCreatorDonut);
                Destroy(CookerInfoDonut);
                Destroy(CookerInfoCDonut);
                Table2Creator.SetActive(true);
                machineishere = true;
                Machinecreatoranimation2 = false;
            }

        }


        //MachineUpgader
        if (MachineUpgraderanimation == true)
        {

            MachineUpgrader.GetComponent<Animator>().SetBool("scale", true);
            if (ordercounter > 0.05f)
            {
                if (coin > 0)
                {
                    if (Machinelvl1coin > 0)
                    {

                        Machinelvl1coin--;
                        coin--;
                    }
                    ordercounter = 0;

                }
            }

            if (Machinelvl1coin == 0)
            {
                ConfettiCookerPizzaUp.SetActive(true);
                startefectcounter = true;
                machinelvl1 = false;
                machinelvl2 = true;
                Destroy(MachineUpgraderPizza);
                lvl2MacBoxNum = lvl1MacBoxNum;
                Destroy(lvl1machinenumber);
                lvl2machinenumber.SetActive(true);
                MachineUpgraderPizzaMax.SetActive(true);
                MachineUpgraderanimation = false;
            }

        }
        //TruckUpgrader
        if (TruckUpgraderanimation == true)
        {

            TruckUpgrader.GetComponent<Animator>().SetBool("scale", true);
            if (ordercounter > 0.05f)
            {
                if (coin > 0)
                {
                    if (Trucklvl1coin > 0)
                    {

                        Trucklvl1coin--;
                        coin--;
                    }
                    ordercounter = 0;

                }
            }

            if (Trucklvl1coin == 0)
            {
                ConfettiTruck.SetActive(true);

                startefectcounter = true;
                Destroy(TruckUpgraderp);
                Destroy(TruckInfo);
                Destroy(TruckInfoC);
                _dur.lvl1truck = false;
                _dur.lvl2truck = true;
                TruckUpgraderanimation = false;
                TruckUpgraderMax.SetActive(true);
            }

        }
        //Table1Spawner
        if (Table1creatoranimation == true)
        {

            table1Spawner.GetComponent<Animator>().SetBool("scale", true);
            if (ordercounter > 0.05f)
            {
                if (coin > 0)
                {
                    if (table1coin > 0)
                    {

                        table1coin--;
                        coin--;
                    }
                    ordercounter = 0;

                }

            }

            if (table1coin == 0)
            {

                ConfettiTabel1.SetActive(true);
                startefectcounter = true;
                SpawnTable1();
                table1 = true;
                Destroy(TableInfo);
                Destroy(TableInfoC);
                Destroy(Table1Creator);

                Table1creatoranimation = false;
            }

        }
        //Table2Spawner
        if (Table2creatoranimation == true)
        {

            table2Spawner.GetComponent<Animator>().SetBool("scale", true);
            if (ordercounter > 0.05f)
            {
                if (coin > 0)
                {
                    if (table2coin > 0)
                    {

                        table2coin--;
                        coin--;
                    }
                    ordercounter = 0;

                }

            }

            if (table2coin == 0)
            {
                ConfettiTabel2.SetActive(true);
                startefectcounter = true;
                SpawnTable2();
                table2 = true;
                Destroy(Table2Creator);
                Table3Creator.SetActive(true);
                Table2creatoranimation = false;
            }

        }
        //Table3Spawner
        if (Table3creatoranimation == true)
        {

            table3Spawner.GetComponent<Animator>().SetBool("scale", true);
            if (ordercounter > 0.05f)
            {
                if (coin > 0)
                {
                    if (table3coin > 0)
                    {

                        table3coin--;
                        coin--;
                    }
                    ordercounter = 0;

                }

            }

            if (table3coin == 0)
            {
                ConfettiTabel3.SetActive(true);
                startefectcounter = true;
                SpawnTable3();
                table3 = true;
                Destroy(Table3Creator);
                Table3creatoranimation = false;
            }

        }
        //Table4Spawner
        if (Table4creatoranimation == true)
        {

            table4Spawner.GetComponent<Animator>().SetBool("scale", true);
            if (ordercounter > 0.05f)
            {
                if (coin > 0)
                {
                    if (table4coin > 0)
                    {

                        table4coin--;
                        coin--;
                    }
                    ordercounter = 0;

                }

            }

            if (table4coin == 0)
            {
                ConfettiTabel4.SetActive(true);
                startefectcounter = true;
                SpawnTable4();
                table4 = true;
                Destroy(Table4Creator);
                Table4creatoranimation = false;
            }

        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "MachineCreator")
        {
            Machinecreatoranimation = false;
            startordercounter = false;
            machineSpawner.GetComponent<Animator>().SetBool("scale", false);

        }
        if (other.gameObject.tag == "MachineCreator2")
        {
            Machinecreatoranimation2 = false;
            startordercounter = false;
            machineSpawner2.GetComponent<Animator>().SetBool("scale", false);

        }
        if (other.gameObject.tag == "MachineUpgrader")
        {
            MachineUpgraderanimation = false;
            startordercounter = false;
            MachineUpgrader.GetComponent<Animator>().SetBool("scale", false);

        }
        if (other.gameObject.tag == "TruckUpgrader")
        {
            TruckUpgraderanimation = false;
            startordercounter = false;
            TruckUpgrader.GetComponent<Animator>().SetBool("scale", false);

        }
        if (other.gameObject.tag == "Table1Creator")
        {
            Table1creatoranimation = false;
            startordercounter = false;
            table1Spawner.GetComponent<Animator>().SetBool("scale", false);

        }
        if (other.gameObject.tag == "Table2Creator")
        {
            Table2creatoranimation = false;
            startordercounter = false;
            table2Spawner.GetComponent<Animator>().SetBool("scale", false);

        }
        if (other.gameObject.tag == "Table3Creator")
        {
            Table3creatoranimation = false;
            startordercounter = false;
            table3Spawner.GetComponent<Animator>().SetBool("scale", false);

        }
        if (other.gameObject.tag == "Table4Creator")
        {
            Table4creatoranimation = false;
            startordercounter = false;
            table4Spawner.GetComponent<Animator>().SetBool("scale", false);

        }
        if (other.gameObject.tag == "Level2Teleporter")
        {
            Level2Teleporteranimation = false;
            startordercounter = false;
            Level3Telporter.GetComponent<Animator>().SetBool("scale", false);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "TrashBox")
        {
            for (int t = 0; t < 3; t++)
            {
            }

        }
        if (other.gameObject.tag == "Table1Creator")
        {
            Table1creatoranimation = true;
            startordercounter = true;

        }
        if (other.gameObject.tag == "Table2Creator")
        {
            Table2creatoranimation = true;
            startordercounter = true;
        }
        if (other.gameObject.tag == "Table3Creator")
        {
            Table3creatoranimation = true;
            startordercounter = true;
        }
        if (other.gameObject.tag == "Table4Creator")
        {
            Table4creatoranimation = true;
            startordercounter = true;
        }
        if (other.gameObject.tag == "MachineCreator")
        {
            Machinecreatoranimation = true;
            startordercounter = true;
        }
        if (other.gameObject.tag == "MachineCreator2")
        {
            Machinecreatoranimation2 = true;
            startordercounter = true;
        }
        if (other.gameObject.tag == "MachineUpgrader")
        {
            MachineUpgraderanimation = true;
            startordercounter = true;
        }
        if (other.gameObject.tag == "TruckUpgrader")
        {
            TruckUpgraderanimation = true;
            startordercounter = true;
        }
        if (other.gameObject.tag == "Level2Teleporter")
        {
            Level2Teleporteranimation = true;
            startordercounter = true;
        }
    }

    void SpawnTable1()
    {

        float x = table1location.transform.position.x;
        float y = table1location.transform.position.y;
        float z = table1location.transform.position.z;

        array[0] = new Vector3(x, y, z);

        Instantiate(table, array[0], Quaternion.identity);

    }
    void SpawnTable2()
    {

        float x = table2location.transform.position.x;
        float y = table2location.transform.position.y;
        float z = table2location.transform.position.z;

        array[0] = new Vector3(x, y, z);

        Instantiate(table1p, array[0], Quaternion.identity);

    }
    void SpawnTable3()
    {

        float x = table3location.transform.position.x;
        float y = table3location.transform.position.y;
        float z = table3location.transform.position.z;

        array[0] = new Vector3(x, y, z);

        Instantiate(table2p, array[0], Quaternion.identity);

    }
    void SpawnTable4()
    {

        float x = table4location.transform.position.x;
        float y = table4location.transform.position.y;
        float z = table4location.transform.position.z;

        array[0] = new Vector3(x, y, z);

        Instantiate(table2p, array[0], Quaternion.identity);

    }
    void SpawnMachinePizza()
    {


        float x = machinelocationPizza.transform.position.x;
        float y = machinelocationPizza.transform.position.y;
        float z = machinelocationPizza.transform.position.z;






        Instantiate(machinePizza, new Vector3(x, y, z), Quaternion.identity);

    }
    void SpawnMachineDonut()
    {


        float x = machinelocationDonut.transform.position.x;
        float y = machinelocationDonut.transform.position.y;
        float z = machinelocationDonut.transform.position.z;






        Instantiate(machineDonut, new Vector3(x, y, z), Quaternion.identity);

    }

}
