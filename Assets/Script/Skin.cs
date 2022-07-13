using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SerializeField]
[CreateAssetMenu(fileName = "Skin", menuName = "CreateSkin")]
public class Skin : ScriptableObject
{
    [SerializeField]
    private string Information;
    [SerializeField]
    private string SkinName;
    [SerializeField]
    private int AttackDamage;
    [SerializeField]
    private Sprite Icon;
    [SerializeField]
    private int Price;
   
    


    public Sprite GetIcon()
    {
        return Icon;
    }
    public int GetAttackDamage()
    {
        return AttackDamage;
    }
    public int GetPrice()
    {
        return Price;
    }
    public string GetInformation()
    {
        return Information;
    }

    public string GetSkinName()
    {
        return SkinName;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
