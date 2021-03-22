using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipComponent : MonoBehaviour
{
    public bool isActive;
    public string componentName;
    // Start is called before the first frame update
    public void toggleActive() { isActive = !isActive; }
}
