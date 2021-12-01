using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class HotSpotManager : MonoBehaviour
{
	public GameObject Livingroom;
	public GameObject Cantina;
	public GameObject Cube;
	public GameObject Mezzanine;

    // Start is called before the first frame update
    public void openLivingRoom()
	{
		Cantina.SetActive(false);
		Cube.SetActive(false);
		Mezzanine.SetActive(false);
		Livingroom.SetActive(true);
	}

	public void openCantina()
	{
		Livingroom.SetActive(false);
		Cube.SetActive(false);
		Mezzanine.SetActive(false);
		Cantina.SetActive(true);
	}

	public void openCube()
	{
		Livingroom.SetActive(false);
		Cantina.SetActive(false);
		Mezzanine.SetActive(false);
		Cube.SetActive(true);
	}

	public void openMezzanine()
	{
		Livingroom.SetActive(false);
		Cantina.SetActive(false);
		Cube.SetActive(false);
		Mezzanine.SetActive(true);
	}
}
