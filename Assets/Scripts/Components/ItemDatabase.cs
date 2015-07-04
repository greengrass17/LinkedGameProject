﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {
	public static ItemDatabase instance;

	public List<ItemPickable> itemList = new List<ItemPickable> ();

	void Awake ()
	{
		instance = this;
	}
}