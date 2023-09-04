using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodNumber2 : MonoBehaviour
{
    public Text CoinS;   
    public Text PizzaS;
    public Text DonutS;
    public Text MachineCratorCoinsPizzaS;
    public Text MachineCratorCoinsDonutS;
    public Text MachineUpgraderCoinsPizzaS;
    public Text MachineUpgraderCoinsDonutS;
    public Text Table1CratorCoinssS;
    public Text Table2CratorCoinsS;
    public Text Table3CratorCoinsS;
    public Text Table4CratorCoinsS;
    public Text TruckUpgraderCoinsS;
    public Text Level2TelporterCoinsS;
    public Text Tabl1ordernumberS;
    public Text Tabl2ordernumberS;
    public Text Tabl3ordernumberS; 
    public Text Tabl4ordernumberS;
    public TextMesh lvl1machineBoxNumberS;
    public TextMesh lvl2machineBoxNumberS;
    public TextMesh lvl1machineBoxNumberS2;
    public TextMesh lvl2machineBoxNumberS2;
    [SerializeField] CostumerControllers _spawner;
    [SerializeField] PlayerJoystick2 _player2;
    // Start is called before the first frame update
    void Start()
    {   

    }

    // Update is called once per frame
    void Update()
    {
        //CreatorAniamations

        MachineCratorCoinsPizzaS.text = "" + PlayerJoystick2.Machinecoin;
        MachineCratorCoinsDonutS.text = "" + PlayerJoystick2.Machinecoin2;
        MachineUpgraderCoinsPizzaS.text = "" + PlayerJoystick2.Machinelvl1coin;
        MachineUpgraderCoinsDonutS.text = "" + PlayerJoystick2.Machinelvl1coin2;
        Table1CratorCoinssS.text = "" + PlayerJoystick2.table1coin;
        Table2CratorCoinsS.text = "" + PlayerJoystick2.table2coin;
        Table3CratorCoinsS.text = "" + PlayerJoystick2.table3coin;
        Table4CratorCoinsS.text = "" + PlayerJoystick2.table4coin;
        TruckUpgraderCoinsS.text = "" + PlayerJoystick2.Trucklvl1coin;
        Level2TelporterCoinsS.text = "" + PlayerJoystick2.Level2Teleportercoin;
        CoinS.text = "" + PlayerJoystick2.coin;
       //DonutS.text = "" + _player2.w;
      // PizzaS.text = "" + _player2.w;


        /*//MachineBoxnNumber

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

        if (_spawner.Table3[0] != null)
        {
            Tabl3ordernumber.text = "" + _spawner.Table3[0].GetComponent<Table3Costumer>().Order1Number;
        }
        */

    }
}
