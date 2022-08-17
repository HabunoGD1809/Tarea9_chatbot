using Newtonsoft.Json;
class Chatbot{

    public static string Name = "";
    public static string Artificial(string pregunta){

        pregunta = pregunta.ToLower();

        var respuesta = "\nNo entendí tu pregunta";

        if(pregunta.Contains("rector") || (pregunta.Contains("Omar".ToLower()))){
            respuesta = @"
        El nombre del rector es Omar Mendez.. Si deseas saber más, visita: 
        https://twitter.com/rec_omarmendez";
        }
        if(pregunta.Contains("Amadis".ToLower()))
        {
            respuesta = @"
        Amadis Suarez Genao es un desarrollador de soluciones tecnologicas,
        integraciones en diferentes tecnologias: Web, Movil y Escritorio... 
        Si deseas saber más, visita su sitio web: https://adamix.net";
        }
        if(pregunta.Contains("ubicado") || pregunta.Contains("ubicacion"))
        {
            respuesta = @"
        El ITLA se encuentra ubicado en la Autopista Las Américas, 
        Km. 27, La Caleta, Boca Chica, RD.";
        }
        if(pregunta.Contains("hora"))
        {
            respuesta = @"    
        La hora es: " + DateTime.Now.ToString("HH:mm:ss");
        }
        if(pregunta.Contains("dia"))
        {
            respuesta = @"    
        El dia actual es: " + DateTime.Now.ToString("dddd");
        }
        if(pregunta.Contains("autor") || pregunta.Contains("creador")){
            respuesta = @"
        Mi autor es:         
            ╔═══╗            ╔╗  ╔╗       
            ║╔══╝            ║║  ║║       
            ║╚══╗╔═╗╔══╗ ╔═╗ ║║╔╗║║ ╔╗╔═╗ 
            ║╔══╝║╔╝╚ ╗║ ║╔╗╗║╚╝╝║║ ╠╣║╔╗╗
           ╔╝╚╗  ║║ ║╚╝╚╗║║║║║╔╗╗║╚╗║║║║║║
           ╚══╝  ╚╝ ╚═══╝╚╝╚╝╚╝╚╝╚═╝╚╝╚╝╚╝
            
                Nombre: Franklin J.
                Apellio: Valdez
                Matricula: 2022-0678
                Telefono: 809-580-4557";
        }
        if(pregunta.Contains("Carreras".ToLower()) || pregunta.Contains("carrera".ToLower())){
            respuesta = @"
        ITLA brinda 15 Carreras de Educación Superior:
            
            1.	Simulaciones interactivas y videojuegos
            2.	Telecomunicaciones
            3.	Inteligencia artificial
            4.	Informática forense
            5.	Energías renovables
            6.	Redes de información
            7.	Mecatrónica
            8.	Manufactura automatizada
            9.	Manufactura de dispositivos médicos
            10.	Diseño industrial
            11.	Multimedia
            12.	Sonido
            13.	Desarrollo de software
            14.	Analítica y ciencia de los datos
            15.	Seguridad informática";
        }
        if(pregunta.Contains("Simulaciones".ToLower()) || pregunta.Contains("Videojuegos".ToLower()) || pregunta.Contains("Interactivas".ToLower())){
            respuesta = @"
                        Tecnólogo Simulaciones interactivas y videojuegos:

        Al concluir el Tecnólogo en Desarrollo de Simulaciones Interactivas y Videojuegos, obtendrás los conocimientos en Programación; Marketing; Diseño Vectorial; Matemática; Programación Orientada a Objetos; Planeamiento de Negocios; Inteligencia Artificial; Guión y Storyboard; Modelado 3D; Marketing de Videojuegos; Arte Conceptual; Dibujo Técnico; Planificación lógica y estratégica; Animación 2D y 3D; Manipulación de imagen y sonido; Game design; Testeo; Realidad virtual; Captura de movimiento y todo lo necesario para llevar los proyectos desde el borrador inicial hasta su concreción final, listos para ser distribuidos.";
        }
        if (pregunta.Contains("Telecomunicaciones".ToLower()))
        {
            respuesta = @"
                                Tecnólogo en Telecomunicaciones:

        Al concluir el Tecnólogo en Telecomunicaciones serás capaz de diseñar, implementar y gestionar sistemas de telecomunicaciones; instalar, operar y mantener equipos electrónicos relacionados con sistemas de información y telecomunicación. Además, podrás dar soporte y mantenimiento a sistemas, determinar los requerimientos para la instalación y funcionamiento de redes de telecomunicación, ofrecer consultorías y ejecutar proyectos de telecomunicaciones. Esta carrera está orientada a la resolución de problemas contemporáneos, adaptándose a escenarios cambiantes, con alto sentido innovador y apegándose a los principios éticos y legales de la profesión.";
        }
        if (pregunta.Contains("Inteligencia".ToLower()) || pregunta.Contains("Artificial".ToLower()))
        {
            respuesta = @"
                            Tecnólogo en Inteligencia artificial:

        Al concluir el Tecnólogo en Inteligencia Artificial, tendrás la capacidad de modelar, diseñar y desarrollar sistemas de comportamiento inteligente, a fin de resolver problemas reales y retos que se puedan presentar en tus ámbitos laborales y de desarrollo profesional, guiados por la curiosidad, la pasión, la integridad, el trabajo en equipo y el mejoramiento continuo.";
        }
        if (pregunta.Contains("Informatica".ToLower()) || pregunta.Contains("Forense".ToLower()))
        {
            respuesta = @"
                        Tecnólogo en Informática Forense:

        Al completar el plan de estudios de manera exitosa serás capaz de:

        Planificar, gestionar y ejecutar investigaciones forenses que permitan identificar, preservar y presentar datos electrónicos válidos dentro de un proceso legal, ejerciendo su profesión con una fuerte orientación a la resolución de problemas complejos; adaptándose a los constantes cambios, con actitud emprendedora y ética.";
        }
        if (pregunta.Contains("Energias".ToLower()) || pregunta.Contains("Energia".ToLower()) || pregunta.Contains("Renovables".ToLower()) || pregunta.Contains("Renovable".ToLower()))
        {
            respuesta = @"
                            Tecnólogo en Energías Renovables:

        Al concluir el Tecnólogo en Energías Renovables, obtendrás conocimiento sobre la instalación, operación y mantenimiento de proyectos de pequeña y mediana escala de Energías Renovables para las actividades productivas de los distintos sectores industriales. Además, recibirás una importante formación matemática y eléctrica; estarás preparado para desarrollar proyectos de emprendimiento asociados a las Energías Renovables. Esta carrera promueve el desarrollo de personas integrales comprometidas con la sociedad, integrando la ética y el desarrollo de las competencias necesarias para el mundo de hoy como la capacidad de trabajar en equipo, así como también, la capacidad de generar ideas innovadoras, de aprender y actualizarse permanentemente.";
        }
        if (pregunta.Contains("Redes".ToLower()) || pregunta.Contains("Informacion".ToLower()))
        {
            respuesta = @"
                        Tecnólogo en Redes de Información:

        Al completar el plan de estudios de manera exitosa serás capaz de:

        Diseñar, implementar y gestionar arquitecturas de redes empresariales, desarrollando su práctica profesional con una fuerte orientación a la resolución de problemas contemporáneos, adaptándose a escenarios cambiantes, con alto sentido innovador y apegándose a los principios éticos y legales de la profesión.";
        }
        if (pregunta.Contains("Mecatronica".ToLower()) || pregunta.Contains("Automatizada".ToLower()))
        {
            respuesta = @"
                        Tecnólogo en Mecatrónica Automatizada:

        Como egresado del Tecnólogo en Mecatrónica dominarás la automatización de procesos de manufactura, integrando componentes mecánicos, eléctricos, electrónicos y de software aplicado al control. Podrás aplicar los procesos de producción la automatización para hacerlos más eficientes y emplear sistemas de control en los mismos.";
        }
        if (pregunta.Contains("Manufactura".ToLower()) || pregunta.Contains("Medicos".ToLower()))
        {
            respuesta = @"
                    Tecnólogo en Manufactura de dispositivos médicos:

        Al concluir el Tecnólogo de Manufactura Automatizada serás capaz de manejar equipos y maquinarias de Control Numérico Computarizado (CNC), realizar operaciones de Manufactura Integrada por Computador (CIM), operar y manejar con destreza máquinas herramientas programables, diseñar y fabricar moldes de inyección plástica y aplicar todos los métodos automatizados de manufactura.

        Obtendrás las habilidades para desenvolverte en industrias de metalmecánica dedicadas a la producción de piezas en masa o de extremada precisión, producción de moldes de inyección o piezas que requieran tecnologías de manufactura muy avanzadas.";
        }
        if (pregunta.Contains("Diseño".ToLower()) || pregunta.Contains("Industrial".ToLower()))
        {
            respuesta = @"
                            Tecnólogo en Diseño industrial:   

        Al finalizar el tecnólogo de Diseño Industrial estarás preparado para desempeñar labores en procesos de diseño y manufactura asistida por computador, construcción de componentes como moldes, los cuales permiten grandes volúmenes de fabricación; obtendrás destrezas en operaciones de construcción de maquetas, así como el manejo de materiales.";
        }
        if (pregunta.Contains("Multimedia".ToLower()))
        {
            respuesta = @"
                            Tecnólogo en Multimedia:

        Al concluir el Tecnólogo en Multimedia serás capaz de brindar soluciones de comunicación audiovisual de forma creativa y eficaz que den respuesta a las necesidades del sector empresarial, educativo e industria en general. Con una formación altamente orientada a la praxis, podrás adquirir las competencias esenciales en el uso de técnicas y tecnologías que permitan conceptualizar, diseñar y ejecutar proyectos de comunicación comercial y corporativa por medio de la animación 2D y 3D, diseño gráfico, web y editorial, ilustración, video y audio digital en agencias de publicidad, televisión y casas editoras, con alto sentido crítico e innovador, orientado a las tendencias y necesidades del mercado, fomentando el espíritu emprendedor.";
        }
        if (pregunta.Contains("Sonido".ToLower()))
        {
            respuesta = @"
                            Tecnólogo en Sonido:

        Al concluir el Tecnólogo en Sonido, contarás con las competencias necesarias para diseñar, desarrollar y supervisar la ejecución de proyectos de sonido por medio de técnicas y softwares de audio digital aplicables para audiovisuales, la radio, industria discográfica y del entretenimiento, desde espectáculos musicales hasta eventos corporativos, con sentido ético y responsable.";
        }
        if (pregunta.Contains("Desarrollo".ToLower()) || pregunta.Contains("Software".ToLower()))
        {
            respuesta = @"
                            Tecnólogo en Desarrollo de software:

        Al concluir el Tecnólogo en Desarrollo de Software conocerás todas las etapas que intervienen en el proceso de desarrollo de software, enfocándose en la práctica de las tareas más técnicas.

        Estarás capacitado para aplicar los conocimientos, técnicas, habilidades y herramientas modernas de la disciplina para las actividades de tecnología de ingeniería en sentido estricto.";
        }
        if (pregunta.Contains("Analitica".ToLower()) || pregunta.Contains("Ciencia".ToLower()) || pregunta.Contains("Datos".ToLower())){
            respuesta = @"
                            Tecnólogo en Analítica y ciencia de los datos:

        Al finalizar el Tecnólogo en Analítica y Ciencia de los datos contarás con competencias para manejar de las técnicas y herramientas aplicables a la analítica de datos con el objetivo de proponer soluciones basadas en evidencias y ser aplicadas en el mercado local e internacional.

        Podrás crear sistemas de información automatizados para la toma de decisiones, administrar bases de datos, diseñar y aplicar modelos y algoritmos para extraer conocimiento de valor a partir de dichos datos, analizar los datos para identificar patrones y tendencias e interpretar los datos para descubrir soluciones y oportunidades.";
        }
        if (pregunta.Contains("Seguridad".ToLower()) || pregunta.Contains("Informatica".ToLower()))
        {
            respuesta = @"
                            Tecnólogo en Seguridad informática:

        Al completar el plan de estudios de manera exitosa serás capaz de:

        Planificar, diseñar, implementar y administrar arquitecturas de ciberseguridad de acuerdo con las necesidades globales actuales, desempeñando sus funciones con un enfoque sólido de resolución de problemas complejos; siendo versátil, con actitud innovadora, ética, y de liderazgo.";
        }
        if(pregunta.Contains("nota") || pregunta.Contains("calificacion")){
            respuesta = @"
        La calificacion final de mi Creador será de 98 puntos.
            ";
        }
        if(pregunta.Contains("llegar") || pregunta.Contains("llego")){
            respuesta = @"
        Si desea saber como llegar al Instituto desde su ubicacion 
        visite:https://goo.gl/maps/UfrSCExq7TKRPcPH9";
        }
        if(pregunta.Contains("mi nombre es")){
            var palabras = pregunta.Split(' ');
            Chatbot.Name = palabras[palabras.Length - 1];
            respuesta = "Hola" + Chatbot.Name + "!";
        }
        else if(((pregunta.Contains("nombre") || pregunta.Contains("llamo") && pregunta.Contains("mi") || pregunta.Contains("me")))){
            if(Chatbot.Name.Length == 0){
                Console.WriteLine("Ingresa tu nombre: ");
                Chatbot.Name = Console.ReadLine() + " ";
            }
            respuesta = "Tu nombre es: " + Chatbot.Name;
        }
        return respuesta;
    }
    public static void saveName()
    {
        var save = JsonConvert.SerializeObject(Chatbot.Name);
        File.WriteAllText("name.json", save);
    }
}