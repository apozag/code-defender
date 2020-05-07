using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueGap : VariableGap {

	// Use this for initialization
	new void Start () {
        base.Start();
        allowedTypes.Add((int)BlockType.SUM);
        allowedTypes.Add((int)BlockType.SUBS);
        allowedTypes.Add((int)BlockType.MULT);
        allowedTypes.Add((int)BlockType.DIV);
        allowedTypes.Add((int)BlockType.RANDOM);
        allowedTypes.Add((int)BlockType.FUNCTION_RETURN_CALL);
	}

}
