﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionControl2 : MonoBehaviour
{

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "End") //If the player touch the "end" object, he can play the next level 
        {
            PlayerPrefs.SetInt("lastLevel", 5); //We save that the player finished the secondLevel
            gameObject.SetActive(false);
            Initiate.Fade("Level3", Color.black, 0.5f);
        }
        else if (collider.gameObject.tag == "ShrinkBonus") //If the player touch the ShrinkBonus
        {
            collider.gameObject.SetActive(false); //I disable the Bonus
            gameObject.transform.localScale -= new Vector3(1, 1, 1);
        }
    }
}
