using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class toggle_showTooltipInCenterOfObject : MonoBehaviour 
{
	Toggle toggle;
	// Use this for initialization
	void Start () 
	{
		toggle = GetComponent<Toggle> ();
		toggle.onValueChanged.AddListener(ValueChanged);
	}
	
	void ValueChanged(bool value)
	{
		TooltipSetup.instance.showTooltipInCenterOfObject = value;
	}
}
