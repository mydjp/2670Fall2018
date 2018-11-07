
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{
	public ActionObject Action;
	private Text Label;
	public IntData number;

	private void Start()
	{
		Label = GetComponent<Text>();
		Label.text = number.Value.ToString();
		Action.Raise += RaiseHandler;
	}

	private void RaiseHandler()
	{
		number.Value++;
		Label.text = number.Value.ToString();
	}
}
