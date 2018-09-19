using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class ChangeColor : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {
	public Text text1;
	public Text text2;
	public Text text3;
	public Button colorButton;

	private float r, g, b;
	private Color temp;
	private ColorBlock cb;
	bool pointerDown;

	

	// Use this for initialization
	void Start () {
		//can only generate random HSV colors... just have to convert the values later
		temp = Random.ColorHSV();
		


		cb = colorButton.colors;
		cb.normalColor = temp;
		cb.highlightedColor = temp;
		colorButton.colors = cb;


		text1.color = cb.normalColor;
		text2.color = cb.normalColor;


	}

	// Update is called once per frame
	void Update () {

        //updating temp color
		r = temp.r;
		g = temp.g;
		b = temp.b;
		
		//convert values here
		text3.text = "Color: " +Mathf.Round(r*255) + "r, " + Mathf.Round(g * 255) + "g, " + Mathf.Round(b * 255) 
			+ "b, " + "\n #" + ColorUtility.ToHtmlStringRGB(temp);

        //whenever the buoon is pressed down the color is set to the button and text
		if (pointerDown)
		{
			temp = Random.ColorHSV();
			cb.normalColor = temp;
			cb.highlightedColor = temp;
			colorButton.colors = cb;


			text1.color = cb.normalColor;
			text2.color = cb.normalColor;
			pointerDown = false;
		}


	}
    //event handlers
	public void OnPointerDown(PointerEventData eventData)
	{
		pointerDown = true;
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		pointerDown = false;
	}
}

