using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractMode : MonoBehaviour {
    FlexibleMusicManager fmm;
	// Use this for initialization
	void Start () {
        fmm = FindObjectOfType<FlexibleMusicManager>();

	}
	
	// Update is called once per frame
	void Update () {
        if (fmm && fmm.CurrentTrackNumber() > 0) {
            fmm.repeat = true;
        }
	}
}
