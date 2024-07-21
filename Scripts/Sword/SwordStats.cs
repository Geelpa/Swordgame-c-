using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SwordStats : MonoBehaviour
{
    public int Attack;
    public float Dps;

    [SerializeField] public Text AttackText;
    [SerializeField] public Text DpsText;

    Skeleton Skeleton;

    // Start is called before the first frame update
    void Start()
    {
        AttackText.text = "Attack: " + Attack;
        DpsText.text = "Dps: " + Dps;

        Skeleton = GameObject.Find("Enemy").GetComponent<Skeleton>();
    }

    }
