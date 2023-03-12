using DAS_D1.Classes;

namespace DAS_D1
{
    public partial class AppForm : Form
    {
        List<EntertainmentProgramItem> entertainmentProgramItems = new();
        List<BookItem> bookItems = new();
        List<ProgrammingLanguageItem> programmingLanguageItems = new();

        public AppForm()
        {
            InitializeComponent();

        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            entertainmentProgramItems.Add(new EntertainmentProgramItem(
            "Game Of Thrones",
            "Juego de tronos",
            new string[] { "David Benioff", "D. B. Weiss" },
            new string[] {"Sean Bean",
            "Nikolaj Coster-Waldau",
            "Peter Dinklage",
            "Emilia Clarke",
            "Lena Headey",
            "Iain Glen",
            "Kit Harington",
            "Sophie Turner",
            "Maisie Williams",
            "Isaac Hempstead-Wright",
            "Natalie Dormer"},
            new string[] { "Estados Unidos" },
            8,
            73,
            "La trama de Game of \r\nThrones está basada en la serie \r\nde novelas Canción de hielo y \r\nfuego, y relata las vivencias de \r\nun grupo de personajes de \r\ndistintas casas nobiliarias en el \r\ncontinente ficticio Poniente para \r\ntener el control del Trono de \r\nHierro y gobernar los siete \r\nreinos que conforman el \r\nterritorio"
            ));

            entertainmentProgramItems.Add(new EntertainmentProgramItem(
            "CHERNOBYL",
            "Chernóbil",
            new string[] { "Craig Mazin" },
            new string[] { "Jared Harris", "Stellan Skarsgård", "Emily Watson" },
            new string[] { "Estados Unidos", "Reino Unido" },
            1,
            5,
            "La serie gira en torno al desastre \r\nnuclear de Chernóbil de abril de \r\n1986 y los esfuerzos de limpieza \r\nsin precedentes que siguieron. \r\nCuenta con un reparto \r\nencabezado por Jared Harris, \r\nStellan Skarsgård y Emily \r\nWatson.\r\n"
            ));

            entertainmentProgramItems.Add(new EntertainmentProgramItem(
            "THE MARVELOUS MRS. MAISEL",
            "La maravillosa Señora Maisel",
            new string[] { "Amy Sherman-Palladino" },
            new string[] { "Rachel Brosnahan", "Michael Zegen", "Alex Borstein", "Tony Shalhoub", "Marin Hinkle" },
            new string[] { "Estados Unidos" },
            3,
            26,
             "La serie cuenta la historia de un \r\nama de casa en Nueva York que \r\ndescubre que tiene una habilidad \r\nespecial para la comedia en vivo. \r\nEl primer episodio se estrenó \r\ncomo parte de la temporada de \r\npilotos de primavera de Amazon \r\nStudios el 17 de marzo de 2017, \r\nrecibiendo la aclamación de la \r\ncrítica."
            ));

            bookItems.Add(new BookItem(
                "HARRY \r\nPOTTER",
           "J. K. Rowling",
           "Novela",
           "Literatura fantástica\r\n, literatura \r\njuvenil\r\n, novela de \r\ndesarrollo\r\ny literatura infantil y \r\njuvenil",
           "3407 (ENG)\r\n3665 (ESP)\r\n",
           "Harry Potter\r\nRon weasley\r\nHermione Granger\r\nGinny Weasley\r\nNeville Longbottom\r\nAlbus Dumbledore",
           "Lord Voldemort\r\nMortífagos",
          "La historia comienza con la \r\ncelebración del mundo mágico. \r\nDurante muchos años, había sido \r\naterrorizado por el \r\nmalvado mago Lord Voldemort. \r\nLa noche del 31 de octubre, \r\nmató a Lily\r\ny James Potter. Sin \r\nembargo, cuando intenta matar a \r\nsu hijo de 1 año, Harry, la \r\nmaldición asesina Avada \r\nKedavra se vuelve sobre sí \r\nmismo. El cuerpo de Voldemort \r\nresulta destruido, pero él \r\nsobrevive: no está muerto ni \r\nvivo. Por su parte, a Harry solo \r\nle queda una cicatriz con forma \r\nde rayo en la frente que es el \r\núnico remanente físico de la \r\nmaldición de Voldemort. Harry \r\nes el único sobreviviente de la \r\nmaldición asesina, y a raíz de la \r\nmisteriosa derrota de Voldemort, \r\nel mundo mágico empieza a \r\nllamarlo como «el niño que \r\nsobrevivió»"
           ));

            bookItems.Add(new BookItem(
           "GOOSEBUMPS",
           "Robert Lawrence Stine",
           "Ciencia ficción, literatura infantil y suspenso",
           "Suspenso, terror, juvenil",
           "---",
           "El protagonista principal de una \r\nhistoria de Pesadillas / \r\nEscalofríos, es a menudo situado \r\nen una ubicación remota o de \r\nalguna manera aislada en \r\nalgunas situaciones.",
           "----",
           "La serie consta de un total de 60 \r\nlibros para España, el último de \r\nlos cuales (Sangre de monstruo \r\nIV) se publicó en 1999, mientras \r\nque en Hispanoamérica consta \r\nde 45 historias.\r\nEl nombre se tradujo en España \r\ncomo Pesadillas y en \r\nHispanoamérica \r\ncomo Escalofríos.\r\n"
           ));

            bookItems.Add(new BookItem(
           "PERRY MASON",
           "Erle Stanley Gardner",
           "Novela policiaca",
           "xx",
           "xx",
           "Perry Mason",
           "xx",
          "El personaje era un abogado que \r\nllegó a aparecer en 80 novelas e \r\nhistorias cortas, la mayoría de \r\nlas cuales versaban sobre la \r\ndefensa de un cliente que había \r\nsido acusado de asesinato. En \r\ngeneral, Perry Mason era capaz \r\nde demostrar la inocencia de su \r\ncliente mediante la averiguación \r\nde la culpabilidad del verdadero \r\nasesino, otro personaje de la \r\nhistoria."));

            programmingLanguageItems.Add(new ProgrammingLanguageItem(
           "PYTHON",
           "Python Software Foundation",
           ".py, .pyc, .pyd, .pyo, .pyw, .pyz",
           "1991",
           "Multiplataforma",
           "Orientado a objetos, imperativo, funcional, reflexivo",
           "3.8.3",
            "Python Software Foundation License"));

            programmingLanguageItems.Add(new ProgrammingLanguageItem(
            "JAVA",
            "James Gosling y Sun Microsystems",
            "java, class, jar, jad y jmod",
            "1996",
            "Multiplataforma",
            "Orientado a objetos, imperativo",
            "14.01",
             "Licencia: GNU GPL / Java Community Process"));

            programmingLanguageItems.Add(new ProgrammingLanguageItem(
           "JAVASCRIPT",
           "xx",
           ".js",
           "1995",
           "xx",
           "Multiparadigma, programación funcional, programación basada en prototipos, imperativo, interpretado (scripting)",
           "ECMAScript2016",
            "xx"));

            foreach (var entertainmentProgramItem in entertainmentProgramItems)
            {
                dgv1.Rows.Add(entertainmentProgramItem.Name,
                    entertainmentProgramItem.SpanishTitle,
                    string.Join(", ", entertainmentProgramItem.CreatedBy),
                    string.Join(", ", entertainmentProgramItem.Protagonists),
                    string.Join(", ", entertainmentProgramItem.OriginCountries),
                    entertainmentProgramItem.Seasons.ToString(),
                    entertainmentProgramItem.Episodes.ToString(),
                    entertainmentProgramItem.Synopsis
                    );
            }

            foreach (var book in bookItems)
            {
                dgv2.Rows.Add(book.Name,
                    book.Name,
                    book.Author,
                    book.Gender,
                    book.SubGender,
                    book.Pages,
                    book.Protagonists,
                    book.Antagonists,
                    book.Argument
                    );
            }

            foreach (var language in programmingLanguageItems)
            {
                dgv3.Rows.Add(
                    language.Name,
                    language.Developers,
                    language.Extensions,
                    language.YearOfCreation,
                    language.OS,
                    language.Paradigm,
                    language.LastVersion,
                    language.License
                    );
            }
        }
    }
}
