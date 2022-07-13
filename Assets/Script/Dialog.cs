using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;

public class Dialog : MonoBehaviour
{
    Flowchart flowchart;

    [SerializeField]
    string message = "";
   



    // Start is called before the first frame update
    void Start()
    {
       
        flowchart = GetComponent<Flowchart>();

        StartCoroutine("Prologue");
      
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Prologue()
    {
        flowchart.SendFungusMessage(message);
        yield return new WaitUntil(() => flowchart.GetExecutingBlocks().Count == 0);

        FadeManager.Instance.LoadScene("Game",2.0f);



    }
   
   
  
}