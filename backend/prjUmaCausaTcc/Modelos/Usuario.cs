﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
public class Usuario : Banco
{
    #region Propriedades
    public int Codigo { get; set; }
    private string _nome;
    public string Nome
    {
        get => _nome; 
        set
        {
            if (!String.IsNullOrEmpty(value))
                _nome = value;
            else
                throw new Exception("O nome não pode estar vazio!");
        }
    }
    private string _email;
    public string Email
    {
        get => _email;
        set
        {
            if (!String.IsNullOrEmpty(value))
                _email = value;
            else
                throw new Exception("O email não deve estar vazio!");
        }
    }
    private string _emailContato;
    public string EmailContato
    {
        get => _emailContato;
        set
        {
            if (!String.IsNullOrEmpty(_emailContato))
                _emailContato = value;
            else
                throw new Exception("O email de contato não deve estar vazio!");
        }
    }
    
    private string _telefone;
    public string Telefone
    {
        get => _telefone;
        set
        {
            if (!String.IsNullOrEmpty(value))
                _telefone = value;
            else
                throw new Exception("O número de telefone não deve estar vazio!");
        }
    }

    private string _identificacao;
    public string Identificacao
    {
        get => _identificacao;
        set
        {
            if (!String.IsNullOrEmpty(value))
                _identificacao = value;
            else
                throw new Exception("O documento não pode estar vazio!");
        }
    }

    private string _descricao;
    public string Descricao
    {
        get => _descricao;
        set
        {
            if (!String.IsNullOrEmpty(value))
                _descricao = value;
            else
                throw new Exception("A descrição não pode estar vazia!");
        }
    }

    private int _cep;
    public int Cep
    {
        get => _cep;
        set
        {
            if (value.ToString().Length != 8)
                throw new Exception("O cep deve conter 8 caracteres");
            else
                _cep = value;
        }
    }

    private string _estado;
    public string Estado
    {
        get => _estado;
        set
        {
            if (!String.IsNullOrEmpty(value))
                _estado = value;
            else
                throw new Exception("O nome do estado não deve estar vazio!");
        }
    }

    private string _cidade;
    public string Cidade
    {
        get => _cidade;
        set
        {
            if (!String.IsNullOrEmpty(value))
                _cidade = value;
            else
                throw new Exception("O nome da cidade não deve estar vazio!");
        }
    }

    private string _rua;
    public string Rua
    {
        get => _rua;
        set
        {
            if (!String.IsNullOrEmpty(value))
                _rua = value;
            else
                throw new Exception("O nome da rua não deve estar vazio!");
        }
    }
    private string _numero;
    public string Numero
    {
        get => _numero;
        set
        {
            if (!String.IsNullOrEmpty(value))
                _numero = value;
            else
                throw new Exception("O numero do endereço não deve estar vazio!");
        }
    }
    private string _bairro;
    public string Bairro
    {
        get => _bairro;
        set
        {
            if (!String.IsNullOrEmpty(value))
                _bairro = value;
            else
                throw new Exception("O nome do bairro não deve estar vazio!");
        }
    }
    private string _complemento;
    public string Complemento
    {
        get => _complemento;
        set { _complemento = value; }
    }

    public string Latitude { get; private set; }
    public string Longitude { get; private set; }
    
    private string _fotoPerfil;
    public string FotoPerfil
    {
        get => _fotoPerfil;
        set { _fotoPerfil = value; }
    }
    private string _website;
    public string Website
    {
        get => _website;
        set { _website = value; }
    }
    private string _banner;
    public string Banner
    {
        get => _banner;
        set { _banner = value; }
    }
    private string _numeroPix;
    public string NumeroPix
    {
        get => _numeroPix;
        set
        {
            if (!String.IsNullOrEmpty(value))
                _numeroPix = value;
            else
                throw new Exception("O pix não deve estar vazio!");
        }
    }
    
    public bool Banido { get; private set; }
    public DateTime DataDesbloqueio { get; private set; }
    public bool PosssibilidadeBusca { get; private set; }

    public TipoUsuario TipoDoUsuario { get; set; }
    #endregion

    #region Metodos
    
