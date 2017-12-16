using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleSave : MonoBehaviour {

    public GameObject managerScript;
    public GameObject player;


    public void Save()
    {
        Debug.Log("Save ES2");
        ES2.Save(player.transform, "playerPosition");

        ES2.Save(SceneManager.GetActiveScene().name, "savedScene");

        ManagerScript script = managerScript.GetComponent<ManagerScript>();
        ES2.Save(script.ammo, "ammo");
        ES2.Save(script.magazines, "magazines");
        ES2.Save(script.brokenArm, "brokenArm");
    }
}
