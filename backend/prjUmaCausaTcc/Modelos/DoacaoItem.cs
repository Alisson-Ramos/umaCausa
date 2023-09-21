﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class DoacaoItem : Banco
{
    #region Propriedades
    public Usuario Doador { get; set; }
    public Usuario ONG { get; set; }
    public string NomeItem { get; set; }
    public DateTime DataDoacao { get; set; }
    public DateTime DataRecebimento { get; set; }
    public int Quantidade { get; set; }
    public bool DoacaoConfirmada { get; set; }
    public TipoItem TipoItem { get; set; }
    public TipoEntrega TipoEntrega { get; set; }

    public string DataDesejada { get; set; }
    public string HorarioDesejado { get; set; }

    #endregion

    #region Metodos
<<<<<<< HEAD

    #endregion

    public bool CadastrarDoacaoItem(int doador, int ong, string nome, int quantidade, TipoItem tipo, TipoEntrega entrega, string dataDesejada, string horaDesejado)
=======
    public bool CadastrarDoacaoItem(string nome, int doador, int ong, int quantidade, TipoItem tipo, TipoEntrega entrega)
>>>>>>> origin/alisson2
    {
        List<Parametro> parametros = new List<Parametro>()
        {
            new Parametro("pIdUsuarioDoador",doador.ToString()),
            new Parametro("pIdUsuarioOng",ong.ToString()),
            new Parametro("pNmItem", nome),
            new Parametro("pQtItem", quantidade.ToString()),
            new Parametro("pIdTipoItem", tipo.Codigo.ToString()),
            new Parametro("pIdTipoEntrega", entrega.Codigo.ToString()),
            new Parametro("pHoraDoacao", horaDesejado.ToString()),
            new Parametro("pDataDoacao", dataDesejada.ToString()),
        };
        try
        {
            Conectar();
            Executar("CadastrarDoacaoItem", parametros);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
        finally
        {
            Desconectar();
        }
    }

    #endregion
}
