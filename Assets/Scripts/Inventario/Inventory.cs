using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

	public List<GameObject> Slots = new List<GameObject> ();
	public List<Item> Items = new List<Item>();
	ItemDatabase database;
    public GameObject slots;
    
	public GameObject tooltip;

	public void showTooltip(Vector3 toolPosition, Item item){
		tooltip.SetActive (true);
		tooltip.GetComponent<RectTransform> ().localPosition = new Vector3 (toolPosition.x + 480, toolPosition.y, toolPosition.z);
		tooltip.transform.GetChild (0).GetComponent<Text> ().text = item.itemName;
		//tooltip.transform.GetChild (1).GetComponent<Text> ().text = item.itemEnergy;
		tooltip.transform.GetChild (2).GetComponent<Text> ().text = item.itemDesc;
	}

	public void closeTooltip(){
		tooltip.SetActive (false);
	}
	// Use this for initialization
	void Start () {
		int slotMount = 0;
		database = GameObject.FindGameObjectWithTag ("ItemDatabase").GetComponent<ItemDatabase> ();

		int x = -150;
		int y = 55;

        for (int i = 0; i < 3; i++) {
            for (int k = 0; k < 3; k++) {
                GameObject slot = (GameObject)Instantiate(slots);
				slot.GetComponent<SlotScript>().slotNumber = slotMount;
				Slots.Add(slot);
				Items.Add(new Item());
                slot.transform.SetParent(this.gameObject.transform);
                slot.name = "Slot" + i + "." + k;
                slot.GetComponent<RectTransform>().localPosition = new Vector3(x, y, 0);
                x = x + 55;
                if (k == 2) {
                    x = -150;
                    y = y - 55;
                }
				slotMount++;
            }
        }
	}	

	public void addItem(int id){
		for (int i = 0; i < database.items.Count; i++) {
			//Dara problemas cuando tenga una fruta guardada en el inventario
			//Quizas eliminar el IF solucione el problema
			if (database.items[i].itemID == id) {
				Item item = database.items[i];
				addItemAtEmptySlot(item);
				break;
			}
		}
	}

	void addItemAtEmptySlot(Item item){
		for (int i = 0; i < Items.Count; i++) {
			if (Items[i].itemName == null) {
				Items[i] = item;
				break;
			}
		}
	}
}
