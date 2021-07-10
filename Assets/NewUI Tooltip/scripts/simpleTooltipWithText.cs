using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// Add this script to your tooltip gameObject to setup the GameObject containing the text for it.
/// </summary>
public class simpleTooltipWithText : MonoBehaviour 
{
	public Text text;
	public float maxWidth = 200f;
	public static float MaxWidth = 200f;
	public float padding = 5f;
	public static float Padding = 5f;

	void Awake()
	{
		MaxWidth = maxWidth;
		Padding = padding;
		text.rectTransform.anchoredPosition = new Vector2 (padding, -padding);
	}
}
