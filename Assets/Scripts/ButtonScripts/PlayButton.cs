﻿
/***********************************************************************************************************
 * Produced by App Advisory - http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/




using UnityEngine;
using System.Collections;

namespace AppAdvisory.MathGame
{
	public class PlayButton : ButtonHelper
	{
		override public void OnClicked()
		{
			
//#if UNITY_EDITOR
//			menuManager.GoToGame();
//			RemoveListener();
//			return;
//#endif
			if (KinetManager.Instance.CheckIsPlayable() )
			{
				menuManager.GoToGame();
				RemoveListener();
			}
		}
	}
}