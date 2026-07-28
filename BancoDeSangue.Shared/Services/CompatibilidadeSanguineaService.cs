namespace BancoDeSangue.Shared.Services;
public enum TipoSanguineo { A_Pos, A_Neg, B_Pos, B_Neg, AB_Pos, AB_Neg, O_Pos, O_Neg }
public class CompatibilidadeSanguineaService
{
      public bool PodeDoar(TipoSanguineo doador, TipoSanguineo receptor)
   {
      return (doador, receptor) switch
        {
              // Doador O- (Doador Universal)
         (TipoSanguineo.O_Neg, _) => true,
              // Receptor AB+ (Receptor Universal)
          (_, TipoSanguineo.AB_Pos) => true,
              // Compatibilidades Específicas
         (TipoSanguineo.O_Pos, TipoSanguineo.O_Pos or TipoSanguineo.A_Pos or TipoSanguineo.B_Pos or TipoSanguineo.AB_Pos) => true,
         (TipoSanguineo.A_Neg, TipoSanguineo.A_Pos or TipoSanguineo.A_Neg or TipoSanguineo.AB_Pos or TipoSanguineo.AB_Neg) => true,
         (TipoSanguineo.A_Pos, TipoSanguineo.A_Pos or TipoSanguineo.AB_Pos) => true,
         (TipoSanguineo.B_Neg, TipoSanguineo.B_Pos or TipoSanguineo.B_Neg or TipoSanguineo.AB_Pos or TipoSanguineo.AB_Neg) => true,
         (TipoSanguineo.B_Pos, TipoSanguineo.B_Pos or TipoSanguineo.AB_Pos) => true,
         (TipoSanguineo.AB_Neg, TipoSanguineo.AB_Pos or TipoSanguineo.AB_Neg) => true,
          _ => false
        };
   }    
}