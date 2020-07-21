using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy_Dreams : MonoBehaviour
{
    public Image img;
    public Sprite[] dreams;
    
    public void BuyDream()
    {
        int random_dreams = Random.Range(0, dreams.Length);
         
        img.sprite = dreams[random_dreams];
    }
}
