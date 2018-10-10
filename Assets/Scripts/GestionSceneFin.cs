﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GestionSceneFin : MonoBehaviour {

    public InputField champNomJoueur;

    private void Start()
    {
        champNomJoueur.text =PlayerPrefs.GetString("nomJoueur") + "Vous avez perdu";
    }

    public void Rejouer()
    {
        SceneManager.LoadScene("SceneJeu");
    }
}
