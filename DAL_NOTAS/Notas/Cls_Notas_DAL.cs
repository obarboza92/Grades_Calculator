using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_NOTAS.Notas
{
    public class Cls_Notas_DAL
    {
        #region Variables de Porcentajes

            private byte _bPorcTareas, _bPorcQuices, _bPorcParI, _bPorcParII, _bPorcParIII;

        #endregion

        #region Variables Notas Quices

            private float _fQuizI, _fQuizII, _fQuizIII, _fNotaQuices;

        #endregion

        #region Variables Notas Tareas

        private float _fTareaI, _fTareaII, _fTareaIII, _fTareaIV, _fNotaTareas;

        #endregion

        #region Variables Notas Parciales

            private float _fParcialI, _fParcialII, _fParcialIII;

        #endregion

        #region Variable Nota Final

            private float _fNotaFinal;

        #endregion

        #region Metodos o Constructores Publicos 

            public byte BPorcTareas { get => _bPorcTareas; set => _bPorcTareas = value; }
            public byte BPorcQuices { get => _bPorcQuices; set => _bPorcQuices = value; }
            public byte BPorcParI { get => _bPorcParI; set => _bPorcParI = value; }
            public byte BPorcParII { get => _bPorcParII; set => _bPorcParII = value; }
            public byte BPorcParIII { get => _bPorcParIII; set => _bPorcParIII = value; }
            public float FQuizI { get => _fQuizI; set => _fQuizI = value; }
            public float FQuizII { get => _fQuizII; set => _fQuizII = value; }
            public float FQuizIII { get => _fQuizIII; set => _fQuizIII = value; }
            public float FNotaQuices { get => _fNotaQuices; set => _fNotaQuices = value; }
            public float FTareaI { get => _fTareaI; set => _fTareaI = value; }
            public float FTareaII { get => _fTareaII; set => _fTareaII = value; }
            public float FTareaIII { get => _fTareaIII; set => _fTareaIII = value; }
            public float FTareaIV { get => _fTareaIV; set => _fTareaIV = value; }
            public float FNotaTareas { get => _fNotaTareas; set => _fNotaTareas = value; }
            public float FParcialI { get => _fParcialI; set => _fParcialI = value; }
            public float FParcialII { get => _fParcialII; set => _fParcialII = value; }
            public float FParcialIII { get => _fParcialIII; set => _fParcialIII = value; }
            public float FNotaFinal { get => _fNotaFinal; set => _fNotaFinal = value; }
        

        #endregion
    }
}
