using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {

    public List<Item> items = new List<Item>();

	// Use this for initialization
	void Start () {
        items.Add(new Item("Cambur", 0, "Primera Fruta",30,Item.ItemType.Consumable));
        items.Add(new Item("Cambur_Descompuesto", 1, "Segunda Fruta", 20, Item.ItemType.Rotten));
        items.Add(new Item("Manzana", 2, "Tercera Fruta", 50, Item.ItemType.Consumable));
		items.Add(new Item("Manzana_Descompuesta", 3, "Cuarta Fruta", 5, Item.ItemType.Rotten));
		items.Add(new Item("Chaqueta", 4, "Primer Equipo", 0, Item.ItemType.Chest));
		items.Add(new Item("Llave_Inglesa", 5, "Primera Herramienta", 0, Item.ItemType.Quest));
		items.Add(new Item("Botella", 6, "Segunda Herramienta", 0, Item.ItemType.Quest));
		items.Add(new Item("Destornillador", 7, "Tercera Herramienta", 0, Item.ItemType.Quest));
		items.Add(new Item("Hojas Sueltas", 8, "Cura Envenenamiento", 0, Item.ItemType.Consumable));
		items.Add(new Item("Llave", 9, "Abre la cerradura de un carro", 0, Item.ItemType.Quest));
		items.Add(new Item("Pumarosa", 10, "Quinta Fruta", 30, Item.ItemType.Rotten));
		items.Add(new Item("Maletin", 11, "Parece transportar algo adentro", 0, Item.ItemType.Quest));
		items.Add(new Item("Polvo de Hierbas", 12, "Cura heridas", 0, Item.ItemType.Consumable));
		items.Add(new Item("Pistola", 13, "Un arma disparada", 0, Item.ItemType.Quest));
		items.Add(new Item("Casquillos", 14, "Casquillos pertenecientes a un arma", 0, Item.ItemType.Quest));
		items.Add(new Item("Identificacion", 15, "Parece ser que es mi identificacion", 0, Item.ItemType.Quest));
		items.Add(new Item("Periodico", 16, "Contiene la foto del bosque Kanto", 0, Item.ItemType.Quest));
		items.Add(new Item("Mango", 17, "Sexta Fruta", 40, Item.ItemType.Consumable));
		items.Add(new Item("Ciruela", 18, "Septima Fruta", 20, Item.ItemType.Rotten));
		items.Add(new Item("Pumarosa", 19, "Octava Fruta", 40, Item.ItemType.Consumable));
		items.Add(new Item("Uvas", 20, "Novena Fruta", 50, Item.ItemType.Consumable));
		items.Add(new Item("Telefono", 21, "Parece tener muy poca bateria", 0, Item.ItemType.Quest));
		items.Add(new Item("Uvas", 22, "Decima Fruta", 40, Item.ItemType.Rotten));
		items.Add(new Item("Bolso", 23, "Segunda mejora en el bolso", 0, Item.ItemType.Chest));
		items.Add(new Item("Vara", 24, "Parece ser una herramienta util", 0, Item.ItemType.Quest));
		items.Add(new Item("Ciruela", 25, "Septima Fruta", 30, Item.ItemType.Consumable));
	}
}
