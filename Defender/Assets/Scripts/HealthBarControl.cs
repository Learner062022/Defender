using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarControl : MonoBehaviour
{
    public Image fill;

    public void UpdateHealthBar(float percent)
    {
        fill.fillAmount = percent;
    }
}
