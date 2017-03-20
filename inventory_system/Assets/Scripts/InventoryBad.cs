using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBad {

    /// <summary>
    /// Deze method hanteert niet de open/closed principe
    /// aangezien hij NIET open is voor uitbreiding
    /// en ook NIET gesloten is voor verandering
    /// Deze class is specifiek voor een project
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public string GetItem(string type)
    {
        var currentItem = "";
        switch (type)
        {
            case "rock":
                currentItem = "rock instance";
                break;
            case "spoon":
                currentItem = "spoon instance";
                break;
            case "chair":
                currentItem = "chair instance";
                break;
            case "table":
                currentItem = "table instance";
                break;
            case "cup":
                currentItem = "cup instance";
                break;
        }
        currentItem = currentItem.Substring(1);
        return currentItem;
    }

}
