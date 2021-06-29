using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_NOTAS.Ecuaciones
{
    public class Cls_Ecuaciones_DAL
    {
        #region Variables Definicion

            private float _fPrimNum, _fSegNum, _fTercNum, _fResultado;

        #endregion

        #region Metodos o Constructores Publicos

            public float FPrimNum { get => _fPrimNum; set => _fPrimNum = value; }
            public float FSegNum { get => _fSegNum; set => _fSegNum = value; }
            public float FTercNum { get => _fTercNum; set => _fTercNum = value; }
            public float FResultado { get => _fResultado; set => _fResultado = value; }

        #endregion
    }
}
