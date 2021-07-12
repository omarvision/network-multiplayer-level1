using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour
{
    private void Start()
    {
        if (isLocalPlayer == true)
        {
            this.GetComponent<UserControl>().enabled = true;
        }
    }
}