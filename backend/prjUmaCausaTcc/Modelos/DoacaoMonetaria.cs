﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class DoacaoMonetaria : Banco
{
    #region Propriedades
    public Usuario Doador { get; set; }
    public double ValorDoacao { get; set; }
    public DateTime DataDoacao { get; set; }
    public int CodigoComprovante { get; set; }  
    public int CodigoDoacao { get; set; }   
    #endregion

    #region Metodos
    public void CadastrarDoacaoMonetaria(int doador, int ong, double valor)
    {
        List<Parametro> parametros = new List<Parametro>()
        {
            new Parametro("pIdUsuarioDoador",doador.ToString()),
            new Parametro("pIdUsuarioOng",ong.ToString()),
            new Parametro("pVlMonetario", valor.ToString().Replace(",",".")),
        };
        try
        {
            Conectar();
            Executar("CadastrarDoacaoMonetaria", parametros);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            Desconectar();
        }
    }

    public int GerarComprovante()
    {
        try
        {
            var dados = Consultar("GerarCodigoComprovante", null);
            if (dados.Read())
            {
                CodigoComprovante = dados.GetInt32("comprovante");
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            Desconectar();
        }

        return CodigoComprovante;
    }

    #endregion
}