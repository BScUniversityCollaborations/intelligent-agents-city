using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Declaring variables for default values
    public int defaultGold = 0;
    public float defaultEnergy = 100.0f;
    public float defaultExploration = 0.0f;
    public int defaultEnergyPots = 0;

    //variables that will be used during combat
    public int npcGold;
    public int NpcGold
    {
        get { return npcGold; }
        set { npcGold = value; }
    }

    public float npcEnergy;
    public float NpcEnergy
    {
        get { return npcEnergy; }
        set { npcEnergy = value; }
    }

    public float npcExploration;
    public float NpcExploration
    {
        get { return npcExploration; }
        set { npcExploration = value; }
    }

    public int npcEnergyPots;
    public int NpcEnergyPots
    {
        get { return npcEnergyPots; }
        set { npcEnergyPots = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        //initialize the variables that will be used by the monsters
        npcGold = defaultGold;
        npcEnergy = defaultEnergy;
        npcExploration = defaultExploration;
        npcEnergyPots = defaultEnergyPots;
    }

    // Update is called once per frame
    void Update()
    {
        npcEnergy -= 1 * Time.deltaTime;

    }
}
