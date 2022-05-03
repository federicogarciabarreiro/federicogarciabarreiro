﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBreakable {

    void Break();
    void SwitchBreakableState(bool state);
}
