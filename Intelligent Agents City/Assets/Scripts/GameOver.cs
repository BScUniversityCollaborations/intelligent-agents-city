using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{   
    List<bool> dead = new List<bool>();

    [SerializeField] public TextMeshProUGUI textWinner;
    public TextMeshProUGUI TextWinner
    {
        get { return textWinner; }
        set { textWinner = value; }
    }


    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
       // countDead = 0;
        bool isDeadNPC1 = GameObject.Find("NPC_1").GetComponent<NPC>().isDead;
        bool isDeadNPC2 = GameObject.Find("NPC_2").GetComponent<NPC>().isDead;
        bool isDeadNPC3 = GameObject.Find("NPC_3").GetComponent<NPC>().isDead;
        bool isDeadNPC4 = GameObject.Find("NPC_4").GetComponent<NPC>().isDead;

        dead.Insert(0, isDeadNPC1);
        dead.Insert(1, isDeadNPC2);
        dead.Insert(2, isDeadNPC3);
        dead.Insert(3, isDeadNPC4);


        if(!isDeadNPC1 && isDeadNPC2 && isDeadNPC3 && isDeadNPC4)
        {
            Time.timeScale = 0;
           
            Debug.Log("NPC1 W");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
            textWinner.SetText("NPC1");
        }

        if (isDeadNPC1 && !isDeadNPC2 && isDeadNPC3 && isDeadNPC4)
        {
            Time.timeScale = 0;
          
            Debug.Log("NPC2 W");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            textWinner.SetText("NPC2");

        }

        if (isDeadNPC1 && isDeadNPC2 && !isDeadNPC3 && isDeadNPC4)
        {
            Time.timeScale = 0;
            
            Debug.Log("NPC3 W");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            textWinner.SetText("NPC3");
        }

        if (isDeadNPC1 && isDeadNPC2 && isDeadNPC3 && !isDeadNPC4)
        {
            Time.timeScale = 0; 
           
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            textWinner.SetText("NPC4") ;
            Debug.Log("NPC4 W");  
           
        }
          
           

   
    }

}
