using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public void Continue()
    {
        PauseControl.instance.Unpause();
    }
}
