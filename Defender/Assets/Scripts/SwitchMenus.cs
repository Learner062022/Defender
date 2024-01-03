using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMenus : MonoBehaviour
{
    public GameObject menuToOpen;
    public GameObject menuToClose;

    public void Switch()
    {
        menuToOpen.SetActive(true);
        menuToClose.SetActive(false);
    }
}
