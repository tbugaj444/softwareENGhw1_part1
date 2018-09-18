using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class colorBlock : MonoBehaviour {
    public Image Block;
    public Slider red;
    public Slider green;
    public Slider blue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Block.color = new Color(red.value / 255, green.value / 255, blue.value / 255);

	}
}
