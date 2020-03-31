using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksLoader : MonoBehaviour
{

    PaletteController pc;

    // Start is called before the first frame update
    void Start()
    {
        pc = GetComponent<PaletteController>();

        string topic = PlayerPrefs.GetString("TOPIC");
        string level = PlayerPrefs.GetString("LEVEL");

        List<BlockType> types = BlockUnlockHelper.getUnlockedBlocks(topic, level);

        foreach (BlockType b in types)
        {
            pc.addBlock(BlockUnlockHelper.getCategory(b), BlockUnlockHelper.getDraggablePrefab(b));
        }

        pc.int_variable_template = BlockUnlockHelper.getDraggablePrefab(BlockType.INT_VAR);
        pc.string_variable_template = BlockUnlockHelper.getDraggablePrefab(BlockType.STRING_VAR);
        pc.float_variable_template = BlockUnlockHelper.getDraggablePrefab(BlockType.FLOAT_VAR);

        pc.setCurrentCategory(0);

        pc.refresh();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
