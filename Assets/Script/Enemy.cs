using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Enemy : MonoBehaviour
{

    [SerializeField]
    int Enemy_Score = 0;
    [SerializeField]
    private AudioClip se;

    [SerializeField]
    Text UI_Text;
   
    Event gameEvent;
    

  


    // Start is called before the first frame update
    void Start()
    {
        gameEvent = GetComponent<Event>();

      
        
      
    }

    // Update is called once per frame
    void Update()
    {

        UI_Text.text = "Score" + GameManager.instance.Score;
        
      
    }
   
  
    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "tomato")
       
        AudioSource.PlayClipAtPoint(se, transform.position);
        GameManager.instance.Score += Enemy_Score;



    }

    public void Move()
    {
       


            this.transform.DOMoveX(-45, 6f).OnComplete(() =>
            this.transform.DOMoveY(9, 1f).OnComplete(() =>
            this.transform.DOMoveX(45, 6f).OnComplete(() =>
            this.transform.DOMoveX(-45, 6f).OnComplete(() =>         
            this.transform.DOMoveX(45, 6f).OnComplete(() =>



            {
                Destroy(this.gameObject);
                gameEvent.GameEndEvent();




            })))));

        }
    }
   




