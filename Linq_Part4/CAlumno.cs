﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Part4
{
    class CAlumno
    {
        private string nombre;
        private int id;

        public CAlumno(string pNombre, int pID)
        {
            nombre = pNombre;
            id = pID;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }


        public override string ToString()
        {
            return string.Format("Estudiante {0}, {1}", nombre, id);
        }
    }
}
