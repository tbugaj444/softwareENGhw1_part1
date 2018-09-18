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

	public virtual LineRenderer lineRenderer
	{
		get
		{
			return mylines;
		}
	}

	public virtual new Camera camera
	{
		get
		{
			return m_Camera;
		}
	}

	public virtual List<Vector3> points
	{
		get
		{
			return m_Points;
		}
	}

	protected void Start()
	{
			
		m_Points = new List<Vector3>();
	}

	protected void Update()
	{
		Vector3 mp = m_Camera.ScreenToWorldPoint(Input.mousePosition);
		if (mp.y <= 35&& mp.y>=-46)
		{
			if (Input.GetMouseButtonDown(0))
			{
				lines[i] = new GameObject();
				lines[i].AddComponent<LineRenderer>();


				mylines = lines[i].GetComponent<LineRenderer>();
				mylines.transform.position.Set(0f, 0f, 0f);
				mylines.material = mat;

				LineColor.r = red.value/255;
				LineColor.g = green.value/255;
				LineColor.b = blue.value/255;
				LineColor.a = 1f;
				
				mylines.material.color = LineColor;


                i++;
				m_Points.Clear();
			}
			if (Input.GetMouseButton(0))
			{
				Vector3 mousePosition = m_Camera.ScreenToWorldPoint(Input.mousePosition);
				mousePosition.z = mylines.transform.position.z;

				if (!m_Points.Contains(mousePosition))
				{
					m_Points.Add(mousePosition);
					mylines.positionCount = m_Points.Count;

					mylines.SetPosition(mylines.positionCount - 1, mousePosition);
				}

			}
			
		}
	}

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



	



