using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SlotScript : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler {

    public Item item;
    Image itemImage;
	public int slotNumber;
	Inventory inventory;

	// Use this for initialization
	void Start () {
		inventory = GameObject.FindGameObjectWithTag ("Inventory").GetComponent<Inventory> ();
        itemImage = gameObject.transform.GetChild(0).GetComponent<Image>();
		//Debug.Log (itemImage.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
	    if (inventory.Items[slotNumber].itemName != null) {
            itemImage.gameObject.SetActive(true);
			itemImage.sprite = inventory.Items[slotNumber].itemIcon;
        } else {
			itemImage.gameObject.SetActive(false);
        }
	}

	public void OnPointerDown(PointerEventData data) {
		GameMaster.instance.varEnergiaMaxima = GameMaster.instance.varEnergiaMaxima + inventory.Items[slotNumber].itemEnergy;
		if (inventory.Items [slotNumber].itemID == 0) {
			GameMaster.instance.varEnvenamiento = 0.05f;
			GameMaster.instance.goTextoDescrip.GetComponent<Text> ().color = Color.green;
		} else {
			GameMaster.instance.varEnvenamiento = 0f;
			GameMaster.instance.goTextoDescrip.GetComponent<Text> ().color = Color.white;
		}
		if (inventory.Items [slotNumber].itemID == 0 && GameMaster.instance.varInCar == true) {
			Debug.Log("pasando");
		}
		Debug.Log (GameMaster.instance.varEnergiaMaxima);
		inventory.Items [slotNumber].itemName = null;
		inventory.Items [slotNumber].itemID = 0;
		inventory.Items [slotNumber].itemEnergy = 0;
		inventory.Items [slotNumber].itemDesc = null;

	}

	public void OnPointerEnter (PointerEventData data) {
        if (inventory.Items[slotNumber].itemName != null){
			inventory.showTooltip(inventory.Slots[slotNumber].GetComponent<RectTransform>().localPosition, inventory.Items[slotNumber]);
		}
	}

	public void OnPointerExit (PointerEventData data) {
		if (inventory.Items [slotNumber].itemName != null) {
			inventory.closeTooltip ();
		}
	}
}