using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualEButton : MonoBehaviour
{
    public VIDEDemoPlayer videDemoPlayer;
    public DoorAction doorAction;
    
    public void VirtualEPressed()
    {
        Debug.Log("Virtual E Pressed");
        videDemoPlayer.TryInteract();
        doorAction.TryDoorAction();
    }
}
