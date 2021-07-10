using UnityEngine;
using System.Collections;

/// <summary>
/// This class is used to set the tooltip GameObject
/// </summary>
public class TooltipSetup : MonoBehaviour 
{
	/// <summary>
	/// Retrieve the Canvas to display the tooltip on and calulate it's boundary
	/// to properly place the tooltip within the screen area
	/// </summary>
	public Canvas canvasObject;

	public bool showTooltipInCenterOfObject = true;


	public static TooltipSetup instance;
	[SerializeField]
	private RectTransform tooltipObject;


	public static RectTransform TooltipObject
	{
		get
		{
			return instance.tooltipObject;
		}
		set
		{
			instance.tooltipObject = value;
			InitializeTooltip(instance.tooltipObject);
		}
	}


	// Use this for initialization
	void Awake ()
	{
		instance = this;

		if (tooltipObject != null) 
		{
			InitializeTooltip(tooltipObject);
		}
	}


	protected static void InitializeTooltip(RectTransform tooltipObject)
	{
		UI_TooltipReceiver.UITooltipObject = tooltipObject;
		
		//set a CanvasGroup to the new tooltip if there is none
		if (!tooltipObject.GetComponent<CanvasGroup>())
		{
			CanvasGroup group = tooltipObject.gameObject.AddComponent<CanvasGroup>();
			group.blocksRaycasts = false;
			group.interactable = false;
		}

		//set tooltip pivot to top left
		tooltipObject.pivot = new Vector2(0f, 1f);
		tooltipObject.gameObject.SetActive (false);
		
		//Set the text object in UI_TooltipReceiverWithText script
		if (tooltipObject.GetComponent<simpleTooltipWithText>() != null)
			UI_TooltipReceiverWithText.textObject = UI_TooltipReceiver.UITooltipObject.GetComponent<simpleTooltipWithText>().text;
		else
			UI_TooltipReceiverWithText.textObject = null;
	}
}
