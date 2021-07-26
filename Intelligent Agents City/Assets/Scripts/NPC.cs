using System;
using TMPro;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Declaring variables for default values
    public int defaultGold = 0;
    public float defaultEnergy = 10.0f;
    public float defaultExploration = 0.0f;
    public int defaultEnergyPots = 0;

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

        npcEnergy -= 1 * Time.deltaTime;

        if (npcEnergy >= 0.0f)
            textMeshProEnergy.SetText("Energy: {0}%", (float)Math.Round(npcEnergy * 100f) / 100f);
        textMeshProGold.SetText("Gold: {0}", NpcGold);

        if (npcEnergy == 0.0f)
            GameObject.Destroy(this);

    }
}
