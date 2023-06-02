using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public int coins;
     void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Coin")
        {
            Debug.Log("Coin collected!");
            coins = coins + 1;
            Col.gameObject.SetActive(false);

        }
    }
}
