using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualDown : MonoBehaviour
{
    public VIDEUIManager1 manager;

    public void VirtualDownPressed()
    {
        manager.SPressed();
    }
}
