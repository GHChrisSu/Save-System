using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleLoad : MonoBehaviour {

    public GameObject managerScript;
    public GameObject player;

    public void Load()
    {
        Debug.Log("Load ES2");
        Transform transform = ES2.Load<Transform>("playerPosition");
        player.transform.position = transform.position;

        ManagerScript script = managerScript.GetComponent<ManagerScript>();
        script.ammo = ES2.Load<int>("ammo");
        script.magazines = ES2.Load<int>("magazines");
        script.brokenArm = ES2.Load<bool>("brokenArm");
    }
}
