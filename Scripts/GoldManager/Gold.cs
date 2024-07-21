using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Gold : MonoBehaviour
{
    public int GoldAmount;
    [SerializeField] Text GoldAmountText;

    Skeleton Skeleton;

    // Start is called before the first frame update
    void Start()
    {
        Skeleton = GameObject.Find("Enemy").GetComponent<Skeleton>();

        GoldAmountText.text = "Gold: " + GoldAmount;
    }

    public void Loot()
    {
        GoldAmount += Skeleton.Drop;
        GoldAmountText.text = "Gold: " + GoldAmount;

    }

    public void RefreshGold()
    {
        GoldAmountText.text = "Gold: " + GoldAmount;

    }
}
