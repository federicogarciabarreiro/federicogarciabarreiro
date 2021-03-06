using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITimeSlowable {

    void SlowDown(int xTimes);
    void Reset();

    Transform GetTransform();
}
