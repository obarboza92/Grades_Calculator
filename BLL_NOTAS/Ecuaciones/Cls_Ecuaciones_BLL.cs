using DAL_NOTAS.Ecuaciones;
using System.Windows.Forms;

namespace BLL_NOTAS.Ecuaciones
{
    public class Cls_Ecuaciones_BLL
    {
        #region Metodos

         public void Calculo_Ecuacion(ref Cls_Ecuaciones_DAL obj_Ecuaciones_DAL)
        {
            obj_Ecuaciones_DAL.FResultado = (obj_Ecuaciones_DAL.FTercNum - obj_Ecuaciones_DAL.FSegNum) / obj_Ecuaciones_DAL.FPrimNum;
        }
        #endregion
    }
}
