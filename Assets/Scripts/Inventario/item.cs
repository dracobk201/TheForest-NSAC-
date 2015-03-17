using UnityEngine;
using System.Collections;

public class Item{

	public string itemName;
	public int itemID;
	public string itemDesc;
	public Sprite itemIcon;
	public GameObject itemModel;
	public int itemEnergy;
	public ItemType itemType;

	public enum ItemType {                     
		Consumable,
		Rotten,
		Quest,
		Chest,
	}

	public Item (string name, int id, string desc, int energy, ItemType type) {
		itemName = name;
		itemID = id;
		itemDesc = desc;
		itemEnergy = energy;
		itemType = type;
		itemIcon = Resources.Load<Sprite> ("" + name);
	}

	public Item() {

	}
}
