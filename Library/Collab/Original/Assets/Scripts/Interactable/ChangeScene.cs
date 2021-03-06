﻿using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : Interactable
{
    public string scene;
    public override void interact()
    {
        SceneManager.LoadScene(scene);
        if (scene == "Forest")
        { 
            SamController.instance.transform.position = new Vector3(-75, -30, 0);
            ZoneName.zone = "Forêt";
        }
        else if (scene == "Camp" && SceneManager.GetActiveScene().name == "Forest")
        {
            SamController.instance.transform.position = new Vector3(38.6f, 2.17f, 0);
            ZoneName.zone = "Campement";
        }
        else if (scene == "Spaceship")
        {
            SamController.instance.transform.position = new Vector3(-2.9f, -1.4f, 0);
            ZoneName.zone = "Vaisseau";
        }
        else if (scene == "Camp" && SceneManager.GetActiveScene().name == "Spaceship")
        {
            SamController.instance.transform.position = new Vector3(0.58f, 3.19f, 0);
            ZoneName.zone = "Campement";
        }
        else if(scene == "Mountain" && SceneManager.GetActiveScene().name == "Camp")
        {
            SamController.instance.transform.position = new Vector3(4.55f, -5.0f, 0);
            ZoneName.zone = "Montagne";
        }
        else if (scene == "Camp" && SceneManager.GetActiveScene().name == "Mountain")
        {
            SamController.instance.transform.position = new Vector3(5.5f, 43.0f, 0);
            ZoneName.zone = "Campement";
        }
        else if (scene == "Caverne")
        {
            SamController.instance.transform.position = new Vector3(2.49f, 9.37f, 0);
            ZoneName.zone = "Caverne";
        }
        else if (scene == "Camp" && SceneManager.GetActiveScene().name == "Caverne")
        {
            SamController.instance.transform.position = new Vector3(-32.51f, 4.26f, 0);
            ZoneName.zone = "Campement";
        }
        else if (scene == "Village")
        {
            SamController.instance.transform.position = new Vector3(0, 24, 0);
            ZoneName.zone = "Village";
        }
        else if (scene == "Camp" && SceneManager.GetActiveScene().name == "Village")
        {
            SamController.instance.transform.position = new Vector3(1.5f, -35f, 0);
            ZoneName.zone = "Campement";
        }

    }
}
