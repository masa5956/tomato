using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;
using UnityEngine.SceneManagement;

public class Event : MonoBehaviour
{
    Flowchart flowchart;

    [SerializeField]
    string gamestart = "";


    Enemy enemy;

    [SerializeField]

    GameObject GameEndPanel;

    [SerializeField]
    Text ScoreUI;
    [SerializeField]
    Text GetCoinUI;
   

  

    
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<Enemy>();
        flowchart = GetComponent<Flowchart>();

        StartCoroutine(Prologue());

        GameEndPanel.SetActive(false);

       
     


    }

    // Update is called once per frame
    void Update()
    {
      
   
         
            
       

    }

    IEnumerator Prologue()
    {
        flowchart.SendFungusMessage(gamestart);
        yield return new WaitUntil(() => flowchart.GetExecutingBlocks().Count == 0);
        enemy.Move();
        
      
        
      
 
    }
    public void GameEndEvent()
    {
        //GameManager.instance.Coin += GameManager.instance.Score / 2;
        GameEndPanel.SetActive(true);
        GameManager.instance.Coin += GameManager.instance.Score / 2;
        ScoreUI.text = "Score" + GameManager.instance.Score;
        GetCoinUI.text = "Coin" + GameManager.instance.Coin;

       

    }
    public void Coin_Calcukate()
    {
       
    }
   
   
}