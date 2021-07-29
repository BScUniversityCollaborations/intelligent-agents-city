using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class NPC : MonoBehaviour
{
    // Declaring variables for default values
    public int defaultGold = 0;
    public float defaultEnergy = 10.0f;
    public float defaultExploration = 0.0f;
    public int defaultEnergyPots = 0;

    public int maxEnergy = 1000;
    public int currentEnergy;
    

    [SerializeField] TextMeshProUGUI textMeshProEnergy;
    [SerializeField] TextMeshProUGUI textMeshProGold;

    //variables that will be used during combat
    [SerializeField] public int npcGold;
    public int NpcGold
    {
        get { return npcGold; }
        set { npcGold = value; }
    }

    [SerializeField] public float npcEnergy;
    public float NpcEnergy
    {
        get { return npcEnergy; }
        set { npcEnergy = value; }
    }

    [SerializeField] public float npcExploration;
    public float NpcExploration
    {
        get { return npcExploration; }
        set { npcExploration = value; }
    }

    [SerializeField] public int npcEnergyPots;
    public int NpcEnergyPots
    {
        get { return npcEnergyPots; }
        set { npcEnergyPots = value; }
    }

    [SerializeField] public EnergyBar energyBar;
    public EnergyBar EnergyBar
    {
        get { return energyBar; }
        //set { npcEnergyPots = value; }
    }


    // Start is called before the first frame update
    void Start()
    {
        // Initialize the variables that will be used by the monsters
        npcGold = defaultGold;
        npcEnergy = defaultEnergy;
        npcExploration = defaultExploration;
        npcEnergyPots = defaultEnergyPots;
        
        if (name == "NPC_1")
        {
           currentEnergy = maxEnergy;
            energyBar.setMaxEnegry(maxEnergy);
            textMeshProEnergy = GameObject.Find("Txt_NPC_1_Energy_Value")
                                          .GetComponent<TextMeshProUGUI>();
            textMeshProGold = GameObject.Find("Txt_NPC_1_Gold_Value")
                                          .GetComponent<TextMeshProUGUI>();
        }
        else if (name == "NPC_2")
        {
         
            textMeshProEnergy = GameObject.Find("Txt_NPC_2_Energy_Value")
                                          .GetComponent<TextMeshProUGUI>();
            textMeshProGold = GameObject.Find("Txt_NPC_2_Gold_Value")
                                          .GetComponent<TextMeshProUGUI>();
        }
        else if (name == "NPC_3")
        {
            textMeshProEnergy = GameObject.Find("Txt_NPC_3_Energy_Value")
                                          .GetComponent<TextMeshProUGUI>();
            textMeshProGold = GameObject.Find("Txt_NPC_3_Gold_Value")
                                          .GetComponent<TextMeshProUGUI>();
        }
        else
        {
            textMeshProEnergy = GameObject.Find("Txt_NPC_4_Energy_Value")
                                          .GetComponent<TextMeshProUGUI>();
            textMeshProGold = GameObject.Find("Txt_NPC_4_Gold_Value")
                                          .GetComponent<TextMeshProUGUI>();
        }
    }

    // Update is called once per frame
    void Update()
    {

        //npcEnergy -= 1 * Time.deltaTime;

        /* if (npcEnergy >= 0.0f)
             textMeshProEnergy.SetText("Energy: {0}%", (float)Math.Round(npcEnergy * 100f) / 100f);
         textMeshProGold.SetText("Gold: {0}", NpcGold);

         if (npcEnergy == 0.0f)
             GameObject.Destroy(this);
         */

        /*if(currentEnergy >= 0)
        {
             TakeEnergy(1);
        }*/

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeEnergy(20);
        }
        
        /*if (currentEnergy == 0)
        {
            GameObject.Destroy(this);
        }*/

    }

    void TakeEnergy(int energy)
    {
        currentEnergy -= energy;
        energyBar.setMaxEnegry(currentEnergy);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            // Grab this trigger's name.
            string npc = gameObject.name;
            // Compares this object's name with those below.
            switch (npc)
            {
                case "NPC_1":
                    NpcGold += 1;
                    textMeshProGold.SetText("Gold: {0}", NpcGold);
                    break;
                case "NPC_2":
                    NpcGold += 1;
                    textMeshProGold.SetText("Gold: {0}", NpcGold);
                    break;
                case "NPC_3":
                    NpcGold += 1;
                    textMeshProGold.SetText("Gold: {0}", NpcGold);
                    break;
                case "NPC_4":
                    NpcGold += 1;
                    textMeshProGold.SetText("Gold: {0}", NpcGold);
                    break;
            }
        }

        /* if (other.gameObject.CompareTag("Energy Pot"))
         {
             Destroy(other.gameObject);
             // Grab this trigger's name.
             string npc = gameObject.name;
             // Compares this object's name with those below.
             switch (npc)
             {
                 case "NPC_1":

                     npcEnergy += 1 * Time.deltaTime;


                     break;
                 case "NPC_2":

                     npcEnergy += 1 * Time.deltaTime;


                     break;
                 case "NPC_3":

                     npcEnergy += 1 * Time.deltaTime;



                     break;
                 case "NPC_4":
                     npcEnergy += 1 * Time.deltaTime;



                     break;
             }
         }*/


    }

    

}
