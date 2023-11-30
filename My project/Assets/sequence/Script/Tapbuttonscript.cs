using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Tapbuttonscript : Button
{
    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);

        ///gamemanager should start the game
        GameManager.instance.StartGame();

        ///diactivate the start panel
        gameObject.SetActive(false);
    }
}
