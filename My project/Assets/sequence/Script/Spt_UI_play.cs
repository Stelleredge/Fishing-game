using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Spt_UI_play : Button
{
    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        //start the game
        GameManager.instance.Startgame();
        //
        gameObject.SetActive(false);
    }
}
