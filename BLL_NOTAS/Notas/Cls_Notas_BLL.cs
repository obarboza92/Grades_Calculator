using DAL_NOTAS.Notas;
using System;

namespace BLL_NOTAS.Notas
{
    public class Cls_Notas_BLL
    {

        #region Metodos

        //Calculo de Notas de Quices
        public void Calculo_Nota_Quices(ref Cls_Notas_DAL obj_Notas_DAL)
        {
            obj_Notas_DAL.FNotaQuices = (obj_Notas_DAL.FQuizI + obj_Notas_DAL.FQuizII + obj_Notas_DAL.FQuizIII) / 3;
            Math.Round(obj_Notas_DAL.FNotaQuices,2);
        }

        //Calculo de Notas de Tareas
        public void Calculo_Nota_Tareas(ref Cls_Notas_DAL obj_Notas_DAL)
        {
            obj_Notas_DAL.FNotaTareas = (obj_Notas_DAL.FTareaI + obj_Notas_DAL.FTareaII + obj_Notas_DAL.FTareaIII + obj_Notas_DAL.FTareaIV) / 4;
            Math.Round(obj_Notas_DAL.FNotaTareas,2);
        }

        //Calculo de Nota Final
        public void Calculo_Nota_Final(ref Cls_Notas_DAL obj_Notas_DAL)
        {
            obj_Notas_DAL.FNotaFinal = obj_Notas_DAL.FNotaQuices * obj_Notas_DAL.BPorcQuices/100 + 
                obj_Notas_DAL.FNotaTareas * obj_Notas_DAL.BPorcTareas/100 + 
                obj_Notas_DAL.FParcialI * obj_Notas_DAL.BPorcParI/100 + 
                obj_Notas_DAL.FParcialII * obj_Notas_DAL.BPorcParII / 100 + 
                obj_Notas_DAL.FParcialIII * obj_Notas_DAL.BPorcParIII / 100;

             Math.Round(obj_Notas_DAL.FNotaFinal, 2);
        }
            
        #endregion
    }
}
