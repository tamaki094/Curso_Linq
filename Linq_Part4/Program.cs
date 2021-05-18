using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Linq_Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<CEstudiante> estudiantes = new List<CEstudiante>
            //{
            //    new CEstudiante("Ana", "A100", "Mercadotecnia", 10.0),
            //    new CEstudiante("Luis", "S250", "Orientado a objetos", 9.0),
            //    new CEstudiante("Juan", "S875", "Programacion Basica", 5.0),
            //    new CEstudiante("Susana", "A432", "Mercadotecnia", 8.7),
            //    new CEstudiante("Pablo", "A156", "Mercadotecnia", 4.3),
            //    new CEstudiante("Alberto", "S456", "Programacion orientada a objetos", 8.3),
            //};

            //var reprobados = from e in estudiantes
            //                 where e.Promedio <= 5.0
            //                 select e;

            //Console.WriteLine("Reprobados");
            //foreach (CEstudiante estudiante in reprobados)
            //{
            //    Console.WriteLine(estudiante);
            //}


            //queryArrayList();


            //ArrayList estudiantes = new ArrayList()
            //{
            //    new CEstudiante("Ana", "A100", "Mercadotecnia", 10.0),
            //    new CEstudiante("Luis", "S250", "Orientado a objetos", 9.0),
            //    new CEstudiante("Juan", "S875", "Programacion Basica", 5.0),
            //    new CEstudiante("Susana", "A432", "Mercadotecnia", 8.7),
            //    new CEstudiante("Pablo", "A156", "Mercadotecnia", 4.3),
            //    new CEstudiante("Alberto", "S456", "Programacion orientada a objetos", 8.3),
            //};

            //var estL = estudiantes.OfType<CEstudiante>();

            //var reprobados = from e in estL
            //                 where e.Promedio <= 5.0
            //                 select e;


            //Console.WriteLine("Reprobados");

            //foreach (CEstudiante estudiante in reprobados)
            //{
            //    Console.WriteLine(estudiante);
            //}
            //Console.WriteLine("----------------------------------");


            //List<CEstudiante> estudiantes = new List<CEstudiante>
            //{
            //    new CEstudiante("Ana", "A100", "Mercadotecnia", 10.0),
            //    new CEstudiante("Luis", "S250", "Orientado a objetos", 9.0),
            //    new CEstudiante("Juan", "S875", "Programacion Basica", 5.0),
            //    new CEstudiante("Susana", "A432", "Mercadotecnia", 8.7),
            //    new CEstudiante("Pablo", "A156", "Mercadotecnia", 4.3),
            //    new CEstudiante("Alberto", "S456", "Programacion orientada a objetos", 8.3),
            //    new CEstudiante("Edri", "A094", "Programacion orientada a objetos", 10),
            //};


            //var nombrePromedio = from e in estudiantes
            //                     select new { e.Nombre, e.Promedio };

            //foreach (var np in nombrePromedio)
            //{
            //    Console.WriteLine(np.ToString());
            //}




            //List<CEstudiante> estudiantes = new List<CEstudiante>
            //{
            //    new CEstudiante("Ana", "A100", "Mercadotecnia", 10.0),
            //    new CEstudiante("Luis", "S250", "Orientado a objetos", 9.0),
            //    new CEstudiante("Juan", "S875", "Programacion Basica", 5.0),
            //    new CEstudiante("Susana", "A432", "Mercadotecnia", 8.7),
            //    new CEstudiante("Pablo", "A156", "Mercadotecnia", 4.3),
            //    new CEstudiante("Alberto", "S456", "Programacion orientada a objetos", 8.3),
            //    new CEstudiante("Edri", "A094", "Programacion orientada a objetos", 10),
            //};

            ////CONTEO
            //int cantidad = (from e in estudiantes
            //                where e.Promedio > 5
            //                select e).Count();

            //Console.WriteLine("La cantidad de aprobados es {0}", cantidad);


            //Console.WriteLine("---------------------");


            ////REVERSA
            //var aprobados = from e in estudiantes
            //                where e.Promedio > 5
            //                select e;

            //foreach(CEstudiante est in aprobados)
            //{
            //    Console.WriteLine(est);
            //}

            //Console.WriteLine("Orden inverso");

            //foreach (CEstudiante est in aprobados.Reverse())
            //{
            //    Console.WriteLine(est);
            //}


            ////ORDENAMIENTO

            //Console.WriteLine("Ordenamiento: Descendente");
            //var ordenados = from e in estudiantes
            //                orderby e.Promedio descending
            //                select e;

            //foreach(CEstudiante est in ordenados)
            //{
            //    Console.WriteLine(est);
            //}



            //var ordenadosA = from e in estudiantes
            //                 orderby e.Promedio ascending
            //                 select e;
            //Console.WriteLine("Ordenamiento: Ascendente");

            //foreach (CEstudiante est in ordenadosA)
            //{
            //    Console.WriteLine(est);
            //}


            //int[] numeros = { 2, 7, 89, 45, 31, 32, 46, 52, 3, 99, 101 };

            //Console.WriteLine("----------------------------");


            //int maximo = (from n in numeros select n).Max();
            //Console.WriteLine("El maximo es {0}", maximo);

            //int minimo = (from n in numeros select n).Min();
            //Console.WriteLine("El minimo es {0}", minimo);

            //double promedio = (from n in numeros select n).Average();
            //Console.WriteLine("El promedio es {0}", promedio);


            //double suma = (from n in numeros select n).Sum();
            //Console.WriteLine("La suma es {0}", suma);


            //List<int> conjunto1 = new List<int> { 2, 4, 6, 8, 9 };
            //List<int> conjunto2 = new List<int> { 2, 5, 6, 7, 9 };

            ////Except: nos da la diferiencia entre dos contenedores

            //var excpt = (from n1 in conjunto1 select n1).Except(from n2 in conjunto2 select n2);

            //Console.WriteLine("Except");
            //foreach (int num in excpt)
            //{
            //    Console.WriteLine(num);
            //}



            ////Intersect: nos da lo comun entre dos contenedores
            //var ints = (from n1 in conjunto1 select n1).Intersect(from n2 in conjunto2 select n2);

            //Console.WriteLine("Intersect");
            //foreach (int num in ints)
            //{
            //    Console.WriteLine(num);
            //}


            ////Union: nos da la union de los dos contenedores sin repeticiones

            //var un = (from n1 in conjunto1 select n1).Union(from n2 in conjunto2 select n2);

            //Console.WriteLine("Union");


            //foreach (var n in un)
            //{
            //    Console.WriteLine(n);           
            //}

            ////Concat: concateena directamente los contenedores

            //var concatenado = (from n1 in conjunto1 select n1).Concat(from n2 in conjunto2 select n2);

            //Console.WriteLine("Concat");


            //foreach (var n in concatenado)
            //{
            //    Console.WriteLine(n);
            //}


            ////Distinc: remueve los duplicados

            //Console.WriteLine("Distinct");

            //foreach (var item in concatenado.Distinct())
            //{
            //    Console.WriteLine(item);
            //}


            //sintaxisFluida();


            //operadoresLinq();

            //subQuery();


            //queryProgresivo();


            //operadoresLinqPart2();

            //linqParaXml();

            //xmlDocument();

            //ArreglosXml();

            //StringXml();

            ElementosXml();
        }

        private static void queryArrayList()
        {
            ArrayList lista = new ArrayList();
            lista.AddRange(new object[] { "hola", 5, 6.7, false, 4, 2, "saludos", 3.5, 3 });

            var enteros = lista.OfType<int>();


          
            foreach(int n in enteros)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("-------------------");
       
        }



        private static void sintaxisFluida()
        {
            int[] numeros = { 978,1, 2, 3,578, 4, 333,5, 6, 7, 8, 9, 10, 11, 12, 621, 13, 14, 15, 16, 89, 17, 18 };
            IEnumerable<int> pares = numeros.Where(n => n % 2 == 0);
            foreach(int num in pares)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("-------------------");



            string[] postres = {"manzana caramelizada", "pay de manzana", "pastel de chocolate", "pay de limon", "brownies", "chesecake", "fresas con crema", "atole", "capirotada" };

            IEnumerable<string> encontrados = postres.Where(p => p.Contains("manzana"));

            foreach (string postre in encontrados)
            {
                Console.WriteLine(postre);
            }

            Console.WriteLine("-------------------");


            IEnumerable<string> manzanas = postres
                .Where(p => p.Contains("manzana"))
                .OrderBy(p => p.Length)
                .Select(p => p.ToUpper());

            foreach (string manzana in manzanas)
            {
                Console.WriteLine(manzana);
            }

            Console.WriteLine("-------------------");

        }


        private static void operadoresLinq()
        {
            int[] numeros = { 978, 1, 2, 3, 578, 4, 333, 5, 6, 7, 8, 9, 10, 11, 12, 621, 13, 14, 15, 16, 89, 17, 18 };
            IEnumerable<int> desdeInicio = numeros.Take(5);

            foreach (int n in desdeInicio)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("-------------------------------");

            IEnumerable<int> brinco = numeros.Skip(5);

            foreach (int n in brinco)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("-------------------------------");

            int primero = numeros.First();

            Console.WriteLine("El primero es {0}", primero);

            Console.WriteLine("-------------------------------");

            int ultimo = numeros.Last();

            Console.WriteLine("El ultimo es {0}", ultimo);

            Console.WriteLine("-------------------------------");


            int indice = numeros.ElementAt(5);

            Console.WriteLine("En el indice 5 esta  {0}", indice);

            Console.WriteLine("-------------------------------");


            bool any = numeros.Any();

            Console.WriteLine("La secuencia contiene elementos  {0}", any);
            Console.WriteLine("Hay multiplos de 5 - {0}", numeros.Any(n => n % 5 == 0));

            Console.WriteLine("-------------------------------");
        }


        private static void subQuery()
        {
            string[] postres = { 
                "manzana caramelizada"
                , "pay de manzana"
                , "pastel de chocolate"
                , "pay de limon"
                , "brownies"
                , "chesecake"
                , "fresas con crema"
                , "atole"
                , "capirotada"
                , "tiramisu"
                , "helado"
                , "platanos con crema"
                , "flan"
                , "gelatina"
                , "pastel tres leches"
                , "tortas de platano"
                , "pan de zanahoria"
                , " duraznos con crema"
                , "nieve"
                , "chamoyada"
                , "volcan de chocolate"
            };

            //Ordenar de acuerdo a la ultima palabra del elemento
            IEnumerable<string> resultados = postres.OrderBy(p => p.Split().Last());


            foreach (string postre in resultados)
            {
                Console.WriteLine(postre);
            }

            Console.WriteLine("---------------------------------------");


            int[] numeros = {19, 978, 1, 2, 3, 578, 4, 333, 5, 6, 7, 8, 9, 10, 11, 12, 621, 13, 14, 15, 16, 89, 17, 18, 1000, 977, 1005 };

            IEnumerable<int> nums = numeros.Where(n => n < numeros.First()).OrderByDescending(n => n);

            foreach (int n in nums)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("---------------------------------------");


            IEnumerable<int> nums3 = numeros
                .Where(n => n <= (numeros.Where(n2 => n2 % 2 == 0)).First()).OrderBy(m => m);

            foreach (int n in nums3)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("---------------------------------------");
        }

        private static void queryProgresivo()
        {
            string[] postres = {
                "manzana caramelizada"
                , "pay de manzana"
                , "pastel de chocolate"
                , "pay de limon"
                , "brownies"
                , "chesecake"
                , "fresas con crema"
                , "atole"
                , "capirotada"
                , "tiramisu"
                , "helado"
                , "platanos con crema"
                , "flan"
                , "gelatina"
                , "pastel tres leches"
                , "tortas de platano"
                , "pan de zanahoria"
                , " duraznos con crema"
                , "nieve"
                , "chamoyada"
                , "volcan de chocolate"
                , "pay de manzana y pera"
            };

            bool mayusculas = true;

            IEnumerable<string> resultado;

            var manzanas = postres.Where(n => n.Contains("manzana"));
            var ordenadas = manzanas.OrderBy(n => n);

            if(mayusculas)
            {
                resultado = ordenadas.Select(n => n.ToUpper());
            }
            else
            {
                resultado = ordenadas.Select(n => n.ToLower());
            }


            foreach(string postre in resultado)
            {
                Console.WriteLine(postre);
            }

            Console.WriteLine("---------------------------------------");

            //INTO:  se puede interpretar de dos formas, aqui lo vemos en una contoniacion de query
            //solo se puede usar despues de un select o group
            //Digamos que reinicia el query pwermitiendo tener otros where, order by y select


            // Ojo con into! , las variables de rango salen de ambito, p no sera conocido por el query de pays\




            IEnumerable<string> encontrados = from p in postres
                                              where p.Contains("manzana")
                                              orderby p
                                              select p
                                              into pays
                                              where pays.Contains("pay")
                                              select pays;

            foreach(string postre in encontrados)
            {
                Console.WriteLine(postre);
            }

            Console.WriteLine("------------------");


            //Envolver Queries - weapping
            //es otra opcion de cini oidenis trabajar con el query
            //No confundir esta tecnica con los subqueries que colocan el query en la expresion lambda

            IEnumerable<string> mipay = from p in
                                            (
                                            from p1 in postres
                                            where p1.Contains("manzana")
                                            orderby p1
                                            select p1
                                            )
                                        where p.Contains("pay")
                                        select p;

            foreach (string postre in mipay)
            {
                Console.WriteLine(postre);
            }

            Console.WriteLine("-----------------------------------------");



            //LET: nos permite colocar una nueva variable junto con la de rango

            IEnumerable<string> mispays = from p in postres
                                          let manzanitas = (
                                          from p1 in postres
                                          where p1.Contains("manzana")
                                          orderby p1
                                          select p1)
                                          where manzanitas.Contains("pay")
                                          select p;

            foreach (string pay in mispays)
            {
                Console.WriteLine(pay);
            }

            Console.WriteLine("-----------------------------------------");
        }

        private static void operadoresLinqPart2()
        {
            /**
             * Hay tres categorias para los operadoes de query
             * Secuencia asecuancia: secuencia de entrada, secuencia de SALIDA
             * Secuencia de entrrada: elemento sencillo o escalar
             * Nada de entrada: secuencia de saida
             * 
             * Secuencia a secuencia:
             * Filtro: where, take, takewhile, skip, skipwhile, distict
             * Proyeccion: select, selectmany
             * Union: join, groupjoin, zip
             * Ordenamiento: orderby, thenby, reverse
             * Agrupamiento: groupby
             * Conversion import: oftype, cast
             * 
             * Secuencia a elemento o escalar
             * Operadores deelemento: first, firstordefault, last, lastordefault, single, singleordefault, elementat, elemntarordefault, defaultempty      * Agregacion: aggregate, average, count, longcount, sum, max, min
             * Cuantifdicador: all, any, contains, sequenceequal
             * 
             * Nada de entrada, secuencia de salida
             * Generacion: empty, range, repeat
             */




            ////Where
            string[] postres = {
                "manzana caramelizada"
                , "pay de manzana"
                , "pastel de chocolate"
                , "pay de limon"
                , "brownies"
                , "pay de queso"
                , "fresas con crema"
                , "atole"
                , "capirotada"
                , "tiramisu"
                , "helado"
                , "platanos con crema"
                , "flan"
                , "gelatina"
                , "pastel tres leches"
                , "tortas de platano"
                , "pan de zanahoria"
                , " duraznos con crema"
                , "nieve"
                , "chamoyada"
                , "volcan de chocolate"
                , "pay de manzana y pera"
                , "paleta de hielo"
                , "banana split"
                , "frappe"
                , "pastel redbelbet"
                , "pastel de helado"
                , "sandwich de helado"
                , "camote"
                , "palatanos fritos"
                , "arroz con leche"
                , "dulce de calabaza"
            };


            //Console.WriteLine("*------------------WHERE----------------* \r \n");
            //IEnumerable<string> r1 = postres.Where((n, i) => i % 2 == 0);

            //foreach (string postre in r1)
            //{
            //    Console.WriteLine(postre);
            //}


            //Console.WriteLine("*------------------StartsWith----------------* \r \n");
            //IEnumerable<string> r2 = from p in postres
            //                         where p.StartsWith("pay")
            //                         select p;

            //foreach (string postre in r2)
            //{
            //    Console.WriteLine(postre);
            //}


            //Console.WriteLine("*------------------EndsWith----------------* \r \n");
            //IEnumerable<string> r3 = from p in postres
            //                         where p.EndsWith("manzana")
            //                         select p;

            //foreach (string postre in r3)
            //{
            //    Console.WriteLine(postre);
            //}


            //int[] numeros = {  19, 978, 1, 2, 3, 578, 4, 333, 5, 6, 7, 8, 9, 10, 11, 12, 621, 13, 14, 15, 16, 89, 17, 18, 1000, 977, 1005 };


            ////TakeWhile enumera la secuencia de entrada y omite cada elemento hasta que el predicado es falso e ignora el resto

            //Console.WriteLine("*------------------TakeWhile----------------* \r \n");
            //var r4 = numeros.TakeWhile(n => n < 8);

            //foreach (int i in r4)
            //{
            //    Console.WriteLine(i);
            //}

            ////SkypeWhile enumera la secuencia ignora los elementos hasta que el predicado es falso y omite el resto
            //Console.WriteLine("*------------------SkipWhile----------------* \r \n");

            //var r5 = numeros.SkipWhile(n => n < 8);

            //foreach (int i in r5)
            //{
            //    Console.WriteLine(i);
            //}


            ////Proyeccion
            ////Select transforma el elemento de entrada con la expresion lambda
            ////Selectmany transforma el elemento, lo aplana y concatena con las subsecuencias resultantes

            ////Proyeccion indexada
            //Console.WriteLine("*------------------Slect Indexado----------------* \r \n");
            //IEnumerable<string> r6 = postres.Select((p, i) => " Indice " + i + " para el postre " + p);

            //foreach (string postre in r6)
            //{
            //    Console.WriteLine(postre);
            //}

            ////SelectMany
            ////En sekect cada elemento de entrada produce un elemento de salida
            ////En SelectMany produce 0...n elementos

            //Console.WriteLine("*------------------SlectMany----------------* \r \n");

            //IEnumerable<string> r7 = postres.SelectMany(p => p.Split());

            //foreach (string postre in r7)
            //{
            //    Console.WriteLine(postre);
            //}


            //Console.WriteLine("-Comparemos ocn select: \r \n");

            //IEnumerable<string[]> r8 = postres.Select(p => p.Split());

            //foreach (string[] postre_frase in r8)
            //{
            //    Console.WriteLine("***Postre:");
            //    foreach (string palabra_postre in postre_frase)
            //    {
            //        Console.WriteLine(palabra_postre);
            //    }
            //}


            ////Console.WriteLine("*------------------Select con multiples varoables de rango----------------* \r \n");

            ////IEnumerable<string> r9 = from p in postres
            ////                         from p1 in p.Split()
            ////                         select p1 + " ===" + p;


            ////foreach (string n in r9)
            ////{
            ////    Console.WriteLine(n);
            ////}

            ////IEnumerable<string> r10 = from p in postres
            ////                         from p1 in postres
            ////                         select "Yo quiero " + p1 + " y tu quieres " + p;

            ////foreach (string n in r10)
            ////{
            ////    Console.WriteLine(n);
            ////}


            Console.WriteLine("*------------------Join----------------* \r \n");

            List<CAlumno> estudiantes = new List<CAlumno>
            {
                new CAlumno("Ana", 1),
                new CAlumno("Mario", 2),
                new CAlumno("Susana", 3),
                new CAlumno("Alan", 4),
            };


            List<CCurso> cursos = new List<CCurso>
            {
                new CCurso("Progrmacion Orientada a Objetos", 1),
                new CCurso("Progrmacion estructurada", 2),
                new CCurso("Administracion de bases de datos", 3),
                new CCurso("Diseno por computadora", 4),
                new CCurso("Analisis y diseno de sistemas", 5),
                new CCurso("Redes", 6),
                new CCurso("Logica Computacional", 7),
                new CCurso("Arquitectura Computacional", 9),
                new CCurso("Algoritmos computacionales", 10),
                new CCurso("Bases de datos relacionales", 11),
                new CCurso("Ingenieria del Software", 12)
            };


            List<CAlumnoCurso> alumnos_cursos = new List<CAlumnoCurso>
            {
                new CAlumnoCurso(1, 1),
                new CAlumnoCurso(1, 3),
                new CAlumnoCurso(1, 5),
                new CAlumnoCurso(2, 11),
                new CAlumnoCurso(3, 4),
                new CAlumnoCurso(3, 6),
                new CAlumnoCurso(4, 1),
                new CAlumnoCurso(4, 1),
                new CAlumnoCurso(4, 2),
                new CAlumnoCurso(4, 3),
                new CAlumnoCurso(4, 4),
                new CAlumnoCurso(4, 5),
                new CAlumnoCurso(4, 6),
                new CAlumnoCurso(4, 7),
                new CAlumnoCurso(4, 8),
            };




            //var listado1 = from e in estudiantes
            //               from c in cursos
            //               where c.Id == e.Id
            //               select e.Nombre + " esta en el curso " + c.Curso;

            //var listado2 = from e in estudiantes
            //               join c in cursos on e.Id equals c.Id
            //               select e.Nombre + " esta en el curso " + c.Curso;

            //Console.WriteLine("-****Join sin usar clausula join   \r \n");

            //foreach (string item in listado1)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-****Join usando clausula join   \r \n");

            //foreach (string item in listado2)
            //{
            //    Console.WriteLine(item);
            //}


            //  GroupJoin: los resultados se obtienen de forma jerarquica
            //la sintaxis es la misma pero utilizamos into

            var listado3 = from e in estudiantes
                            join ce in alumnos_cursos on e.Id equals ce.IdAlumno
                            into tmpListado
                            select new { estudiante = e.Nombre, tmpListado };

            foreach (var lst in listado3)
            {
                Console.WriteLine(lst.estudiante + " tiene " + lst.tmpListado.Count() + " materias ");

                foreach (var lst2 in lst.tmpListado)
                {
                    Console.WriteLine(lst2);
                }
            }


            var listado4 = from e in estudiantes
                           join ce in alumnos_cursos on e.Id equals ce.IdAlumno
                           join c in cursos on ce.IdCurso equals c.Id
                           select new { 
                               Nombre_Estudiante = e.Nombre ,
                               Curso = c.Curso
                           };
            
            foreach (var item in listado4)
            {
                Console.WriteLine(item);
            }


            //ZIP : Regresa una secuencia que aplica una funcion a cada par

            Console.WriteLine("*----------------- ZIP ---------------------* \r \n");

            string[] helados = { "chocolate", "fresa", "vainilla", "limon"};
            IEnumerable<string> r12 = postres.Zip(helados, (p, h) => p + " con helado de " + h);

            foreach(string n in r12)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("*----------------- ORDENAMIENTO ---------------------* \r \n");

            string[] palabras = { "hola", "piedra", "pato", "pastel", "carros", "auto"};

            //ordenar palabras por (orderby/(longitud) y luego ThenBy(alfabeticamente)
            IEnumerable<string> palabrasOrd = palabras.OrderBy(p => p.Length).ThenBy(p => p);

            foreach (string palabra in palabrasOrd)
            {
                Console.WriteLine(palabra);
            }


            Console.WriteLine("*----------------- Agrupamiento ---------------------* \r \n");

            string[] archivos = System.IO.Directory.GetFiles("C:\\");

            Console.WriteLine("Archivos obtenidos por GetFiles");

            foreach (string archivo in archivos)
            {
                Console.WriteLine(archivo);
            }

            var archivoAg = archivos.GroupBy(a => System.IO.Path.GetExtension(a));

            Console.WriteLine("Resultados agrupados");

            foreach(IGrouping<string, string> g in archivoAg)
            {
                Console.WriteLine("Archivos de extension {0} ", g.Key);
                foreach (string archivo in g)
                {
                    Console.WriteLine(" \t {0} ", archivo);
                }
            }

            int[] numeros = {1,2,3, 4 };

            Console.WriteLine("*----------------- Agregacion ---------------------* \r \n");

            int agregado = numeros.Aggregate(0, (t, n) => t + (n * 2));
            //0 + (1 * 2) = 2
            //2 + (2 * 2) = 6
            //6 + (3 * 2) = 12
            //12 + (4 * 2) = 20

            Console.WriteLine(agregado);


            Console.WriteLine("*----------------- Cuantificadores ---------------------* \r \n");
            Console.WriteLine("*--All \n");

            //devuelve tru si todos los elementos cumplen con la exprecion del predicado
            bool todos = numeros.All(n => n < 10);
            Console.WriteLine(todos);

            int[] numeros2 = {1, 2 ,3 ,4};

            Console.WriteLine("*--SequenceEqual \n");

            //compara que dos secuencias sean iguales
            bool iguales = numeros.SequenceEqual(numeros2);

            Console.WriteLine(iguales);



        }


        private static void  linqParaXml()
        {
            XElement raiz = new XElement("raiz");
            XElement el1 = new XElement("Elemento1");
            el1.Add(new XAttribute("atributo", "valor"));
            el1.Add(new XAttribute("Anidado", "Contenido"));

            raiz.Add(el1);

            Console.WriteLine(raiz);

            Console.WriteLine("-------------------------------");


            //esta forma de crear el documento se conoce como construccion funcional


            XElement documento = new XElement("Alumnos",
                new XElement("Ana", new XAttribute("ID", "10100"),
                    new XElement("Curso", "Administracion"),
                    new XElement("Promedio", "10")),
                new XElement("Luis", new XAttribute("ID", "25350"),
                    new XElement("Curso", "Programacion"),
                    new XElement("Promedio", "9.5")
                )
            );


            Console.WriteLine(documento);

            documento.Save("Alumnos.xml");
        }

        private static void xmlDocument()
        {
            XDocument documento = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Listado alumnos"),
                new XProcessingInstruction("xml-stylesheet", "href='MyStyles.css' title='Compact' type='text/css'"),
                new XElement("Alumnos",
                    new XElement("Ana", new XAttribute("ID", "10100"),
                        new XElement("Curso", "Administracion"),
                        new XElement("Promedio", "10")),
                    new XElement("Luis", new XAttribute("ID", "25350"),
                        new XElement("Curso", "Programacion"),
                        new XElement("Promedio", "9.5")
                    )
                )
            );

            documento.Save("Alumnos_2.xml");

            Console.WriteLine(documento);
        }

        private static void ArreglosXml()
        {
            var listado = new[]
            {
                new {Nombre = "Jose", Calif=8, Curso="Programacion"},
                new {Nombre = "Susana", Calif=9, Curso="UML"},
                new {Nombre = "Maria", Calif=10, Curso="Orientado a objetos"},
                new {Nombre = "Luis", Calif=10, Curso="UML"}
            };

            XElement alumnos = new XElement("Alumnos",
                from a in listado
                select new XElement("Alumno", new XAttribute("Nombre", a.Nombre),
                        new XElement("Curso", a.Curso),
                        new XElement("Calificacion", a.Calif)
                        )
                );


            Console.WriteLine(alumnos);

            alumnos.Save("Alumnos_" + DateTime.Now.ToString("yyyymMMdd_HHMMss") + ".xml");
        }

        private static void StringXml()
        {
            string alumnos = @"<Alumnos>
              <Alumno Nombre='Jose'>
                <Curso>Programacion</Curso>
                <Calificacion>8</Calificacion>
              </Alumno>
              <Alumno Nombre='Susana'>
                <Curso>UML</Curso>
                <Calificacion>9</Calificacion>
              </Alumno>
              <Alumno Nombre='Maria'>
                <Curso>Orientado a objetos</Curso>
                <Calificacion>10</Calificacion>
              </Alumno>
              <Alumno Nombre='Luis'>
                <Curso>UML</Curso>
                <Calificacion>10</Calificacion>
              </Alumno>
            </Alumnos>";


            XElement alumnosx = XElement.Parse(alumnos);

            Console.WriteLine(alumnosx);
        }


        private static void ElementosXml()
        {

            var escuela = new XElement("Escuela",
                                            new XElement("Ciencias_Exactas",
                                                new XElement("Materia", "Matematicas"),
                                                new XElement("Materia", "Fisica"),
                                                new XElement("Materia", "Quimica")
                                            ),
                                            new XElement("Artes",
                                                new XElement("Materia", "Historia del arte"),
                                                new XElement("Practica", "Pintura"),
                                                new XElement("Practica", "Danza"),
                                                new XElement("Practica", "Teatro y Actuacion")
                                            ),
                                            new XElement("Ciencias_Sociales",
                                                new XElement("Materia", "Civismo"),
                                                new XElement("Materia", "Espanol"),
                                                new XElement("Materia", "Piscologia"),
                                                new XElement("Materia", "Derecho Penal")
                                            )
                                        );


            Console.WriteLine(escuela);
            Console.WriteLine("-----------------------------------");

            //Nodes regresa a los hijos
            foreach (XNode node in escuela.Nodes())
            {
                Console.WriteLine(node.ToString());
            }

            Console.WriteLine("-----------------------------------");
            // Elements regresa a los hijos de los nodos de tipo XElement
            foreach (XElement elemento in escuela.Elements())
            {
                Console.WriteLine(elemento.Name  +  " = " + elemento.Value);
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine(escuela.FirstNode);


            Console.WriteLine("-----------------------------------");
            Console.WriteLine(escuela.FirstNode.Parent.Name);



            Console.WriteLine("-----------------------------------");
            Console.WriteLine(escuela.LastNode);

            IEnumerable<string> materias = from curso in escuela.Elements()
                                           where curso.Elements().Any(materia => materia.Value == "Fisica")
                                           select curso.Value;

            Console.WriteLine("-----------------------------------");
            //Obtiene todos los elementos del curso sonse se encuentre Fisica
            foreach (string item in materias)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("-----------------------------------");
            //Obtiene el nombre del elemento de padre de Fisica
            IEnumerable<XName> tipoCurso = from curso in escuela.Elements()
                                           where curso.Elements().Any(materia => materia.Value == "Fisica")
                                           select curso.Name;


            foreach (XName name in tipoCurso)
            {
                Console.WriteLine(name);
            }



            Console.WriteLine("-----------------------------------");
            IEnumerable<string> materias2 = from curso in escuela.Elements()
                                            from asignatura in curso.Elements()
                                            where asignatura.Name == "Practica"
                                            select asignatura.Value;

            foreach(string m in materias2)
            {
                Console.WriteLine(m);
            }


            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Hay {0} Ciencias Exactas " , escuela.Elements("Ciencias_Exactas").Count());


            Console.WriteLine("-----------------------------------");
            string mat = escuela.Element("Ciencias_Exactas").Element("Materia").Value;
            Console.WriteLine(mat);


            Console.WriteLine("-----------------------------------");
            escuela.SetElementValue("Deportes", "No Hay");     
            Console.WriteLine(escuela);
            Console.WriteLine("*--------------------");
            escuela.SetElementValue("Deportes", "Sin Presupuesto");
            Console.WriteLine(escuela);

            Console.WriteLine("-----------------------------------");
            escuela.FirstNode.AddAfterSelf(new XElement("Asignaturas"));
            Console.WriteLine(escuela);



            Console.WriteLine("-----------------------------------");
            escuela.FirstNode.AddBeforeSelf(new XElement("Escuela_Libre"));
            Console.WriteLine(escuela);

            Console.WriteLine("-----------------------------------");
            var mate2 = escuela.Element("Ciencias_Exactas").Element("Materia");
            mate2.SetValue("Geometria no Euclidiana");
            Console.WriteLine(escuela);


            Console.WriteLine("-----------------------------------");
            XDocument alumnos = XDocument.Load("Alumnos_2021120517_130531.xml");
            Console.WriteLine(alumnos);

            Console.WriteLine("-----------------------------------");
            //Eliminamos a los maestros
            alumnos.Descendants("Maestros").Remove();
            Console.WriteLine(alumnos);

            //Console.WriteLine("-----------------------------------");
            ////Eliminamos las calificaciones
            //alumnos.Descendants("Calificacion").Remove();
            //Console.WriteLine(alumnos);

            Console.WriteLine("-----------------------------------");
            //Obtenemos las calificaciones
            var califs = from a in alumnos.Descendants("Calificacion")
                         select a.Value;

            foreach(var calif in califs)
            {
                Console.WriteLine(calif);
            }
        }
    }
}
