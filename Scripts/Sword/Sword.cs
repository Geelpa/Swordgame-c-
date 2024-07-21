using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sword : MonoBehaviour
{
    SwordStats SwordStats;
    Skeleton Skeleton;

    public Image Redbar;

    // Start is called before the first frame update
    void Awake()
    {
        SwordStats = GetComponent<SwordStats>();
        Skeleton = GameObject.Find("Enemy").GetComponent<Skeleton>();
    }

    void Start()
    {
        InvokeRepeating("Dps", 0, 0.1f);
    }

    public void Hit()
    {

        if (Skeleton.CurrentHealth > SwordStats.Attack)
        {
            Skeleton.CurrentHealth -= SwordStats.Attack;
            Skeleton.Redbar.fillAmount = Skeleton.CurrentHealth / Skeleton.Health;
        }

        else
        {
            Skeleton.Redbar.fillAmount = Skeleton.Health;
            Skeleton.Die();
        }

    }

    public void Dps()
    {
        if (Skeleton.CurrentHealth > SwordStats.Dps)
        {
            Skeleton.CurrentHealth -= SwordStats.Dps;
            Skeleton.Redbar.fillAmount = Skeleton.CurrentHealth / Skeleton.Health;

        }
        else
        {
            Skeleton.Redbar.fillAmount = Skeleton.Health;
            Skeleton.Die();
        }
    }
}
