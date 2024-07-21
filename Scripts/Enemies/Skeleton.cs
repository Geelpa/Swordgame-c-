using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Skeleton : MonoBehaviour
{
    public int Health;
    public float CurrentHealth;
    [SerializeField] Text HealthText;

    public Image Redbar;

    public int Drop;
    public int CurrentDrop;

    public int Level;
    [SerializeField] Text LevelText;


    Gold Gold;

    // Start is called before the first frame update
    void Start()
    {
        Gold = GameObject.Find("Gold").GetComponent<Gold>();

        HealthText.text = "" + CurrentHealth + Health;
        CurrentHealth = Health;

        Level = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //HealthText.text = "Health: " + string.Format("{0:0.00}", CurrentHealth) + "/" + Health;
        HealthText.text = string.Format("{0:0}", CurrentHealth) + "/" + Health;
    }

    public void Die()
    {
        Gold.Loot();

        Level++;
        LevelText.text = "Skeleton ( " + Level + " )";

        Drop++;
        CurrentDrop = Drop;

        Health = Level * 5;
        CurrentHealth = Health;
    }
}
