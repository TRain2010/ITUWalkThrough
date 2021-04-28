using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VIDE_Data;

public class VirtualUp : MonoBehaviour
{
    public VIDEUIManager1 manager;
    
    public void VirtualUpPressed()
    {
        manager.WPressed();
    }
}
