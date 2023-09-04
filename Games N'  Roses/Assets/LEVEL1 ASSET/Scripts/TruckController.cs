using UnityEngine;

public class TruckController : MonoBehaviour
{
    [SerializeField] private Transform startTrasform = null;
    [SerializeField] private Animator myDoor = null;


    public Transform TpBoxpointtt;
    public Transform truck;
    public GameObject truckBoxpoint;
    public GameObject TpBoxpoint;
    public GameObject kutu;
    public GameObject boxToPlayer;
    public GameObject boxToPlayerpoint;
    public GameObject arac;
    public GameObject[] kutular;
    public GameObject[] boxes;
    public Vector3[] array;

    private int a;
    private int j = 0;
    private int t = 0;


    public bool lvl1truck;
    public bool lvl2truck;
    private bool donus;
    private bool gidis;
    public bool check;
    public bool count;
    public bool count2;

    public double counter;
    private float sayac;
    private bool startsayaç;


    // Start is called before the first frame update
    void Start()
    {
        gidis = true;
        lvl1truck = true;
        lvl2truck = false;
    }



    void TpBoxToKitchen()
    {

        float x = TpBoxpoint.transform.position.x;
        float y = TpBoxpoint.transform.position.y;
        float z = TpBoxpoint.transform.position.z;


        array[0] = new Vector3(x, y, z);
        array[1] = new Vector3(x, y, z - 7.01f);
        array[2] = new Vector3(x, y, z - 14.01f);
        array[3] = new Vector3(x + 7.01f, y, z);
        array[4] = new Vector3(x + 7.01f, y, z - 7.01f);
        array[5] = new Vector3(x + 7.01f, y, z - 14.01f);
        array[6] = new Vector3(x + 14.01f, y, z);
        array[7] = new Vector3(x + 14.01f, y, z - 7.01f);
        array[8] = new Vector3(x + 14.01f, y, z - 14.01f);
        array[9] = new Vector3(x, y+5f, z);
        array[10] = new Vector3(x, y + 5f, z - 7.01f);
        array[11] = new Vector3(x, y + 5f, z - 14.01f);
        array[12] = new Vector3(x + 7.01f, y + 5f, z);
        array[13] = new Vector3(x + 7.01f, y + 5f, z - 7.01f);
        array[14] = new Vector3(x + 7.01f, y + 5f, z - 14.01f);
        array[15] = new Vector3(x + 14.01f, y + 5f, z);
        array[16] = new Vector3(x + 14.01f, y + 5f, z - 7.01f);
        array[17] = new Vector3(x + 14.01f, y + 5f, z - 14.01f);
        //



    }


    void TpBoxInTruck()
    {


        float x = truckBoxpoint.transform.position.x;
        float y = truckBoxpoint.transform.position.y;
        float z = truckBoxpoint.transform.position.z;

        //x- mape dogru
        //z- kamyonun dýþýna

        array[0] = new Vector3(x, y, z);
        array[1] = new Vector3(x, y, z + 7.2f);
        array[2] = new Vector3(x, y, z + 14.4f);
        array[3] = new Vector3(x, y, z + 21.6f);
        array[4] = new Vector3(x + 7.2f, y, z);
        array[5] = new Vector3(x + 7.2f, y, z + 7.2f);
        array[6] = new Vector3(x + 7.2f, y, z + 14.4f);
        array[7] = new Vector3(x + 7.2f, y, z + 21.6f);

       


        if (lvl1truck == true)
        {

            for (int k = 0; k < 4; k++)
            {
                if (kutular[k] == null)
                {
                    if (j < 4)
                    {
                        kutular[k] = Instantiate(kutu, array[k], Quaternion.identity);
                        kutular[k].transform.SetParent(truck);
                        j++;

                    }

                }
            }

        }

        if (lvl2truck == true)
        {
            for (int k = 0; k < 8; k++)
            {
                if (kutular[k] == null)
                {
                    if (j < 8)
                    {
                        kutular[k] = Instantiate(kutu, array[k], Quaternion.identity);
                        kutular[k].transform.SetParent(truck);
                        j++;

                    }

                }
            }

        }



        j = 0;
    }



    // Update is called once per frame
    void Update()
    {


        if (startsayaç == true)
        {
            sayac += 0.5f * Time.deltaTime;

        }



        if (lvl1truck == true)
        {
            if (count == true)
            {
                counter += 0.1d * Time.deltaTime;
                if (counter > 0.2d)
                {
                    myDoor.Play("TruckDoorClose", 0, 0.0f);
                    count2 = true;


                    for (int k = 0; k < 9; k++)
                    {
                        if (boxes[k] == null)
                        {
                            if (kutular[t] != null && t < 4)
                            {

                                if (sayac > 0.4F)
                                {
                                    TpBoxToKitchen();
                                    kutular[t].transform.position = Vector3.Lerp(array[k], startTrasform.position, 0.01f);
                                    kutular[t].transform.SetParent(TpBoxpointtt);
                                    boxes[k] = kutular[t];
                                    kutular[t] = null;
                                    t++;
                                    sayac = 0;
                                }


                            }

                        }
                    }

                }

            }

        }



        if (lvl2truck == true )
        {
            if (count == true)
            {
                counter += 0.1d * Time.deltaTime;
                if (counter > 0.2d)
                {
                   myDoor.Play("TruckDoorClose", 0, 0.0f);
                   count2 = true;
                    
                    for (int k = 0; k < 18; k++)
                    {

                            if (boxes[k] == null)
                            {
                                if (kutular[t] != null && t < 8)
                                {

                                    if (sayac > 0.2F)
                                    {
                                        TpBoxToKitchen();
                                        kutular[t].transform.position = Vector3.Lerp(array[k], startTrasform.position, 0.01f);
                                        kutular[t].transform.SetParent(TpBoxpointtt);
                                        boxes[k] = kutular[t];
                                        kutular[t] = null;
                                        t++;
                                       if (t ==8)
                                       {

                                        t=7;

                                       }
                                        sayac = 0;
                                    }


                                }

                    
                            }
                    }

                    

                }
            }
        }


        if (gidis == true)
        {
            if (counter > 0.5f)
            {
                Vector3 positon = this.transform.position;
                positon.x += 3f;
                this.transform.position = positon;

            }



        }

        if (donus == true)
        {
            Vector3 positon = this.transform.position;
            positon.x -= 3f;
            this.transform.position = positon;
        }
    }

    
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == "donus")
            {
                TpBoxInTruck();

                gidis = false;
                donus = true;
                counter = 0;
                count2 = false;
            }


            if (other.gameObject.name == "gidis")
            {
            t = 0;
               startsayaç = true;
                count = true;
                myDoor.Play("TruckDoorOpen", 0, 0.0f);

                donus = false;
                gidis = true;

                
            }

            if (other.gameObject.name == "doorOpen")
            {



            }
            if (other.gameObject.name == "doorClose")
            {
                count = false;
                startsayaç = false;
            }


        }


}
