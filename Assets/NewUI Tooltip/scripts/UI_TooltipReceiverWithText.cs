using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UI_TooltipReceiverWithText : UI_TooltipReceiver 
{
	[HideInInspector]
	/// <summary>
	/// The tooltip text object
	/// </summary>
	public static Text textObject = null;
	[Multiline]
	public string text;


	public override void OnPointerEnter(PointerEventData data)
	{ 
		if (UITooltipObject.GetComponent<simpleTooltipWithText>() &&
		    UITooltipObject.GetComponent<simpleTooltipWithText>().text != textObject) 
		{
			textObject = UITooltipObject.GetComponent<simpleTooltipWithText>().text;
		}

		if (textObject) 
		{
			textObject.text = text;
			ResizeBackgroundImageWidthToText();
		}
		//base.OnPointerEnter (data);
		ShowTooltip(true, data);

		if (textObject) 
		{
			ResizeBackgroundImageHeightToText();
		}

		UpdateTooltipPosition(data);
	}


	/// <summary>
	/// separate the code for resizing width and height to give unity time to properly calculate the preferredHeight
	/// </summary>
	public void ResizeBackgroundImageWidthToText()
	{
		textObject.CalculateLayoutInputHorizontal();

		float textWidthSize = textObject.preferredWidth;
		if (textWidthSize > simpleTooltipWithText.MaxWidth)
			textWidthSize = simpleTooltipWithText.MaxWidth;

		textObject.rectTransform.sizeDelta = new Vector2(textWidthSize, textObject.rectTransform.sizeDelta.y);
		UITooltipObject.GetComponent<RectTransform>().sizeDelta = 
			new Vector2(textObject.rectTransform.sizeDelta.x + simpleTooltipWithText.Padding*2, 
			            textObject.rectTransform.sizeDelta.y + simpleTooltipWithText.Padding*2);
	}

	public void ResizeBackgroundImageHeightToText()
	{
		float textHeightSize = textObject.preferredHeight;
		textObject.rectTransform.sizeDelta = new Vector2(textObject.rectTransform.sizeDelta.x, textHeightSize);
		UITooltipObject.GetComponent<RectTransform>().sizeDelta = 
			new Vector2(textObject.rectTransform.sizeDelta.x + simpleTooltipWithText.Padding*2, 
			            textObject.rectTransform.sizeDelta.y + simpleTooltipWithText.Padding*2);
	}
}
