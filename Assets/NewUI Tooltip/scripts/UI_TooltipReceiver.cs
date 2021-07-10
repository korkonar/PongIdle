using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

/// <summary>
/// Add this script to any UI gameObject to display a chosen UI tooltip
/// </summary>
public class UI_TooltipReceiver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	public static RectTransform UITooltipObject;

	
	protected void ShowTooltip(bool show, PointerEventData data)
	{
		if (UITooltipObject != null) 
		{
			/*if (show)
			{
				UpdateTooltipPosition(data);
			}*/

			SetActive(show);
			UITooltipObject.gameObject.GetComponent<CanvasGroup>().blocksRaycasts = false;
		}
	}


	public virtual void OnPointerEnter(PointerEventData data)
	{
		if (!data.dragging)
		{
			ShowTooltip (true, data);
			UpdateTooltipPosition(data);
		}
	}


	public virtual void OnPointerExit(PointerEventData data)
	{
		ShowTooltip(false, data);
	}


	public static void SetActive(bool show)
	{
		UITooltipObject.gameObject.SetActive(show);
	}
	

	protected virtual void UpdateTooltipPosition(PointerEventData data)
	{
		Vector3 globalMousePos = Vector3.zero;

		RectTransformUtility.ScreenPointToWorldPointInRectangle(
			data.pointerCurrentRaycast.gameObject.GetComponent<RectTransform>(),
			data.position, data.enterEventCamera, out globalMousePos);

		if(globalMousePos.x +UITooltipObject.rect.width>1100)globalMousePos.x=1100-UITooltipObject.rect.width;
		if(globalMousePos.y -UITooltipObject.rect.height<0)globalMousePos.y=0+UITooltipObject.rect.height;

		UITooltipObject.position = globalMousePos;

		//print(globalMousePos);

		//bool showTooltipInCenterOfObject = TooltipSetup.instance.showTooltipInCenterOfObject;
		//RectTransform selectedObjectRectTrans = GetComponent<RectTransform>();
		//Rect SelectedRect = selectedObjectRectTrans.rect;

		/*
		Vector3 SelectedLocalPos = new Vector3(selectedObjectRectTrans.transform.localPosition.x,
		                                       selectedObjectRectTrans.transform.localPosition.y, 0);


		if (!showTooltipInCenterOfObject)
		{
			UITooltipObject.localPosition = SelectedLocalPos + new Vector3 (SelectedRect.width / 2, SelectedRect.height / 2, 0);
		} 
		else
			UITooltipObject.localPosition = SelectedLocalPos;

		

		#region reposition tooltip if out of screen
		Rect TooltipRect = UITooltipObject.rect;
		Vector2 tooltipPosToAnchor = UITooltipObject.anchoredPosition;

		Rect CanvasRect = TooltipSetup.instance.canvasObject.pixelRect;
		Vector3 CanvasPosition = TooltipSetup.instance.canvasObject.transform.position;;


		if (UITooltipObject.anchoredPosition.x + TooltipRect.width > CanvasRect.width) 
		{
			if (showTooltipInCenterOfObject)
			{
				UITooltipObject.localPosition -= new Vector3 (TooltipRect.width , 0, 0);
			}
			else{
				UITooltipObject.localPosition =  globalMousePos + new Vector3 (- (SelectedRect.width/2) - TooltipRect.width, SelectedRect.height / 2, 0);
				//UITooltipObject.localPosition =  SelectedLocalPos + new Vector3 (- (SelectedRect.width/2) - TooltipRect.width, SelectedRect.height / 2, 0);
			}
		}


		if (TooltipRect.height - UITooltipObject.anchoredPosition.y > CanvasRect.height) 
		{
			if (showTooltipInCenterOfObject)
			{
				UITooltipObject.localPosition += new Vector3 (0, TooltipRect.height , 0);
			}
			else
				UITooltipObject.anchoredPosition = 
					new Vector2 (UITooltipObject.anchoredPosition.x, - (CanvasRect.height - TooltipRect.height));
		}

		#endregion
		*/
	}

	
}