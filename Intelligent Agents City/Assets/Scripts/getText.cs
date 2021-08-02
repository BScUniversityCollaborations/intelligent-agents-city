using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class getText : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI npcWinner;
   
    Game game = new Game();

    // Start is called before the first frame update
    void Start()
    {
        npcWinner = GameObject.Find("NPCNAME").GetComponent<TextMeshProUGUI>();
        string text = game.TextWinner.text;
        npcWinner.SetText(text.ToString());
        Debug.Log(text);
    }

    // Update is called once per frame
    void Update()
    {
        /*   TextMeshProUGUI texture = GameObject.Find("textWinner").GetComponent<TextMeshProUGUI>();
           npcWinner = GameObject.Find("NPCNAME").GetComponent<TextMeshProUGUI>();
           npcWinner.SetText(texture.ToString());
           Debug.Log("the winner " + npcWinner);
   */



    /*    TextMeshProUGUI winner = game.textWinner;
        string ok = winner.GetParsedText();
        TextMeshProUGUI nautName = GetComponent<TextMeshProUGUI>();
        npcWinner.text = game.TextWinner.text;
        Debug.Log("the winner " + npcWinner);
        // npcWinner.SetText("NPC", npcWinner);*/
    }
}