    public bool CadastrarDoador(string nome, string senha, string email, string telefone, string identificacao, string cep, string estado, string cidade, string rua, string numero, string bairro, string complemento, string latitude, string longitude)
    {
        List<Parametro> parametros = new List<Parametro>()
        { 
            new Parametro("pEmail",email),
            new Parametro("pNomeUsuario",nome),
            new Parametro("pSenha", senha),
            new Parametro("pTelefone", telefone),
            new Parametro("pNomeIdentificacao", identificacao),
            new Parametro("pCep",cep),
            new Parametro("pEstado",estado),
            new Parametro("pCidade",cidade),
            new Parametro("pRua",rua),
            new Parametro("pNumero",numero),
            new Parametro("pBairro",bairro),
            new Parametro("pComplemento",complemento),
            new Parametro("pLongitude",longitude),
            new Parametro("pLatitude",latitude),
        };
        try
        {
            Conectar();
            Executar("CadastrarDoador", parametros);
            Desconectar();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
        
    }

    public bool CadastrarOng(string nome, string senha, string email, string telefone, string identificacao, string cep, string estado, string cidade, string rua, string numero, string bairro, string complemento, string latitude, string longitude, string imagemFotoPerfil, string webSite, string imagemBanner, string pix, string descricao, string emailContato)
    {
        List<Parametro> parametros = new List<Parametro>()
        {
            new Parametro("pEmail",email),
            new Parametro("pNomeUsuario",nome),
            new Parametro("pSenha", senha),
            new Parametro("pTelefone", telefone),
            new Parametro("pNomeIdentificacao", identificacao),
            new Parametro("pEstado",estado),
            new Parametro("pCidade",cidade),
            new Parametro("pRua",rua),
            new Parametro("pNumero",numero),
            new Parametro("pBairro",bairro),
            new Parametro("pComplemento",complemento),
            new Parametro("pLongitude",longitude),
            new Parametro("pLatitude",latitude),
            new Parametro("pCep",cep),
            new Parametro("pEmailContato",emailContato),
            new Parametro("pImagemFotoPerfil",imagemFotoPerfil),
            new Parametro("pWebSite",webSite),
            new Parametro("pImagemBanner",imagemBanner),
            new Parametro("pPix",pix),
            new Parametro("pDescricao",descricao)
        };
        try
        {
            Conectar();
            Executar("CadastrarOng", parametros);
            Desconectar();
            return true;
        }
        catch (Exception)
        {
            return false;
        }

    }
    public bool ExcluirUsuario(int codigo)
    {
        List<Parametro> parametros = new List<Parametro>()
        {
            new Parametro ("pIdUsuario", codigo.ToString())
        };
        try
        {
            Conectar();
            Executar("ExcluirUsuario", parametros);
            Desconectar();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
     public bool AlterarSenhaUsuario(int codigo, string senhaAntiga, string senhaAtual )
    {
        List<Parametro> parametros = new List<Parametro>()
        {
            new Parametro ("pIdUsuario", codigo.ToString()),
            new Parametro ("pSenhaDigitada", senhaAntiga),
            new Parametro ("pNovaSenha", senhaAtual)
        };
        try
        {
            Conectar();
            Executar("ExcluirUsuario", parametros);
            Desconectar();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    #endregion
    public Usuario()
    {
    }

    public Usuario(int codigo, string nome, string email, string emailContato, string telefone, string identificacao, int cEP, string estado, string rua, string numero, string bairro, string complemento, string latitude, string longitude, bool posssibilidadeBusca, TipoUsuario tipoDoUsuario)
    {
       this.Codigo = codigo;
       this.Nome = nome;
       this.Email = email;
       this.EmailContato = emailContato;
       this.Telefone = telefone;
       this.Identificacao = identificacao;
       this.Cep = cEP;
       this.Estado = estado;
       this.Rua = rua;
       this.Numero = numero;
       this.Bairro = bairro;
       this.Complemento = complemento;
       this.Latitude = latitude;
       this.Longitude = longitude;
       this.PosssibilidadeBusca = posssibilidadeBusca;
       this.TipoDoUsuario = tipoDoUsuario;
    }
}