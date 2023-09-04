using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(Rigidbody), typeof(CapsuleCollider))]
public class PlayerJoytick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    //
    int f6 = 0;
    int f5;
    int f4;
    int f3;
    int f2;
    int f1;
    int f;
    public GameObject finish6;
    public GameObject finish5;
    public GameObject finish4;
    public GameObject finish3;
    public GameObject finish2;
    public GameObject finish1;
    public GameObject finish;
    public GameObject bir;
    public GameObject iki;
    public GameObject joystick;
    public GameObject xxxx;
    public GameObject Level1Camera;
    public GameObject Level1SkipCamera;
    public static bool startefectcounter;
    public static bool startefectcountercontrol;
    public float efectcounter;
    public GameObject TpPoint;
    public GameObject ConfettiTabel1;
    public GameObject ConfettiTabel2;
    public GameObject ConfettiTabel3;
    public GameObject ConfettiTruck;
    public GameObject ConfettiCooker;
    public GameObject ConfettiCookerUp;
    public GameObject ConfettiLvl2;
    public GameObject CookerInfo;
    public GameObject TableInfo;
    public GameObject TruckInfo;
    public GameObject CookerInfoC;
    public GameObject TableInfoC;
    public GameObject TruckInfoC;
    public bool skiplevel;


    public bool LEVEL1;
    public bool LEVEL2;
    public static bool walkingbool;
    public static bool walkingbool2;
    public static bool walkingbool3;
    public static bool eatingbool;
    public static bool eatingbool2;
    public static bool eatingbool3;

    [SerializeField] private Animator canvascoin = null;
    [SerializeField] private Animator table1Spawner = null;
    [SerializeField] private Animator table2Spawner = null;
    [SerializeField] private Animator table3Spawner = null;
    [SerializeField] private Animator machineSpawner = null;
    [SerializeField] private Animator TruckUpgrader = null;
    [SerializeField] private Animator MachineUpgrader = null;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private CostumerControllers _crator;
    [SerializeField] private VariableJoystick _joystick;
    [SerializeField] private Animator _animator;
    [SerializeField] private TruckController _dur;
    [SerializeField] private float _moveSpeed = 60;
    public Transform tabless1;
    public Transform player;
    public Transform machines;
    public GameObject carryPoint;
    public GameObject Chef;
    public GameObject convertBoxPoint;
    public GameObject convertFoodPoint;
    public GameObject StoreFoodPoint;
    public GameObject MachineCarryPoint;
    public GameObject[] PlayerCarryPoints;
    public GameObject[] MachineCarryBoxPoints;
    public GameObject[] foods;
    public Vector3[] arrayconvertfood;
    public Vector3[] arrayfood;
    public Vector3[] array;
    public Vector3[] carryPoints;
    public Vector3[] orderPoints;

    public GameObject box;
    public GameObject table;
    public GameObject table1p;
    public GameObject table2p;
    public GameObject machine;
    public GameObject food;
    public GameObject donut;

    public GameObject machinelocation;
    public float counter;
    public float ordercounter;
    public float animationcounter;
    public float sayac;
    public bool startordercounter;
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
    public bool deneme;
    public static bool table1;
    public static bool table2;
    public static bool table3;
    public static bool machineishere;
    public static bool walkingcostumer;
    public int j = 0;
    public int c = 0;
    public int n = 0;
    public int q = 0;
    public int i = 0;
    public int R = 3;
    public int o = 0;
    public int e = 2;
    public int w = 0;
    private int p = 0;
    public int lvl1MacBoxNum = 0;
    public int lvl2MacBoxNum = 0;
    private int h = 0;
    private int v = 2;
    public int playercarrylengt;

    //Coins-Spanwer
    public static int coin = 0;
    public static int Machinecoin = 15;
    public static int Machinelvl1coin = 25;
    public static int Trucklvl1coin = 25;
    public static int Level2Teleportercoin = 150;
    public static int table1coin = 5;
    public static int table2coin = 10;
    public static int table3coin = 20;
    //bools-Spawner
    public bool Machinecreatoranimation;
    public bool MachineUpgraderanimation;
    public bool Table1creatoranimation;
    public bool Table2creatoranimation;
    public bool Table3creatoranimation;
    public bool TruckUpgraderanimation;
    public bool Level2Teleporteranimation;
    //Creator
    public GameObject Level2Telporter;
    public GameObject MachineCreator;
    public GameObject MachineUpgraderp;
    public GameObject MachineUpgraderMax;
    public GameObject TruckUpgraderp;
    public GameObject TruckUpgraderMax;
    public GameObject Table1Creator;
    public GameObject Table2Creator;
    public GameObject Table3Creator;
    public GameObject table1ordernumbercanvas;
    public GameObject table2ordernumbercanvas;
    public GameObject table3ordernumbercanvas;
    public GameObject lvl1machinenumber;
    public GameObject lvl2machinenumber;
    //Location
    public GameObject table1location;
    public GameObject table2location;
    public GameObject table3location;
    Animator anim;

    //ORDER
    public GameObject[] table1order;
    public GameObject[] table2order;
    public GameObject[] table3order;
    public int table1ordernumber;
    public int table2ordernumber;
    public int table3ordernumber;

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
        table1Spawner.GetComponent<Animator>().SetBool("scale", false);
        table2Spawner.GetComponent<Animator>().SetBool("scale", false);
        table3Spawner.GetComponent<Animator>().SetBool("scale", false);
        MachineUpgrader.GetComponent<Animator>().SetBool("scale", false);
        TruckUpgrader.GetComponent<Animator>().SetBool("scale", false);
        machinelvl1 = true;



    }


    void Update()
    {


        if (TpFoods.a == true)
        {
            TpFood();
            TpFoods.a = false;

        }

        if (startanimationcounter == true)
        {
            animationcounter += 0.5f * Time.deltaTime;
            // Debug.Log("Animation:" + animationcounter);
        }

        if (startsayac == true)
        {
            sayac += 0.5f * Time.deltaTime;
            // Debug.Log("machinesayac:" + sayac);
        }

        if (startcounter == true)
        {
            counter += 0.5f * Time.deltaTime;
            //  Debug.Log("BBBBBBBB"+counter);
        }

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
            ConfettiTruck.SetActive(false);
            ConfettiCooker.SetActive(false);
            ConfettiCookerUp.SetActive(false);
            ConfettiLvl2.SetActive(false);
            startefectcounter = false;
            efectcounter = 0;

        }

        // Tp Box to  Player From Kitchen Store

        if (playertpstart == true)
        {

            for (int i = 17; i >= 0; i--)
            {

                if (_dur.boxes[i] != null)
                {
                    if (PlayerCarryPoints[o] == null && o < 3)
                    {
                        if (counter >= 0.2f)
                        {
                            TpObjectPlayer();
                            PlayerCarryPoints[o] = _dur.boxes[i];
                            _dur.boxes[i].transform.position = carryPoints[o];
                            _dur.boxes[i].transform.SetParent(player);
                            _dur.boxes[i].transform.rotation = player.transform.rotation;
                            _dur.boxes[i] = null;
                            if (o < 2)
                            {
                                o++;
                            }
                            counter = 0;
                        }
                    }

                }
            }

        }

        /////////-------------Machine---------------//////////


        ////---- LVL1 MACHÝNE----/////

        // Take Box from Chef
        if (machinelvl1 == true)
        {
            if (machinetpstart == true)
            {
                e = 2;
                for (int i = 0; i < 4; i++)
                {
                    if (MachineCarryBoxPoints[i] == null)
                    {
                        if (PlayerCarryPoints[e] != null && e >= 0)
                        {
                            if (PlayerCarryPoints[e].tag == "Box")
                            {
                                if (counter > 0.1f)
                                {

                                    TpBoxMachine();
                                    MachineCarryBoxPoints[i] = PlayerCarryPoints[e];
                                    PlayerCarryPoints[e].transform.position = carryPoints[i];
                                    lvl1MacBoxNum += 1;
                                    MachineCarryBoxPoints[i].transform.SetParent(machines);
                                    MachineCarryBoxPoints[i].transform.rotation = MachineCarryPoint.transform.rotation;
                                    PlayerCarryPoints[e] = null;
                                    counter = 0;
                                    if (o > 0)
                                    {
                                        o--;
                                    }
                                }
                            }
                        }

                        if (e > 0)
                        {
                            e--;
                            i--;
                        }

                    }

                }
            }
        }

        // Convert Box to Food
        if (machinelvl1 == true)
        {

            if (machineishere == true)
            {
                for (int k = 0; k < 8; k++)
                {

                    if (foods[7] == null)
                    {
                        if (MachineCarryBoxPoints[R] != null && R >= 0)
                        {
                            startsayac = true;
                            if (sayac > 0.9f)
                            {

                                Destroy(MachineCarryBoxPoints[R]);
                                lvl1MacBoxNum -= 1;
                                MachineCarryBoxPoints[R] = null;
                                SpawnBoxA();

                                if (BoxConvert.controlbox == true)
                                {
                                    SpawnDonutA();
                                }

                                sayac = 0;
                            }
                        }
                        R--;

                        if (R == -1)
                        {
                            R = 3;
                        }
                    }

                }

            }
        }



        ////---- LVL2 MACHÝNE----/////

        // Take Box from Chef
        if (machinelvl2 == true)
        {
            if (machinetpstart == true)
            {
                e = 2;
                for (int i = 0; i < 8; i++)
                {
                    if (MachineCarryBoxPoints[i] == null)
                    {
                        if (PlayerCarryPoints[e] != null && e >= 0)
                        {
                            if (PlayerCarryPoints[e].tag == "Box")
                            {
                                if (counter > 0.1f)
                                {

                                    TpBoxMachine();
                                    MachineCarryBoxPoints[i] = PlayerCarryPoints[e];
                                    PlayerCarryPoints[e].transform.position = carryPoints[i];
                                    lvl2MacBoxNum += 1;
                                    MachineCarryBoxPoints[i].transform.SetParent(machines);
                                    MachineCarryBoxPoints[i].transform.rotation = MachineCarryPoint.transform.rotation;
                                    PlayerCarryPoints[e] = null;
                                    counter = 0;
                                    if (o > 0)
                                    {
                                        o--;
                                    }
                                }
                            }
                        }

                        if (e > 0)
                        {
                            e--;
                            i--;
                        }

                    }

                }
            }
        }

        // Convert Box to Food
        if (machinelvl2 == true)
        {

            if (machineishere == true)
            {
                for (int k = 0; k < 8; k++)
                {

                    if (foods[15] == null)
                    {
                        if (MachineCarryBoxPoints[R] != null && R >= 0)
                        {
                            startsayac = true;
                            if (sayac > 0.9f)
                            {


                                Destroy(MachineCarryBoxPoints[R]);
                                lvl2MacBoxNum -= 1;
                                MachineCarryBoxPoints[R] = null;
                                SpawnBoxA();

                                if (BoxConvert.controlbox == true)
                                {
                                    SpawnDonutA();
                                }
                                sayac = 0;
                            }
                        }

                        R--;
                        if (R == -1)
                        {
                            R = 7;
                        }
                    }

                }

            }
        }




        /////////-------------Costumer---------------//////////


        // Tp Food to  Player From Machine Store
        if (foodtpstart == true)
        {
            for (int i = 15; i >= 0; i--)
            {

                if (foods[i] != null)
                {
                    if (PlayerCarryPoints[o] == null && o < 3)
                    {
                        if (counter >= 0.2f)
                        {
                            TpObjectPlayer();
                            PlayerCarryPoints[o] = foods[i];
                            foods[i].transform.position = carryPoints[o];
                            w++;
                            foods[i].transform.SetParent(player);
                            foods[i].transform.rotation = player.transform.rotation;
                            foods[i] = null;
                            if (o < 2)
                            {
                                o++;
                            }
                            counter = 0;
                        }
                    }

                }
            }

        }



        // Tp  Order Food on Table
        //check ordernumber canvas

        if (_crator.Table1[0] != null)
        {
            if (_crator.Table1[0].GetComponent<CostumersMovement>().ordernumbercanvas == true)
            {
                table1ordernumbercanvas.SetActive(true);

            }
            if (_crator.Table1[0].GetComponent<CostumersMovement>().ordernumbercanvas == false)
            {
                table1ordernumbercanvas.SetActive(false);
            }


        }


        if (_crator.Table2[0] != null)
        {
            if (_crator.Table2[0].GetComponent<Table2Costumers>().tabl2ordernumbercanvas == true)
            {
                table2ordernumbercanvas.SetActive(true);

            }
            if (_crator.Table2[0].GetComponent<Table2Costumers>().tabl2ordernumbercanvas == false)
            {
                table2ordernumbercanvas.SetActive(false);

            }

        }

        if (_crator.Table3[0] != null)
        {
            if (_crator.Table3[0].GetComponent<Table3Costumer>().tabl3ordernumbercanvas == true)
            {
                table3ordernumbercanvas.SetActive(true);

            }
            if (_crator.Table3[0].GetComponent<Table3Costumer>().tabl3ordernumbercanvas == false)
            {
                table3ordernumbercanvas.SetActive(false);

            }

        }
        //table1Costumers
        if (_crator.Table1[0] != null)
        {

            if (table1ordertpstart == true && _crator.Table1[0].GetComponent<CostumersMovement>().isTabletrigger == true)
            {

                v = 2;
                for (int i = 0; i < 15; i++)
                {
                    if (_crator.Table1[0].GetComponent<CostumersMovement>().Order1Number > 0)
                    {
                        if (PlayerCarryPoints[v] != null && v >= 0)
                        {
                            if (PlayerCarryPoints[v].tag == "Donut")
                            {
                                if (ordercounter > 0.2f)
                                {
                                    eatingbool = true;
                                    PlayerCarryPoints[v].transform.position = _crator.Table1[0].GetComponent<CostumersMovement>().orderPoints.transform.position;
                                    w--;
                                    table1order[n] = PlayerCarryPoints[v];
                                    n++;
                                    PlayerCarryPoints[v].transform.SetParent(tabless1);
                                    PlayerCarryPoints[v] = null;
                                    _crator.Table1[0].GetComponent<CostumersMovement>().Order1Number--;

                                    if (_crator.Table1[0].GetComponent<CostumersMovement>().Order1Number == 0)
                                    {
                                        _crator.Table1[0].GetComponent<CostumersMovement>().GetComponent<Animator>().SetBool("eating", false);
                                        walkingbool = true;
                                        eatingbool = false;
                                        Destroy(table1order[0]);
                                        Destroy(table1order[1]);
                                        Destroy(table1order[2]);
                                        Destroy(table1order[3]);
                                        Destroy(table1order[4]);
                                        Destroy(table1order[5]);
                                        Destroy(table1order[6]);
                                        Destroy(table1order[7]);
                                        Destroy(table1order[8]);
                                        n = 0;

                                    }

                                    if (o > 0)
                                    {
                                        o--;
                                    }

                                    ordercounter = 0;
                                }


                            }
                        }

                        if (v > 0)
                        {
                            v--;

                        }


                    }

                }
            }

        }
        //table2Costumers
        if (_crator.Table2[0] != null)
        {
            if (table2ordertpstart == true && _crator.Table2[0].GetComponent<Table2Costumers>().isTabletrigger1 == true)
            {

                v = 2;
                for (int i = 0; i < 15; i++)
                {
                    if (_crator.Table2[0].GetComponent<Table2Costumers>().Order1Number > 0)
                    {
                        if (PlayerCarryPoints[v] != null && v >= 0)
                        {
                            if (PlayerCarryPoints[v].tag == "Donut")
                            {
                                if (ordercounter > 0.2f)
                                {
                                    eatingbool2 = true;
                                    PlayerCarryPoints[v].transform.position = _crator.Table2[0].GetComponent<Table2Costumers>().orderPoints.transform.position;
                                    w--;
                                    table2order[c] = PlayerCarryPoints[v];
                                    c++;
                                    PlayerCarryPoints[v].transform.SetParent(tabless1);
                                    PlayerCarryPoints[v] = null;
                                    _crator.Table2[0].GetComponent<Table2Costumers>().Order1Number--;

                                    if (_crator.Table2[0].GetComponent<Table2Costumers>().Order1Number == 0)
                                    {
                                        _crator.Table2[0].GetComponent<Table2Costumers>().GetComponent<Animator>().SetBool("eating", false);
                                        walkingbool2 = true;
                                        eatingbool2 = false;
                                        Destroy(table2order[0]);
                                        Destroy(table2order[1]);
                                        Destroy(table2order[2]);
                                        Destroy(table2order[3]);
                                        Destroy(table2order[4]);
                                        Destroy(table2order[5]);
                                        Destroy(table2order[6]);
                                        Destroy(table2order[7]);
                                        Destroy(table2order[8]);
                                        c = 0;

                                    }

                                    if (o > 0)
                                    {
                                        o--;
                                    }

                                    ordercounter = 0;
                                }
                            }
                        }

                        if (v > 0)
                        {
                            v--;

                        }
                    }

                }
            }


        }
        //table3Costumers
        if (_crator.Table3[0] != null)
        {
            if (table3ordertpstart == true && _crator.Table3[0].GetComponent<Table3Costumer>().isTabletrigger1 == true)
            {
                v = 2;
                for (int i = 0; i < 15; i++)
                {
                    if (_crator.Table3[0].GetComponent<Table3Costumer>().Order1Number > 0)
                    {
                        if (PlayerCarryPoints[v] != null && v >= 0)
                        {
                            if (PlayerCarryPoints[v].tag == "Donut")
                            {
                                if (ordercounter > 0.2f)
                                {
                                    eatingbool3 = true;
                                    PlayerCarryPoints[v].transform.position = _crator.Table3[0].GetComponent<Table3Costumer>().orderPoints.transform.position;
                                    w--;
                                    table3order[p] = PlayerCarryPoints[v];
                                    p++;
                                    PlayerCarryPoints[v].transform.SetParent(tabless1);
                                    PlayerCarryPoints[v] = null;
                                    _crator.Table3[0].GetComponent<Table3Costumer>().Order1Number--;

                                    if (_crator.Table3[0].GetComponent<Table3Costumer>().Order1Number == 0)
                                    {

                                        _crator.Table3[0].GetComponent<Table3Costumer>().GetComponent<Animator>().SetBool("eating", false);
                                        walkingbool3 = true;
                                        eatingbool3 = false;
                                        Destroy(table3order[0]);
                                        Destroy(table3order[1]);
                                        Destroy(table3order[2]);
                                        Destroy(table3order[3]);
                                        Destroy(table3order[4]);
                                        Destroy(table3order[5]);
                                        Destroy(table3order[6]);
                                        Destroy(table3order[7]);
                                        Destroy(table3order[8]);
                                        p = 0;

                                    }

                                    if (o > 0)
                                    {
                                        o--;
                                    }


                                    ordercounter = 0;
                                }


                            }
                        }

                        if (v > 0)
                        {
                            v--;

                        }


                    }

                }
            }

        }


        if (skiplevel == true)
        {
            Vector3 positon = xxxx.transform.localPosition;
            positon.x += 0.6f;
            positon.z -= 0.45f;
            xxxx.transform.position = positon;

        }






        /////////-------------Player Movement---------------//////////

        _rigidbody.velocity = new Vector3(_joystick.Vertical * _moveSpeed + Time.deltaTime, _rigidbody.velocity.y, _joystick.Horizontal * -_moveSpeed + Time.deltaTime);
        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            Chef.GetComponent<Animator>().SetBool("isWalking", true);
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            if (PlayerCarryPoints[0] != null)
            {
                Chef.GetComponent<Animator>().SetBool("isCarryWalking", true);
                transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            }
        }
        if (LEVEL2 == false)
        {
            if (_joystick.Horizontal == 0 || _joystick.Vertical == 0)
            {
                Chef.GetComponent<Animator>().SetBool("isWalking", false);
                Chef.GetComponent<Animator>().SetBool("isCarryWalking", false);
                Chef.GetComponent<Animator>().SetBool("isCarrying", false);
                if (PlayerCarryPoints[0] != null)
                {
                    Chef.GetComponent<Animator>().SetBool("isCarryWalking", false);
                    Chef.GetComponent<Animator>().SetBool("isCarrying", true);
                }
            }
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

                Level1SkipCamera.SetActive(true);
                Chef.transform.position = TpPoint.transform.position;
                Chef.transform.rotation = TpPoint.transform.rotation;
                LEVEL2 = true;
                xxxx.GetComponent<Animator>().SetBool("isWalking", true);
                skiplevel = true;
                joystick.SetActive(false);
                Level2Teleporteranimation = false;

            }

        }
        //MachineSpawner
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
                ConfettiCooker.SetActive(true);
                startefectcounter = true;
                SpawnMachine();
                lvl1machinenumber.SetActive(true);
                MachineUpgraderp.SetActive(true);
                Destroy(MachineCreator);
                Destroy(CookerInfo);
                Destroy(CookerInfoC);
                machineishere = true;
                Machinecreatoranimation = false;
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
                ConfettiCookerUp.SetActive(true);
                startefectcounter = true;
                machinelvl1 = false;
                machinelvl2 = true;
                Destroy(MachineUpgraderp);
                lvl2MacBoxNum = lvl1MacBoxNum;
                Destroy(lvl1machinenumber);
                lvl2machinenumber.SetActive(true);
                MachineUpgraderMax.SetActive(true);
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
                Table2Creator.SetActive(true);
                Table1creatoranimation = false;
                bir.SetActive(false);
                iki.SetActive(false);
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

    }
    IEnumerator Wait()
    {

        yield return new WaitForSecondsRealtime(3);

    }
    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.name == "ITable")
        {
            TableInfo.SetActive(false);
        }
        if (other.gameObject.name == "ICooker")
        {
            CookerInfo.SetActive(false);

        }
        if (other.gameObject.name == "ITruck")
        {
            TruckInfo.SetActive(false);
        }

        if (other.gameObject.tag == "Table1")
        {
            table1ordertpstart = false;
            startordercounter = false;

        }
        if (other.gameObject.tag == "Table2")
        {
            table2ordertpstart = false;
            startordercounter = false;

        }
        if (other.gameObject.tag == "Table3")
        {
            table3ordertpstart = false;
            startordercounter = false;

        }
        if (other.gameObject.tag == "MachineCreator")
        {
            Machinecreatoranimation = false;
            startordercounter = false;
            machineSpawner.GetComponent<Animator>().SetBool("scale", false);

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
        if (other.gameObject.tag == "Level2Teleporter")
        {
            Level2Teleporteranimation = false;
            startordercounter = false;
            Level2Telporter.GetComponent<Animator>().SetBool("scale", false);

        }
        if (other.gameObject.name == "CarryFoodPoint")
        {

            startcounter = false;
            foodtpstart = false;
            counter = 0;

        }
        if (other.gameObject.name == "MachineCarryTpPoint")
        {

            startsayac = false;
            machinetpstart = false;
            counter = 0;
            startanimationcounter = false;
        }
        if (other.gameObject.tag == "CarryPoint")
        {
            startcounter = false;
            playertpstart = false;
            machinetpstart = false;
            counter = 0;

        }

    }
    private void OnTriggerStay(Collider other)
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "TpLevel2Finish")
        {
            LEVEL2 = true;
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }

        if (other.gameObject.name == "ITable")
        {
            TableInfo.SetActive(true);
        }

        if (other.gameObject.name == "ICooker")
        {
            CookerInfo.SetActive(true);

        }

        if (other.gameObject.name == "ITruck")
        {

            TruckInfo.SetActive(true);
        }

        if (other.gameObject.tag == "Donut")
        {
            if (f5 < 1)
            {
                finish5.SetActive(false);
                finish6.SetActive(true);
                f5++;
            }
        }
        if (other.gameObject.tag == "Table1")
        {
            if (f6 < 1)
            {


                f6++;
            }
            startordercounter = true;
            table1ordertpstart = true;
            finish6.SetActive(false);
        }
        if (other.gameObject.tag == "Table2")
        {
            startordercounter = true;
            table2ordertpstart = true;
        }
        if (other.gameObject.tag == "Table3")
        {
            startordercounter = true;
            table3ordertpstart = true;
        }
        if (other.gameObject.name == "CarryFoodPoint")
        {


            startcounter = true;
            foodtpstart = true;

        }
        if (other.gameObject.tag == "CarryPoint")
        {
            if (f3 < 1)
            {
                finish3.SetActive(false);
                finish4.SetActive(true);
                f3++;
            }

            startcounter = true;
            playertpstart = true;

        }

        if (other.gameObject.name == "MachineCarryTpPoint")
        {
            if (f4 < 1)
            {
                finish4.SetActive(false);
                finish5.SetActive(true);
                f4++;
            }
            startcounter = true;
            machinetpstart = true;
        }
        if (other.gameObject.name == "TrashBox")
        {
            for (int t = 0; t < 3; t++)
            {
                Destroy(PlayerCarryPoints[t]);
                PlayerCarryPoints[t] = null;
                o = 0;
            }
        }
        if (other.gameObject.tag == "Table1Creator")
        {
            if (f < 1)
            {
                finish.SetActive(false);
                finish2.SetActive(true);
                f++;
            }
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
        if (other.gameObject.tag == "MachineCreator")
        {
            if (f2 < 1)
            {
                finish2.SetActive(false);
                finish3.SetActive(true);
                f2++;
            }

            Machinecreatoranimation = true;
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
        if (other.gameObject.name == "start")
        {
            finish1.SetActive(false);
            finish.SetActive(true);
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
    void SpawnMachine()
    {


        float x = machinelocation.transform.position.x;
        float y = machinelocation.transform.position.y;
        float z = machinelocation.transform.position.z;






        Instantiate(machine, new Vector3(x, y, z), Quaternion.identity);

    }
    void TpObjectPlayer()
    {

        //TpBpxPlayer

        float x = carryPoint.transform.position.x;
        float y = carryPoint.transform.position.y;
        float z = carryPoint.transform.position.z;

        carryPoints[0] = new Vector3(x, y, z);
        carryPoints[1] = new Vector3(x, y + 5.35f, z);
        carryPoints[2] = new Vector3(x, y + 10.7f, z);

    }
    void TpBoxMachine()
    {

        //TpBoxMachine
        float x = MachineCarryPoint.transform.position.x;
        float y = MachineCarryPoint.transform.position.y;
        float z = MachineCarryPoint.transform.position.z;

        carryPoints[0] = new Vector3(x, y, z + 7);
        carryPoints[1] = new Vector3(x, y, z);
        carryPoints[2] = new Vector3(x - 7, y, z + 7);
        carryPoints[3] = new Vector3(x - 7, y, z);
        carryPoints[4] = new Vector3(x, y + 5, z + 7);
        carryPoints[5] = new Vector3(x, y + 5, z);
        carryPoints[6] = new Vector3(x - 7, y + 5, z + 7);
        carryPoints[7] = new Vector3(x - 7, y + 5, z);


    }
    void SpawnDonutA()
    {


        float x = convertFoodPoint.transform.position.x;
        float y = convertFoodPoint.transform.position.y;
        float z = convertFoodPoint.transform.position.z;

        arrayconvertfood[0] = new Vector3(x, y, z);

        Instantiate(food, arrayconvertfood[0], Quaternion.identity);


    }
    void SpawnBoxA()
    {


        float x = convertBoxPoint.transform.position.x;
        float y = convertBoxPoint.transform.position.y;
        float z = convertBoxPoint.transform.position.z;

        arrayconvertfood[0] = new Vector3(x, y, z);

        Instantiate(box, arrayconvertfood[0], Quaternion.identity);
        // BoxConvert.controlbox = false;

    }
    public void TpFood()
    {

        h = 0;
        float x = StoreFoodPoint.transform.position.x;
        float y = StoreFoodPoint.transform.position.y;
        float z = StoreFoodPoint.transform.position.z;

        arrayfood[0] = new Vector3(x + 8.8f, y, z);
        arrayfood[1] = new Vector3(x + 8.8f, y, z + 8.8f);
        arrayfood[2] = new Vector3(x, y, z);
        arrayfood[3] = new Vector3(x, y, z + 8.8f);
        arrayfood[4] = new Vector3(x + 8.8f, y + 3, z);
        arrayfood[5] = new Vector3(x + 8.8f, y + 3, z + 8.8f);
        arrayfood[6] = new Vector3(x, y + 3, z);
        arrayfood[7] = new Vector3(x, y + 3, z + 8.8f);
        arrayfood[8] = new Vector3(x + 8.8f, y + 6, z);
        arrayfood[9] = new Vector3(x + 8.8f, y + 6, z + 8.8f);
        arrayfood[10] = new Vector3(x, y + 6, z);
        arrayfood[11] = new Vector3(x, y + 6, z + 8.8f);
        arrayfood[12] = new Vector3(x + 8.8f, y + 9, z);
        arrayfood[13] = new Vector3(x + 8.8f, y + 9, z + 8.8f);
        arrayfood[14] = new Vector3(x, y + 9, z);
        arrayfood[15] = new Vector3(x, y + 9, z + 8.8f);

        if (machinelvl1 == true)
        {

            for (int i = 0; i < 8; i++)
            {

                if (foods[i] == null && h < 1)
                {
                    foods[i] = Instantiate(donut, arrayfood[i], Quaternion.identity);
                    h++;
                }

            }

        }

        if (machinelvl2 == true)
        {

            for (int i = 0; i < 16; i++)
            {

                if (foods[i] == null && h < 1)
                {
                    foods[i] = Instantiate(donut, arrayfood[i], Quaternion.identity);
                    h++;
                }

            }
        }
    }

}



