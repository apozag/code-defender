using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Localization
{

    static readonly Dictionary<string, Dictionary<string, string>> strings;

    static Localization()
    {
        strings = new Dictionary<string, Dictionary<string, string>>()
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
            {"2_LOADING", new Dictionary<string, string>()
            {
                {"ENG", "Loading..." },
                {"ESP", "Cargando..." }
            } },

            {"5_OPTIONS", new Dictionary<string, string>()
            {
                {"ENG", "Options" },
                {"ESP", "Opciones" }
            } },
            {"Opciones", new Dictionary<string, string>()
            {
                {"ENG", "Options" },
            } },
            {"Options", new Dictionary<string, string>()
            {
                {"ESP", "Opciones" }
            } },
            {"Atrás", new Dictionary<string, string>()
            {
                {"ENG", "Back" },
            } },
            {"Back", new Dictionary<string, string>()
            {
                {"ESP", "Atrás" }
            } },

            {"3_ENTER_VARNAME" , new Dictionary<string, string>(){
                {"ENG", "Write a name for the new variable" },
                {"ESP", "Escribe un nombre para la nueva variable" }
            } },
             {"3_BASIC", new Dictionary<string, string>()
            {
                { "ENG", "Basic"},
                { "ESP", "Báscos"}
            } },
            {"3_ACTIONS", new Dictionary<string, string>()
            {
                { "ENG", "Actions"},
                { "ESP", "Acciones"}
            } },
             {"3_VARIABLES", new Dictionary<string, string>()
            {
                { "ENG", "Variables"},
                { "ESP", "Variables"}
            } },
              {"3_LOOPS", new Dictionary<string, string>()
            {
                { "ENG", "Loops"},
                { "ESP", "Bucles"}
            } },
               {"3_CONDITIONS", new Dictionary<string, string>()
            {
                { "ENG", "Conditions"},
                { "ESP", "Condiciones"}
            } },
                {"3_OPERATIONS", new Dictionary<string, string>()
            {
                { "ENG", "Operations"},
                { "ESP", "Operaciones"}
            } },
            {"3_BRANCH", new Dictionary<string, string>()
            {
                { "ENG", "Branch"},
                { "ESP", "Ramificación"}
            } },

            {"MON_1", new Dictionary<string, string>()
            {
                { "ENG", "Greetings human! My name is Bytey. I´m nothing less than the antivirus of your phone."},
                { "ESP", "¡Saludos humano! Mi nombre es Bytey. Soy nada menos que el antivirus de tu móvil"}
            } },
             {"MON_2", new Dictionary<string, string>()
            {
                { "ENG", "And not junt any antivirus... A talking one! How cool is that?"},
                { "ESP", "Y no cualquier antivirus... ¡Uno que habla! ¿Que te parece?"}
            } },
              {"MON_3", new Dictionary<string, string>()
            {
                { "ENG", "We´ll have time to konow each other better. Don´t get me wrong, but there´s an emergency I have te take care of with your help."},
                { "ESP", "Ya tendremos tiempo de conocernos más a fondo. No te lo tomes a mal, pero hay una emergencia que tengo que resolver cuanto antes con tu ayuda."}
            } },
               {"MON_4", new Dictionary<string, string>()
            {
                { "ENG", "It´s about a computer virus that sneaked into your phone and could be dangerous if we don´t eliminate it."},
                { "ESP", "Se trata de un virus informático que se ha colado en tu dispositivo y podría ser dañino si no lo eliminamos."}
            } },
            {"MON_5", new Dictionary<string, string>()
            {
                { "ENG", "I know I am the antivirus and it´s my job... but... it turns out that my developers didn´t quite finished me entirely."},
                { "ESP", "Sé que yo soy el antivirus y es mi trabajo... pero... resulta que mis desarrolladores me han dejado a medio acabar."}
            } },
            {"MON_6", new Dictionary<string, string>()
            {
                { "ENG", "That´s where you come into play! You´re going to help me do my job by programming in the Java programming language."},
                { "ESP", "Ahí es donde entras tú, me vas a ayudar a hacer mi trabajo programando en el lenguaje de programación Java."}
            } },
            {"MON_7", new Dictionary<string, string>()
            {
                { "ENG", "Don´t look at me like that! I´s not that bad!"},
                { "ESP", "¡No me mires así! ¡No es para tanto! Yo te ayudaré a aprender poco a poco."}
            } },
            {"MON_8", new Dictionary<string, string>()
            {
                { "ENG", "In order for you seewhats going on inside your phone, I will turn on the camera and display my surroundings with AUGMENTED REALITY."},
                { "ESP", "Para que puedas ver lo que pasa dentro de tu móvil, encenderé la cámara y proyectaré en REALIDAD AUMENTADA mis alrededores."}
            } },
            { "MON_9", new Dictionary<string, string>()
            {
                { "ENG", "Don´t worry, I didn´t know what augmented reality was either until recently. You´re gonna like it."},
                { "ESP", "No te preocupes, yo tampoco sabía lo que era la realidad aumentada hasta hace poco. Te va a gustar."}
            } },
            { "MON_10", new Dictionary<string, string>()
            {
                { "ENG", "Let´s get started!"},
                { "ESP", "¡Vamos a ello!"}
            } },
            {"TUT_1_1_0", new Dictionary<string, string>()
            {
                { "ENG", "Press to lift panel" },
                { "ESP", "Pulsa para subir el panel" }

            } },
            {"TUT_1_1_1", new Dictionary<string, string>()
            {
                { "ENG", "Go to the Action category" },
                { "ESP", "Ve a la categoría de Acción" }

            } },
             {"TUT_1_1_2", new Dictionary<string, string>()
            {
                { "ENG", "Drag the block to a blank space" },
                { "ESP", "Arrastra el bloque hasta un hueco en blanco" }

            } },
             {"TUT_1_1_3", new Dictionary<string, string>()
            {
                { "ENG", "Press to execute your code" },
                { "ESP", "Pulsa para ejecutar el código" }

            } },
            {"CONTINUE", new Dictionary<string, string>()
            {
                { "ENG", "Continue" },
                { "ESP", "Continuar" }

            } },

            {"3_WIN", new Dictionary<string, string>()
            {
                {"ENG", "Level complete!" },
                {"ESP", "Nivel superado!" }
            } },
             {"3_WIN_RETRY", new Dictionary<string, string>()
            {
                {"ENG", "Retry" },
                {"ESP", "Reintentar" }
            } },
              {"3_WIN_CONTINUE", new Dictionary<string, string>()
            {
                {"ENG", "Continue" },
                {"ESP", "Continuar" }
            } },

            {"TST_NOT_BELONG", new Dictionary<string, string>()
            {
                {"ENG", "This block doesn't belong there." },
                {"ESP", "Este bloque no se puede colocar aquí"}
            } },
            {"TST_GAP_EMPTY", new Dictionary<string, string>()
            {
                {"ENG", "There can´t be any empy gaps." },
                {"ESP", "No puede haber bloques vacíos."}
            } },
            {"TST_NOT_COMPATIBLE_INT", new Dictionary<string, string>()
            {
                {"ENG", "Data type not compatible with int" },
                {"ESP", "Tipo de dato no compatible con int"}
            } },
            {"TST_NOT_COMPATIBLE_STRING", new Dictionary<string, string>()
            {
                {"ENG", "Data type not compatible with string" },
                {"ESP", "Tipo de dato no compatible con string"}
            } },
            {"TST_NOT_COMPATIBLE_FLOAT", new Dictionary<string, string>()
            {
                {"ENG", "Data type not compatible with float" },
                {"ESP", "Tipo de dato no compatible con float"}
            } },
            {"TST_WAIT_APPEAR", new Dictionary<string, string>()
            {
                {"ENG", "Wait for the world scene to appear to execute the code." },
                {"ESP", "Espera a que aparezca el escenario para ejecutar el código."}
            } },
             {"TST_WAIT_END", new Dictionary<string, string>()
            {
                {"ENG", "You have to wait or stop the execution to try again." },
                {"ESP", "Debes esperar o parar la ejecución para volver a intentarlo."}
            } },
              {"TST_NO_RECURSION", new Dictionary<string, string>()
            {
                {"ENG", "¡You called \"aux\" inside the function itself!\nThis is a thing, but we better leave it for the next topic."},
                {"ESP", "¡Has llamado a \"aux\" dentro de la misma función!\nEsto se puede hacer, pero mejor lo dejamos para el siguiente tema"}   
            } },
            {"TST_TOO_MANY_CALLS", new Dictionary<string, string>()
            {
                {"ENG", "Too many recursive calls!"},
                {"ESP", "¡Demasiadas llamadas recursivas!"}
            } },
            {"TST_INFINITE_LOOP", new Dictionary<string, string>()
            {
                {"ENG", "You made an infinite loop or with too may iterations!"},
                {"ESP", "¡Has hecho un bucle infinito o con demasiadas iteraciones!"}
            } },
             {"TST_ARRAY_INDEX_OUT", new Dictionary<string, string>()
            {
                {"ENG", "The index is higher than the array size!"},
                {"ESP", "¡El indice es más grande que el tamaño del array!"}
            } },
             {"TST_ENTRYPOINT_NOT_FOUND", new Dictionary<string, string>()
            {
                {"ENG", "Entry point (main function) not found."},
                {"ESP", "No se encontró punto de entrada (función main)."}
            } },
              {"TST_INCORRECT_DATA", new Dictionary<string, string>()
            {
                {"ENG", "Incorrect data type."},
                {"ESP", "Tipo de dato incorrecto."}
            } },
               {"TST_STRING_COMPARE_WITH", new Dictionary<string, string>()
            {
                {"ENG", "Strings cannot be compared with "},
                {"ESP", "No se puede compara string con "}
            } },
            {"TST_STRING_NOT_SUB", new Dictionary<string, string>()
            {
                {"ENG", "Strings cannot be subtracted."},
                {"ESP", "No se pueden restar dos string. "}
            } },
            {"TST_STRING_NOT_MULT", new Dictionary<string, string>()
            {
                {"ENG", "Strings cannot be multiplied."},
                {"ESP", "No se pueden multiplicar dos string. "}
            } },
            {"TST_STRING_NOT_DIV", new Dictionary<string, string>()
            {
                {"ENG", "Strings cannot be divided."},
                {"ESP", "No se pueden dividir dos string. "}
            } },
            {"TST_STRING_QUOTE", new Dictionary<string, string>()
            {
                {"ENG", "String values must be in quotation marks."},
                {"ESP", "un valore string debe ir entre comillas."}
            } },

            { "INF_99_99_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Training mode"},
                { "ESP", "Modo de entrenamiento"}
            } },
            { "INF_99_99_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Here you can experiment with the blocks you have unlocked."},
                { "ESP", "Aquí podrás experimentar con los bloques que hayas debloqueado."}
            } },

            { "INF_1_1_T_0", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo boque:"}
            } },
            { "INF_1_1_E_0", new Dictionary<string, string>()
            {
                { "ENG", "All code in Java must be contained inside a CLASS. The main class is called Main."},
                { "ESP", "Todo el cíódigo en Java debe estar recogido en una CLASE. La clase principal se llama Main."}
            } },
            { "INF_1_1_T_1", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_1_1_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Classes contain functions. Inside of them we will write the code that will be executed."},
                { "ESP", "Las clases contienen funciones. Dentro de ellas se escribe el código que se ejecutará"}
            } },
             { "INF_1_1_T_2", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo boque:"}
            } },
             { "INF_1_1_E_2", new Dictionary<string, string>()
            {
                { "ENG", "The main function is called main.\nWe´re going to put stuff in it!"},
                { "ESP", "La función principal se llama main.\n¡Vamos a meter cosas dentro!"}
            } },
             { "INF_1_1_T_3", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo boque:"}
            } },
              { "INF_1_1_E_3", new Dictionary<string, string>()
            {
                { "ENG", "It will make Bytey move one cell towards the direction he is facing."},
                { "ESP", "Hará avanzar a Bytey una casilla hacia donde esté mirando.\nCategoría: Acciones."}
            } },
              { "INF_1_1_T_4", new Dictionary<string, string>()
            {
                { "ENG", "Movement: level 1"},
                { "ESP", "Movimiento: nivel 1"}
            } },
            { "INF_1_1_E_4", new Dictionary<string, string>()
            {
                { "ENG", "Take Bytey to the yellow platform."},
                { "ESP", "Lleva a Bytey a la casilla amarilla."}
            } },

              { "INF_1_2_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Movement: level 2"},
                { "ESP", "Movimiento: nivel 2"}
            } },
            { "INF_1_2_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Take Bytey to the yellow platform."},
                { "ESP", "Lleva a Bytey a la casilla amarilla."}
            } },

            { "INF_1_2_T_1", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_1_2_E_1", new Dictionary<string, string>()
            {
                { "ENG", "It will make Bytey turn to his right. He will walk towards that direction now!"},
                { "ESP", "Hará girar a Bytey hacia su derecha. ¡Ahora avanzará para ese lado!\nCategoría: Movimiento."}
            } },
             { "INF_1_2_T_2", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_1_2_E_2", new Dictionary<string, string>()
            {
                { "ENG", "It will make Bytey turn to his left. He will walk towards that direction now!"},
                { "ESP", "Hará girar a Bytey hacia su izquierda. ¡Ahora avanzará para ese lado!\nCategoría: Movimiento."}
            } },
            { "INF_1_3_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Movement: level 3"},
                { "ESP", "Movimiento: nivel 3"}
            } },
            { "INF_1_3_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Eliminate the virus and get to the yellow platform."},
                { "ESP", "Elimina al virus y llega a la casilla amarilla."}
            } },
             { "INF_1_3_T_1", new Dictionary<string, string>()
            {
                { "ENG", "How to eliminate a virus"},
                { "ESP", "Cómo eliminar un virus"}
            } },
            { "INF_1_3_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Simply make Bytey go through it. He will take care of the rest!"},
                { "ESP", "Simplemente haz que Bytey pase por esa casilla. ¡El se encargará del resto!"}
            } },

             { "INF_1_4_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Movement: level 4"},
                { "ESP", "Movimiento: nivel 4"}
            } },
            { "INF_1_4_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Make Bytey say hi"},
                { "ESP", "Haz que Bytey diga hola"}
            } },

            { "INF_1_4_T_1", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_1_4_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Press the gap inside the parenthesis to write what you want Bytey to say."},
                { "ESP", "Pulsa el hueco entre paréntesis para escribir lo que quieres que diga bytey."}
            } },
            { "INF_1_4_T_2", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_1_4_E_2", new Dictionary<string, string>()
            {
                { "ENG", "You can find it in the Actions category."},
                { "ESP", "Puedes encontrarlo en la categoría de Acciones."}
            } },

            { "INF_1_5_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Movement: level 5"},
                { "ESP", "Movimiento: nivel 5"}
            } },
            { "INF_1_5_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Get to the yellow platform saying \"step\" every time Bytey takes a step."},
                { "ESP", "LLega a la casilla amarilla diciendo \"paso\" cada vez que Bytey de un paso."}
            } },

            { "INF_2_1_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Variables: level 1"},
                { "ESP", "Variables: nivel 1"}
            } },
            { "INF_2_1_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Create a varaiable and execute to check."},
                { "ESP", "Crea una variable y ejecuta par comprobar."}
            } },
             { "INF_2_1_T_1", new Dictionary<string, string>()
            {
                { "ENG", "What´s a variable?"},
                { "ESP", "¿Qué es una variable?"}
            } },
            { "INF_2_1_E_1", new Dictionary<string, string>()
            {
                { "ENG", "It´s represented by a namee and holds a value which can be used lated."},
                { "ESP", "se representa con un nombre y guarda un valor que se puede usar más tarde."}
            } },
            { "INF_2_1_T_2", new Dictionary<string, string>()
            {
                { "ENG", "What´s a variable?"},
                { "ESP", "¿Qué es una variable?"}
            } },
            { "INF_2_1_E_2", new Dictionary<string, string>()
            {
                { "ENG", "There are several types depending on what they contain. The ones we will be using are:"},
                { "ESP", "Pueden ser de varios tipos dependiendo de lo que contenga. Loa que vamos a utilizar nosotros son:"}
            } },
            { "INF_2_1_T_3", new Dictionary<string, string>()
            {
                { "ENG", "Variable types"},
                { "ESP", "Tipos de variable"}
            } },
            { "INF_2_1_E_3", new Dictionary<string, string>()
            {
                { "ENG", "int\t->\tnumber without decimals (integer)\nstring\t->\tcharacter string (text)\nfloat\t->\tnumber with decimals"},
                { "ESP", "int\t->\tnúmero sin decimales\nstring\t->\tcadena de caracteres (texto)\nfloat\t->\tnumero con decimales"}
            } },
            { "INF_2_1_T_4", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_2_1_E_4", new Dictionary<string, string>()
            {
                { "ENG", "Creates an integer variable. You can find it in the Variables category."},
                { "ESP", "Crea una variable de tipo int (número entero). Luego puedes encontrarla en Variables para usarla."}
            } },
            { "INF_2_1_T_5", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_2_1_E_5", new Dictionary<string, string>()
            {
                { "ENG", "Assigns a new value to the variable you place in the left gap."},
                { "ESP", "Asigna un nuevo valor a la variable que coloques a la izquierda."}
            } },

            { "INF_2_2_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Variables: level 2"},
                { "ESP", "Variables: level 2"}
            } },
            { "INF_2_2_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Assign the variable str1 to str2."},
                { "ESP", "Asigna la variable str1 a str2."}
            } },
            { "INF_2_2_T_1", new Dictionary<string, string>()
            {
                { "ENG", "About variables:"},
                { "ESP", "Sobre las variables:"}
            } },
            { "INF_2_2_E_1", new Dictionary<string, string>()
            {
                { "ENG", "The code is read from top to bottom so variables can´t be used before they are created."},
                { "ESP", "El código se lee de arriba a abajo, asique no se puede usar una variable antes de crearla."}
            } },
            { "INF_2_2_T_2", new Dictionary<string, string>()
            {
                { "ENG", "About variables:"},
                { "ESP", "Sobre las variables:"}
            } },
            { "INF_2_2_E_2", new Dictionary<string, string>()
            {
                { "ENG", "Variables can be assigned to one another while they are the same type (int, string, float...)"},
                { "ESP", "Se puede asignar el valor de una variable a otra siempre que  sean del mismo tipo. (int, string, float...)"}
            } },
            { "INF_2_2_T_3", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_2_2_E_3", new Dictionary<string, string>()
            {
                { "ENG", "creates a float variables (number with decimals)"},
                { "ESP", "Crea una variable de tipo float  (número con decimales)"}
            } },
            { "INF_2_2_T_4", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_2_2_E_4", new Dictionary<string, string>()
            {
                { "ENG", "creates a float variables (number with decimals)"},
                { "ESP", "Crea una variable de tipo string (texto).\n¡Su valor debe ir siempre netre comillas!"}
            } },

            { "INF_2_3_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Variables: level 3"},
                { "ESP", "Variables: nivel 3"}
            } },
            { "INF_2_3_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Calculate the sum of num1 and num2."},
                { "ESP", "calcula la suma de num1 y num2."}
            } },
            { "INF_2_3_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Operations"},
                { "ESP", "Operaciones"}
            } },
            { "INF_2_3_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Use operations to asign this sum to a new variable. Place a variable in each of the two gaps."},
                { "ESP", "Utiliza las operaciones para asignar a una nueva variable esta suma. Coloca en cada hueco de la operación una variable."}
            } },
            { "INF_2_3_T_2", new Dictionary<string, string>()
            {
                { "ENG", "Operate different variable types."},
                { "ESP", "Operar distintos tipos de variables."}
            } },
            { "INF_2_3_E_2", new Dictionary<string, string>()
            {
                { "ENG", "Only certain variable types can be operated with each other. You can experiment more with this in the traning mode."},
                { "ESP", "Sólo algunos tipos de variables se pueden operar entre sí. Puedes experimentar más con esto en el modo entrenamiento."}
            } },
            { "INF_2_3_T_3", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_2_3_E_3", new Dictionary<string, string>()
            {
                { "ENG", "You can find this and other operation blocks in the Operation category."},
                { "ESP", "Puedes encontrar éste y otros bloques de operación en la cartegoría de Operaciones."}
            } },

            { "INF_2_4_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Variables: level 4"},
                { "ESP", "Variables: nivel 4"}
            } },
            { "INF_2_4_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Calculate the average of the variables into a new variable. Make Bytey say the result."},
                { "ESP", "Calcula la media de las variables en una nueva variable. Haz que Bytey diga el resultado."}
            } },
            { "INF_2_4_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Arithmetic average"},
                { "ESP", "Media aritmética"}
            } },
            { "INF_2_4_E_1", new Dictionary<string, string>()
            {
                { "ENG", "How to calculate the average? Very easy: sum all of the values and divide it between the number of values you added."},
                { "ESP", "¿Que cómo se calcula la media? Muy fácil: suma todos los valores y divídelo entre el número de valores que has sumado."}
            } },

            { "INF_3_1_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Conditionals: level 1"},
                { "ESP", "Condicionales: nivel 1"}
            } },
            { "INF_3_1_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Take Bytey to the yellow platform."},
                { "ESP", "Haz que Bytey llegue a la casilla amarilla."}
            } },
            { "INF_3_1_T_1", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_3_1_E_1", new Dictionary<string, string>()
            {
                { "ENG", "The code inside the keys is only executed if the condition in the header gap is true."},
                { "ESP", "El código que haya dentro de las llaves sólo se ejecuta si la condición de la cabecera es verdadera."}
            } },
             { "INF_3_1_T_2", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_3_1_E_2", new Dictionary<string, string>()
            {
                { "ENG", "It´s true if both values are equal."},
                { "ESP", "Es verdadera si los dos datos son iguales."}
            } },
            { "INF_3_1_T_3", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_3_1_E_3", new Dictionary<string, string>()
            {
                { "ENG", "It´s true if both values are NOT equal."},
                { "ESP", "Es verdadera si los dos datos son distintos."}
            } },
            { "INF_3_1_T_4", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_3_1_E_4", new Dictionary<string, string>()
            {
                { "ENG", "You can find all the conditions in the Conditions category."},
                { "ESP", "Puedes encontrar todas las condicioens en la categoría de Condiciones"}
            } },

             { "INF_3_2_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Conditionals: level 2"},
                { "ESP", "Condicionales: nivel 2"}
            } },
            { "INF_3_2_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Eliminate the enemies and get to the yellow platform."},
                { "ESP", "Elimina a los enemigos y llega a la casilla amarilla."}
            } },
            { "INF_3_2_T_1", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque"}
            } },
            { "INF_3_2_E_1", new Dictionary<string, string>()
            {
                { "ENG", "It can be placed under un \"if\" or another \"else if\". If theupper conditions aren't true, this one gets checked."},
                { "ESP", "Se puede colocar debajo de un \"if\" u otro \"else if\". Si la condición de arriba no se cumple, se comprueba ésta."}
            } },

            { "INF_3_2_T_2", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque"}
            } },
            { "INF_3_2_E_2", new Dictionary<string, string>()
            {
                { "ENG", "It doesn´t depend on a condition. If none the upper conditions are true, the code inside of it gets executed."},
                { "ESP", "No depende de una condición, si la condición de arriba no se cumple, se ejecuta el código que tenga dentro."}
            } },

            { "INF_3_3_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Conditionals: level 3"},
                { "ESP", "Condicionales: nivel 3"}
            } },
            { "INF_3_3_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Eliminate the enemies and get to the yellow platform."},
                { "ESP", "Elimina a los enemigos y llega a la casilla amarilla."}
            } },
            { "INF_3_3_T_1", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_3_3_E_1", new Dictionary<string, string>()
            {
                { "ENG", "The logic AND (&&) is true ONLY IF both of the conditions on each side are true."},
                { "ESP", "El AND lógico (&&) es verdadero SOLO SI las dos condiciones a ambos lados son verdaderas."}
            } },
            { "INF_3_3_T_2", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_3_3_E_2", new Dictionary<string, string>()
            {
                { "ENG", "The logoc OR ( || ) is true if either one of the two conditions is true. It's false if both are false."},
                { "ESP", "El OR lógico ( || ) es verdadero si alguna de las dos condiciones es verdadera. Es falso si ninguna es verdadera."}
            } },
            { "INF_4_1_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Loops: level 1"},
                { "ESP", "Bucles: nivel 1"}
            } },
             { "INF_4_1_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Eliminate the enemies."},
                { "ESP", "Elimina a los enemigos."}
            } },
             { "INF_4_1_T_1", new Dictionary<string, string>()
            {
                { "ENG", "What's a loop?"},
                { "ESP", "¿Qué es un bucle?"}
            } },
            { "INF_4_1_E_1", new Dictionary<string, string>()
            {
                { "ENG", "It's a structure that repeats the code inside of it several times."},
                { "ESP", "Es una estructura que repite el código que contenga varias veces."}
            } },
             { "INF_4_1_T_2", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_4_1_E_2", new Dictionary<string, string>()
            {
                { "ENG", "Repeats the code it contains while condition inside the header is true."},
                { "ESP", "Repite el código que contiene mientras que se cumpla la condición de la cabecera."}
            } },
            { "INF_4_1_T_3", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_4_1_E_3", new Dictionary<string, string>()
            {
                { "ENG", "¡CAREFUL!\nIf the condition is always met, you will enter an infinite loop!"},
                { "ESP", "¡CUIDADO!\n¡Si la condición se cumple siempre, entrarás en un bucle infinito!"}
            } },

            { "INF_4_2_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Loops: level 1"},
                { "ESP", "Bucles: nivel 1"}
            } },
             { "INF_4_2_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Eliminate the enemies and get to the yellow platform."},
                { "ESP", "Elimina a los enemigos y llega la casilla amarilla."}
            } },
             { "INF_4_2_T_1", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
             { "INF_4_2_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Don't let its apearence scare you, the 'for' loop is easy to use and very useful."},
                { "ESP", "No te asustes por su apariencia, el bucle 'for' es facil de usar y muy útil."}
            } },
             { "INF_4_2_T_2", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
             { "INF_4_2_E_2", new Dictionary<string, string>()
            {
                { "ENG", "First, an integer variable is created. We will use it to count how many times the loop repeats itself."},
                { "ESP", "Primero se crea una variable de tipo int que servirá para contar las veces que se repite el bucle."}
            } },
             { "INF_4_2_T_3", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
             { "INF_4_2_E_3", new Dictionary<string, string>()
            {
                { "ENG", "The second thing is the condition that has to be met in order for the loop to repeat."},
                { "ESP", "Lo segundo es la condición que se tiene que cumplir para que se repita el bucle."}
            } },
              { "INF_4_2_T_4", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
             { "INF_4_2_E_4", new Dictionary<string, string>()
            {
                { "ENG", "The most common condition used is that the variable we created earlier has to be less than a maximum number."},
                { "ESP", "La condición que se suele poner es que la variable creada antes sea menor que un número máximo."}
            } },
             { "INF_4_2_T_5", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
             { "INF_4_2_E_5", new Dictionary<string, string>()
            {
                { "ENG", "the third thing is the increment. This means our variable is added 1 every time the loop repeats."},
                { "ESP", "Lo tercero es el incremento, es decir, indica que con cada vez que se repita el bucle, a la variable se le suma 1."}
            } },
              { "INF_4_2_T_6", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
             { "INF_4_2_E_6", new Dictionary<string, string>()
            {
                { "ENG", "This way we can control exactly how many times the loop will be repeated."},
                { "ESP", "De esta forma, podemos controlar exactamente cuántas veces se hará el bucle."}
            } },

             { "INF_4_3_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Loops: level 3"},
                { "ESP", "Bucles: nivel 3"}
            } },
             { "INF_4_3_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Eliminate the enemies and get to the yellow platform."},
                { "ESP", "Elimina a los enemigos y llega la casilla amarilla."}
            } },
             { "INF_4_3_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Nested loops"},
                { "ESP", "Bucles anidados"}
            } },
             { "INF_4_3_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Loops can be put inside other loops.\nAmazing right? Thats what we call nested loops."},
                { "ESP", "Los bucles se pueden meter unos dentro de otros.\n¿Increíble verdad? A ésto se le llama bucles anidados."}
            } },
             { "INF_4_3_T_2", new Dictionary<string, string>()
            {
                { "ENG", "Clue"},
                { "ESP", "Pista"}
            } },
             { "INF_4_3_E_2", new Dictionary<string, string>()
            {
                { "ENG", "Take a look at the pattern the enemy positions make."},
                { "ESP", "Fíjate bien en el patrón que siguen las posiciones de los enemigos."}
            } },
              { "INF_4_3_T_3", new Dictionary<string, string>()
            {
                { "ENG", "Clue"},
                { "ESP", "Pista"}
            } },
             { "INF_4_3_E_3", new Dictionary<string, string>()
            {
                { "ENG", "Maybe we cold use the outer loop to turn and the inner loop to move?"},
                { "ESP", "¿Quizás podríamos usar el bucle exterior para girar y el interior para avanzar?"}
            } },

             { "INF_4_4_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Loops: level 4"},
                { "ESP", "Bucles: nivel 4"}
            } },
             { "INF_4_4_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Eliminate the enemies and get to the yellow platform."},
                { "ESP", "Elimina a los enemigos y llega la casilla amarilla."}
            } },
              { "INF_4_4_T_1", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
             { "INF_4_4_E_1", new Dictionary<string, string>()
            {
                { "ENG", "The 'do while' loop is very similar to the 'while' loop."},
                { "ESP", "El bloque 'do while' es muy parecido al 'while'."}
            } },
             { "INF_4_4_T_2", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
             { "INF_4_4_E_2", new Dictionary<string, string>()
            {
                { "ENG", "The main difference is that the condition is at the end."},
                { "ESP", "La principal diferencia es qiue la condición está al final."}
            } },
              { "INF_4_4_T_3", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
             { "INF_4_4_E_3", new Dictionary<string, string>()
            {
                { "ENG", "This way, the first time the loop is executed, the condition is not taken into account"},
                { "ESP", "Por lo que la primera vez que se hace el bucle no se comprueba la condición."}
            } },

              { "INF_4_5_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Loops: level 5"},
                { "ESP", "Bucles: nivel 5"}
            } },
             { "INF_4_5_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Create an array with a size of 5."},
                { "ESP", "Crea un array de tamaño 5."}
            } },
              { "INF_4_5_T_1", new Dictionary<string, string>()
            {
                { "ENG", "What's an array?"},
                { "ESP", "¿Qué es un array?"}
            } },
             { "INF_4_5_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Is an ordered set of data of the same type."},
                { "ESP", "Es un conjunto ordenado de datos del mismo tipo."}
            } },
             { "INF_4_5_T_2", new Dictionary<string, string>()
            {
                { "ENG", "What's an array?"},
                { "ESP", "¿Qué es un array?"}
            } },
             { "INF_4_5_E_2", new Dictionary<string, string>()
            {
                { "ENG", "Arrays can contain any kind of data but we´ll only use int type."},
                { "ESP", "Se pueden hacer arrays de cualquier tipo de dato  pero nosotros utilizaremos de tipo int."}
            } },
             { "INF_4_5_T_3", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
             { "INF_4_5_E_3", new Dictionary<string, string>()
            {
                { "ENG", "Creates an array of int. Apart from the name, we also have to indicate the size (the amount of numbers it will store)"},
                { "ESP", "Crea un array de int. Aparte del nombre hay que indicar el tamaño (la cantidad de numeros que guarda)"}
            } },
              { "INF_4_5_T_4", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
             { "INF_4_5_E_4", new Dictionary<string, string>()
            {
                { "ENG", "You can find it in the Variables category."},
                { "ESP", "Puedes encontrarlo en la categoríoa de Variables."}
            } },


             { "INF_5_1_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Functions: level 1"},
                { "ESP", "Funciones: nivel 1"}
            } },
             { "INF_5_1_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Eliminate the enemies and get to the yellow platform."},
                { "ESP", "Elimina a los enemigos y llega la casilla amarilla."}
            } },
              { "INF_5_1_T_1", new Dictionary<string, string>()
            {
                { "ENG", "What's a function?"},
                { "ESP", "¿Qué es una función?"}
            } },
             { "INF_5_1_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Until now, we unly had one function: thye \"main\" function. It gets executed automatically when the program starts running."},
                { "ESP", "Hasta ahora sólo teníamos una función: la función \"main\". Se ejecuta autmáticamente cuando comienza el programa."}
            } },
              { "INF_5_1_T_2", new Dictionary<string, string>()
            {
                { "ENG", "What's a function?"},
                { "ESP", "¿Qué es una función?"}
            } },
             { "INF_5_1_E_2", new Dictionary<string, string>()
            {
                { "ENG", "But we can create more functions containing different code. Always inside a class."},
                { "ESP", "Pero podemos crear más funciones con distinto código dentro. Siempre dentro de alguna clase."}
            } },
              { "INF_5_1_T_3", new Dictionary<string, string>()
            {
                { "ENG", "What's a function?"},
                { "ESP", "¿Qué es una función?"}
            } },
             { "INF_5_1_E_3", new Dictionary<string, string>()
            {
                { "ENG", "To execute it, we have to call them from the main function with a \"function call\" block"},
                { "ESP", "Para ejecutarlas tenemos que llamarlas desde la función \"main\" con un bloque de lamada a función."}
            } },
              { "INF_5_1_T_4", new Dictionary<string, string>()
            {
                { "ENG", "What's a function?"},
                { "ESP", "¿Qué es una función?"}
            } },
             { "INF_5_1_E_4", new Dictionary<string, string>()
            {
                { "ENG", "You dont have to worry about the weird words in front of the function name yet."},
                { "ESP", "No te preocupes todavía por las palabrejas que van delante del nombre de la función. "}
            } },
              { "INF_5_1_T_5", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque"}
            } },
             { "INF_5_1_E_5", new Dictionary<string, string>()
            {
                { "ENG", "It calls the function called \"aux\". This will make he code inside it execute."},
                { "ESP", "Llama a la función llamada \"aux\". Esto hará que se ejecute todo el código que tenga dentro.\nPuedes encontrarlo en Básicos"}
            } },

              { "INF_5_2_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Functions: level 2"},
                { "ESP", "Funciones: nivel 2"}
            } },
             { "INF_5_2_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Make local2 equal to local1."},
                { "ESP", "Haz que local2 sea igual a local1."}
            } },
              { "INF_5_2_T_1", new Dictionary<string, string>()
            {
                { "ENG", "LOCAL VARIABLES"},
                { "ESP", "VARIABLES LOCALES"}
            } },
             { "INF_5_2_E_1", new Dictionary<string, string>()
            {
                { "ENG", "You will probably realize that you can´t use a variable that was created in a different function."},
                { "ESP", "Seguramente de darás cuenta de que no puedes usar una variable creada en una función diferente."}
            } },
             { "INF_5_2_T_2", new Dictionary<string, string>()
            {
                { "ENG", "LOCAL VARIABLES"},
                { "ESP", "VARIABLES LOCALES"}
            } },
             { "INF_5_2_E_2", new Dictionary<string, string>()
            {
                { "ENG", "That's becouse they are LOCAL variables."},
                { "ESP", "Esto es porque son variables LOCALES."}
            } },
             { "INF_5_2_T_3", new Dictionary<string, string>()
            {
                { "ENG", "GLOBAL VARIABLES"},
                { "ESP", "VARIABLES GLOBALES"}
            } },
             { "INF_5_2_E_3", new Dictionary<string, string>()
            {
                { "ENG", "In the other hand, GLOBAL variables are those declared outside of the functions. Usually at the beginning of the class."},
                { "ESP", "Por otro lado, las variables GLOBALES son las que se declaran fuera de las funciones. Normalmente al principio de la clase."}
            } },
              { "INF_5_2_T_4", new Dictionary<string, string>()
            {
                { "ENG", "GLOBAL VARIABLES"},
                { "ESP", "VARIABLES GLOBALES"}
            } },
             { "INF_5_2_E_4", new Dictionary<string, string>()
            {
                { "ENG", "GLOBAL variables can be shared between different functions\nSharing is living!"},
                { "ESP", "Las variables GLOBALES sí se pueden compartir entre varias funciones.\n¡Compartir es vivir!"}
            } },

              { "INF_5_3_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Functions: level 3"},
                { "ESP", "Funciones: nivel 3"}
            } },
             { "INF_5_3_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Eliminate the enemies and get to the yellow platform."},
                { "ESP", "Elimina a los enemigos y llega la casilla amarilla."}
            } },


              { "INF_6_1_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Recursivity: level 1"},
                { "ESP", "Recursividad: nivel 1"}
            } },
             { "INF_6_1_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Get to the yellow platform using recursivity."},
                { "ESP", "Llega la casilla amarilla usando la recursividad."}
            } },
             { "INF_6_1_T_1", new Dictionary<string, string>()
            {
                { "ENG", "What's recursivity?"},
                { "ESP", "¿Qué es la recursividad?"}
            } },
             { "INF_6_1_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Recusivity takes place when a function calls itself."},
                { "ESP", "La recursividad se produce cuando una función se llama a sí misma."}
            } },
             { "INF_6_1_T_2", new Dictionary<string, string>()
            {
                { "ENG", "What's recursivity?"},
                { "ESP", "¿Qué es la recursividad?"}
            } },
             { "INF_6_1_E_2", new Dictionary<string, string>()
            {
                { "ENG", "It works kind of like a loop which we have to control with \"if\", \"else if\" or \"else\"."},
                { "ESP", "De esta manera, entramos en una especie de bucle que tenemos que controlar con \"if\", \"else if\" o \"else \"."}
            } },
             { "INF_6_1_T_3", new Dictionary<string, string>()
            {
                { "ENG", "Clue"},
                { "ESP", "Pista"}
            } },
             { "INF_6_1_E_3", new Dictionary<string, string>()
            {
                { "ENG", "use the variable \"i\" to count and control how many times the functions is executes."},
                { "ESP", "Usa la variable \"i\" para contar y controlar las veces que se ejecuta la función."}
            } },

              { "INF_6_2_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Recursivity: level 2"},
                { "ESP", "Recursividad: nivel 2"}
            } },
             { "INF_6_2_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Get to the yellow platform using recursivity."},
                { "ESP", "Llega la casilla amarilla usando la recursividad."}
            } },
               { "INF_6_2_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Clue"},
                { "ESP", "Pista"}
            } },
             { "INF_6_2_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Ok, this level might drive us a little crazy..."},
                { "ESP", "Vale, este nivel nos va a hacer usar algo más el coco..."}
            } },
               { "INF_6_2_T_2", new Dictionary<string, string>()
            {
                { "ENG", "Clue"},
                { "ESP", "Pista"}
            } },
             { "INF_6_2_E_2", new Dictionary<string, string>()
            {
                { "ENG", "The enemies positions follow a pattern. Each one is separated from the previous one an extra cell every time."},
                { "ESP", "La posición de los enemigos sigue un patrón. Cada uno se separa del anterior cada vez una casilla más."}
            } },
              { "INF_6_2_T_3", new Dictionary<string, string>()
            {
                { "ENG", "Clue"},
                { "ESP", "Pista"}
            } },
             { "INF_6_2_E_3", new Dictionary<string, string>()
            {
                { "ENG", "Each time, also, we will have to turn to the right one more time than the previous in order to face towards the next enemy."},
                { "ESP", "Cada vez, también, hay que girar una vez más que la anterior para dirigirse al nuevo objetivo."}
            } },
             { "INF_6_2_T_4", new Dictionary<string, string>()
            {
                { "ENG", "Clue"},
                { "ESP", "Pista"}
            } },
             { "INF_6_2_E_4", new Dictionary<string, string>()
            {
                { "ENG", "I know you can do it!"},
                { "ESP", "¡Sé que puedes hacerlo!"}
            } },

        };
    }

    public static string getString(string id, string language)
    {
        if (!strings.ContainsKey(id))
            return id;

        return strings[id][language];
    }

    public static void translate(Text[] texts)
    {
        foreach (Text text in texts)
        {
            text.text = getString(text.text, PlayerPrefs.GetString("LANGUAGE"));
        }
    }
}
