using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageManager : MonoBehaviour
{
    public GameObject messagebox;
	
	public void ShowMessage()
	{
		if (messagebox.activeInHierarchy == false)
		{
			messagebox.SetActive(true);
		}
		else
		{
			messagebox.SetActive(false);
		}
	}
}
