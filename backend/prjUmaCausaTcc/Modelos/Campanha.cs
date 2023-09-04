﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Web;
using System.Web.Management;

public class Campanha : Banco
{
    #region Propriedades
    protected int Codigo { get; set; }

    private string _nome;
    public string Nome
    {
        get => _nome;
        set { 
            if (String.IsNullOrEmpty(_nome))
                _nome = value; 
        }
    }

    private string _descricao;
    public string Descricao
    {
        get => _descricao;
        set {
            if (String.IsNullOrEmpty(_descricao))
                _descricao = value;
        }
    }

    private DateTime _dataInicio;
    public DateTime DataInicio
    {
        get => _dataInicio;
        set { _dataInicio = value; }
    }

    private DateTime _dataPrevistaFim;
    public DateTime DataPrevistaFim
    {
        get => _dataPrevistaFim;
        set { _dataPrevistaFim = value; }
    }

    private DateTime _dataFim;
    public DateTime DataFim
    {
        get => _dataFim;
        set
        {
            _dataFim = value;
        }
    }

    private int _quantidadeMeta;
    public int QuantidadeMeta
    {
        get => _quantidadeMeta;
        set
        {
            if (_quantidadeMeta != 0)
                _quantidadeMeta = value;
        }
    }
    
    private int _quantidadeArrecadada;
    public int QuantidadeArrecadada
    {
        get => _quantidadeArrecadada;
        set
        {
            if (_quantidadeArrecadada != 0)
                _quantidadeArrecadada = value;
        }
    }

    private string _banner;
    public string Banner
    {
        get => _banner;
        set
        {
            if (String.IsNullOrEmpty(_banner))
                _banner = value;
        }
    }
    
    private int _quantidadeDenuncias;
    public int QuantidadeDenuncias
    {
        get => _quantidadeDenuncias;
        set { _quantidadeDenuncias = value; }
    }
    
    public CategoriaCampanha Categoria { get; set; }
    public Usuario ONG { get; set; }
    public TipoItem TipoItemArrecadado { get; set; }
    #endregion

    #region Metodos
    public bool CriarCampanha(string nome, string descricao, DateTime inicioCampanha, DateTime fimCampanha, double meta, string banner, Usuario usuario, CategoriaCampanha categoria, TipoItem tipo)
    {
        List<Parametro> parametros = new List<Parametro>()
        {
            new Parametro ("pNmCampanha", nome),
            new Parametro ("pDsCampanha", descricao),
            new Parametro ("pDtInicioCampanha",inicioCampanha.ToString("yyyy-MM-dd")),
            new Parametro ("pDtFimEsperada", fimCampanha.ToString("yyyy-MM-dd")),
            new Parametro ("pQtMeta", meta.ToString()),
            new Parametro ("pImgBannerCampanha",banner),
            new Parametro ("pIdUsuario", usuario.Codigo.ToString()),
            new Parametro ("pIdCategoriaCampanha",categoria.Codigo.ToString()),
            new Parametro ("pIdTipoItem", tipo.Codigo.ToString())
        };
        try
        {
            Conectar();
            Executar("CriarCampanha", parametros);
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
    public bool EncerrarCampanha(int codigo, DateTime fimCampanha, Usuario usuario)
    {
        List<Parametro> parametros = new List<Parametro>()
        {
            new Parametro ("pDtFimEsperada", fimCampanha.ToString("yyyy-MM-dd")),
            new Parametro ("pIdUsuario", usuario.Codigo.ToString()),
            new Parametro ("pIdCampanha", codigo.ToString()),
        };
        try
        {
            Conectar();
            Executar("EncerrarCampanha", parametros);
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
    public bool ExcluirCampanha(int codigo)
    {
        List<Parametro> parametros = new List<Parametro>()
        {
            new Parametro ("pIdCampanha", codigo.ToString())
        };
        try
        {
            Conectar();
            Executar("ExcluirCampanha", parametros);
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
