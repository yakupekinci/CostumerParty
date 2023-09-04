using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodNumeber : MonoBehaviour
{
    public Text Coin;
    public Text Donut;
    public Text MachineCratorCoins;
    public Text MachineUpgraderCoins;
    public Text Table1CratorCoins;
    public Text Table2CratorCoins;
    public Text Table3CratorCoins;
    public Text TruckUpgraderCoins;
    public Text Level2TelporterCoins;
    public Text Tabl1ordernumber;
    public Text Tabl2ordernumber;
    public Text Tabl3ordernumber;
    public TextMesh lvl1machineBoxNumber;
    public TextMesh lvl2machineBoxNumber;
    [SerializeField] CostumerControllers _spawner;
    [SerializeField] PlayerJoytick _player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //CreatorAniamations
        
        MachineCratorCoins.text = "" + PlayerJoytick.Machinecoin;
        MachineUpgraderCoins.text = "" + PlayerJoytick.Machinelvl1coin;
        Table1CratorCoins.text = "" + PlayerJoytick.table1coin;
        Table2CratorCoins.text = "" + PlayerJoytick.table2coin;
        Table3CratorCoins.text = "" + PlayerJoytick.table3coin;
        TruckUpgraderCoins.text = "" + PlayerJoytick.Trucklvl1coin;
        Level2TelporterCoins.text = "" + PlayerJoytick.Level2Teleportercoin;
        Coin.text = "" + PlayerJoytick.coin;
        Donut.text = "" + _player.w;
        Coin.text = "" + PlayerJoytick.coin;


        //MachineBoxnNumber

        if (_player.machinelvl1 == true)
        {
            lvl1machineBoxNumber.text = _player.lvl1MacBoxNum + "/4";
        }
        if (_player.machinelvl2 == true)
        {
            lvl2machineBoxNumber.text = _player.lvl2MacBoxNum + "/8";
        }


         
        //Tables
        if (_spawner.Table1[0] != null)
        {
            Tabl1ordernumber.text = "" + _spawner.Table1[0].GetComponent<CostumersMovement>().Order1Number;
        }

        if (_spawner.Table2[0] != null)
        {
            Tabl2ordernumber.text = "" + _spawner.Table2[0].GetComponent<Table2Costumers>().Order1Number;
        }

        if (_spawner.Table3[0] !=null)
        {
            Tabl3ordernumber.text = "" + _spawner.Table3[0].GetComponent<Table3Costumer>().Order1Number;
        }
      

    }
}
