using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

public class Strings
{

    static Dictionary<string, Dictionary<string, string>> strings = new Dictionary<string, Dictionary<string, string>>()
    {
        {"0_PLAY", new Dictionary<string, string>()
        {
            { "ENG", "Play"},
            { "ESP", "Jugar"}
        } },
        {"0_OPTIONS", new Dictionary<string, string>()
        {
            { "ENG", "Options"},
            { "ESP", "Opciones"}
        } },
        {"0_TRAINING", new Dictionary<string, string>()
        {
            { "ENG", "Training mode"},
            { "ESP", "Modo de entrenemiento"}
        } },
        {"0_EXIT", new Dictionary<string, string>()
        {
            { "ENG", "Exit"},
            { "ESP", "Salir"}
        } },
        {"1_TITLE", new Dictionary<string, string>()
        {
            { "ENG", "Select topic"},
            { "ESP", "Selecciona el tema"}
        } },
        {"1_TOPIC1", new Dictionary<string, string>()
        {
            { "ENG", "Movement"},
            { "ESP", "Movimiento"}
        } },
        {"1_TOPIC2", new Dictionary<string, string>()
        {
            { "ENG", "Variables"},
            { "ESP", "Variables"}
        } },

        {"1_TOPIC3", new Dictionary<string, string>()
        {
            { "ENG", "Conditionals"},
            { "ESP", "Condicionales"}
        } },
        {"1_TOPIC4", new Dictionary<string, string>()
        {
            { "ENG", "Loops"},
            { "ESP", "Bucles"}
        } },
        {"1_TOPIC5", new Dictionary<string, string>()
        {
            { "ENG", "Functions"},
            { "ESP", "Funciones"}
        } },
        {"1_TOPIC6", new Dictionary<string, string>()
        {
            { "ENG", "Recursivity"},
            { "ESP", "Recursividad"}
        } },
        { "1_BACK", new Dictionary<string, string>()
        {
            { "ENG", "Back"},
            { "ESP", "Atrás"}
        } },
        {"2_TITLE", new Dictionary<string, string>()
        {
            { "ENG", "Select level"},
            { "ESP", "Selecciona el nivel"}
        } },
        {"BACK", new Dictionary<string, string>()
        {
            { "ENG", "Select level"},
            { "ESP", "Selecciona el nivel"}
        } },
    };
   
    public static string getString(string id, string language)
    {
        if (!strings.ContainsKey(id))
            return id;

        return strings[id][language];
    }
}
