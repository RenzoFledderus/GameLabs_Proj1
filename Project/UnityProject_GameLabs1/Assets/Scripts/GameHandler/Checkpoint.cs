﻿using UnityEngine;
using System;
using System.Collections;

public class Checkpoint : MonoBehaviour {

    public CheckPointData thisCheckPoint;

    private void OnTriggerEnter(Collider x)
    {
        if (x.transform.tag == "Player")
            SaveProgress();
    }

    private void SaveProgress()
    {
        GameHandler.savedData.level = thisCheckPoint.checkPoint;
        GameHandler.savedData.level = thisCheckPoint.level;
    }

    [Serializable]
    public class CheckPointData
    {
        public int level = 1;
        public int checkPoint = 1;
    }
}