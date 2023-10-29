using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerCam : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera forward;
	[SerializeField] CinemachineVirtualCamera backward;
	
	private void OnEnable()
	{
		CamSwitcher.Register(forward);
		CamSwitcher.Register(backward);
		CamSwitcher.SwitchCamera(forward);
	}
	
	private void OnDisable()
	{
		CamSwitcher.Unregister(forward);
		CamSwitcher.Unregister(backward);
	}
	
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			print("Cam switch requested");
			if(CamSwitcher.IsActiveCamera(forward))
			{
				print("Switching to Back Cam");
				CamSwitcher.SwitchCamera(backward);
			}
			else if(CamSwitcher.IsActiveCamera(backward))
			{
				print("Switching to Front Cam");
				CamSwitcher.SwitchCamera(forward);
			}
		}
	}
}
