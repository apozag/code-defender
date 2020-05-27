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
                { "ENG", "Recursion"},
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
             {"5_RESTART", new Dictionary<string, string>()
            {
                {"ENG", "Restart game progress" },
                {"ESP", "Borrar progreso del juego" }
            } },
              {"5_RESTART_CONFIRMATION", new Dictionary<string, string>()
            {
                {"ENG", "You will loose all unlocked levels and blocks. Are you sure you want continue?" },
                {"ESP", "Perderás todos los niveles y bloques desbloqueados. ¿Seguro que quieres continuar?" }
            } },
               {"5_CANCEL", new Dictionary<string, string>()
            {
                {"ENG", "Cancel" },
                {"ESP", "Cancelar" }
            } },
                {"5_CONTINUE", new Dictionary<string, string>()
            {
                {"ENG", "Continue" },
                {"ESP", "Continuar" }
            } },
                 {"5_CHANGE_LANG", new Dictionary<string, string>()
            {
                {"ENG", "Cambiar a Español" },
                {"ESP", "Switch to English" }
            } },

            {"Perderás todos los niveles y bloques desbloqueados. ¿Seguro que quieres continuar?", new Dictionary<string, string>()
            {
                {"ENG", "You will loose all unlocked levels and blocks. Are you sure you want continue?" },
            } },
            {"You will loose all unlocked levels and blocks. Are you sure you want continue?", new Dictionary<string, string>()
            {
                {"ESP", "Perderás todos los niveles y bloques desbloqueados. ¿Seguro que quieres continuar?" }
            } },
             {"Borrar progreso del juego", new Dictionary<string, string>()
            {
                {"ENG", "Restart game progress" },
            } },
            {"Restart game progress", new Dictionary<string, string>()
            {
                {"ESP", "Borrar progreso del juego" }
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
             {"Cambiar a Español", new Dictionary<string, string>()
            {
                {"ESP", "Switch to English" }
            } },
              {"Switch to English", new Dictionary<string, string>()
            {
                {"ENG", "Cambiar a Español" }
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
                { "ENG", "And not just any antivirus... A talking one! How cool is that?"},
                { "ESP", "Y no cualquier antivirus... ¡Uno que habla! ¿Que te parece?"}
            } },
              {"MON_3", new Dictionary<string, string>()
            {
                { "ENG", "We´ll have time to know each other better. Don´t get me wrong, but there´s an emergency I have to take care of with your help."},
                { "ESP", "Ya tendremos tiempo de conocernos más a fondo. No te lo tomes a mal, pero hay una emergencia que tengo que resolver cuanto antes con tu ayuda."}
            } },
               {"MON_4", new Dictionary<string, string>()
            {
                { "ENG", "It´s about a computer virus that sneaked into your phone and could be dangerous if we don´t eliminate it."},
                { "ESP", "Se trata de un virus informático que se ha colado en tu dispositivo y podría ser dañino si no lo eliminamos."}
            } },
            {"MON_5", new Dictionary<string, string>()
            {
                { "ENG", "I know I am the antivirus and it´s my job... but... it turns out that my developers didn´t quite finish me entirely."},
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
                { "ENG", "In order for you see what's going on inside your phone, I will turn on the camera and display my surroundings with AUGMENTED REALITY."},
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
                { "ENG", "Drag the block to a blank space (Tap to continue)" },
                { "ESP", "Arrastra el bloque hasta un hueco en blanco (Toca para continuar)" }

            } },
            { "TUT_1_1_3", new Dictionary<string, string>()
            {
                { "ENG", "You can delete a block pressing this button (Tap to continue)" },
                { "ESP", "Puedes eliminar un bloque pulsando éste botón (Toca para continuar)" }

            } },
             {"TUT_1_1_4", new Dictionary<string, string>()
            {
                { "ENG", "Press to execute your code" },
                { "ESP", "Pulsa para ejecutar el código" }

            } },
             {"TUT_1_2_0", new Dictionary<string, string>()
            {
                { "ENG", "Are you stuck or don't remember what you had to do? Click here to see the level info again." },
                { "ESP", "¿Te has quedado atascado o no recuerdas qué hay que hacer? Pulsa aquí para volver a ver la información del nivel." }

            } },
             {"TUT_1_2_1", new Dictionary<string, string>()
            {
                { "ENG", "If the table disapeared or you want to change it's position, click here" },
                { "ESP", "Si el escenario ha desaparecido o quieres cambiarlo de sitio, pulsa aquí." }

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
             {"TST_SELECT_TO_DELETE", new Dictionary<string, string>()
            {
                {"ENG", "Press on a block to select it, then press the delete button." },
                {"ESP", "Para eliminar un bloque, púlsalo para seleccionarlo antes"}
            } },
             {"TST_DIFFERENT_TYPE_ASSIGN", new Dictionary<string, string>()
            {
                {"ENG", "You can´t assign a variable to a different type." },
                {"ESP", "No puedes asignar una variable a otra de distinto tipo."}
            } },
            {"TST_VAR_NOT_DEFINED_1", new Dictionary<string, string>(){
                {"ENG",  "The variable " },
                {"ESP", "La variable " }
            } },
            {"TST_VAR_NOT_DEFINED_2", new Dictionary<string, string>(){
                {"ENG",  " is not defined in this scope." },
                {"ESP", " no está definida en éste ámbito." }
            } },
             {"TST_VAR_DELETED", new Dictionary<string, string>(){
                {"ENG",  " has been deleted." },
                {"ESP", " ha sido eliminada." }
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
                {"ESP", "No se puede comparar string con "}
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
                {"ESP", "un valor string debe ir entre comillas."}
            } },
             {"TST_MULTIPLE_MAIN", new Dictionary<string, string>()
            {
                {"ENG", "There can only be one main function!"},
                {"ESP", "¡Sólo puede haber una función main!"}
            } },
            {"TST_MULTIPLE_FUNCTION", new Dictionary<string, string>()
            {
                {"ENG", "There can't be two functions with the same name!"},
                {"ESP", "¡No puede haber dos funciones con el mismo nombre!"}
            } },
             {"TST_NO_FUNCTION", new Dictionary<string, string>()
            {
                {"ENG", "You must create the function before calling it."},
                {"ESP", "Debes crear la función para poder llamarla."}
            } },
            {"TST_MULTIPLE_CLASS", new Dictionary<string, string>()
            {
                {"ENG", "There can't be two classes with the same name!"},
                {"ESP", "¡No puede haber dos clases con el mismo nombre!"}
            } },
             {"TST_ELSEIF_UNDER", new Dictionary<string, string>()
            {
                {"ENG", "An \"else if\" must be under an \"if\" or another \"else if\"."},
                {"ESP", "Un \"else if\" debe estar bajo un \"if\" u otro \"else if\"."}
            } },
              {"TST_ELSE_UNDER", new Dictionary<string, string>()
            {
                {"ENG", "An \"else\" must be under an \"if\" or an \"else if\"."},
                {"ESP", "Un \"else\" debe estar bajo un \"if\" o un \"else if\"."}
            } },
               {"TST_NEGATIVE_VALUE", new Dictionary<string, string>()
            {
                {"ENG", "Can´t insert a negative value in this case."},
                {"ESP", "No se puede introducir un valor negativo en este caso."}
            } },
                {"TST_NO_RETURN", new Dictionary<string, string>()
            {
                {"ENG", "The function aux must return a value."},
                {"ESP", "La función aux debe devolver un valor (con RETURN)."}
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

              { "INF_1_6_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Movement: level 6"},
                { "ESP", "Movimiento: nivel 6"}
            } },
            { "INF_1_6_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Eliminate the worm."},
                { "ESP", "Elimina al gusano."}
            } },
             { "INF_1_6_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Worms"},
                { "ESP", "Gusanos"}
            } },
            { "INF_1_6_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Worms are a kind of virus that replicates itself to infect other devices."},
                { "ESP", "Los gusanos son un tipo de virus que se multiplican para infectar otros dispositivos."}
            } },
            { "INF_1_6_T_2", new Dictionary<string, string>()
            {
                { "ENG", "Worms"},
                { "ESP", "Gusanos"}
            } },
            { "INF_1_6_E_2", new Dictionary<string, string>()
            {
                { "ENG", "Each worm will create two copies of itself in 4 turns."},
                { "ESP", "Cada gusano creará dos copias más de si mismo al pasar 4 turnos."}
            } },
            { "INF_1_6_T_3", new Dictionary<string, string>()
            {
                { "ENG", "Turns"},
                { "ESP", "Turnos"}
            } },
            { "INF_1_6_E_3", new Dictionary<string, string>()
            {
                { "ENG", "Moving one step or saying something counts as 1 turn.\nTurning right or left does NOT count!"},
                { "ESP", "Moverse un paso o hablar cuentan como 1 turno.\n¡Girar NO cuenta!"}
            } },

            { "INF_1_7_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Movement: level 7"},
                { "ESP", "Movimiento: nivel 7"}
            } },
            { "INF_1_7_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Eliminate the enemies."},
                { "ESP", "Elimina los enemigos."}
            } },

            { "INF_1_8_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Movement: level 8"},
                { "ESP", "Movimiento: nivel 8"}
            } },
            { "INF_1_8_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Eliminate the enemies."},
                { "ESP", "Elimina a los enemigos."}
            } },

             { "INF_1_9_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Movement: level 9"},
                { "ESP", "Movimiento: nivel 9"}
            } },
            { "INF_1_9_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Eliminate the enemies."},
                { "ESP", "Elimina a los enemigos."}
            } },

             { "INF_1_10_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Movement: level 10"},
                { "ESP", "Movimiento: nivel 10"}
            } },
            { "INF_1_10_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Eliminate the enemies."},
                { "ESP", "Elimina a los enemigos."}
            } },

            { "INF_2_1_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Variables: level 1"},
                { "ESP", "Variables: nivel 1"}
            } },
            { "INF_2_1_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Create a variable and execute to check."},
                { "ESP", "Crea una variable y ejecuta para comprobar."}
            } },
             { "INF_2_1_T_1", new Dictionary<string, string>()
            {
                { "ENG", "What´s a variable?"},
                { "ESP", "¿Qué es una variable?"}
            } },
            { "INF_2_1_E_1", new Dictionary<string, string>()
            {
                { "ENG", "It´s represented by a name and holds a value which can be used later."},
                { "ESP", "Se representa con un nombre y guarda un valor que se puede usar más tarde."}
            } },
            { "INF_2_1_T_2", new Dictionary<string, string>()
            {
                { "ENG", "What´s a variable?"},
                { "ESP", "¿Qué es una variable?"}
            } },
            { "INF_2_1_E_2", new Dictionary<string, string>()
            {
                { "ENG", "There are several types depending on what they contain. The ones we will be using are:"},
                { "ESP", "Pueden ser de varios tipos dependiendo de lo que contenga. Los que vamos a utilizar nosotros son:"}
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
                { "ENG", "Assigns a new value to the variable you put in the left gap."},
                { "ESP", "Asigna un nuevo valor a la variable que coloques a la izquierda."}
            } },

            { "INF_2_2_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Variables: level 2"},
                { "ESP", "Variables: level 2"}
            } },
            { "INF_2_2_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Assign the variable word_1 to word_2."},
                { "ESP", "Asigna la variable word_1 a word_2."}
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
                { "ENG", "Variables can be assigned to one another if they are the same type (int, string, float...)"},
                { "ESP", "Se puede asignar el valor de una variable a otra siempre que sean del mismo tipo. (int, string, float...)"}
            } },
            { "INF_2_2_T_3", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_2_2_E_3", new Dictionary<string, string>()
            {
                { "ENG", "Creates a float variable (number with decimals)"},
                { "ESP", "Crea una variable de tipo float (número con decimales)"}
            } },
            { "INF_2_2_T_4", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_2_2_E_4", new Dictionary<string, string>()
            {
                { "ENG", "Creates a string variable (text).\nIt's value must be in quotation marks!"},
                { "ESP", "Crea una variable de tipo string (texto).\n¡Su valor debe ir siempre entre comillas!"}
            } },

            { "INF_2_3_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Variables: level 3"},
                { "ESP", "Variables: nivel 3"}
            } },
            { "INF_2_3_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Calculate the sum of num1 and num2."},
                { "ESP", "Calcula la suma de num1 y num2."}
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
                { "ENG", "Only certain variable types can be operated with each other. You can experiment more with this in the training mode."},
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

             { "INF_2_5_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Variables: level 5"},
                { "ESP", "Variables: nivel 5"}
            } },
            { "INF_2_5_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Bytey must advance forward, but he doesn´t know how many steps!"},
                { "ESP", "Bytey tiene que avanzar hacia adelante. ¡Pero no sabe cuántos pasos!"}
            } },
            { "INF_2_5_T_1", new Dictionary<string, string>()
            {
                 { "ENG", "Variables: level 5"},
                { "ESP", "Variables: nivel 5"}
            } },
            { "INF_2_5_E_1", new Dictionary<string, string>()
            {
                { "ENG", "The variable \"cm\" contains how many centimeters he has to advance, and the variables \"cm_per_step\" contains the number of centimeters by step"},
                { "ESP", "En la variable \"cm\" están los centímetros que hay que avanzar y en la variable \"cm_per_step\" los centímetros que se avanzan a cada paso."}
            } },
             { "INF_2_5_T_2", new Dictionary<string, string>()
            {
                 { "ENG", "Variables: level 5"},
                { "ESP", "Variables: nivel 5"}
            } },
            { "INF_2_5_E_2", new Dictionary<string, string>()
            {
                { "ENG", "When you have the result, insert it inside the parenthesis."},
                { "ESP", "Cuando tengas el resultado, introdúcelo en el hueco entre paréntesis."}
            } },

             { "INF_2_6_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Variables: level 6"},
                { "ESP", "Variables: nivel 6"}
            } },
            { "INF_2_6_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Bytey knows how many steps he must take in total. This number is in the variable \"total_steps\"."},
                { "ESP", "Bytey sabe cuántos pasos debe dar en total. Está en la variable \"total_steps\"."}
            } },
            { "INF_2_6_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Variables: level 6"},
                { "ESP", "Variables: nivel 6"}
            } },
            { "INF_2_6_E_1", new Dictionary<string, string>()
            {
                { "ENG", "But he must distribute them in 3 equal batches. He turns left between each one."},
                { "ESP", "Pero ha de repartir los pasos en 3 tandas iguales, entre las que realiza un giro"}
            } },

             { "INF_2_7_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Variables: level 7"},
                { "ESP", "Variables: nivel 7"}
            } },
            { "INF_2_7_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Make Bytey move a number of steps equal to the average of the two variables."},
                { "ESP", "Haz que bytey se mueva un número de pasos igual a la media de las dos variables."}
            } },
             { "INF_2_7_T_1", new Dictionary<string, string>()
            {
                { "ENG", "About this block:"},
                { "ESP", "Respecto a este bloque:"}
            } },
            { "INF_2_7_E_1", new Dictionary<string, string>()
            {
                { "ENG", "As you will see it's not available in your palette, but it will be part of some levels."},
                { "ESP", "Como podrás observar no está disponible en tu paleta, pero formará parte de algunos niveles."}
            } },

             { "INF_2_8_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Variables: level 8"},
                { "ESP", "Variables: nivel 8"}
            } },
            { "INF_2_8_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Make Bytey move a number of steps equal to the double of the value of variable."},
                { "ESP", "Haz que bytey se mueva un número de pasos igual al doble del valor de la variable."}
            } },

             { "INF_2_9_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Variables: level 9"},
                { "ESP", "Variables: nivel 9"}
            } },
            { "INF_2_9_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Make Bytey say the content of the variable \"word\" three times in the same bubble."},
                { "ESP", "Haz que Bytey diga lo que pone en la variable \"word\" tres veces en el mismo bocadillo."}
            } },
             { "INF_2_9_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Adding Strings"},
                { "ESP", "Sumar Strings"}
            } },
            { "INF_2_9_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Remember that Strings can be added with each other. This will concatenate their values."},
                { "ESP", "Recuerda que los String se pueden sumar entre sí haciendo que se encadenen sus valores."}
            } },

            { "INF_2_10_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Variables: level 10"},
                { "ESP", "Variables: nivel 10"}
            } },
            { "INF_2_10_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Make Bytey say the content of the variable \"word\" plus the result of the sum."},
                { "ESP", "Haz que Bytey diga lo que pone en la variable \"word\" más el resultado de la suma."}
            } },
            { "INF_2_10_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Variables: level 10"},
                { "ESP", "Variables: nivel 10"}
            } },
            { "INF_2_10_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Also make Bytey move the number of steps resulting of the sum."},
                { "ESP", "Además, haz que Bytey avance los pasos que resulten de la suma."}
            } },
             { "INF_2_10_T_2", new Dictionary<string, string>()
            {
                { "ENG", "Variables: level 10"},
                { "ESP", "Variables: nivel 10"}
            } },
            { "INF_2_10_E_2", new Dictionary<string, string>()
            {
                { "ENG", "For example: \"El resultado es: 5\"\nRemember that Strings can be added with some data types."},
                { "ESP", "Por ejemplo: \"El resultado es: 5\"\nRecuerda que los String se pueden sumar con algunos tipos de datos."}
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
                { "ENG", "It can be placed under un \"if\" or another \"else if\". If the upper conditions aren't true, this one gets checked."},
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
                { "ENG", "The logic AND (&&) is true ONLY IF both of the conditions at each side are true."},
                { "ESP", "El AND lógico (&&) es verdadero SOLO SI las dos condiciones a ambos lados son verdaderas."}
            } },
            { "INF_3_3_T_2", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_3_3_E_2", new Dictionary<string, string>()
            {
                { "ENG", "The logic OR ( || ) is true if either one of the two conditions is true. It's false if both are false."},
                { "ESP", "El OR lógico ( || ) es verdadero si alguna de las dos condiciones es verdadera. Es falso si ninguna es verdadera."}
            } },


            { "INF_3_4_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Conditionals: level 4"},
                { "ESP", "Condicionales: nivel 4"}
            } },
            { "INF_3_4_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Eliminate the enemies and get to the yellow platform."},
                { "ESP", "Elimina a los enemigos y llega a la casilla amarilla."}
            } },
            { "INF_3_4_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Worms!"},
                { "ESP", "¡Gusanos!"}
            } },
            { "INF_3_4_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Remember they replicate every 4 seconds"},
                { "ESP", "Recuerda que se reproducen cada 4 movimientos."}
            } },
             { "INF_3_4_T_2", new Dictionary<string, string>()
            {
                { "ENG", "Worms!"},
                { "ESP", "¡Gusanos!"}
            } },
            { "INF_3_4_E_2", new Dictionary<string, string>()
            {
                { "ENG", "The first will generate two more in horizontal. This two will later generate other two in vertical and so on."},
                { "ESP", "Primero genera dos en horizontal, estos dos más tarde generarán dos en vertical, y así alternadamente."}
            } },

             { "INF_3_5_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Conditionals: level 5"},
                { "ESP", "Condicionales: nivel 5"}
            } },
            { "INF_3_5_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Get to the yellow platform."},
                { "ESP", "Llega a la casilla de salida."}
            } },
            { "INF_3_5_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Conditionals: level 5"},
                { "ESP", "Condicionales: nivel 5"}
            } },
            { "INF_3_5_E_1", new Dictionary<string, string>()
            {
                { "ENG", "That's not all! Make also sure the condition in both \"if\" statements are met."},
                { "ESP", "¡Eso no es todo! Asegúrate también de que la condición de ambos \"if\" se cumple.."}
            } },

             { "INF_3_6_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Conditionals: level 6"},
                { "ESP", "Condicionales: nivel 6"}
            } },
            { "INF_3_6_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Eliminate the enemy and get to the yellow platform."},
                { "ESP", "Elimina al enemigo y llega a la plataforma amarilla."}
            } },

           { "INF_3_7_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Conditionals: level 7"},
                { "ESP", "Condicionales: nivel 7"}
            } },
            { "INF_3_7_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Move one step to the left if \"random_num\" is higher than 5. Move one stepto the right otherwise."},
                { "ESP", "Muévete un paso a la izquierda si \"random_num\" es mayor que 5. Muévete un paso a la derecha en caso contrario."}
            } },
           { "INF_3_7_T_1", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_3_7_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Generates a random integer number (int) between the two numbers in the parenthesis."},
                { "ESP", "Genera un número entero (int) aleatorio entre los dos números entre paréntesis."}
            } },
            { "INF_3_7_T_2", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_3_7_E_2", new Dictionary<string, string>()
            {
                { "ENG", "Both numbers are included in the range, meaning they can come out as well."},
                { "ESP", "Ambos números están incluidos en el rango, es decir, que pueden salir."}
            } },
             { "INF_3_7_T_3", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_3_7_E_3", new Dictionary<string, string>()
            {
                { "ENG", "You can find it in the Operations category."},
                { "ESP", "Puedes encontrarlo en la categoría de Operaciones."}
            } },

             { "INF_3_8_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Conditionals: level 8"},
                { "ESP", "Condicionales: nivel 8"}
            } },
            { "INF_3_8_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Make Bytey say \"higher\" or \"lower\" depending on the variable \"number\" being higher or lower than \"average\"."},
                { "ESP", "Haz que Bytey diga \"mayor\" o \"menor\" según la variable \"number\" sea mayor o menor que la variable \"average\"."}
            } },
            { "INF_3_8_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Conditionals: level 8"},
                { "ESP", "Condicionales: nivel 8"}
            } },
            { "INF_3_8_E_1", new Dictionary<string, string>()
            {
                { "ENG", "If they are equal, he will say \"equal\""},
                { "ESP", "Si son iguales, entonces dirá \"igual\""}
            } },

            { "INF_3_9_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Conditionals: level 9"},
                { "ESP", "Condicionales: nivel 9"}
            } },
            { "INF_3_9_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Go to the yellow platform ONLY if \"number\" is LOWER than 5 AND HIGHER than 2."},
                { "ESP", "Ve a la casilla amarilla SOLO si \"number\" es MENOR que 5 Y MAYOR que 2."}
            } },

            { "INF_3_10_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Conditionals: level 10"},
                { "ESP", "Condicionales: nivel 10"}
            } },
            { "INF_3_10_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Make sure \"number\" is always positive in the end of the program."},
                { "ESP", "Asegúrate de que el \"number\" es siempre positivo al final del programa."}
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
                { "ENG", "The third thing is the increment. This means our variable is added 1 every time the loop repeats."},
                { "ESP", "Lo tercero es el incremento, es decir, indica que cada vez que se repita el bucle, a la variable se le suma 1."}
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
                { "ENG", "Loops can be put inside other loops.\nAmazing right? That's what called nested loops."},
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
                { "ESP", "La principal diferencia es que la condición está al final."}
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
                { "ESP", "Se pueden hacer arrays de cualquier tipo de dato pero nosotros utilizaremos de tipo int."}
            } },
             { "INF_4_5_T_3", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
             { "INF_4_5_E_3", new Dictionary<string, string>()
            {
                { "ENG", "Creates an array of int. Apart from the name, we also have to indicate the size."},
                { "ESP", "Crea un array de int. Aparte del nombre hay que indicar el tamaño."}
            } },
              { "INF_4_5_T_4", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
             { "INF_4_5_E_4", new Dictionary<string, string>()
            {
                { "ENG", "You can find it in the Variables category."},
                { "ESP", "Puedes encontrarlo en la categoría de Variables."}
            } },

             { "INF_4_6_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Loops: level 6"},
                { "ESP", "Bucles: nivel 6"}
            } },
             { "INF_4_6_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Create an array of size 10 containing the numbers from 1 to 10."},
                { "ESP", "Crea un array de tamaño 10 que contenga los números del 1 al 10."}
            } },
              { "INF_4_6_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Accessing array positions"},
                { "ESP", "Acceder a posiciones del array"}
            } },
             { "INF_4_6_E_1", new Dictionary<string, string>()
            {
                { "ENG", "As we already know, arrays contain ordered data."},
                { "ESP", "Como ya sabemos, los arrays contienen datos de manera odenada."}
            } },
              { "INF_4_6_T_2", new Dictionary<string, string>()
            {
                { "ENG", "Accessing array positions"},
                { "ESP", "Acceder a posiciones del array"}
            } },
             { "INF_4_6_E_2", new Dictionary<string, string>()
            {
                { "ENG", "And with ordered we mean each data has an index which indicates in what position to find it."},
                { "ESP", "Y por ordenado nos referimos a que cada dato tiene un índice que indica en qué posición se encuentra."}
            } },
             { "INF_4_6_T_3", new Dictionary<string, string>()
            {
                { "ENG", "Arrays and loops"},
                { "ESP", "Arrays y bucles"}
            } },
             { "INF_4_6_E_3", new Dictionary<string, string>()
            {
                { "ENG", "Using a \"for\" loop we can access each position of the array with the iteration counting variable"},
                { "ESP", "Usando un bucle \"for\" podemos acceder a cada posición del array con la varible que cuenta las iteraciones."}
            } },

             { "INF_4_7_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Loops: level 7"},
                { "ESP", "Bucles: nivel 7"}
            } },
             { "INF_4_7_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Create an array of size 10 containing the numbers from 2 to 20 TWO BY TWO (2, 4, 6, 8...)."},
                { "ESP", "Crea un array de tamaño 10 que contenga los números del 2 al 20 DE DOS EN DOS (2, 4, 6, 8...)."}
            } },

            { "INF_4_8_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Loops: level 8"},
                { "ESP", "Bucles: nivel 8"}
            } },
            { "INF_4_8_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Copy the content of the array \"original\" into the array \"copy\" element by element using a loop."},
                { "ESP", "Copia el contenido del array \"original\" en el array \"copy\" elemento por elemento usando un bucle."}
            } },

            { "INF_4_9_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Loops: level 9"},
                { "ESP", "Bucles: nivel 9"}
            } },
            { "INF_4_9_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Make Bytey say the content of the array \"numbers\" backwards (from the last one to the first one)."},
                { "ESP", "Haz que Bytey diga el contenido del array \"numbers\" al revés (del último al primero)."}
            } },

            { "INF_4_10_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Loops: level 10"},
                { "ESP", "Bucles: nivel 10"}
            } },
            { "INF_4_10_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Search for a number lower than 3 in the array. If you find it, make Bytey move that number of steps."},
                { "ESP", "Busca un número menor que 3 en el array. Si lo encuentras, haz que Bytey se mueva ese número de pasos."}
            } },
            { "INF_4_10_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Loops: level 10"},
                { "ESP", "Bucles: nivel 10"}
            } },
            { "INF_4_10_E_1", new Dictionary<string, string>()
            {
                { "ENG", "There might be several numbers lower than 3!"},
                { "ESP", "¡Puede que haya varios números menores que 3!"}
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
                { "ENG", "Until now, we unly had one function: the \"main\" function. It gets executed automatically when the program starts running."},
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
                { "ESP", "Pero podemos crear más funciones con distinto código. Siempre dentro de alguna clase."}
            } },
              { "INF_5_1_T_3", new Dictionary<string, string>()
            {
                { "ENG", "What's a function?"},
                { "ESP", "¿Qué es una función?"}
            } },
             { "INF_5_1_E_3", new Dictionary<string, string>()
            {
                { "ENG", "To execute it, we have to call them from the main function with a \"function call\" block"},
                { "ESP", "Para ejecutarlas tenemos que llamarlas desde la función \"main\" con un bloque de llamada a función."}
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
                { "ESP", "Llama a la función llamada \"aux\". Esto hará que se ejecute todo el código que tenga dentro."}
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

              { "INF_5_4_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Functions: level 4"},
                { "ESP", "Funciones: nivel 4"}
            } },
             { "INF_5_4_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Eliminate the enemies and get to the yellow platform."},
                { "ESP", "Elimina a los enemigos y llega la casilla amarilla."}
            } },

              { "INF_5_5_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Functions: level 5"},
                { "ESP", "Funciones: nivel 5"}
            } },
             { "INF_5_5_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Use a functions with parameters"},
                { "ESP", "Usa una función con parámetros."}
            } },
              { "INF_5_5_T_1", new Dictionary<string, string>()
            {
                { "ENG", "What are parameters?"},
                { "ESP", "¿Qué son los parámetros"}
            } },
             { "INF_5_5_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Some functions can recieve parameters"},
                { "ESP", "Algunas funciones pueden recibir parámetros."}
            } },

              { "INF_5_5_T_2", new Dictionary<string, string>()
            {
                { "ENG", "What are parameters?"},
                { "ESP", "¿Qué son los parámetros"}
            } },
             { "INF_5_5_E_2", new Dictionary<string, string>()
            {
                { "ENG", "This means that, when we call the function, we have to write inside the parenthesis one or several values."},
                { "ESP", "Significa que, al llamar a la función, hay que poner entre paréntesis uno o varios valores."}
            } },
              { "INF_5_5_T_3", new Dictionary<string, string>()
            {
                { "ENG", "What are parameters?"},
                { "ESP", "¿Qué son los parámetros"}
            } },
             { "INF_5_5_E_3", new Dictionary<string, string>()
            {
                { "ENG", "We can access this value inside the functions with a variable defined in the function header."},
                { "ESP", "A éste valor se puede acceder dentro de la función con una variable que se define en la cabecera."}
            } },
             { "INF_5_5_T_4", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
             { "INF_5_5_E_4", new Dictionary<string, string>()
            {
                { "ENG", "Calls he function \"aux\". Write the parameter in the parenthesis. Find it in Basics."},
                { "ESP", "Llama a la función \"aux\". Escribe en el hueco entre paréntesis el parámetro. Encuéntralo en Básicos."}
            } },
             { "INF_5_5_T_5", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
             { "INF_5_5_E_5", new Dictionary<string, string>()
            {
                { "ENG", "Note that the parameter variable is called \"param\". Find this variable in Variables."},
                { "ESP", "Observa que la variable parámetro se llama \"param\". Encuentra esta variable en Variables."}
            } },
             { "INF_5_5_T_6", new Dictionary<string, string>()
            {
                { "ENG", "Objective"},
                { "ESP", "Objetivo"}
            } },
             { "INF_5_5_E_6", new Dictionary<string, string>()
            {
                { "ENG", "Pass number 3 as a parameter to the function."},
                { "ESP", "Pasa el número 3 como parámetro a la función."}
            } },

            { "INF_5_6_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Functions: level 6"},
                { "ESP", "Funciones: nivel 6"}
            } },
            { "INF_5_6_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Use a function that makes Bytey move the number of steps passed as a parameter."},
                { "ESP", "Usa una función que mueva a Bytey el número de pasos que se le pase como parámetro."}
            } },
            { "INF_5_6_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Functions: level 6"},
                { "ESP", "Funciones: nivel 6"}
            } },
            { "INF_5_6_E_1", new Dictionary<string, string>()
            {
                { "ENG", "He must move 6 steps."},
                { "ESP", "Se debe mover 6 pasos."}
            } },

            { "INF_5_7_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Functions: level 7"},
                { "ESP", "Funciones: nivel 7"}
            } },
            { "INF_5_7_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Use a function that makes Bytey move the number of steps passed as a parameter."},
                { "ESP", "Usa una función que mueva a Bytey el número de pasos que se le pase como parámetro."}
            } },
            { "INF_5_7_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Functions: level 7"},
                { "ESP", "Funciones: nivel 7"}
            } },
            { "INF_5_7_E_1", new Dictionary<string, string>()
            {
                { "ENG", "But not straight: turning to the left every three steps."},
                { "ESP", "Pero que no se mueva recto, sino que gire a la izquierda cada tres pasos."}
            } },
             { "INF_5_7_T_2", new Dictionary<string, string>()
            {
                { "ENG", "Functions: level 7"},
                { "ESP", "Funciones: nivel 7"}
            } },
            { "INF_5_7_E_2", new Dictionary<string, string>()
            {
                { "ENG", "Total steps: 9."},
                { "ESP", "Pasos totales: 9."}
            } },

            { "INF_5_8_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Functions: level 8"},
                { "ESP", "Funciones: nivel 8"}
            } },
            { "INF_5_8_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Use a function with parameters to eliminate the enemies."},
                { "ESP", "Usa una función con parámetros para eliminar a los enemigos."}
            } },        
            { "INF_5_8_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Functions: level 8"},
                { "ESP", "Funciones: nivel 8"}
            } },
            { "INF_5_8_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Bytey desnt't have any code this time!\nYou'll have to program it from scratch  ."},
                { "ESP", "Bytey no tiene nada de código ésta vez!\nTendrás que programar desde cero"}
            } },

             { "INF_5_9_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Functions: level 9"},
                { "ESP", "Funciones: nivel 9"}
            } },
            { "INF_5_9_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Use a function with parameters to eliminate the enemies and get to the yellow platform."},
                { "ESP", "Usa una función con parámetros para eliminar a los enemigos y llegar a la casilla amarila."}
            } },

             { "INF_5_10_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Functions: level 10"},
                { "ESP", "Funciones: nivel 10"}
            } },
            { "INF_5_10_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Use a function with parameters to eliminate the enemies and get to the yellow platform."},
                { "ESP", "Usa una función con parámetros para eliminar a los enemigos y llegar a la casilla amarilla."}
            } },

              { "INF_6_1_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Recursion: level 1"},
                { "ESP", "Recursividad: nivel 1"}
            } },
             { "INF_6_1_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Get to the yellow platform using recursion."},
                { "ESP", "Llega la casilla amarilla usando la recursividad."}
            } },
             { "INF_6_1_T_1", new Dictionary<string, string>()
            {
                { "ENG", "What's recursion?"},
                { "ESP", "¿Qué es la recursividad?"}
            } },
             { "INF_6_1_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Recursion takes place when a function calls itself."},
                { "ESP", "La recursividad se produce cuando una función se llama a sí misma."}
            } },
             { "INF_6_1_T_2", new Dictionary<string, string>()
            {
                { "ENG", "What's recursion?"},
                { "ESP", "¿Qué es la recursividad?"}
            } },
             { "INF_6_1_E_2", new Dictionary<string, string>()
            {
                { "ENG", "It works kind of like a loop which we have to control with \"if\", \"else if\" or \"else\"."},
                { "ESP", "De esta manera, entramos en una especie de bucle que tenemos que controlar con \"if\", \"else if\" o \"else\"."}
            } },
             { "INF_6_1_T_3", new Dictionary<string, string>()
            {
                { "ENG", "Clue"},
                { "ESP", "Pista"}
            } },
             { "INF_6_1_E_3", new Dictionary<string, string>()
            {
                { "ENG", "Use the variable \"i\" to count and control how many times the functions is executed."},
                { "ESP", "Usa la variable \"i\" para contar y controlar las veces que se ejecuta la función."}
            } },

              { "INF_6_2_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Recursion: level 2"},
                { "ESP", "Recursividad: nivel 2"}
            } },
             { "INF_6_2_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Eliminate the enemies and get to the yellow platform using recursion."},
                { "ESP", "Elimina a los enemigos y llega la casilla amarilla usando la recursividad."}
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

             { "INF_6_3_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Recursion: level 3"},
                { "ESP", "Recursividad: nivel 3"}
            } },
             { "INF_6_3_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Eliminate the enemies and get to the yellow platform using recursion."},
                { "ESP", "Elimina a los enemigos y llega la casilla amarilla usando la recursividad."}
            } },
             { "INF_6_3_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Clue"},
                { "ESP", "Pista"}
            } },
             { "INF_6_3_E_1", new Dictionary<string, string>()
            {
                { "ENG", "After doing the recursive call, we can \"undo\" what we did before the call"},
                { "ESP", "Tras hacer la llamada recursiva, podemos \"deshacer\" lo que hemos hecho antes de la llamada." }
            } },

            { "INF_6_4_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Recursion: level 4"},
                { "ESP", "Recursividad: nivel 4"}
            } },
            { "INF_6_4_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Get to the yellow platform using recursion."},
                { "ESP", "Llega a la casilla amarilla usando la recursividad."}
            } },
            { "INF_6_4_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Recursion and parameters"},
                { "ESP", "Recursividad y parámetros"}
            } },
            { "INF_6_4_E_1", new Dictionary<string, string>()
            {
                { "ESP", "Ahora vamos a controlar las veces que llamamos a la función a través del parámetro."},
                { "ENG", "Now we're going to control how many times we call the function through the parameter."}
            } },
             { "INF_6_4_T_2", new Dictionary<string, string>()
            {
                { "ENG", "Recursion and parameters"},
                { "ESP", "Recursividad y parámetros"}
            } },
            { "INF_6_4_E_2", new Dictionary<string, string>()
            {
                { "ENG", "Instead of using a global variable."},
                { "ESP", "En lugar de usar una variable global."}
            } },

            { "INF_6_5_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Recursion: level 5"},
                { "ESP", "Recursividad: nivel 5"}
            } },
            { "INF_6_5_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Return values"},
                { "ESP", "Devolver valores."}
            } },
             { "INF_6_5_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Return Values"},
                { "ESP", "Devolver valores"}
            } },
            { "INF_6_5_E_1", new Dictionary<string, string>()
            {
                { "ENG", "As we alreay know, functions can recieve values as parameters."},
                { "ESP", "Las funciones, como sabemos, pueden recibir valores en forma de parámetros."}
            } },
             { "INF_6_5_T_2", new Dictionary<string, string>()
            {
                { "ENG", "Return Values"},
                { "ESP", "Devolver valores"}
            } },
            { "INF_6_5_E_2", new Dictionary<string, string>()
            {
                { "ENG", "As well, they can RETURN values, meaning they send a value back to where they were called"},
                { "ESP", "A su vez pueden DEVOLVER valores, es decir, mandan un valor de vuelta a desde donde la llamaron."}
            } },
            { "INF_6_5_T_3", new Dictionary<string, string>()
            {
                { "ENG", "Return Values"},
                { "ESP", "Devolver valores"}
            } },
            { "INF_6_5_E_3", new Dictionary<string, string>()
            {
                { "ENG", "This way, we can put function call blocks inside round gaps becouse we know they will return a value."},
                { "ESP", "De esta manera, podemos meter bloques de llamada a función en huecos redondos porque sabemos que devolverán un valor."}
            } },
            { "INF_6_5_T_4", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_6_5_E_4", new Dictionary<string, string>()
            {
                { "ENG", "Creates a function which recieves a parameter \"param\" and returns an int value."},
                { "ESP", "Crea una función que recibe un parámero \"param\" y devuelve un valor int."}
            } },
            { "INF_6_5_T_5", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_6_5_E_5", new Dictionary<string, string>()
            {
                { "ENG", "The function must contain a RETURN block which returns the value in the gap."},
                { "ESP", "La función debe contener un bloque RETURN que devuelve el valor en el hueco."}
            } },
            { "INF_6_5_T_6", new Dictionary<string, string>()
            {
                { "ENG", "New block:"},
                { "ESP", "Nuevo bloque:"}
            } },
            { "INF_6_5_E_6", new Dictionary<string, string>()
            {
                { "ENG", "Calls the function."},
                { "ESP", "Llama a la función."}
            } },
            { "INF_6_5_T_7", new Dictionary<string, string>()
            {
                { "ENG", "New blocks"},
                { "ESP", "Nuevos bloques"}
            } },
            { "INF_6_5_E_7", new Dictionary<string, string>()
            {
                { "ENG", "Find them in the Basic catgory."},
                { "ESP", "Encuéntralos en la categoría de Básicos."}
            } },
            { "INF_6_5_T_8", new Dictionary<string, string>()
            {
                { "ENG", "Objective"},
                { "ESP", "Objetivo"}
            } },
            { "INF_6_5_E_8", new Dictionary<string, string>()
            {
                { "ENG", "Create a function returning any value.\nMake Bytey say this value"},
                { "ESP", "Crea una función que devuelva cualquier valor.\nHaz que Bytey diga este valor"}
            } },

            { "INF_6_6_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Recursion: level 6"},
                { "ESP", "Recursividad: nivel 6"}
            } },
            { "INF_6_6_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Make Bytey say the sum of all the numbers from 1 to 10 using recursion."},
                { "ESP", "Haz que Bytey diga la suma de todos los números del 1 al 10 usando la recursividad."}
            } },
            { "INF_6_6_T_1", new Dictionary<string, string>()
            {
                { "ENG", "By the way!"},
                { "ESP", "¡Por cierto!"}
            } },
            { "INF_6_6_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Note that you can call the function recursively in the RETURN block gap."},
                { "ESP", "Ten en cuenta que puedes llamar a la función de forma recursiva dentro del hueco del bloque RETURN."}
            } },
             { "INF_6_6_T_2", new Dictionary<string, string>()
            {
                { "ENG", "By the way!"},
                { "ESP", "¡Por cierto!"}
            } },
            { "INF_6_6_E_2", new Dictionary<string, string>()
            {
                { "ENG", "Oh! and you can put multiple RETURN blocks, but it only makes sense in different branches (IF, ELSE...)"},
                { "ESP", "Ah! y puedes poner varios bloques de RETURN pero sólo tiene sentido en distintas ramas (IF, ELSE...)"}
            } },

            { "INF_6_7_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Recursion: level 6"},
                { "ESP", "Recursividad: nivel 6"}
            } },
            { "INF_6_7_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Using similar technique to the one of the previous level, calculate 6 FACTORIAL and make Bytey say it."},
                { "ESP", "Usando una técnica similar a la del nivel anterior, calcula el FACTORIAL de 6 y haz que BYtey lo diga."}
            } },
            { "INF_6_7_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Factorial"},
                { "ESP", "Factorial"}
            } },
            { "INF_6_7_E_1", new Dictionary<string, string>()
            {
                { "ENG", "The factorial of a number is the PRODUCT of all the numbers between 1 and that number."},
                { "ESP", "El factorial de un número es el PRODUCTO de todos los números entre 1 y ese número."}
            } },

             { "INF_6_8_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Recursion: level 8"},
                { "ESP", "Recursividad: nivel 8"}
            } },
            { "INF_6_8_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Bytey must move one step for each number lower than 4 in the array."},
                { "ESP", "Bytey debe moverse un paso por cada número menor a 4 que haya en el array."}
            } },
            { "INF_6_8_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Recursion: level 8"},
                { "ESP", "Recursividad: nivel 8"}
            } },
            { "INF_6_8_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Use recursion."},
                { "ESP", "Usa la recursividad."}
            } },
            { "INF_6_8_T_2", new Dictionary<string, string>()
            {
                { "ENG", "Clue"},
                { "ESP", "Pista"}
            } },
            { "INF_6_8_E_2", new Dictionary<string, string>()
            {
                { "ENG", "The parameter will be the index we're looking at. It returns the correspondent sum."},
                { "ESP", "El parámetro será el índice que vas a mirar. La función devuelve la suma correspondiente."}
            } },

            { "INF_6_9_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Recursion: level 9"},
                { "ESP", "Recursividad: nivel 9"}
            } },
            { "INF_6_9_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Bytey must move the number of steps equal to the lowest value of the array."},
                { "ESP", "Bytey debe moverse un número de pasos igual a el valor más pequeño del array."}
            } },
            { "INF_6_9_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Recursion: level 9"},
                { "ESP", "Recursividad: nivel 9"}
            } },
            { "INF_6_9_E_1", new Dictionary<string, string>()
            {
                { "ENG", "Use recursion."},
                { "ESP", "Usa la recursividad."}
            } },
            { "INF_6_9_T_2", new Dictionary<string, string>()
            {
                { "ENG", "Clue"},
                { "ESP", "Pista"}
            } },
            { "INF_6_9_E_2", new Dictionary<string, string>()
            {
                { "ENG", "Recieves an index as a parameter. Returns the lowest value."},
                { "ESP", "Recibe como parámetro el índice que va a mirar. Devuelve el número menor."}
            } },


             { "INF_6_10_T_0", new Dictionary<string, string>()
            {
                { "ENG", "Recursion: level 10"},
                { "ESP", "Recursividad: nivel 10"}
            } },
            { "INF_6_10_E_0", new Dictionary<string, string>()
            {
                { "ENG", "Sort the array from least to greatest using recursion."},
                { "ESP", "Ordena el array de menor a mayor usando la recursividad."}
            } },
            { "INF_6_10_T_1", new Dictionary<string, string>()
            {
                { "ENG", "Recursion: level 10"},
                { "ESP", "Recursividad: nivel 10"}
            } },
            { "INF_6_10_E_1", new Dictionary<string, string>()
            {
                { "ENG", "This time we don't need to return anything, so we'll use the function only with parameters"},
                { "ESP", "En este caso no es necesario devolver nada, asique usamos la función sólo con parámetros."}
            } },
            { "INF_6_10_T_2", new Dictionary<string, string>()
            {
                { "ENG", "Clue"},
                { "ESP", "Pista"}
            } },
            { "INF_6_10_E_2", new Dictionary<string, string>()
            {
                { "ENG", "Is smoke coming out of your ears? You can find lots of examples of this in the internet."},
                { "ESP", "¿Ya te empieza a salir humo de las orejas? En internet puedes encontrar muchos ejemplos de esto."}
            } },


             { "MSG_3_8_1", new Dictionary<string, string>()
            {
                { "ENG", "\"higher\""},
                { "ESP", "\"mayor\""}
            } },
              { "MSG_1_5", new Dictionary<string, string>()
            {
                { "ENG", "\"step\""},
                { "ESP", "\"paso\""}
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
        string lang = PlayerPrefs.GetString("LANGUAGE", "ESP");
        foreach (Text text in texts)
        {
            text.text = getString(text.text, lang);
        }
    }
}
