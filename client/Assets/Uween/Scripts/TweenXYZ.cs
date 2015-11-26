﻿using UnityEngine;

namespace Uween
{

public class TweenXYZ : TweenVec3P
{
    public static TweenXYZ Add(GameObject g, float duration, Vector3 to)
    {
        return Add<TweenXYZ>(g, duration, to);
    }
    
    public static TweenXYZ Add(GameObject g, float duration, float toX, float toY, float toZ)
    {
        return Add<TweenXYZ>(g, duration, toX, toY, toZ);
    }
    
    override public Vector3 value
    {
        get
        {
            return vector;
        }
        set
        {
            vector = value;
        }
    }
}

}
