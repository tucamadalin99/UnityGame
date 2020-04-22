using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    public int maxHp = 100;
    public int currHp;

    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currHp = maxHp;
        healthBar.SetMaxHealth(maxHp);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDmg(20);
            healthBar.SetHealth(currHp);
        }
    }

    void TakeDmg(int dmg)
    {
        currHp -= dmg;
    }
}
