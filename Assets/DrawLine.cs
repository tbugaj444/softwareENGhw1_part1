using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class DrawLine : MonoBehaviour
{

	
	private LineRenderer mylines;
	public Camera m_Camera;
	protected GameObject[] lines = new GameObject[1000];
	protected List<Vector3> m_Points;

	public Button reset;
	public Slider red;
	public Slider green;
	public Slider blue;


	int i = 0;
	public Material mat;
	public Canvas Can;
	Color LineColor;

	

	protected void Start()
	{
		//creating list of points for the line 
		m_Points = new List<Vector3>();
	}

	protected void Update()
	{
		Vector3 mp = m_Camera.ScreenToWorldPoint(Input.mousePosition);
        //keeps it within boundaries of app
		if (mp.y <= 35&& mp.y>=-46)
		{
            //on touch
			if (Input.GetMouseButtonDown(0))
			{
                //creates a new line rendering object
				lines[i] = new GameObject();
				lines[i].AddComponent<LineRenderer>();


				mylines = lines[i].GetComponent<LineRenderer>();
                //for whatever reason without this it feels the need to draw behing the camera and therefor not be rendered 
				mylines.transform.position.Set(0f, 0f, 0f);
				mylines.material = mat;
                //sets line color
				LineColor.r = red.value/255;
				LineColor.g = green.value/255;
				LineColor.b = blue.value/255;
				LineColor.a = 1f;
				
				mylines.material.color = LineColor;

                //onto nect line
                i++;
				m_Points.Clear();
			}
            //while touching
			if (Input.GetMouseButton(0))
			{   //converts point to positions on screen
				Vector3 mousePosition = m_Camera.ScreenToWorldPoint(Input.mousePosition);
				mousePosition.z = mylines.transform.position.z;

				if (!m_Points.Contains(mousePosition))
				{
					m_Points.Add(mousePosition);
					mylines.positionCount = m_Points.Count;
                    //set positions draws the line
					mylines.SetPosition(mylines.positionCount - 1, mousePosition);
				}

			}
			
		}
	}
    //reset function to clear lines from canvas
	public void Reset()
	{
        
        for (int j = 0; j < lines.Length; j++) {
            if (lines[j] == null)
            {
                break;
            }
            else {
                Destroy(lines[j]);

            }
        }
		if (m_Points != null)
		{
			m_Points.Clear();
		}
        i = 0;

	}
	

}



	



