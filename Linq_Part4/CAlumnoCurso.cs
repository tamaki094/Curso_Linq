using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Part4
{
    class CAlumnoCurso
    {

        private int idAlumno;
        private int idCurso;

        public CAlumnoCurso(int pIdAlumno, int pIdCurso)
        {
            idAlumno = pIdAlumno;
            idCurso = pIdCurso;
        }

        public int IdAlumno { get => idAlumno; set => idAlumno = value; }
        public int IdCurso { get => idCurso; set => idCurso = value; }


        public override string ToString()
        {
            return string.Format("{0} => {1}", idAlumno, idCurso);
        }
    }
}
