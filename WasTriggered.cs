using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WasTriggered : MonoBehaviour {
	public bool trigger {get; set;};
	
	void Awake() {
		trigger = true;
	}
}
