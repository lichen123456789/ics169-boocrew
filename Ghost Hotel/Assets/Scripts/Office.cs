﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Office : MonoBehaviour {

	public Player player;
	public DialogueManager DialogueManager;
	[TextArea(1,10)]
	public string[] dialogue;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<Player> ();
		DialogueManager = FindObjectOfType<DialogueManager> ();

		if (player.office && !player.home) {
			player.talking = true;
			DialogueManager.ForceClose ();
			DialogueManager.ShowBox (dialogue, true, false, false, false, "", "");
			GameObject.Find ("OFFICE").SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}