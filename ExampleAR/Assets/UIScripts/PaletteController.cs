using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaletteController : MonoBehaviour {

    public VerticalLayoutGroup vlg;


    List<GameObject> structure;
    List<GameObject> loops;
    List<GameObject> variables;
    List<GameObject> movement;
    List<GameObject> comparison;
    List<GameObject> operations;
    List<GameObject> branch;

    public GameObject int_variable_template;
    public GameObject string_variable_template;
    public GameObject float_variable_template;

    CodePanelController cpc;

    int currentCategory;

	// Use this for initialization
	void Start () {
        cpc = FindObjectOfType<CodePanelController>();
        structure = new List<GameObject>();
        loops = new List<GameObject>();
        variables = new List<GameObject>();
        movement = new List<GameObject>();
        comparison = new List<GameObject>();
        operations = new List<GameObject>();
        branch = new List<GameObject>();

        currentCategory = 0;

        refresh();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void loadBlocks(int category){

        currentCategory = category;

        foreach (Transform child in vlg.transform)
        {
            Destroy(child.gameObject);
        }  

        switch (category)
        {
            case 0:
                foreach (GameObject go in structure)
                {
                    GameObject g = Instantiate(go);
                    g.transform.SetParent(vlg.transform);
                    g.transform.localScale = new Vector2(1, 1);
                }
                break;

            case 1:
                foreach (GameObject go in loops)
                {
                    GameObject g = Instantiate(go);
                    g.transform.SetParent(vlg.transform);
                    g.transform.localScale = new Vector2(1, 1);
                }
                break;

            case 2:
                List<Variable<int>> varsInt = cpc.getIntVariables();
                List<Variable<string>> varsString = cpc.getStringVariables();
                List<Variable<float>> varsFloat = cpc.getFloatVariables();

                for(int i = 0; i < varsInt.Count; i++)
                {
                    GameObject newvar = Instantiate(int_variable_template);
                    newvar.GetComponentInChildren<Text>().text = varsInt[i].name;
                    newvar.transform.SetParent(vlg.transform);
                    newvar.transform.localScale = new Vector2(1, 1);

                }

                for (int i = 0; i < varsString.Count; i++)
                {
                    GameObject newvar = Instantiate(string_variable_template);
                    newvar.GetComponentInChildren<Text>().text = varsString[i].name;
                    newvar.transform.SetParent(vlg.transform);
                    newvar.transform.localScale = new Vector2(1, 1);

                }

                for (int i = 0; i < varsFloat.Count; i++)
                {
                    GameObject newvar = Instantiate(float_variable_template);
                    newvar.GetComponentInChildren<Text>().text = varsFloat[i].name;
                    newvar.transform.SetParent(vlg.transform);
                    newvar.transform.localScale = new Vector2(1, 1);

                }

                foreach (GameObject go in variables)
                {
                    GameObject g = Instantiate(go);
                    g.transform.SetParent(vlg.transform);
                    g.transform.localScale = new Vector2(1, 1);
                }
                break;

            case 3:
                foreach (GameObject go in movement)
                {
                    GameObject g = Instantiate(go);
                    g.transform.SetParent(vlg.transform);
                    g.transform.localScale = new Vector2(1, 1);
                }
                break;

            case 4:
                foreach (GameObject go in comparison)
                {
                    GameObject g = Instantiate(go);
                    g.transform.SetParent(vlg.transform);
                    g.transform.localScale = new Vector2(1, 1);
                }
                break;

            case 5:
                foreach (GameObject go in operations)
                {
                    GameObject g = Instantiate(go);
                    g.transform.SetParent(vlg.transform);
                    g.transform.localScale = new Vector2(1, 1);
                }
                break;

            case 6:
                foreach (GameObject go in branch)
                {
                    GameObject g = Instantiate(go);
                    g.transform.SetParent(vlg.transform);
                    g.transform.localScale = new Vector2(1, 1);
                }
                break;

            default:
                return;
        }

    }

    public void addBlock(int category, GameObject go)
    {
        switch (category)
        {
            case 0:
                structure.Add(go);
                break;
            case 1:
                loops.Add(go);
                break;
            case 2:
                variables.Add(go);
                break;
            case 3:
                movement.Add(go);
                break;
            case 4:
                comparison.Add(go);
                break;
            case 5:
                operations.Add(go);
                break;
            case 6:
                branch.Add(go);
                break;
        }
    }

    public void setCurrentCategory(int category)
    {
        currentCategory = category;
    }

    public void refresh()
    {
        loadBlocks(currentCategory);
    }
}


