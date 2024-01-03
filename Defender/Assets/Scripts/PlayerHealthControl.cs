using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealthControl : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth = 0;
    public HealthBarControl healthBar;
    public UnityEvent death;
    public List<Component> deathComponentClearList = new ();
    public List<GameObject> deathObjDestroyList = new ();
    bool dead;

    void Start()
    {
        currentHealth = maxHealth;
    }

    static void DestroyComponent<T>(List<T> itemList) where T : UnityEngine.Object
    {
        foreach (var item in itemList)
        {
            UnityEngine.Object.Destroy(item);
        }
    }

    void UpdateHealth(int val)
    {
        if (dead)
        {
            return;
        }

        currentHealth = Mathf.Clamp(currentHealth += val, 0, maxHealth);

        healthBar.UpdateHealthBar((float)currentHealth/(float)maxHealth);

        if (currentHealth <= 0)
        {
            dead = true;
            PauseControl.instance.GameOver();
            death.Invoke();
            DestroyComponent(deathComponentClearList);
            DestroyComponent(deathObjDestroyList);
        }
    }
}
